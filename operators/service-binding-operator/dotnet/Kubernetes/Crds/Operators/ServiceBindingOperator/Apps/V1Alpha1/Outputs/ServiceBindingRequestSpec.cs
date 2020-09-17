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
    public sealed class ServiceBindingRequestSpec
    {
        /// <summary>
        /// ApplicationSelector is used to identify the application connecting to the backing service operator.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.ServiceBindingRequestSpecApplicationSelector ApplicationSelector;
        /// <summary>
        /// BackingServiceSelector is used to identify the backing service operator. Deprecation Notice: In the upcoming release, this field would be depcreated. It would be mandatory to set "backingServiceSelectors".
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.ServiceBindingRequestSpecBackingServiceSelector BackingServiceSelector;
        /// <summary>
        /// BackingServiceSelectors is used to identify multiple backing services. This would be made a required field after 'BackingServiceSelector' is removed.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.ServiceBindingRequestSpecBackingServiceSelectors> BackingServiceSelectors;
        /// <summary>
        /// Custom env variables
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.ServiceBindingRequestSpecCustomEnvVar> CustomEnvVar;
        /// <summary>
        /// DetectBindingResources is flag used to bind all non-bindable variables from different subresources owned by backing operator CR.
        /// </summary>
        public readonly bool DetectBindingResources;
        /// <summary>
        /// EnvVarPrefix is the prefix for environment variables
        /// </summary>
        public readonly string EnvVarPrefix;
        /// <summary>
        /// MountPathPrefix is the prefix for volume mount
        /// </summary>
        public readonly string MountPathPrefix;

        [OutputConstructor]
        private ServiceBindingRequestSpec(
            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.ServiceBindingRequestSpecApplicationSelector applicationSelector,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.ServiceBindingRequestSpecBackingServiceSelector backingServiceSelector,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.ServiceBindingRequestSpecBackingServiceSelectors> backingServiceSelectors,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.ServiceBindingRequestSpecCustomEnvVar> customEnvVar,

            bool detectBindingResources,

            string envVarPrefix,

            string mountPathPrefix)
        {
            ApplicationSelector = applicationSelector;
            BackingServiceSelector = backingServiceSelector;
            BackingServiceSelectors = backingServiceSelectors;
            CustomEnvVar = customEnvVar;
            DetectBindingResources = detectBindingResources;
            EnvVarPrefix = envVarPrefix;
            MountPathPrefix = mountPathPrefix;
        }
    }
}
