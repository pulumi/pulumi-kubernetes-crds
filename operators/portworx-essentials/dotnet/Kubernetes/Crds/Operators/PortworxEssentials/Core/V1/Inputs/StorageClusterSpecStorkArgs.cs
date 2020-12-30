// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    /// <summary>
    /// Contains STORK related spec.
    /// </summary>
    public class StorageClusterSpecStorkArgs : Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputMap<object>? _args;

        /// <summary>
        /// It is map of arguments given to STORK. Example: driver: pxd
        /// </summary>
        public InputMap<object> Args
        {
            get => _args ?? (_args = new InputMap<object>());
            set => _args = value;
        }

        /// <summary>
        /// Flag indicating whether STORK needs to be enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageClusterSpecStorkEnvArgs>? _env;

        /// <summary>
        /// List of environment variables used by STORK. This is an array of Kubernetes EnvVar where the value can be given directly or from a source like field, config map or secret.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageClusterSpecStorkEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageClusterSpecStorkEnvArgs>());
            set => _env = value;
        }

        /// <summary>
        /// Flag indicating if Stork pods should run in host network.
        /// </summary>
        [Input("hostNetwork")]
        public Input<bool>? HostNetwork { get; set; }

        /// <summary>
        /// Docker image of the STORK container.
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// Flag indicating if the STORK image needs to be locked to the given image. If the image is not locked, it can be updated by the storage driver during upgrades.
        /// </summary>
        [Input("lockImage")]
        public Input<bool>? LockImage { get; set; }

        public StorageClusterSpecStorkArgs()
        {
        }
    }
}
