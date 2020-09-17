// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Build.V1Alpha1
{

    /// <summary>
    /// StrategyRef refers to the BuildStrategy to be used to build the container image. There are namespaced scope and cluster scope BuildStrategy
    /// </summary>
    public class BuildSpecStrategyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// API version of the referent
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// BuildStrategyKind indicates the kind of the buildstrategy, namespaced or cluster scoped.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Name of the referent; More info: http://kubernetes.io/docs/user-guide/identifiers#names
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public BuildSpecStrategyArgs()
        {
        }
    }
}
