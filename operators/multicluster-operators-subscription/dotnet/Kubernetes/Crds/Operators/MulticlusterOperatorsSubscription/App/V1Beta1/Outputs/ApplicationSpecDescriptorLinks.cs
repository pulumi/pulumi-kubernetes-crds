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
    public sealed class ApplicationSpecDescriptorLinks
    {
        /// <summary>
        /// Description is human readable content explaining the purpose of the link.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Url typically points at a website address.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private ApplicationSpecDescriptorLinks(
            string description,

            string url)
        {
            Description = description;
            Url = url;
        }
    }
}