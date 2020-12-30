// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1
{

    [OutputType]
    public sealed class ServiceSpec
    {
        /// <summary>
        /// ResourceContext defines the CloudFoundry context and resource group
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1.ServiceSpecContext Context;
        public readonly string ExternalName;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1.ServiceSpecParameters> Parameters;
        public readonly string Plan;
        public readonly string ServiceClass;
        public readonly string ServiceClassType;
        public readonly ImmutableArray<string> Tags;

        [OutputConstructor]
        private ServiceSpec(
            Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1.ServiceSpecContext context,

            string externalName,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1Alpha1.ServiceSpecParameters> parameters,

            string plan,

            string serviceClass,

            string serviceClassType,

            ImmutableArray<string> tags)
        {
            Context = context;
            ExternalName = externalName;
            Parameters = parameters;
            Plan = plan;
            ServiceClass = serviceClass;
            ServiceClassType = serviceClassType;
            Tags = tags;
        }
    }
}
