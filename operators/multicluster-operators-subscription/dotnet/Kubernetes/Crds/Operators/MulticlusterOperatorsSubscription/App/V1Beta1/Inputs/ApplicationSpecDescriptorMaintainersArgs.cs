// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.App.V1Beta1
{

    /// <summary>
    /// ContactData contains information about an individual or organization.
    /// </summary>
    public class ApplicationSpecDescriptorMaintainersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Email is the email address.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        /// <summary>
        /// Name is the descriptive name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Url could typically be a website address.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public ApplicationSpecDescriptorMaintainersArgs()
        {
        }
    }
}
