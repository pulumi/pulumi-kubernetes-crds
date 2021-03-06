// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha1
{

    /// <summary>
    /// AzureSqlActionSpec defines the desired state of AzureSqlAction
    /// </summary>
    public class AzureSqlActionSpecArgs : Pulumi.ResourceArgs
    {
        [Input("actionName", required: true)]
        public Input<string> ActionName { get; set; } = null!;

        [Input("dbName")]
        public Input<string>? DbName { get; set; }

        [Input("dbUser")]
        public Input<string>? DbUser { get; set; }

        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        [Input("serverAdminSecretName")]
        public Input<string>? ServerAdminSecretName { get; set; }

        [Input("serverName", required: true)]
        public Input<string> ServerName { get; set; } = null!;

        [Input("serverSecretKeyVault")]
        public Input<string>? ServerSecretKeyVault { get; set; }

        [Input("userSecretKeyVault")]
        public Input<string>? UserSecretKeyVault { get; set; }

        public AzureSqlActionSpecArgs()
        {
        }
    }
}
