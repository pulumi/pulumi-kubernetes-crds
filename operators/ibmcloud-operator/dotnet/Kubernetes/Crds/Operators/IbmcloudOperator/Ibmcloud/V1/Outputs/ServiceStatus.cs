// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1
{

    [OutputType]
    public sealed class ServiceStatus
    {
        /// <summary>
        /// ResourceContext defines the CloudFoundry context and resource group
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1.ServiceStatusContext Context;
        /// <summary>
        /// DashboardURL is the dashboard URL for the service
        /// </summary>
        public readonly string DashboardURL;
        /// <summary>
        /// ExternalName is the name for the service as it appears on IBM Cloud
        /// </summary>
        public readonly string ExternalName;
        public readonly int Generation;
        /// <summary>
        /// InstanceID is the instance ID for the service
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// Message is a detailed message on current status
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Parameters pass configuration to the service during creation
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1.ServiceStatusParameters> Parameters;
        /// <summary>
        /// Plan for the service from the IBM Cloud Catalog
        /// </summary>
        public readonly string Plan;
        /// <summary>
        /// ServiceClass is the name of the service from the IBM Cloud Catalog
        /// </summary>
        public readonly string ServiceClass;
        /// <summary>
        /// ServiceClassType is set to CF if the service is CloundFoundry
        /// </summary>
        public readonly string ServiceClassType;
        /// <summary>
        /// State is a short name for the current status
        /// </summary>
        public readonly string State;
        public readonly ImmutableArray<string> Tags;

        [OutputConstructor]
        private ServiceStatus(
            Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1.ServiceStatusContext context,

            string dashboardURL,

            string externalName,

            int generation,

            string instanceId,

            string message,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Ibmcloud.V1.ServiceStatusParameters> parameters,

            string plan,

            string serviceClass,

            string serviceClassType,

            string state,

            ImmutableArray<string> tags)
        {
            Context = context;
            DashboardURL = dashboardURL;
            ExternalName = externalName;
            Generation = generation;
            InstanceId = instanceId;
            Message = message;
            Parameters = parameters;
            Plan = plan;
            ServiceClass = serviceClass;
            ServiceClassType = serviceClassType;
            State = state;
            Tags = tags;
        }
    }
}
