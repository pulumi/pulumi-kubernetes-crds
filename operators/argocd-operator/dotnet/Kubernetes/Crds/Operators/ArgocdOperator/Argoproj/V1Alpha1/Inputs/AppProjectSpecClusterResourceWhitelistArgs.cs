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
    /// GroupKind specifies a Group and a Kind, but does not force a version.  This is useful for identifying concepts during lookup stages without having partially valid types
    /// </summary>
    public class AppProjectSpecClusterResourceWhitelistArgs : Pulumi.ResourceArgs
    {
        [Input("group", required: true)]
        public Input<string> Group { get; set; } = null!;

        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        public AppProjectSpecClusterResourceWhitelistArgs()
        {
        }
    }
}
