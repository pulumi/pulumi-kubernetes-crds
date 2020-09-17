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
    public sealed class ApplicationStatusOperationStateOperationSyncSourceDirectory
    {
        /// <summary>
        /// ApplicationSourceJsonnet holds jsonnet specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceDirectoryJsonnet Jsonnet;
        public readonly bool Recurse;

        [OutputConstructor]
        private ApplicationStatusOperationStateOperationSyncSourceDirectory(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceDirectoryJsonnet jsonnet,

            bool recurse)
        {
            Jsonnet = jsonnet;
            Recurse = recurse;
        }
    }
}