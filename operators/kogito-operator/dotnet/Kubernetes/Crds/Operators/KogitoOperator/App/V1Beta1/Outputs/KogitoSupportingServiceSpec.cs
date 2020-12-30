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
    public sealed class KogitoSupportingServiceSpec
    {
        /// <summary>
        /// Application properties that will be set to the service. For example 'MY_VAR: my_value'.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Config;
        /// <summary>
        /// Additional labels to be added to the Deployment and Pods managed by the operator.
        /// </summary>
        public readonly ImmutableDictionary<string, string> DeploymentLabels;
        /// <summary>
        /// Environment variables to be added to the runtime container. Keys must be a C_IDENTIFIER.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoSupportingServiceSpecEnv> Env;
        /// <summary>
        /// Image definition for the service. Example: "quay.io/kiegroup/kogito-service:latest". On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// Infra provides list of dependent KogitoInfra objects.
        /// </summary>
        public readonly ImmutableArray<string> Infra;
        /// <summary>
        /// A flag indicating that image streams created by Kogito Operator should be configured to allow pulling from insecure registries. Usable just on OpenShift. Defaults to 'false'.
        /// </summary>
        public readonly bool InsecureImageRegistry;
        /// <summary>
        /// Create Service monitor instance to connect with Monitoring service
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoSupportingServiceSpecMonitoring Monitoring;
        /// <summary>
        /// Custom ConfigMap with application.properties file to be mounted for the Kogito service. The ConfigMap must be created in the same namespace. Use this property if you need custom properties to be mounted before the application deployment. If left empty, one will be created for you. Later it can be updated to add any custom properties to apply to the service.
        /// </summary>
        public readonly string PropertiesConfigMap;
        /// <summary>
        /// Number of replicas that the service will have deployed in the cluster. Default value: 1.
        /// </summary>
        public readonly int Replicas;
        /// <summary>
        /// Defined compute resource requirements for the deployed service.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoSupportingServiceSpecResources Resources;
        /// <summary>
        /// Additional labels to be added to the Service managed by the operator.
        /// </summary>
        public readonly ImmutableDictionary<string, string> ServiceLabels;
        /// <summary>
        /// Defines the type for the supporting service, eg: DataIndex, JobsService Default value: JobsService
        /// </summary>
        public readonly string ServiceType;

        [OutputConstructor]
        private KogitoSupportingServiceSpec(
            ImmutableDictionary<string, string> config,

            ImmutableDictionary<string, string> deploymentLabels,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoSupportingServiceSpecEnv> env,

            string image,

            ImmutableArray<string> infra,

            bool insecureImageRegistry,

            Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoSupportingServiceSpecMonitoring monitoring,

            string propertiesConfigMap,

            int replicas,

            Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.KogitoSupportingServiceSpecResources resources,

            ImmutableDictionary<string, string> serviceLabels,

            string serviceType)
        {
            Config = config;
            DeploymentLabels = deploymentLabels;
            Env = env;
            Image = image;
            Infra = infra;
            InsecureImageRegistry = insecureImageRegistry;
            Monitoring = monitoring;
            PropertiesConfigMap = propertiesConfigMap;
            Replicas = replicas;
            Resources = resources;
            ServiceLabels = serviceLabels;
            ServiceType = serviceType;
        }
    }
}
