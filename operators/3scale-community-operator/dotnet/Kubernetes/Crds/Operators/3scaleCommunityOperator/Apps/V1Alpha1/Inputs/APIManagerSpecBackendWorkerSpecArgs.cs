// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    public class APIManagerSpecBackendWorkerSpecArgs : Pulumi.ResourceArgs
    {
        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        public APIManagerSpecBackendWorkerSpecArgs()
        {
        }
    }
}
