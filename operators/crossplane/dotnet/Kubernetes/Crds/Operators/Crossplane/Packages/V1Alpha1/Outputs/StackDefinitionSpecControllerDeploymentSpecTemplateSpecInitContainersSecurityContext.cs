// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1
{

    [OutputType]
    public sealed class StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersSecurityContext
    {
        public readonly bool AllowPrivilegeEscalation;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersSecurityContextCapabilities Capabilities;
        public readonly bool Privileged;
        public readonly string ProcMount;
        public readonly bool ReadOnlyRootFilesystem;
        public readonly int RunAsGroup;
        public readonly bool RunAsNonRoot;
        public readonly int RunAsUser;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions SeLinuxOptions;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersSecurityContextWindowsOptions WindowsOptions;

        [OutputConstructor]
        private StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersSecurityContext(
            bool allowPrivilegeEscalation,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersSecurityContextCapabilities capabilities,

            bool privileged,

            string procMount,

            bool readOnlyRootFilesystem,

            int runAsGroup,

            bool runAsNonRoot,

            int runAsUser,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersSecurityContextSeLinuxOptions seLinuxOptions,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecInitContainersSecurityContextWindowsOptions windowsOptions)
        {
            AllowPrivilegeEscalation = allowPrivilegeEscalation;
            Capabilities = capabilities;
            Privileged = privileged;
            ProcMount = procMount;
            ReadOnlyRootFilesystem = readOnlyRootFilesystem;
            RunAsGroup = runAsGroup;
            RunAsNonRoot = runAsNonRoot;
            RunAsUser = runAsUser;
            SeLinuxOptions = seLinuxOptions;
            WindowsOptions = windowsOptions;
        }
    }
}
