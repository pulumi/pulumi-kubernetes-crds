// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1
{

    public class MigAnalyticStatusAnalyticsNamespacesExcludedK8SResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("count", required: true)]
        public Input<int> Count { get; set; } = null!;

        [Input("group", required: true)]
        public Input<string> Group { get; set; } = null!;

        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public MigAnalyticStatusAnalyticsNamespacesExcludedK8SResourcesArgs()
        {
        }
    }
}
