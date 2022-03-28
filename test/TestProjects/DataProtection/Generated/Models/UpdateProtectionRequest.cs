// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace DataProtection.Models
{
    /// <summary> UpdateProtectionRequest for the UpdateProtection operation. </summary>
    public partial class UpdateProtectionRequest : ProtectionRequestBase
    {
        /// <summary> Initializes a new instance of UpdateProtectionRequest. </summary>
        /// <param name="datasource"> Datasource object. </param>
        /// <param name="backupSettings"> Full backup settings used to protect the datasource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datasource"/> or <paramref name="backupSettings"/> is null. </exception>
        public UpdateProtectionRequest(Datasource datasource, BackupSettings backupSettings) : base(datasource, backupSettings)
        {
            if (datasource == null)
            {
                throw new ArgumentNullException(nameof(datasource));
            }
            if (backupSettings == null)
            {
                throw new ArgumentNullException(nameof(backupSettings));
            }
        }

        /// <summary> Initializes a new instance of UpdateProtectionRequest. </summary>
        /// <param name="jobLibraryInitializationParams"> The initialization params of the Job Client Lib. The plugin needs this to do progress updates on Jobs. </param>
        /// <param name="datasourceAccessToken"> Access token for the Datasource Mgmt and Data plane. This is an MSI token (in almost all cases). </param>
        /// <param name="additionalProperties"> Additional Properties for extensibility. </param>
        /// <param name="datasourceSet"> DatasourceSet object. </param>
        /// <param name="datasource"> Datasource object. </param>
        /// <param name="backupSettings"> Full backup settings used to protect the datasource. </param>
        internal UpdateProtectionRequest(string jobLibraryInitializationParams, DatasourceTokens datasourceAccessToken, IDictionary<string, string> additionalProperties, DatasourceSet datasourceSet, Datasource datasource, BackupSettings backupSettings) : base(jobLibraryInitializationParams, datasourceAccessToken, additionalProperties, datasourceSet, datasource, backupSettings)
        {
        }
    }
}
