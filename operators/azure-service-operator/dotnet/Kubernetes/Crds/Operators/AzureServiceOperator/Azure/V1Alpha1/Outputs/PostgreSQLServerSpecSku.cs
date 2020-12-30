// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1
{

    [OutputType]
    public sealed class PostgreSQLServerSpecSku
    {
        /// <summary>
        /// Capacity - The scale up/out capacity, representing server's compute units.
        /// </summary>
        public readonly int Capacity;
        /// <summary>
        /// Family - The family of hardware.
        /// </summary>
        public readonly string Family;
        /// <summary>
        /// Name - The name of the sku, typically, tier + family + cores, e.g. B_Gen4_1, GP_Gen5_8.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Size - The size code, to be interpreted by resource as appropriate.
        /// </summary>
        public readonly string Size;
        /// <summary>
        /// Tier - The tier of the particular SKU, e.g. Basic. Possible values include: 'Basic', 'GeneralPurpose', 'MemoryOptimized'
        /// </summary>
        public readonly string Tier;

        [OutputConstructor]
        private PostgreSQLServerSpecSku(
            int capacity,

            string family,

            string name,

            string size,

            string tier)
        {
            Capacity = capacity;
            Family = family;
            Name = name;
            Size = size;
            Tier = tier;
        }
    }
}