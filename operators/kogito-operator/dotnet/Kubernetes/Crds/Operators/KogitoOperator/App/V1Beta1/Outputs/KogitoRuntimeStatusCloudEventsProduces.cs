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
    public sealed class KogitoRuntimeStatusCloudEventsProduces
    {
        public readonly string Source;
        public readonly string Type;

        [OutputConstructor]
        private KogitoRuntimeStatusCloudEventsProduces(
            string source,

            string type)
        {
            Source = source;
            Type = type;
        }
    }
}