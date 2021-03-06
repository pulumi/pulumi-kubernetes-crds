// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1
{

    [OutputType]
    public sealed class SecuritySpec
    {
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.SecuritySpecSecurityConfig> SecurityConfig;
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book.kubebuilder.io/beyond_basics/generating_crd.html
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private SecuritySpec(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.SecuritySpecSecurityConfig> securityConfig,

            string type)
        {
            SecurityConfig = securityConfig;
            Type = type;
        }
    }
}
