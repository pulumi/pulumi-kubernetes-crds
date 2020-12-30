// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1
{

    [OutputType]
    public sealed class KafkaSpecKafkaTemplatePodSecurityContext
    {
        public readonly int FsGroup;
        public readonly string FsGroupChangePolicy;
        public readonly int RunAsGroup;
        public readonly bool RunAsNonRoot;
        public readonly int RunAsUser;
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaTemplatePodSecurityContextSeLinuxOptions SeLinuxOptions;
        public readonly ImmutableArray<int> SupplementalGroups;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaTemplatePodSecurityContextSysctls> Sysctls;
        public readonly Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaTemplatePodSecurityContextWindowsOptions WindowsOptions;

        [OutputConstructor]
        private KafkaSpecKafkaTemplatePodSecurityContext(
            int fsGroup,

            string fsGroupChangePolicy,

            int runAsGroup,

            bool runAsNonRoot,

            int runAsUser,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaTemplatePodSecurityContextSeLinuxOptions seLinuxOptions,

            ImmutableArray<int> supplementalGroups,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaTemplatePodSecurityContextSysctls> sysctls,

            Pulumi.Kubernetes.Types.Outputs.Kafka.V1Beta1.KafkaSpecKafkaTemplatePodSecurityContextWindowsOptions windowsOptions)
        {
            FsGroup = fsGroup;
            FsGroupChangePolicy = fsGroupChangePolicy;
            RunAsGroup = runAsGroup;
            RunAsNonRoot = runAsNonRoot;
            RunAsUser = runAsUser;
            SeLinuxOptions = seLinuxOptions;
            SupplementalGroups = supplementalGroups;
            Sysctls = sysctls;
            WindowsOptions = windowsOptions;
        }
    }
}
