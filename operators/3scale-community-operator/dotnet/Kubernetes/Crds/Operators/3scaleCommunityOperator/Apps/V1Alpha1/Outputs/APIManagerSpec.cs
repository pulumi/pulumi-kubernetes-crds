// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1
{

    [OutputType]
    public sealed class APIManagerSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecApicast Apicast;
        public readonly string AppLabel;
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecBackend Backend;
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecHighAvailability HighAvailability;
        public readonly bool ImageStreamTagImportInsecure;
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecPodDisruptionBudget PodDisruptionBudget;
        public readonly bool ResourceRequirementsEnabled;
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystem System;
        public readonly string TenantName;
        public readonly string WildcardDomain;
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecZync Zync;

        [OutputConstructor]
        private APIManagerSpec(
            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecApicast apicast,

            string appLabel,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecBackend backend,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecHighAvailability highAvailability,

            bool imageStreamTagImportInsecure,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecPodDisruptionBudget podDisruptionBudget,

            bool resourceRequirementsEnabled,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecSystem system,

            string tenantName,

            string wildcardDomain,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecZync zync)
        {
            Apicast = apicast;
            AppLabel = appLabel;
            Backend = backend;
            HighAvailability = highAvailability;
            ImageStreamTagImportInsecure = imageStreamTagImportInsecure;
            PodDisruptionBudget = podDisruptionBudget;
            ResourceRequirementsEnabled = resourceRequirementsEnabled;
            System = system;
            TenantName = tenantName;
            WildcardDomain = wildcardDomain;
            Zync = zync;
        }
    }
}