// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Charts.V1
{

    [OutputType]
    public sealed class XlSpecPrometheus-Mysql-Exporter
    {
        /// <summary>
        /// Enable prometheus mysql exporter
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Enable prometheus mysql exporter
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecPrometheus-Mysql-ExporterMysql Mysql;

        [OutputConstructor]
        private XlSpecPrometheus-Mysql-Exporter(
            bool enabled,

            Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecPrometheus-Mysql-ExporterMysql mysql)
        {
            Enabled = enabled;
            Mysql = mysql;
        }
    }
}
