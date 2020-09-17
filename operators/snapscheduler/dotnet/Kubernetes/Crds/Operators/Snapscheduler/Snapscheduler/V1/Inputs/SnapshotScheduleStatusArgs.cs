// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Snapscheduler.V1
{

    /// <summary>
    /// SnapshotScheduleStatus defines the observed state of SnapshotSchedule
    /// </summary>
    public class SnapshotScheduleStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Snapscheduler.V1.SnapshotScheduleStatusConditionsArgs>? _conditions;

        /// <summary>
        /// Conditions is a list of conditions related to operator reconciliation.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Snapscheduler.V1.SnapshotScheduleStatusConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Snapscheduler.V1.SnapshotScheduleStatusConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// LastSnapshotTime is the time of the most recent set of snapshots generated by this schedule.
        /// </summary>
        [Input("lastSnapshotTime")]
        public Input<string>? LastSnapshotTime { get; set; }

        /// <summary>
        /// NextSnapshotTime is the time when this schedule should create the next set of snapshots.
        /// </summary>
        [Input("nextSnapshotTime")]
        public Input<string>? NextSnapshotTime { get; set; }

        public SnapshotScheduleStatusArgs()
        {
        }
    }
}