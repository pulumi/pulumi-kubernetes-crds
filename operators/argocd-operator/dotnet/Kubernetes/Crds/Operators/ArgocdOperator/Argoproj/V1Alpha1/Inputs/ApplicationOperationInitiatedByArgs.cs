// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// OperationInitiator holds information about the operation initiator
    /// </summary>
    public class ApplicationOperationInitiatedByArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Automated is set to true if operation was initiated automatically by the application controller.
        /// </summary>
        [Input("automated")]
        public Input<bool>? Automated { get; set; }

        /// <summary>
        /// Name of a user who started operation.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public ApplicationOperationInitiatedByArgs()
        {
        }
    }
}
