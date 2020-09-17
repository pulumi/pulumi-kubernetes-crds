// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class ThanosRulerSpecStorageVolumeClaimTemplate
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        public readonly string ApiVersion;
        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        public readonly ImmutableDictionary<string, object> Metadata;
        /// <summary>
        /// Spec defines the desired characteristics of a volume requested by a pod author. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecStorageVolumeClaimTemplateSpec Spec;
        /// <summary>
        /// Status represents the current information/status of a persistent volume claim. Read-only. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecStorageVolumeClaimTemplateStatus Status;

        [OutputConstructor]
        private ThanosRulerSpecStorageVolumeClaimTemplate(
            string apiVersion,

            string kind,

            ImmutableDictionary<string, object> metadata,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecStorageVolumeClaimTemplateSpec spec,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ThanosRulerSpecStorageVolumeClaimTemplateStatus status)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
        }
    }
}
