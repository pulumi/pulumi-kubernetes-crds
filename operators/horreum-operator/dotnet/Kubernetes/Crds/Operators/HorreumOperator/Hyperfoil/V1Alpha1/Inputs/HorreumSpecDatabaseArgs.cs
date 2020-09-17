// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hyperfoil.V1Alpha1
{

    /// <summary>
    /// Database coordinates for Horreum data. Besides `username` and `password` the secret must also contain key `dbsecret` that will be used to sign access to the database.
    /// </summary>
    public class HorreumSpecDatabaseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Hostname for the database
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// Name of the database
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Database port; defaults to 5432
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// Name of secret resource with data `username` and `password`. Created if does not exist.
        /// </summary>
        [Input("secret")]
        public Input<string>? Secret { get; set; }

        public HorreumSpecDatabaseArgs()
        {
        }
    }
}