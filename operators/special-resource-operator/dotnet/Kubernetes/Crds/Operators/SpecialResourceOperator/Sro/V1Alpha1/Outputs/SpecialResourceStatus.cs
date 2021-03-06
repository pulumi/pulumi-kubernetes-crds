// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Sro.V1Alpha1
{

    [OutputType]
    public sealed class SpecialResourceStatus
    {
        /// <summary>
        /// INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private SpecialResourceStatus(string state)
        {
            State = state;
        }
    }
}
