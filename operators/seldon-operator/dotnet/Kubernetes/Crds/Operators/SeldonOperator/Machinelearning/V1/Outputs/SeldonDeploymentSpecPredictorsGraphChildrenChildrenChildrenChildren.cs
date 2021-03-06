// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1
{

    [OutputType]
    public sealed class SeldonDeploymentSpecPredictorsGraphChildrenChildrenChildrenChildren
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsGraphChildrenChildrenChildrenChildrenEndpoint Endpoint;
        public readonly string EnvSecretRefName;
        public readonly string Implementation;
        /// <summary>
        /// Request/response  payload logging. v2alpha1 feature that is added to v1 for backwards compatibility while v1 is the storage version.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsGraphChildrenChildrenChildrenChildrenLogger Logger;
        public readonly ImmutableArray<string> Methods;
        public readonly string ModelUri;
        public readonly string Name;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsGraphChildrenChildrenChildrenChildrenParameters> Parameters;
        public readonly string ServiceAccountName;
        public readonly string Type;

        [OutputConstructor]
        private SeldonDeploymentSpecPredictorsGraphChildrenChildrenChildrenChildren(
            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsGraphChildrenChildrenChildrenChildrenEndpoint endpoint,

            string envSecretRefName,

            string implementation,

            Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsGraphChildrenChildrenChildrenChildrenLogger logger,

            ImmutableArray<string> methods,

            string modelUri,

            string name,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictorsGraphChildrenChildrenChildrenChildrenParameters> parameters,

            string serviceAccountName,

            string type)
        {
            Endpoint = endpoint;
            EnvSecretRefName = envSecretRefName;
            Implementation = implementation;
            Logger = logger;
            Methods = methods;
            ModelUri = modelUri;
            Name = name;
            Parameters = parameters;
            ServiceAccountName = serviceAccountName;
            Type = type;
        }
    }
}
