// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Charts.V1
{

    [OutputType]
    public sealed class XlSpecInfluxdb
    {
        /// <summary>
        /// component specific pod annotations list
        /// </summary>
        public readonly ImmutableDictionary<string, object> Annotations;
        /// <summary>
        /// component specific image options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecInfluxdbImage Image;
        /// <summary>
        /// influxdb persistence options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecInfluxdbPersistence Persistence;

        [OutputConstructor]
        private XlSpecInfluxdb(
            ImmutableDictionary<string, object> annotations,

            Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecInfluxdbImage image,

            Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecInfluxdbPersistence persistence)
        {
            Annotations = annotations;
            Image = image;
            Persistence = persistence;
        }
    }
}
