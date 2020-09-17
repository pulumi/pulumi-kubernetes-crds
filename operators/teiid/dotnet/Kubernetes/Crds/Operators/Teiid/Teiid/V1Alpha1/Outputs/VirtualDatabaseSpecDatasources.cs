// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Teiid.V1Alpha1
{

    [OutputType]
    public sealed class VirtualDatabaseSpecDatasources
    {
        /// <summary>
        /// Name of the Data Source
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Properties required for Data Source connection
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Teiid.V1Alpha1.VirtualDatabaseSpecDatasourcesProperties> Properties;
        /// <summary>
        /// Type of Data Source. ex: Oracle, PostgreSQL, MySQL, Salesforce etc.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private VirtualDatabaseSpecDatasources(
            string name,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Teiid.V1Alpha1.VirtualDatabaseSpecDatasourcesProperties> properties,

            string type)
        {
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}