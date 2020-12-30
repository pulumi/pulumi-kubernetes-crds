// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    /// <summary>
    /// APIManagerSpec defines the desired state of APIManager
    /// </summary>
    public class APIManagerSpecArgs : Pulumi.ResourceArgs
    {
        [Input("apicast")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecApicastArgs>? Apicast { get; set; }

        [Input("appLabel")]
        public Input<string>? AppLabel { get; set; }

        [Input("backend")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecBackendArgs>? Backend { get; set; }

        [Input("highAvailability")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecHighAvailabilityArgs>? HighAvailability { get; set; }

        [Input("imageStreamTagImportInsecure")]
        public Input<bool>? ImageStreamTagImportInsecure { get; set; }

        [Input("monitoring")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecMonitoringArgs>? Monitoring { get; set; }

        [Input("podDisruptionBudget")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecPodDisruptionBudgetArgs>? PodDisruptionBudget { get; set; }

        [Input("resourceRequirementsEnabled")]
        public Input<bool>? ResourceRequirementsEnabled { get; set; }

        [Input("system")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemArgs>? System { get; set; }

        [Input("tenantName")]
        public Input<string>? TenantName { get; set; }

        /// <summary>
        /// Wildcard domain as configured in the API Manager object
        /// </summary>
        [Input("wildcardDomain", required: true)]
        public Input<string> WildcardDomain { get; set; } = null!;

        [Input("zync")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecZyncArgs>? Zync { get; set; }

        public APIManagerSpecArgs()
        {
        }
    }
}
