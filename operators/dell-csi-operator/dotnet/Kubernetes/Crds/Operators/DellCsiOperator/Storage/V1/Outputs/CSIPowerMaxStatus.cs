// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1
{

    [OutputType]
    public sealed class CSIPowerMaxStatus
    {
        /// <summary>
        /// ControllerStatus is the status of Controller pods
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxStatusControllerStatus ControllerStatus;
        /// <summary>
        /// DriverHash is a hash of the driver specification
        /// </summary>
        public readonly int DriverHash;
        /// <summary>
        /// LastUpdate is the last updated state of the driver
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxStatusLastUpdate LastUpdate;
        /// <summary>
        /// NodeStatus is the status of Controller pods
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxStatusNodeStatus NodeStatus;
        /// <summary>
        /// State is the state of the driver installation
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private CSIPowerMaxStatus(
            Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxStatusControllerStatus controllerStatus,

            int driverHash,

            Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxStatusLastUpdate lastUpdate,

            Pulumi.Kubernetes.Types.Outputs.Storage.V1.CSIPowerMaxStatusNodeStatus nodeStatus,

            string state)
        {
            ControllerStatus = controllerStatus;
            DriverHash = driverHash;
            LastUpdate = lastUpdate;
            NodeStatus = nodeStatus;
            State = state;
        }
    }
}
