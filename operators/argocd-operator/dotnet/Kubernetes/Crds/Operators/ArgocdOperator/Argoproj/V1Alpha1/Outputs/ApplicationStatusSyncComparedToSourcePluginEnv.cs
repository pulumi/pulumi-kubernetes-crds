// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationStatusSyncComparedToSourcePluginEnv
    {
        /// <summary>
        /// the name, usually uppercase
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// the value
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private ApplicationStatusSyncComparedToSourcePluginEnv(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
