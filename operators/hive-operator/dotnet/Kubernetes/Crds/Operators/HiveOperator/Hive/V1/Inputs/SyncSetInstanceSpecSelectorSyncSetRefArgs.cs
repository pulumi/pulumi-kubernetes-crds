// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Hive.V1
{

    /// <summary>
    /// SelectorSyncSetRef is a reference to the selectorsyncset for this syncsetinstance.
    /// </summary>
    public class SyncSetInstanceSpecSelectorSyncSetRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name is the name of the SelectorSyncSet
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public SyncSetInstanceSpecSelectorSyncSetRefArgs()
        {
        }
    }
}