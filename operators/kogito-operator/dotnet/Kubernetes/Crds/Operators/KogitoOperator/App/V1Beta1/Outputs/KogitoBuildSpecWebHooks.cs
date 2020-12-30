// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Beta1
{

    [OutputType]
    public sealed class KogitoBuildSpecWebHooks
    {
        /// <summary>
        /// Secret value for webHook
        /// </summary>
        public readonly string Secret;
        /// <summary>
        /// WebHook type, either GitHub or Generic.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KogitoBuildSpecWebHooks(
            string secret,

            string type)
        {
            Secret = secret;
            Type = type;
        }
    }
}
