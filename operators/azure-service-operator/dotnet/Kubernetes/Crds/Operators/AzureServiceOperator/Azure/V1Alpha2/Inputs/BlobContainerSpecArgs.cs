// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha2
{

    /// <summary>
    /// BlobContainerSpec defines the desired state of BlobContainer
    /// </summary>
    public class BlobContainerSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// PublicAccess enumerates the values for public access.
        /// </summary>
        [Input("accessLevel")]
        public Input<string>? AccessLevel { get; set; }

        [Input("accountName")]
        public Input<string>? AccountName { get; set; }

        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        public BlobContainerSpecArgs()
        {
        }
    }
}
