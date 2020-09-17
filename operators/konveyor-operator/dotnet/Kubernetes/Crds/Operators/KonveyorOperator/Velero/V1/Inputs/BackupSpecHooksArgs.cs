// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Velero.V1
{

    /// <summary>
    /// Hooks represent custom behaviors that should be executed at different phases of the backup.
    /// </summary>
    public class BackupSpecHooksArgs : Pulumi.ResourceArgs
    {
        [Input("resources")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Velero.V1.BackupSpecHooksResourcesArgs>? _resources;

        /// <summary>
        /// Resources are hooks that should be executed when backing up individual instances of a resource.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Velero.V1.BackupSpecHooksResourcesArgs> Resources
        {
            get => _resources ?? (_resources = new InputList<Pulumi.Kubernetes.Types.Inputs.Velero.V1.BackupSpecHooksResourcesArgs>());
            set => _resources = value;
        }

        public BackupSpecHooksArgs()
        {
        }
    }
}
