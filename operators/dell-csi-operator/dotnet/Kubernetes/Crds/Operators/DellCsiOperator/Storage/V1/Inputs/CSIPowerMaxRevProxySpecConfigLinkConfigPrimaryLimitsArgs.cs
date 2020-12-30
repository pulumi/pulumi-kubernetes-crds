// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1
{

    /// <summary>
    /// ProxyLimits is used for storing the various types of limits applied for a particular proxy instance
    /// </summary>
    public class CSIPowerMaxRevProxySpecConfigLinkConfigPrimaryLimitsArgs : Pulumi.ResourceArgs
    {
        [Input("maxActiveRead")]
        public Input<int>? MaxActiveRead { get; set; }

        [Input("maxActiveWrite")]
        public Input<int>? MaxActiveWrite { get; set; }

        [Input("maxOutStandingRead")]
        public Input<int>? MaxOutStandingRead { get; set; }

        [Input("maxOutStandingWrite")]
        public Input<int>? MaxOutStandingWrite { get; set; }

        public CSIPowerMaxRevProxySpecConfigLinkConfigPrimaryLimitsArgs()
        {
        }
    }
}
