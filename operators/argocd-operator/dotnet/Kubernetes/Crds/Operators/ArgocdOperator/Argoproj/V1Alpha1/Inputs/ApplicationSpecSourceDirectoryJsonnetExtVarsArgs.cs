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
    /// JsonnetVar is a jsonnet variable
    /// </summary>
    public class ApplicationSpecSourceDirectoryJsonnetExtVarsArgs : Pulumi.ResourceArgs
    {
        [Input("code")]
        public Input<bool>? Code { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public ApplicationSpecSourceDirectoryJsonnetExtVarsArgs()
        {
        }
    }
}
