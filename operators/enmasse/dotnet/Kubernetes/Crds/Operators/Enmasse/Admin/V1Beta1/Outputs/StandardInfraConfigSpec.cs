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
    public sealed class StandardInfraConfigSpec
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecAdmin Admin;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecBroker Broker;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecNetworkPolicy NetworkPolicy;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecRouter Router;
        public readonly string Version;

        [OutputConstructor]
        private StandardInfraConfigSpec(
            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecAdmin admin,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecBroker broker,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecNetworkPolicy networkPolicy,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.StandardInfraConfigSpecRouter router,

            string version)
        {
            Admin = admin;
            Broker = broker;
            NetworkPolicy = networkPolicy;
            Router = router;
            Version = version;
        }
    }
}
