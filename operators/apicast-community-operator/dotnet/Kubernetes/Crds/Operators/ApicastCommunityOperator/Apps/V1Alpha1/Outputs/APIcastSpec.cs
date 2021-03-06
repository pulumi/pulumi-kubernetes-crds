// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1
{

    [OutputType]
    public sealed class APIcastSpec
    {
        public readonly ImmutableDictionary<string, object> AdminPortalCredentialsRef;
        public readonly ImmutableDictionary<string, object> EmbeddedConfigurationSecretRef;

        [OutputConstructor]
        private APIcastSpec(
            ImmutableDictionary<string, object> adminPortalCredentialsRef,

            ImmutableDictionary<string, object> embeddedConfigurationSecretRef)
        {
            AdminPortalCredentialsRef = adminPortalCredentialsRef;
            EmbeddedConfigurationSecretRef = embeddedConfigurationSecretRef;
        }
    }
}
