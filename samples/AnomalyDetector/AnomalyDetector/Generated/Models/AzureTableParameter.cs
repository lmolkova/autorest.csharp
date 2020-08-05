// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace AnomalyDetector.Models
{
    /// <summary> The AzureTableParameter. </summary>
    internal partial class AzureTableParameter
    {
        /// <summary> Initializes a new instance of AzureTableParameter. </summary>
        /// <param name="connectionString"> Azure Table connection string. </param>
        /// <param name="script"> Query script. </param>
        /// <param name="table"> Table name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/>, <paramref name="script"/>, or <paramref name="table"/> is null. </exception>
        internal AzureTableParameter(string connectionString, string script, string table)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }
            if (script == null)
            {
                throw new ArgumentNullException(nameof(script));
            }
            if (table == null)
            {
                throw new ArgumentNullException(nameof(table));
            }

            ConnectionString = connectionString;
            Script = script;
            Table = table;
        }

        /// <summary> Azure Table connection string. </summary>
        public string ConnectionString { get; }
        /// <summary> Query script. </summary>
        public string Script { get; }
        /// <summary> Table name. </summary>
        public string Table { get; }
    }
}
