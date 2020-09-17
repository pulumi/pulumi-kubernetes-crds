// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1
{

    /// <summary>
    /// DriverStatus defines the observed state of CSIDriver
    /// </summary>
    public class CSIPowerMaxStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ControllerStatus is the status of Controller pods
        /// </summary>
        [Input("controllerStatus")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxStatusControllerStatusArgs>? ControllerStatus { get; set; }

        /// <summary>
        /// DriverHash is a hash of the driver specification
        /// </summary>
        [Input("driverHash")]
        public Input<int>? DriverHash { get; set; }

        /// <summary>
        /// LastUpdate is the last updated state of the driver
        /// </summary>
        [Input("lastUpdate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxStatusLastUpdateArgs>? LastUpdate { get; set; }

        /// <summary>
        /// NodeStatus is the status of Controller pods
        /// </summary>
        [Input("nodeStatus")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Storage.V1.CSIPowerMaxStatusNodeStatusArgs>? NodeStatus { get; set; }

        /// <summary>
        /// State is the state of the driver installation
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        public CSIPowerMaxStatusArgs()
        {
        }
    }
}
