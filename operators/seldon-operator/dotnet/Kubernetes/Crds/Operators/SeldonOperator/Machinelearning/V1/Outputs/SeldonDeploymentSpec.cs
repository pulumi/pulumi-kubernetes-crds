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
    public sealed class SeldonDeploymentSpec
    {
        public readonly ImmutableDictionary<string, string> Annotations;
        /// <summary>
        /// Name is Deprecated will be removed in future
        /// </summary>
        public readonly string Name;
        public readonly string Oauth_key;
        public readonly string Oauth_secret;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictors> Predictors;

        [OutputConstructor]
        private SeldonDeploymentSpec(
            ImmutableDictionary<string, string> annotations,

            string name,

            string oauth_key,

            string oauth_secret,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Machinelearning.V1.SeldonDeploymentSpecPredictors> predictors)
        {
            Annotations = annotations;
            Name = name;
            Oauth_key = oauth_key;
            Oauth_secret = oauth_secret;
            Predictors = predictors;
        }
    }
}
