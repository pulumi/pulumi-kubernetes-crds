// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Elasticsearch.V1
{

    /// <summary>
    /// RoleSource references roles to create in the Elasticsearch cluster.
    /// </summary>
    public class ElasticsearchSpecAuthRolesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// SecretName is the name of the secret.
        /// </summary>
        [Input("secretName")]
        public Input<string>? SecretName { get; set; }

        public ElasticsearchSpecAuthRolesArgs()
        {
        }
    }
}
