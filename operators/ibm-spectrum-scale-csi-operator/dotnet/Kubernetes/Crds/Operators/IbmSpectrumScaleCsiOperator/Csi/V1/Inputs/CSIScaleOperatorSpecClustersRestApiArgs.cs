// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Csi.V1
{

    public class CSIScaleOperatorSpecClustersRestApiArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The hostname of the REST server.
        /// </summary>
        [Input("guiHost")]
        public Input<string>? GuiHost { get; set; }

        /// <summary>
        /// The port number running the REST server.
        /// </summary>
        [Input("guiPort")]
        public Input<int>? GuiPort { get; set; }

        public CSIScaleOperatorSpecClustersRestApiArgs()
        {
        }
    }
}
