// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1
{

    public class MigPlanSpecArgs : Pulumi.ResourceArgs
    {
        [Input("closed")]
        public Input<bool>? Closed { get; set; }

        [Input("destMigClusterRef")]
        private InputMap<object>? _destMigClusterRef;
        public InputMap<object> DestMigClusterRef
        {
            get => _destMigClusterRef ?? (_destMigClusterRef = new InputMap<object>());
            set => _destMigClusterRef = value;
        }

        [Input("hooks")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1.MigPlanSpecHooksArgs>? _hooks;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1.MigPlanSpecHooksArgs> Hooks
        {
            get => _hooks ?? (_hooks = new InputList<Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1.MigPlanSpecHooksArgs>());
            set => _hooks = value;
        }

        [Input("migStorageRef")]
        private InputMap<object>? _migStorageRef;
        public InputMap<object> MigStorageRef
        {
            get => _migStorageRef ?? (_migStorageRef = new InputMap<object>());
            set => _migStorageRef = value;
        }

        [Input("namespaces")]
        private InputList<string>? _namespaces;
        public InputList<string> Namespaces
        {
            get => _namespaces ?? (_namespaces = new InputList<string>());
            set => _namespaces = value;
        }

        [Input("persistentVolumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1.MigPlanSpecPersistentVolumesArgs>? _persistentVolumes;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1.MigPlanSpecPersistentVolumesArgs> PersistentVolumes
        {
            get => _persistentVolumes ?? (_persistentVolumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1.MigPlanSpecPersistentVolumesArgs>());
            set => _persistentVolumes = value;
        }

        [Input("srcMigClusterRef")]
        private InputMap<object>? _srcMigClusterRef;
        public InputMap<object> SrcMigClusterRef
        {
            get => _srcMigClusterRef ?? (_srcMigClusterRef = new InputMap<object>());
            set => _srcMigClusterRef = value;
        }

        public MigPlanSpecArgs()
        {
        }
    }
}
