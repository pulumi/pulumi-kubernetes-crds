// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1
{

    [OutputType]
    public sealed class APISpecDefinition
    {
        /// <summary>
        /// Interceptors for API. Default value "&lt;empty&gt;".
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.APISpecDefinitionInterceptors Interceptors;
        /// <summary>
        /// Array of config map names of swagger definitions for the API.
        /// </summary>
        public readonly ImmutableArray<string> SwaggerConfigmapNames;
        public readonly string Type;

        [OutputConstructor]
        private APISpecDefinition(
            Pulumi.Kubernetes.Types.Outputs.Wso2.V1Alpha1.APISpecDefinitionInterceptors interceptors,

            ImmutableArray<string> swaggerConfigmapNames,

            string type)
        {
            Interceptors = interceptors;
            SwaggerConfigmapNames = swaggerConfigmapNames;
            Type = type;
        }
    }
}
