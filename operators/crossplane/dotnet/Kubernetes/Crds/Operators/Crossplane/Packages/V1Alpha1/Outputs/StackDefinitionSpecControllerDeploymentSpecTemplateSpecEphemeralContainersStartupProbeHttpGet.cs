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
    public sealed class StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGet
    {
        public readonly string Host;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders> HttpHeaders;
        public readonly string Path;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGetPort Port;
        public readonly string Scheme;

        [OutputConstructor]
        private StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGet(
            string host,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGetHttpHeaders> httpHeaders,

            string path,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecControllerDeploymentSpecTemplateSpecEphemeralContainersStartupProbeHttpGetPort port,

            string scheme)
        {
            Host = host;
            HttpHeaders = httpHeaders;
            Path = path;
            Port = port;
            Scheme = scheme;
        }
    }
}
