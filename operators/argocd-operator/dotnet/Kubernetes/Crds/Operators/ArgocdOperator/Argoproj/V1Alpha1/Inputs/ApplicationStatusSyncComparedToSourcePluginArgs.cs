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
    /// ConfigManagementPlugin holds config management plugin specific options
    /// </summary>
    public class ApplicationStatusSyncComparedToSourcePluginArgs : Pulumi.ResourceArgs
    {
        [Input("env")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcePluginEnvArgs>? _env;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcePluginEnvArgs> Env
        {
            get => _env ?? (_env = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourcePluginEnvArgs>());
            set => _env = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public ApplicationStatusSyncComparedToSourcePluginArgs()
        {
        }
    }
}
