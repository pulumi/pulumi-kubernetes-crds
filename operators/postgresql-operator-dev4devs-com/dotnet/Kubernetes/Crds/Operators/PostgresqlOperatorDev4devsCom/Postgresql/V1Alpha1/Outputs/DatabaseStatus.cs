// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Postgresql.V1Alpha1
{

    [OutputType]
    public sealed class DatabaseStatus
    {
        /// <summary>
        /// It will be as "OK when all objects are created successfully
        /// </summary>
        public readonly string DatabaseStatus;
        /// <summary>
        /// Status of the Database Deployment created and managed by it
        /// </summary>
        public readonly ImmutableDictionary<string, object> DeploymentStatus;
        /// <summary>
        /// Name of the PersistentVolumeClaim created and managed by it
        /// </summary>
        public readonly ImmutableDictionary<string, object> PvcStatus;
        /// <summary>
        /// Status of the Database Service created and managed by it
        /// </summary>
        public readonly ImmutableDictionary<string, object> ServiceStatus;

        [OutputConstructor]
        private DatabaseStatus(
            string databaseStatus,

            ImmutableDictionary<string, object> deploymentStatus,

            ImmutableDictionary<string, object> pvcStatus,

            ImmutableDictionary<string, object> serviceStatus)
        {
            DatabaseStatus = databaseStatus;
            DeploymentStatus = deploymentStatus;
            PvcStatus = pvcStatus;
            ServiceStatus = serviceStatus;
        }
    }
}
