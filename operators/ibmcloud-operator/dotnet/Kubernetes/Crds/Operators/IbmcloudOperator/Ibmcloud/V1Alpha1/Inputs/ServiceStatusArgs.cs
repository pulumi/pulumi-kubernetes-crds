// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    /// <summary>
    /// ServiceStatus defines the observed state of Service
    /// </summary>
    public class ServiceStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ResourceContext defines the CloudFoundry context and resource group
        /// </summary>
        [Input("context")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.ServiceStatusContextArgs>? Context { get; set; }

        [Input("dashboardURL")]
        public Input<string>? DashboardURL { get; set; }

        [Input("externalName")]
        public Input<string>? ExternalName { get; set; }

        [Input("generation")]
        public Input<int>? Generation { get; set; }

        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("message")]
        public Input<string>? Message { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.ServiceStatusParametersArgs>? _parameters;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.ServiceStatusParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1.ServiceStatusParametersArgs>());
            set => _parameters = value;
        }

        [Input("plan", required: true)]
        public Input<string> Plan { get; set; } = null!;

        [Input("serviceClass", required: true)]
        public Input<string> ServiceClass { get; set; } = null!;

        [Input("serviceClassType", required: true)]
        public Input<string> ServiceClassType { get; set; } = null!;

        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        public ServiceStatusArgs()
        {
        }
    }
}
