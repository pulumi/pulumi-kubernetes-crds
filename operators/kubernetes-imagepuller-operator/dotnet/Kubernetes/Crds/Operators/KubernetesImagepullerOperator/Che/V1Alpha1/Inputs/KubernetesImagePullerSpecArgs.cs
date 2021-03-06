// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Che.V1Alpha1
{

    /// <summary>
    /// KubernetesImagePullerSpec defines the desired state of KubernetesImagePuller
    /// </summary>
    public class KubernetesImagePullerSpecArgs : Pulumi.ResourceArgs
    {
        [Input("cachingCPULimit")]
        public Input<string>? CachingCPULimit { get; set; }

        [Input("cachingCPURequest")]
        public Input<string>? CachingCPURequest { get; set; }

        [Input("cachingIntervalHours")]
        public Input<string>? CachingIntervalHours { get; set; }

        [Input("cachingMemoryLimit")]
        public Input<string>? CachingMemoryLimit { get; set; }

        [Input("cachingMemoryRequest")]
        public Input<string>? CachingMemoryRequest { get; set; }

        [Input("configMapName")]
        public Input<string>? ConfigMapName { get; set; }

        [Input("daemonsetName")]
        public Input<string>? DaemonsetName { get; set; }

        [Input("deploymentName")]
        public Input<string>? DeploymentName { get; set; }

        [Input("images")]
        public Input<string>? Images { get; set; }

        [Input("nodeSelector")]
        public Input<string>? NodeSelector { get; set; }

        public KubernetesImagePullerSpecArgs()
        {
        }
    }
}
