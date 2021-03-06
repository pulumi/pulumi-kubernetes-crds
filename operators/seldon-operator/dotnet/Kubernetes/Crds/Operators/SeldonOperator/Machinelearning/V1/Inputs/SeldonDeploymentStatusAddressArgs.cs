// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1
{

    /// <summary>
    /// Addressable placeholder until duckv1 issue is fixed:    https://github.com/kubernetes-sigs/controller-tools/issues/391
    /// </summary>
    public class SeldonDeploymentStatusAddressArgs : Pulumi.ResourceArgs
    {
        [Input("url")]
        public Input<string>? Url { get; set; }

        public SeldonDeploymentStatusAddressArgs()
        {
        }
    }
}
