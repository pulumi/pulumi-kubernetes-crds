// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Monitoring.V1
{

    [OutputType]
    public sealed class ServiceMonitorSpecEndpointsBasicAuth
    {
        /// <summary>
        /// The secret in the service monitor namespace that contains the password for authentication.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsBasicAuthPassword Password;
        /// <summary>
        /// The secret in the service monitor namespace that contains the username for authentication.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsBasicAuthUsername Username;

        [OutputConstructor]
        private ServiceMonitorSpecEndpointsBasicAuth(
            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsBasicAuthPassword password,

            Pulumi.Kubernetes.Types.Outputs.Monitoring.V1.ServiceMonitorSpecEndpointsBasicAuthUsername username)
        {
            Password = password;
            Username = username;
        }
    }
}
