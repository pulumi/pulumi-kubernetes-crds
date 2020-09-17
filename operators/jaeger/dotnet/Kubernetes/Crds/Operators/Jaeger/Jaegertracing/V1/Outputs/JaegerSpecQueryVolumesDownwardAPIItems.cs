// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1
{

    [OutputType]
    public sealed class JaegerSpecQueryVolumesDownwardAPIItems
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryVolumesDownwardAPIItemsFieldRef FieldRef;
        public readonly int Mode;
        public readonly string Path;
        public readonly Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryVolumesDownwardAPIItemsResourceFieldRef ResourceFieldRef;

        [OutputConstructor]
        private JaegerSpecQueryVolumesDownwardAPIItems(
            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryVolumesDownwardAPIItemsFieldRef fieldRef,

            int mode,

            string path,

            Pulumi.Kubernetes.Types.Outputs.Jaegertracing.V1.JaegerSpecQueryVolumesDownwardAPIItemsResourceFieldRef resourceFieldRef)
        {
            FieldRef = fieldRef;
            Mode = mode;
            Path = path;
            ResourceFieldRef = resourceFieldRef;
        }
    }
}
