// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1
{

    [OutputType]
    public sealed class PackageInstallStatusInstallJob
    {
        public readonly string ApiVersion;
        public readonly string FieldPath;
        public readonly string Kind;
        public readonly string Name;
        public readonly string Namespace;
        public readonly string ResourceVersion;
        public readonly string Uid;

        [OutputConstructor]
        private PackageInstallStatusInstallJob(
            string apiVersion,

            string fieldPath,

            string kind,

            string name,

            string @namespace,

            string resourceVersion,

            string uid)
        {
            ApiVersion = apiVersion;
            FieldPath = fieldPath;
            Kind = kind;
            Name = name;
            Namespace = @namespace;
            ResourceVersion = resourceVersion;
            Uid = uid;
        }
    }
}
