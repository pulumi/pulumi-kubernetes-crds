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
    public sealed class ApplicationStatusHistorySourceDirectory
    {
        /// <summary>
        /// ApplicationSourceJsonnet holds jsonnet specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourceDirectoryJsonnet Jsonnet;
        public readonly bool Recurse;

        [OutputConstructor]
        private ApplicationStatusHistorySourceDirectory(
            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusHistorySourceDirectoryJsonnet jsonnet,

            bool recurse)
        {
            Jsonnet = jsonnet;
            Recurse = recurse;
        }
    }
}