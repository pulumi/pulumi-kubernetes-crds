// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Beta1
{

    [OutputType]
    public sealed class AzureSqlDatabaseSpec
    {
        public readonly string DbName;
        public readonly int Edition;
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        public readonly string Location;
        public readonly Pulumi.Kubernetes.Types.Outputs.Azure.V1Beta1.AzureSqlDatabaseSpecMaxSize MaxSize;
        public readonly string MonthlyRetention;
        public readonly string ResourceGroup;
        public readonly string Server;
        public readonly Pulumi.Kubernetes.Types.Outputs.Azure.V1Beta1.AzureSqlDatabaseSpecSku Sku;
        public readonly int WeekOfYear;
        public readonly string WeeklyRetention;
        public readonly string YearlyRetention;

        [OutputConstructor]
        private AzureSqlDatabaseSpec(
            string dbName,

            int edition,

            string location,

            Pulumi.Kubernetes.Types.Outputs.Azure.V1Beta1.AzureSqlDatabaseSpecMaxSize maxSize,

            string monthlyRetention,

            string resourceGroup,

            string server,

            Pulumi.Kubernetes.Types.Outputs.Azure.V1Beta1.AzureSqlDatabaseSpecSku sku,

            int weekOfYear,

            string weeklyRetention,

            string yearlyRetention)
        {
            DbName = dbName;
            Edition = edition;
            Location = location;
            MaxSize = maxSize;
            MonthlyRetention = monthlyRetention;
            ResourceGroup = resourceGroup;
            Server = server;
            Sku = sku;
            WeekOfYear = weekOfYear;
            WeeklyRetention = weeklyRetention;
            YearlyRetention = yearlyRetention;
        }
    }
}
