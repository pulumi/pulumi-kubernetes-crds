// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1
{

    public class PackageInstallStatusConditionedStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageInstallStatusConditionedStatusConditionsArgs>? _conditions;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageInstallStatusConditionedStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Packages.V1Alpha1.PackageInstallStatusConditionedStatusConditionsArgs>());
            set => _conditions = value;
        }

        public PackageInstallStatusConditionedStatusArgs()
        {
        }
    }
}
