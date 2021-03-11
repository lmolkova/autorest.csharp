// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace AutoRest.CSharp.Input
{
    internal class SchemaUsageProvider
    {
        private readonly Dictionary<Schema, SchemaTypeUsage> _usages = new Dictionary<Schema, SchemaTypeUsage>();

        public SchemaUsageProvider(CodeModel codeModel)
        {
            foreach (var objectSchema in codeModel.Schemas.Objects)
            {
                var usage = objectSchema?.Extensions?.Usage;

                if (usage != null)
                {
                    var schemaTypeUsage = (SchemaTypeUsage)Enum.Parse(typeof(SchemaTypeUsage), usage, true);
                    var recurse = schemaTypeUsage.HasFlag(SchemaTypeUsage.Converter) ? false : true;
                    Apply(objectSchema, schemaTypeUsage, recurse);
                }
            }
            foreach (var operationGroup in codeModel.OperationGroups)
            {
                foreach (var operation in operationGroup.Operations)
                {
                    foreach (var operationResponse in operation.Responses)
                    {
                        var paging = operation.Language.Default.Paging;
                        if (paging != null && operationResponse.ResponseSchema is ObjectSchema objectSchema)
                        {
                            Apply(operationResponse.ResponseSchema, SchemaTypeUsage.Output);
                            foreach (var property in objectSchema.Properties)
                            {
                                var itemName = paging.ItemName ?? "value";
                                if (property.SerializedName == itemName)
                                {
                                    Apply(property.Schema, SchemaTypeUsage.Model | SchemaTypeUsage.Output);
                                }
                            }
                        }
                        else
                        {
                            Apply(operationResponse.ResponseSchema, SchemaTypeUsage.Model | SchemaTypeUsage.Output);
                        }
                    }

                    foreach (var operationResponse in operation.Exceptions)
                    {
                        Apply(operationResponse.ResponseSchema, SchemaTypeUsage.Error | SchemaTypeUsage.Output);
                    }

                    foreach (var parameter in operation.Parameters)
                    {
                        ApplyParameterSchema(parameter);
                    }

                    foreach (var serviceRequest in operation.Requests)
                    {
                        foreach (var parameter in serviceRequest.Parameters)
                        {
                            ApplyParameterSchema(parameter);
                        }
                    }
                }
            }
        }

        private void ApplyParameterSchema(RequestParameter parameter)
        {
            if (parameter.Flattened == true)
            {
                Apply(parameter.Schema, SchemaTypeUsage.FattenedParameters | SchemaTypeUsage.Input, recurse: false);
            }
            else
            {
                Apply(parameter.Schema, SchemaTypeUsage.Model | SchemaTypeUsage.Input);
            }
        }

        private void Apply(Schema? schema, SchemaTypeUsage usage, bool recurse = true)
        {
            if (schema == null)
            {
                return;
            }

            _usages.TryGetValue(schema, out var currentUsage);

            var newUsage = currentUsage | usage;
            if (newUsage == currentUsage)
            {
                return;
            }

            _usages[schema] = newUsage;

            if (!recurse)
            {
                return;
            }

            if (schema is ObjectSchema objectSchema)
            {
                foreach (var parent in objectSchema.Parents!.All)
                {
                    Apply(parent, usage);
                }

                foreach (var child in objectSchema.Children!.All)
                {
                    Apply(child, usage);
                }

                foreach (var schemaProperty in objectSchema.Properties)
                {
                    var propertyUsage = usage;

                    if (schemaProperty.IsReadOnly)
                    {
                        propertyUsage &= ~SchemaTypeUsage.Input;
                    }

                    Apply(schemaProperty.Schema, propertyUsage);
                }
            }
            else if (schema is DictionarySchema dictionarySchema)
            {
                Apply(dictionarySchema.ElementType, usage);
            }
            else if (schema is ArraySchema arraySchema)
            {
                Apply(arraySchema.ElementType, usage);
            }
        }

        public SchemaTypeUsage GetUsage(Schema schema)
        {
            _usages.TryGetValue(schema, out var usage);
            return usage;
        }
    }

    [Flags]
    internal enum SchemaTypeUsage
    {
        None = 0,
        Input = 1,
        Output = Input << 1,

        Model = Output << 1,
        Error = Model << 1,
        FattenedParameters = Error << 1,
        Converter = FattenedParameters << 1
    }
}
