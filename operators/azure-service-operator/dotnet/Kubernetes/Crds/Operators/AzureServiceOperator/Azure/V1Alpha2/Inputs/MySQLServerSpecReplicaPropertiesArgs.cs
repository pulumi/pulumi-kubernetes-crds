// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Azure.V1Alpha2
{

    public class MySQLServerSpecReplicaPropertiesArgs : Pulumi.ResourceArgs
    {
        [Input("sourceServerId")]
        public Input<string>? SourceServerId { get; set; }

        public MySQLServerSpecReplicaPropertiesArgs()
        {
        }
    }
}
