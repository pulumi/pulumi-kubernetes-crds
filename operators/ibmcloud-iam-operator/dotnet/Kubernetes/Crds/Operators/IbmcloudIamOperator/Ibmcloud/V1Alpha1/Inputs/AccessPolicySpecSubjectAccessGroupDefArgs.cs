// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    public class AccessPolicySpecSubjectAccessGroupDefArgs : Pulumi.ResourceArgs
    {
        [Input("accessGroupName", required: true)]
        public Input<string> AccessGroupName { get; set; } = null!;

        [Input("accessGroupNamespace", required: true)]
        public Input<string> AccessGroupNamespace { get; set; } = null!;

        public AccessPolicySpecSubjectAccessGroupDefArgs()
        {
        }
    }
}
