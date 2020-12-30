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
    public sealed class StorageAccountSpecSku
    {
        /// <summary>
        /// Name - The SKU name. Required for account creation; optional for update. Possible values include: 'StandardLRS', 'StandardGRS', 'StandardRAGRS', 'StandardZRS', 'PremiumLRS', 'PremiumZRS', 'StandardGZRS', 'StandardRAGZRS'
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private StorageAccountSpecSku(string name)
        {
            Name = name;
        }
    }
}
