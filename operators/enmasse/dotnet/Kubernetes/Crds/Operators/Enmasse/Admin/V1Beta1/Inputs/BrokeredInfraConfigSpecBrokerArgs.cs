// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1
{

    public class BrokeredInfraConfigSpecBrokerArgs : Pulumi.ResourceArgs
    {
        [Input("addressFullPolicy")]
        public Input<string>? AddressFullPolicy { get; set; }

        /// <summary>
        /// Sets a global limit to the amount of memory the broker can use before it applies the rules determined by addressFullPolicy. Value in bytes or use a byte suffix ("B", "K", "MB", "GB")
        /// </summary>
        [Input("globalMaxSize")]
        public Input<string>? GlobalMaxSize { get; set; }

        [Input("javaOpts")]
        public Input<string>? JavaOpts { get; set; }

        [Input("podTemplate")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.BrokeredInfraConfigSpecBrokerPodTemplateArgs>? PodTemplate { get; set; }

        [Input("resources")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1.BrokeredInfraConfigSpecBrokerResourcesArgs>? Resources { get; set; }

        [Input("storageClassName")]
        public Input<string>? StorageClassName { get; set; }

        [Input("updatePersistentVolumeClaim")]
        public Input<bool>? UpdatePersistentVolumeClaim { get; set; }

        public BrokeredInfraConfigSpecBrokerArgs()
        {
        }
    }
}
