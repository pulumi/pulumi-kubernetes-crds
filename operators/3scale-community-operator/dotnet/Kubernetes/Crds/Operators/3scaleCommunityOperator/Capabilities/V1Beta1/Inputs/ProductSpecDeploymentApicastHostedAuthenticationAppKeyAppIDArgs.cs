// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Beta1
{

    /// <summary>
    /// AppKeyAppIDAuthenticationSpec defines the desired state of AppKey&amp;AppId Authentication
    /// </summary>
    public class ProductSpecDeploymentApicastHostedAuthenticationAppKeyAppIDArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AppID is the name of the parameter that acts of behalf of app id
        /// </summary>
        [Input("appID")]
        public Input<string>? AppID { get; set; }

        /// <summary>
        /// AppKey is the name of the parameter that acts of behalf of app key
        /// </summary>
        [Input("appKey")]
        public Input<string>? AppKey { get; set; }

        /// <summary>
        /// CredentialsLoc available options: headers: As HTTP Headers query: As query parameters (GET) or body parameters (POST/PUT/DELETE) authorization: As HTTP Basic Authentication
        /// </summary>
        [Input("credentials")]
        public Input<string>? Credentials { get; set; }

        /// <summary>
        /// SecuritySpec defines the desired state of Authentication Security
        /// </summary>
        [Input("security")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Capabilities.V1Beta1.ProductSpecDeploymentApicastHostedAuthenticationAppKeyAppIDSecurityArgs>? Security { get; set; }

        public ProductSpecDeploymentApicastHostedAuthenticationAppKeyAppIDArgs()
        {
        }
    }
}
