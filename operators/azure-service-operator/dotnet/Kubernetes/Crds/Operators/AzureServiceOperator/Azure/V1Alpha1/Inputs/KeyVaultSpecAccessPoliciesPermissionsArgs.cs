// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1
{

    /// <summary>
    /// Permissions - Permissions the identity has for keys, secrets, and certificates.
    /// </summary>
    public class KeyVaultSpecAccessPoliciesPermissionsArgs : Pulumi.ResourceArgs
    {
        [Input("certificates")]
        private InputList<string>? _certificates;
        public InputList<string> Certificates
        {
            get => _certificates ?? (_certificates = new InputList<string>());
            set => _certificates = value;
        }

        [Input("keys")]
        private InputList<string>? _keys;
        public InputList<string> Keys
        {
            get => _keys ?? (_keys = new InputList<string>());
            set => _keys = value;
        }

        [Input("secrets")]
        private InputList<string>? _secrets;
        public InputList<string> Secrets
        {
            get => _secrets ?? (_secrets = new InputList<string>());
            set => _secrets = value;
        }

        [Input("storage")]
        private InputList<string>? _storage;
        public InputList<string> Storage
        {
            get => _storage ?? (_storage = new InputList<string>());
            set => _storage = value;
        }

        public KeyVaultSpecAccessPoliciesPermissionsArgs()
        {
        }
    }
}