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
    /// OrphanedResources specifies if controller should monitor orphaned resources of apps in this project
    /// </summary>
    public class AppProjectSpecOrphanedResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("ignore")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectSpecOrphanedResourcesIgnoreArgs>? _ignore;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectSpecOrphanedResourcesIgnoreArgs> Ignore
        {
            get => _ignore ?? (_ignore = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.AppProjectSpecOrphanedResourcesIgnoreArgs>());
            set => _ignore = value;
        }

        /// <summary>
        /// Warn indicates if warning condition should be created for apps which have orphaned resources
        /// </summary>
        [Input("warn")]
        public Input<bool>? Warn { get; set; }

        public AppProjectSpecOrphanedResourcesArgs()
        {
        }
    }
}
