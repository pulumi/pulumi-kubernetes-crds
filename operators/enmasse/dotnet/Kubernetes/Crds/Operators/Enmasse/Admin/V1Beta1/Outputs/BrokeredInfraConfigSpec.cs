// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1
{

    [OutputType]
    public sealed class BrokeredInfraConfigSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.BrokeredInfraConfigSpecAdmin Admin;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.BrokeredInfraConfigSpecBroker Broker;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.BrokeredInfraConfigSpecNetworkPolicy NetworkPolicy;
        public readonly string Version;

        [OutputConstructor]
        private BrokeredInfraConfigSpec(
            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.BrokeredInfraConfigSpecAdmin admin,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.BrokeredInfraConfigSpecBroker broker,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.BrokeredInfraConfigSpecNetworkPolicy networkPolicy,

            string version)
        {
            Admin = admin;
            Broker = broker;
            NetworkPolicy = networkPolicy;
            Version = version;
        }
    }
}
