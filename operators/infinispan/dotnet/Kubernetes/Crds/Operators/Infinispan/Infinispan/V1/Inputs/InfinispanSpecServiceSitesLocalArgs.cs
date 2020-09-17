// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Infinispan.V1
{

    public class InfinispanSpecServiceSitesLocalArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ExposeSpec describe how Infinispan will be exposed externally
        /// </summary>
        [Input("expose", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Infinispan.V1.InfinispanSpecServiceSitesLocalExposeArgs> Expose { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public InfinispanSpecServiceSitesLocalArgs()
        {
        }
    }
}