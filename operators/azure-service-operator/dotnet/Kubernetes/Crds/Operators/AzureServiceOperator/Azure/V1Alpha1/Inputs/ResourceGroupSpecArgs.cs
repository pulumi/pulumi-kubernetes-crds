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
    /// ResourceGroupSpec defines the desired state of ResourceGroup
    /// </summary>
    public class ResourceGroupSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        public ResourceGroupSpecArgs()
        {
        }
    }
}
