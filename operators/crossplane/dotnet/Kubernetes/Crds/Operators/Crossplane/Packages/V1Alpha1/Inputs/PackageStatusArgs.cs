// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class PackageStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditionedStatus")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageStatusConditionedStatusArgs>? ConditionedStatus { get; set; }

        [Input("controllerRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageStatusControllerRefArgs>? ControllerRef { get; set; }

        public PackageStatusArgs()
        {
        }
    }
}
