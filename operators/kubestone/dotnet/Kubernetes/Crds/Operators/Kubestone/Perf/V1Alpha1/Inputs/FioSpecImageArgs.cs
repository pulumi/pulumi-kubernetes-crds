// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1
{

    /// <summary>
    /// Image defines the fio docker image used for the benchmark
    /// </summary>
    public class FioSpecImageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name is the Docker Image location including the tag
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// PullPolicy controls how the docker images are downloaded Defaults to Always if :latest tag is specified, or IfNotPresent otherwise.
        /// </summary>
        [Input("pullPolicy")]
        public Input<string>? PullPolicy { get; set; }

        /// <summary>
        /// PullSecret is an optional list of references to secrets in the same namespace to use for pulling any of the images
        /// </summary>
        [Input("pullSecret")]
        public Input<string>? PullSecret { get; set; }

        public FioSpecImageArgs()
        {
        }
    }
}
