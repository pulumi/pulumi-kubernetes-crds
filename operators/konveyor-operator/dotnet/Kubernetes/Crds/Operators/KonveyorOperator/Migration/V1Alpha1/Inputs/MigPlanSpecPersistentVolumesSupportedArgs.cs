// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1
{

    public class MigPlanSpecPersistentVolumesSupportedArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<string>? _actions;
        public InputList<string> Actions
        {
            get => _actions ?? (_actions = new InputList<string>());
            set => _actions = value;
        }

        [Input("copyMethods", required: true)]
        private InputList<string>? _copyMethods;
        public InputList<string> CopyMethods
        {
            get => _copyMethods ?? (_copyMethods = new InputList<string>());
            set => _copyMethods = value;
        }

        public MigPlanSpecPersistentVolumesSupportedArgs()
        {
        }
    }
}
