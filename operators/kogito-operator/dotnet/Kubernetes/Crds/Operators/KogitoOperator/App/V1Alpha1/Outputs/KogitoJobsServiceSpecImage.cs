// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Alpha1
{

    [OutputType]
    public sealed class KogitoJobsServiceSpecImage
    {
        public readonly string Domain;
        public readonly string Name;
        public readonly string Namespace;
        public readonly string Tag;

        [OutputConstructor]
        private KogitoJobsServiceSpecImage(
            string domain,

            string name,

            string @namespace,

            string tag)
        {
            Domain = domain;
            Name = name;
            Namespace = @namespace;
            Tag = tag;
        }
    }
}
