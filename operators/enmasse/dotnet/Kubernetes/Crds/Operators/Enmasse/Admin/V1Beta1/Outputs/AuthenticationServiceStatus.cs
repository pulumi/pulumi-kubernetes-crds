// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1
{

    [OutputType]
    public sealed class AuthenticationServiceStatus
    {
        public readonly string Host;
        /// <summary>
        /// Status and error messages for the authentication service.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Phase of the authentication service.
        /// </summary>
        public readonly string Phase;
        public readonly int Port;

        [OutputConstructor]
        private AuthenticationServiceStatus(
            string host,

            string message,

            string phase,

            int port)
        {
            Host = host;
            Message = message;
            Phase = phase;
            Port = port;
        }
    }
}
