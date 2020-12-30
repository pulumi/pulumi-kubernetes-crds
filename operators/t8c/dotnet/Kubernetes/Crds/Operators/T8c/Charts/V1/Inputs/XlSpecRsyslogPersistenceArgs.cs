// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Charts.V1
{

    /// <summary>
    /// rsyslog persistence options
    /// </summary>
    public class XlSpecRsyslogPersistenceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// influxdb audit persistent volume size
        /// </summary>
        [Input("auditsize")]
        public Input<string>? Auditsize { get; set; }

        /// <summary>
        /// influxdb log persistent volume size
        /// </summary>
        [Input("logsize")]
        public Input<string>? Logsize { get; set; }

        public XlSpecRsyslogPersistenceArgs()
        {
        }
    }
}
