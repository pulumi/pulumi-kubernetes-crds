// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// AWS is the configuration used when installing on AWS.
    /// </summary>
    public class MachinePoolSpecPlatformAwsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// EC2RootVolume defines the storage for ec2 instance.
        /// </summary>
        [Input("rootVolume", required: true)]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.MachinePoolSpecPlatformAwsRootVolumeArgs> RootVolume { get; set; } = null!;

        /// <summary>
        /// SpotMarketOptions allows users to configure instances to be run using AWS Spot instances.
        /// </summary>
        [Input("spotMarketOptions")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Hive.V1.MachinePoolSpecPlatformAwsSpotMarketOptionsArgs>? SpotMarketOptions { get; set; }

        [Input("subnets")]
        private InputList<string>? _subnets;

        /// <summary>
        /// Subnets is the list of subnets to which to attach the machines. There must be exactly one subnet for each availability zone used.
        /// </summary>
        public InputList<string> Subnets
        {
            get => _subnets ?? (_subnets = new InputList<string>());
            set => _subnets = value;
        }

        /// <summary>
        /// InstanceType defines the ec2 instance type. eg. m4-large
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("zones")]
        private InputList<string>? _zones;

        /// <summary>
        /// Zones is list of availability zones that can be used.
        /// </summary>
        public InputList<string> Zones
        {
            get => _zones ?? (_zones = new InputList<string>());
            set => _zones = value;
        }

        public MachinePoolSpecPlatformAwsArgs()
        {
        }
    }
}
