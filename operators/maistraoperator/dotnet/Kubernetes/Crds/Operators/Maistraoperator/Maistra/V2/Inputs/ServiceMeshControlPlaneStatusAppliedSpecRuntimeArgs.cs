// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecRuntimeArgs : Pulumi.ResourceArgs
    {
        [Input("components")]
        private InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecRuntimeComponentsArgs>? _components;
        public InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecRuntimeComponentsArgs> Components
        {
            get => _components ?? (_components = new InputMap<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecRuntimeComponentsArgs>());
            set => _components = value;
        }

        [Input("defaults")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecRuntimeDefaultsArgs>? Defaults { get; set; }

        public ServiceMeshControlPlaneStatusAppliedSpecRuntimeArgs()
        {
        }
    }
}
