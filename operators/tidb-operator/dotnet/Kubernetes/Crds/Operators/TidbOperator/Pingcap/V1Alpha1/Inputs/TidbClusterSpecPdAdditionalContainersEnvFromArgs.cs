// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1
{

    public class TidbClusterSpecPdAdditionalContainersEnvFromArgs : Pulumi.ResourceArgs
    {
        [Input("configMapRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdAdditionalContainersEnvFromConfigMapRefArgs>? ConfigMapRef { get; set; }

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        [Input("secretRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Pingcap.V1Alpha1.TidbClusterSpecPdAdditionalContainersEnvFromSecretRefArgs>? SecretRef { get; set; }

        public TidbClusterSpecPdAdditionalContainersEnvFromArgs()
        {
        }
    }
}
