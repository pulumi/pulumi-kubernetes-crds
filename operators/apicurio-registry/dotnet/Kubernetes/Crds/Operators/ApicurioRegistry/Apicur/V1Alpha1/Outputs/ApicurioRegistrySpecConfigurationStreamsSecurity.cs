// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apicur.V1Alpha1
{

    [OutputType]
    public sealed class ApicurioRegistrySpecConfigurationStreamsSecurity
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Apicur.V1Alpha1.ApicurioRegistrySpecConfigurationStreamsSecurityScram Scram;
        public readonly Pulumi.Kubernetes.Types.Outputs.Apicur.V1Alpha1.ApicurioRegistrySpecConfigurationStreamsSecurityTls Tls;

        [OutputConstructor]
        private ApicurioRegistrySpecConfigurationStreamsSecurity(
            Pulumi.Kubernetes.Types.Outputs.Apicur.V1Alpha1.ApicurioRegistrySpecConfigurationStreamsSecurityScram scram,

            Pulumi.Kubernetes.Types.Outputs.Apicur.V1Alpha1.ApicurioRegistrySpecConfigurationStreamsSecurityTls tls)
        {
            Scram = scram;
            Tls = tls;
        }
    }
}