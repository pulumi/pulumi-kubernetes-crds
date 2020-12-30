// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Charts.V1
{

    /// <summary>
    /// component specific image options
    /// </summary>
    public class XlSpecMediation-UcsdirectorImageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// component image pull policy
        /// </summary>
        [Input("pullPolicy")]
        public Input<string>? PullPolicy { get; set; }

        /// <summary>
        /// component container registry and repository name
        /// </summary>
        [Input("repository")]
        public Input<string>? Repository { get; set; }

        /// <summary>
        /// component serviceAccountName
        /// </summary>
        [Input("serviceAccountName")]
        public Input<string>? ServiceAccountName { get; set; }

        /// <summary>
        /// component container tag
        /// </summary>
        [Input("tag")]
        public Input<string>? Tag { get; set; }

        public XlSpecMediation-UcsdirectorImageArgs()
        {
        }
    }
}
