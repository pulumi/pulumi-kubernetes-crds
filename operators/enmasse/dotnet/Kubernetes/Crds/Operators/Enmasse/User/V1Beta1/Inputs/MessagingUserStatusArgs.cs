// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.User.V1Beta1
{

    public class MessagingUserStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Applied generation
        /// </summary>
        [Input("generation")]
        public Input<int>? Generation { get; set; }

        /// <summary>
        /// Message describing the current state
        /// </summary>
        [Input("message")]
        public Input<string>? Message { get; set; }

        /// <summary>
        /// The lifecycle phase of the messaging user
        /// </summary>
        [Input("phase")]
        public Input<string>? Phase { get; set; }

        public MessagingUserStatusArgs()
        {
        }
    }
}
