// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1
{

    /// <summary>
    /// Contains spec of a user interface for the storage driver.
    /// </summary>
    public class StorageClusterSpecUserInterfaceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Flag indicating whether the user interface needs to be enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterSpecUserInterfaceEnvArgs>? _env;

        /// <summary>
        /// List of environment variables used by the UI components. This is an array of Kubernetes EnvVar where the value can be given directly or from a source like field, config map or secret.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterSpecUserInterfaceEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha1.StorageClusterSpecUserInterfaceEnvArgs>());
            set => _env = value;
        }

        /// <summary>
        /// Docker image of the user interface container.
        /// </summary>
        [Input("image")]
        public Input<string>? Image { get; set; }

        /// <summary>
        /// Flag indicating if the user interface image needs to be locked to the given image. If the image is not locked, it can be updated by the storage driver during upgrades.
        /// </summary>
        [Input("lockImage")]
        public Input<bool>? LockImage { get; set; }

        public StorageClusterSpecUserInterfaceArgs()
        {
        }
    }
}