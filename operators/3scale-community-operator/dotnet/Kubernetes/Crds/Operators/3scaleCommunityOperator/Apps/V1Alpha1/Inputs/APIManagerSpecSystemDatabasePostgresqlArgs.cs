// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    public class APIManagerSpecSystemDatabasePostgresqlArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Affinity is a group of affinity scheduling rules.
        /// </summary>
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlAffinityArgs>? Affinity { get; set; }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("persistentVolumeClaim")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlPersistentVolumeClaimArgs>? PersistentVolumeClaim { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlTolerationsArgs>? _tolerations;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlTolerationsArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlTolerationsArgs>());
            set => _tolerations = value;
        }

        public APIManagerSpecSystemDatabasePostgresqlArgs()
        {
        }
    }
}
