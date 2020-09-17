// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    public class APIManagerSpecSystemDatabaseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Union type. Only one of the fields can be set
        /// </summary>
        [Input("mysql")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemDatabaseMysqlArgs>? Mysql { get; set; }

        [Input("postgresql")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecSystemDatabasePostgresqlArgs>? Postgresql { get; set; }

        public APIManagerSpecSystemDatabaseArgs()
        {
        }
    }
}