// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Perf.V1Alpha1
{

    [OutputType]
    public sealed class QperfStatus
    {
        /// <summary>
        /// Completed shows the state of completion
        /// </summary>
        public readonly bool Completed;
        /// <summary>
        /// Running shows the state of execution
        /// </summary>
        public readonly bool Running;

        [OutputConstructor]
        private QperfStatus(
            bool completed,

            bool running)
        {
            Completed = completed;
            Running = running;
        }
    }
}
