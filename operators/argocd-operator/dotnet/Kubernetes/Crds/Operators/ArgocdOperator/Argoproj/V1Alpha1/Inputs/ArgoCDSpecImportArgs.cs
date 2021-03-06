// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1
{

    /// <summary>
    /// Import is the import/restore options for ArgoCD.
    /// </summary>
    public class ArgoCDSpecImportArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of an ArgoCDExport from which to import data.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Namespace for the ArgoCDExport, defaults to the same namespace as the ArgoCD.
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        public ArgoCDSpecImportArgs()
        {
        }
    }
}
