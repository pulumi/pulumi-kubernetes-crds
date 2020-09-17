// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.User.V1Beta1
{

    [OutputType]
    public sealed class MessagingUserStatus
    {
        /// <summary>
        /// Applied generation
        /// </summary>
        public readonly int Generation;
        /// <summary>
        /// Message describing the current state
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// The lifecycle phase of the messaging user
        /// </summary>
        public readonly string Phase;

        [OutputConstructor]
        private MessagingUserStatus(
            int generation,

            string message,

            string phase)
        {
            Generation = generation;
            Message = message;
            Phase = phase;
        }
    }
}