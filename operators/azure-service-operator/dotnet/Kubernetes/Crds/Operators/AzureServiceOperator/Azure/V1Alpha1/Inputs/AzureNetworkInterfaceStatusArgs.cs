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
    /// ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
    /// </summary>
    public class AzureNetworkInterfaceStatusArgs : Pulumi.ResourceArgs
    {
        [Input("completed")]
        public Input<string>? Completed { get; set; }

        [Input("containsUpdate")]
        public Input<bool>? ContainsUpdate { get; set; }

        [Input("failedProvisioning")]
        public Input<bool>? FailedProvisioning { get; set; }

        [Input("flattenedSecrets")]
        public Input<bool>? FlattenedSecrets { get; set; }

        [Input("message")]
        public Input<string>? Message { get; set; }

        [Input("output")]
        public Input<string>? Output { get; set; }

        [Input("pollingUrl")]
        public Input<string>? PollingUrl { get; set; }

        [Input("provisioned")]
        public Input<bool>? Provisioned { get; set; }

        [Input("provisioning")]
        public Input<bool>? Provisioning { get; set; }

        [Input("requested")]
        public Input<string>? Requested { get; set; }

        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        [Input("specHash")]
        public Input<string>? SpecHash { get; set; }

        [Input("state")]
        public Input<string>? State { get; set; }

        public AzureNetworkInterfaceStatusArgs()
        {
        }
    }
}
