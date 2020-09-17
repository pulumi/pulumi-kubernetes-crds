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
    /// Projection that may be projected along with other supported volume types
    /// </summary>
    public class FioSpecVolumeVolumeSourceProjectedSourcesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// information about the configMap data to project
        /// </summary>
        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesConfigMapArgs>? ConfigMap { get; set; }

        /// <summary>
        /// information about the downwardAPI data to project
        /// </summary>
        [Input("downwardAPI")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesDownwardAPIArgs>? DownwardAPI { get; set; }

        /// <summary>
        /// information about the secret data to project
        /// </summary>
        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesSecretArgs>? Secret { get; set; }

        /// <summary>
        /// information about the serviceAccountToken data to project
        /// </summary>
        [Input("serviceAccountToken")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Perf.V1Alpha1.FioSpecVolumeVolumeSourceProjectedSourcesServiceAccountTokenArgs>? ServiceAccountToken { get; set; }

        public FioSpecVolumeVolumeSourceProjectedSourcesArgs()
        {
        }
    }
}
