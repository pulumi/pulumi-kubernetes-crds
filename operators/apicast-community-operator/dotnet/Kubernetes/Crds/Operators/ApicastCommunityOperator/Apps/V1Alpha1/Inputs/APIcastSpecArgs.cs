// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    public class APIcastSpecArgs : Pulumi.ResourceArgs
    {
        [Input("adminPortalCredentialsRef")]
        private InputMap<object>? _adminPortalCredentialsRef;
        public InputMap<object> AdminPortalCredentialsRef
        {
            get => _adminPortalCredentialsRef ?? (_adminPortalCredentialsRef = new InputMap<object>());
            set => _adminPortalCredentialsRef = value;
        }

        [Input("embeddedConfigurationSecretRef")]
        private InputMap<object>? _embeddedConfigurationSecretRef;
        public InputMap<object> EmbeddedConfigurationSecretRef
        {
            get => _embeddedConfigurationSecretRef ?? (_embeddedConfigurationSecretRef = new InputMap<object>());
            set => _embeddedConfigurationSecretRef = value;
        }

        public APIcastSpecArgs()
        {
        }
    }
}
