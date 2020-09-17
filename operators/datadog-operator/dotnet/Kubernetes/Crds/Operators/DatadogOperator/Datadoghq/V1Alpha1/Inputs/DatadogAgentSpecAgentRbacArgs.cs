// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Datadoghq.V1Alpha1
{

    /// <summary>
    /// RBAC configuration of the Agent
    /// </summary>
    public class DatadogAgentSpecAgentRbacArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Used to configure RBAC resources creation
        /// </summary>
        [Input("create")]
        public Input<bool>? Create { get; set; }

        /// <summary>
        /// Used to set up the service account name to use Ignored if the field Create is true
        /// </summary>
        [Input("serviceAccountName")]
        public Input<string>? ServiceAccountName { get; set; }

        public DatadogAgentSpecAgentRbacArgs()
        {
        }
    }
}
