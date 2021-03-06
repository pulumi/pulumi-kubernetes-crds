// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1
{

    [OutputType]
    public sealed class StackDefinitionSpecBehaviorEngine
    {
        public readonly string ControllerImage;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecBehaviorEngineKustomize Kustomize;
        public readonly string Type;

        [OutputConstructor]
        private StackDefinitionSpecBehaviorEngine(
            string controllerImage,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.StackDefinitionSpecBehaviorEngineKustomize kustomize,

            string type)
        {
            ControllerImage = controllerImage;
            Kustomize = kustomize;
            Type = type;
        }
    }
}
