// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1
{

    /// <summary>
    /// Request/response  payload logging. v2alpha1 feature that is added to v1 for backwards compatibility while v1 is the storage version.
    /// </summary>
    public class SeldonDeploymentSpecPredictorsGraphChildrenChildrenLoggerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// What payloads to log
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        /// <summary>
        /// URL to send request logging CloudEvents
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public SeldonDeploymentSpecPredictorsGraphChildrenChildrenLoggerArgs()
        {
        }
    }
}
