// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// Actions that the management system should take in response to container lifecycle events. Cannot be updated.
    /// </summary>
    public class PrometheusSpecInitContainersLifecycleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// PostStart is called immediately after a container is created. If the handler fails, the container is terminated and restarted according to its restart policy. Other management of the container blocks until the hook completes. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
        /// </summary>
        [Input("postStart")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecInitContainersLifecyclePostStartArgs>? PostStart { get; set; }

        /// <summary>
        /// PreStop is called immediately before a container is terminated due to an API request or management event such as liveness/startup probe failure, preemption, resource contention, etc. The handler is not called if the container crashes or exits. The reason for termination is passed to the handler. The Pod's termination grace period countdown begins before the PreStop hooked is executed. Regardless of the outcome of the handler, the container will eventually terminate within the Pod's termination grace period. Other management of the container blocks until the hook completes or until the termination grace period is reached. More info: https://kubernetes.io/docs/concepts/containers/container-lifecycle-hooks/#container-hooks
        /// </summary>
        [Input("preStop")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Monitoring.V1.PrometheusSpecInitContainersLifecyclePreStopArgs>? PreStop { get; set; }

        public PrometheusSpecInitContainersLifecycleArgs()
        {
        }
    }
}
