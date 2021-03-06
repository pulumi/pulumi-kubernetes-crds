// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Ibmcloud.V1Alpha1
{

    /// <summary>
    /// AccessGroupSpec defines the desired state of AccessGroup
    /// </summary>
    public class AccessGroupSpecArgs : Pulumi.ResourceArgs
    {
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("serviceIDs")]
        private InputList<string>? _serviceIDs;
        public InputList<string> ServiceIDs
        {
            get => _serviceIDs ?? (_serviceIDs = new InputList<string>());
            set => _serviceIDs = value;
        }

        [Input("userEmails")]
        private InputList<string>? _userEmails;
        public InputList<string> UserEmails
        {
            get => _userEmails ?? (_userEmails = new InputList<string>());
            set => _userEmails = value;
        }

        public AccessGroupSpecArgs()
        {
        }
    }
}
