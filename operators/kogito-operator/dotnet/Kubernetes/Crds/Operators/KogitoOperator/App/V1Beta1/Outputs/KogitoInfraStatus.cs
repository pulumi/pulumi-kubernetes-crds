// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Beta1
{

    [OutputType]
    public sealed class KogitoInfraStatus
    {
        /// <summary>
        /// Application properties extracted from the linked resource that will be added to the deployed Kogito service.
        /// </summary>
        public readonly ImmutableDictionary<string, string> AppProps;
        /// <summary>
        /// KogitoInfraCondition ...
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoInfraStatusCondition Condition;
        /// <summary>
        /// Environment variables extracted from the linked resource that will be added to the deployed Kogito service.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoInfraStatusEnv> Env;
        /// <summary>
        /// List of volumes that should be added to the services bound to this infra instance
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoInfraStatusVolumes> Volumes;

        [OutputConstructor]
        private KogitoInfraStatus(
            ImmutableDictionary<string, string> appProps,

            Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoInfraStatusCondition condition,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoInfraStatusEnv> env,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoInfraStatusVolumes> volumes)
        {
            AppProps = appProps;
            Condition = condition;
            Env = env;
            Volumes = volumes;
        }
    }
}