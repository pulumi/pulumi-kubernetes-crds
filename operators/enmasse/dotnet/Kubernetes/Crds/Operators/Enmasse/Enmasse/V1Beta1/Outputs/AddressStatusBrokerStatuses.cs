// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Enmasse.V1Beta1
{

    [OutputType]
    public sealed class AddressStatusBrokerStatuses
    {
        public readonly string BrokerId;
        public readonly string ClusterId;
        public readonly string State;

        [OutputConstructor]
        private AddressStatusBrokerStatuses(
            string brokerId,

            string clusterId,

            string state)
        {
            BrokerId = brokerId;
            ClusterId = clusterId;
            State = state;
        }
    }
}
