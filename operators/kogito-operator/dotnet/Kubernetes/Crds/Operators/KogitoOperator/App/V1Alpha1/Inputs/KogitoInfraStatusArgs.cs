// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1
{

    /// <summary>
    /// KogitoInfraStatus defines the observed state of KogitoInfra.
    /// </summary>
    public class KogitoInfraStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// KogitoInfraCondition ...
        /// </summary>
        [Input("condition")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoInfraStatusConditionArgs>? Condition { get; set; }

        /// <summary>
        /// InfinispanInstallStatus defines the Infinispan installation status.
        /// </summary>
        [Input("infinispan")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoInfraStatusInfinispanArgs>? Infinispan { get; set; }

        /// <summary>
        /// InfraComponentInstallStatusType is the base structure to define the status for an actor in the infrastructure.
        /// </summary>
        [Input("kafka")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoInfraStatusKafkaArgs>? Kafka { get; set; }

        /// <summary>
        /// InfraComponentInstallStatusType is the base structure to define the status for an actor in the infrastructure.
        /// </summary>
        [Input("keycloak")]
        public Input<Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1.KogitoInfraStatusKeycloakArgs>? Keycloak { get; set; }

        public KogitoInfraStatusArgs()
        {
        }
    }
}
