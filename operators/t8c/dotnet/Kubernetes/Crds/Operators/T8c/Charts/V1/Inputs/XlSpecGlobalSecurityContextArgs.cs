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
    /// Security Context for persistent volumes
    /// </summary>
    public class XlSpecGlobalSecurityContextArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Group ID used for persisent volumes globally.
        /// </summary>
        [Input("fsGroup")]
        public Input<int>? FsGroup { get; set; }

        public XlSpecGlobalSecurityContextArgs()
        {
        }
    }
}
