// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1
{

    /// <summary>
    /// NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized. AzureSQLVNetRuleSpec defines the desired state of AzureSQLVNetRule
    /// </summary>
    public class AzureSQLVNetRuleSpecArgs : Pulumi.ResourceArgs
    {
        [Input("ignoreMissingServiceEndpoint")]
        public Input<bool>? IgnoreMissingServiceEndpoint { get; set; }

        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        [Input("server", required: true)]
        public Input<string> Server { get; set; } = null!;

        [Input("subnetName", required: true)]
        public Input<string> SubnetName { get; set; } = null!;

        [Input("vNetName", required: true)]
        public Input<string> VNetName { get; set; } = null!;

        [Input("vNetResourceGroup", required: true)]
        public Input<string> VNetResourceGroup { get; set; } = null!;

        public AzureSQLVNetRuleSpecArgs()
        {
        }
    }
}
