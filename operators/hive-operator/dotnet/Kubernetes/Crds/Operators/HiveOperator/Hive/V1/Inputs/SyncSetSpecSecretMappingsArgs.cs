// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// SecretMapping defines a source and destination for a secret to be synced by a SyncSet
    /// </summary>
    public class SyncSetSpecSecretMappingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SourceRef specifies the name and namespace of a secret on the management cluster
        /// </summary>
        [Input("sourceRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncSetSpecSecretMappingsSourceRefArgs> SourceRef { get; set; } = null!;

        /// <summary>
        /// TargetRef specifies the target name and namespace of the secret on the target cluster
        /// </summary>
        [Input("targetRef", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.SyncSetSpecSecretMappingsTargetRefArgs> TargetRef { get; set; } = null!;

        public SyncSetSpecSecretMappingsArgs()
        {
        }
    }
}
