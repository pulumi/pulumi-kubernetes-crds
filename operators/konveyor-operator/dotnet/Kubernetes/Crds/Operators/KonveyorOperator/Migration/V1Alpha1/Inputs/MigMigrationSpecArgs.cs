// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1
{

    public class MigMigrationSpecArgs : Pulumi.ResourceArgs
    {
        [Input("canceled")]
        public Input<bool>? Canceled { get; set; }

        [Input("keepAnnotations")]
        public Input<bool>? KeepAnnotations { get; set; }

        [Input("migPlanRef")]
        private InputMap<object>? _migPlanRef;
        public InputMap<object> MigPlanRef
        {
            get => _migPlanRef ?? (_migPlanRef = new InputMap<object>());
            set => _migPlanRef = value;
        }

        [Input("quiescePods")]
        public Input<bool>? QuiescePods { get; set; }

        [Input("stage", required: true)]
        public Input<bool> Stage { get; set; } = null!;

        [Input("verify")]
        public Input<bool>? Verify { get; set; }

        public MigMigrationSpecArgs()
        {
        }
    }
}
