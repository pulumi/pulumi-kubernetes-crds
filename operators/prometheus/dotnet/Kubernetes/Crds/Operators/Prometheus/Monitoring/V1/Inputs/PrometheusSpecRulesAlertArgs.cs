// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Monitoring.V1
{

    /// <summary>
    /// /--rules.alert.*/ command-line arguments
    /// </summary>
    public class PrometheusSpecRulesAlertArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Minimum duration between alert and restored 'for' state. This is maintained only for alerts with configured 'for' time greater than grace period.
        /// </summary>
        [Input("forGracePeriod")]
        public Input<string>? ForGracePeriod { get; set; }

        /// <summary>
        /// Max time to tolerate prometheus outage for restoring 'for' state of alert.
        /// </summary>
        [Input("forOutageTolerance")]
        public Input<string>? ForOutageTolerance { get; set; }

        /// <summary>
        /// Minimum amount of time to wait before resending an alert to Alertmanager.
        /// </summary>
        [Input("resendDelay")]
        public Input<string>? ResendDelay { get; set; }

        public PrometheusSpecRulesAlertArgs()
        {
        }
    }
}
