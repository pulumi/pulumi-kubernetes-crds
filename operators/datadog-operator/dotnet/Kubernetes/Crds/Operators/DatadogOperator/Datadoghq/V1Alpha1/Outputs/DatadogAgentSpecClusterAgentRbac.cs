// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Datadoghq.V1Alpha1
{

    [OutputType]
    public sealed class DatadogAgentSpecClusterAgentRbac
    {
        /// <summary>
        /// Used to configure RBAC resources creation
        /// </summary>
        public readonly bool Create;
        /// <summary>
        /// Used to set up the service account name to use Ignored if the field Create is true
        /// </summary>
        public readonly string ServiceAccountName;

        [OutputConstructor]
        private DatadogAgentSpecClusterAgentRbac(
            bool create,

            string serviceAccountName)
        {
            Create = create;
            ServiceAccountName = serviceAccountName;
        }
    }
}
