// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// SourceRef specifies the name and namespace of a secret on the management cluster
    /// </summary>
    public class SyncSetSpecSecretMappingsSourceRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name is the name of the secret
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Namespace is the namespace where the secret lives. If not present for the source secret reference, it is assumed to be the same namespace as the syncset with the reference.
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        public SyncSetSpecSecretMappingsSourceRefArgs()
        {
        }
    }
}
