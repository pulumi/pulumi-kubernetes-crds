// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Camel.V1
{

    [OutputType]
    public sealed class BuildSpec
    {
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1.BuildSpecTasks> Tasks;

        [OutputConstructor]
        private BuildSpec(ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Camel.V1.BuildSpecTasks> tasks)
        {
            Tasks = tasks;
        }
    }
}
