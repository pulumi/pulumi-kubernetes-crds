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
    public sealed class ArgoCDSpecImport
    {
        /// <summary>
        /// Name of an ArgoCDExport from which to import data.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Namespace for the ArgoCDExport, defaults to the same namespace as the ArgoCD.
        /// </summary>
        public readonly string Namespace;

        [OutputConstructor]
        private ArgoCDSpecImport(
            string name,

            string @namespace)
        {
            Name = name;
            Namespace = @namespace;
        }
    }
}
