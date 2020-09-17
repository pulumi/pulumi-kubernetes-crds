// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    public class APIManagerSpecSystemArgs : Pulumi.ResourceArgs
    {
        [Input("appSpec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemAppSpecArgs>? AppSpec { get; set; }

        [Input("database")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemDatabaseArgs>? Database { get; set; }

        [Input("fileStorage")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemFileStorageArgs>? FileStorage { get; set; }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("memcachedImage")]
        public Input<string>? MemcachedImage { get; set; }

        [Input("redisImage")]
        public Input<string>? RedisImage { get; set; }

        [Input("sidekiqSpec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemSidekiqSpecArgs>? SidekiqSpec { get; set; }

        public APIManagerSpecSystemArgs()
        {
        }
    }
}