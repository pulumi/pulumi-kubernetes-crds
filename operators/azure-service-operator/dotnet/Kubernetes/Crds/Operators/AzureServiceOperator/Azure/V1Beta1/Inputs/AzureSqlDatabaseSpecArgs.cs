// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Beta1
{

    /// <summary>
    /// AzureSqlDatabaseSpec defines the desired state of AzureSqlDatabase
    /// </summary>
    public class AzureSqlDatabaseSpecArgs : Pulumi.ResourceArgs
    {
        [Input("dbName")]
        public Input<string>? DbName { get; set; }

        [Input("edition")]
        public Input<int>? Edition { get; set; }

        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("maxSize")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Beta1.AzureSqlDatabaseSpecMaxSizeArgs>? MaxSize { get; set; }

        [Input("monthlyRetention")]
        public Input<string>? MonthlyRetention { get; set; }

        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        [Input("server", required: true)]
        public Input<string> Server { get; set; } = null!;

        [Input("sku")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Azure.V1Beta1.AzureSqlDatabaseSpecSkuArgs>? Sku { get; set; }

        [Input("weekOfYear")]
        public Input<int>? WeekOfYear { get; set; }

        [Input("weeklyRetention")]
        public Input<string>? WeeklyRetention { get; set; }

        [Input("yearlyRetention")]
        public Input<string>? YearlyRetention { get; set; }

        public AzureSqlDatabaseSpecArgs()
        {
        }
    }
}
