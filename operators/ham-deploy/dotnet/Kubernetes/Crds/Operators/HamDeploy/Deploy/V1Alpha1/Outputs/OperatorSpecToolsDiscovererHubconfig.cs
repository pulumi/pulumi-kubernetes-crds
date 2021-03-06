// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1
{

    [OutputType]
    public sealed class OperatorSpecToolsDiscovererHubconfig
    {
        public readonly string Kubeconfig;
        public readonly string Mountpath;
        /// <summary>
        /// LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorSpecToolsDiscovererHubconfigSecretRef SecretRef;

        [OutputConstructor]
        private OperatorSpecToolsDiscovererHubconfig(
            string kubeconfig,

            string mountpath,

            Pulumi.Kubernetes.Types.Outputs.Deploy.V1Alpha1.OperatorSpecToolsDiscovererHubconfigSecretRef secretRef)
        {
            Kubeconfig = kubeconfig;
            Mountpath = mountpath;
            SecretRef = secretRef;
        }
    }
}
