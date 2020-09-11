// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Operator.V1
{

    /// <summary>
    /// Spec represents a desired deployment configuration of controllers that govern registration and work distribution for attached Klusterlets.
    /// </summary>
    public class ClusterManagerSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// RegistrationImagePullSpec represents the desired image of registration controller installed on hub.
        /// </summary>
        [Input("registrationImagePullSpec")]
        public Input<string>? RegistrationImagePullSpec { get; set; }

        public ClusterManagerSpecArgs()
        {
        }
    }
}