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
    /// EventhubAuthorizationRule defines the name and rights of the access policy
    /// </summary>
    public class EventhubSpecAuthorizationRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name - Name of AuthorizationRule for eventhub
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("rights")]
        private InputList<string>? _rights;

        /// <summary>
        /// Rights - Rights set on the AuthorizationRule
        /// </summary>
        public InputList<string> Rights
        {
            get => _rights ?? (_rights = new InputList<string>());
            set => _rights = value;
        }

        public EventhubSpecAuthorizationRuleArgs()
        {
        }
    }
}