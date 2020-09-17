// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Migration.V1Alpha1
{

    public class MigMigrationStatusArgs : Pulumi.ResourceArgs
    {
        [Input("errors")]
        private InputList<string>? _errors;
        public InputList<string> Errors
        {
            get => _errors ?? (_errors = new InputList<string>());
            set => _errors = value;
        }

        [Input("itenerary")]
        public Input<string>? Itenerary { get; set; }

        [Input("observedDigest")]
        public Input<string>? ObservedDigest { get; set; }

        [Input("phase")]
        public Input<string>? Phase { get; set; }

        [Input("startTimestamp")]
        public Input<string>? StartTimestamp { get; set; }

        public MigMigrationStatusArgs()
        {
        }
    }
}