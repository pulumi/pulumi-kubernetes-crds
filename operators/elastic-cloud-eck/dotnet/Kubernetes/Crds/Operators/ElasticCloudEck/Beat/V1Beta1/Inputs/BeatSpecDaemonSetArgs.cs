// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Beat.V1Beta1
{

    /// <summary>
    /// DaemonSet specifies the Beat should be deployed as a DaemonSet, and allows providing its spec. Cannot be used along with `deployment`. If both are absent a default for the Type is used.
    /// </summary>
    public class BeatSpecDaemonSetArgs : Pulumi.ResourceArgs
    {
        public BeatSpecDaemonSetArgs()
        {
        }
    }
}