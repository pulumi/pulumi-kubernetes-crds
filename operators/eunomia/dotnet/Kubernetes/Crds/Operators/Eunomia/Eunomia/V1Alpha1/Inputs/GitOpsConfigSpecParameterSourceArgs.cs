// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Eunomia.V1Alpha1
{

    /// <summary>
    /// ParameterSource is the location of the parameters, only contextDir is mandatory, if other filed are left blank they are assumed to be the same as ParameterSource
    /// </summary>
    public class GitOpsConfigSpecParameterSourceArgs : Pulumi.ResourceArgs
    {
        [Input("contextDir")]
        public Input<string>? ContextDir { get; set; }

        [Input("httpProxy")]
        public Input<string>? HttpProxy { get; set; }

        [Input("httpsProxy")]
        public Input<string>? HttpsProxy { get; set; }

        [Input("noProxy")]
        public Input<string>? NoProxy { get; set; }

        [Input("ref")]
        public Input<string>? Ref { get; set; }

        [Input("secretRef")]
        public Input<string>? SecretRef { get; set; }

        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public GitOpsConfigSpecParameterSourceArgs()
        {
        }
    }
}
