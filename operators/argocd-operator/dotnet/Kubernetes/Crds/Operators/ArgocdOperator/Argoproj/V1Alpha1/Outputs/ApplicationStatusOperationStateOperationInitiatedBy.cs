// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationStatusOperationStateOperationInitiatedBy
    {
        /// <summary>
        /// Automated is set to true if operation was initiated automatically by the application controller.
        /// </summary>
        public readonly bool Automated;
        /// <summary>
        /// Name of a user who started operation.
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private ApplicationStatusOperationStateOperationInitiatedBy(
            bool automated,

            string username)
        {
            Automated = automated;
            Username = username;
        }
    }
}