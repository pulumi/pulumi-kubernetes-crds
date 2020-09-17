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
    /// Directory holds path/directory specific options
    /// </summary>
    public class ApplicationStatusHistorySourceDirectoryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ApplicationSourceJsonnet holds jsonnet specific options
        /// </summary>
        [Input("jsonnet")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourceDirectoryJsonnetArgs>? Jsonnet { get; set; }

        [Input("recurse")]
        public Input<bool>? Recurse { get; set; }

        public ApplicationStatusHistorySourceDirectoryArgs()
        {
        }
    }
}
