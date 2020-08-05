// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace AnomalyDetector.Models
{
    /// <summary> The DataSourceType. </summary>
    public readonly partial struct DataSourceType : IEquatable<DataSourceType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DataSourceType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureApplicationInsightsValue = "AzureApplicationInsights";
        private const string AzureBlobValue = "AzureBlob";
        private const string AzureCosmosDBValue = "AzureCosmosDB";
        private const string AzureDataExplorerValue = "AzureDataExplorer";
        private const string AzureEventHubsValue = "AzureEventHubs";
        private const string AzureTableValue = "AzureTable";
        private const string HttpRequestValue = "HttpRequest";
        private const string InfluxDBValue = "InfluxDB";
        private const string MongoDBValue = "MongoDB";
        private const string MySqlValue = "MySql";
        private const string PostgreSqlValue = "PostgreSql";
        private const string SqlServerValue = "SqlServer";

        /// <summary> AzureApplicationInsights. </summary>
        public static DataSourceType AzureApplicationInsights { get; } = new DataSourceType(AzureApplicationInsightsValue);
        /// <summary> AzureBlob. </summary>
        public static DataSourceType AzureBlob { get; } = new DataSourceType(AzureBlobValue);
        /// <summary> AzureCosmosDB. </summary>
        public static DataSourceType AzureCosmosDB { get; } = new DataSourceType(AzureCosmosDBValue);
        /// <summary> AzureDataExplorer. </summary>
        public static DataSourceType AzureDataExplorer { get; } = new DataSourceType(AzureDataExplorerValue);
        /// <summary> AzureEventHubs. </summary>
        public static DataSourceType AzureEventHubs { get; } = new DataSourceType(AzureEventHubsValue);
        /// <summary> AzureTable. </summary>
        public static DataSourceType AzureTable { get; } = new DataSourceType(AzureTableValue);
        /// <summary> HttpRequest. </summary>
        public static DataSourceType HttpRequest { get; } = new DataSourceType(HttpRequestValue);
        /// <summary> InfluxDB. </summary>
        public static DataSourceType InfluxDB { get; } = new DataSourceType(InfluxDBValue);
        /// <summary> MongoDB. </summary>
        public static DataSourceType MongoDB { get; } = new DataSourceType(MongoDBValue);
        /// <summary> MySql. </summary>
        public static DataSourceType MySql { get; } = new DataSourceType(MySqlValue);
        /// <summary> PostgreSql. </summary>
        public static DataSourceType PostgreSql { get; } = new DataSourceType(PostgreSqlValue);
        /// <summary> SqlServer. </summary>
        public static DataSourceType SqlServer { get; } = new DataSourceType(SqlServerValue);
        /// <summary> Determines if two <see cref="DataSourceType"/> values are the same. </summary>
        public static bool operator ==(DataSourceType left, DataSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataSourceType"/> values are not the same. </summary>
        public static bool operator !=(DataSourceType left, DataSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataSourceType"/>. </summary>
        public static implicit operator DataSourceType(string value) => new DataSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
