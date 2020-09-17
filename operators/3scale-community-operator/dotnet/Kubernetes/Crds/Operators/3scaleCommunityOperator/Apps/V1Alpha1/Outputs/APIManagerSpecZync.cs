// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1
{

    [OutputType]
    public sealed class APIManagerSpecZync
    {
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecZyncAppSpec AppSpec;
        public readonly string Image;
        public readonly string PostgreSQLImage;
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecZyncQueSpec QueSpec;

        [OutputConstructor]
        private APIManagerSpecZync(
            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecZyncAppSpec appSpec,

            string image,

            string postgreSQLImage,

            Pulumi.Kubernetes.Types.Outputs.Apps.V1Alpha1.APIManagerSpecZyncQueSpec queSpec)
        {
            AppSpec = appSpec;
            Image = image;
            PostgreSQLImage = postgreSQLImage;
            QueSpec = queSpec;
        }
    }
}
