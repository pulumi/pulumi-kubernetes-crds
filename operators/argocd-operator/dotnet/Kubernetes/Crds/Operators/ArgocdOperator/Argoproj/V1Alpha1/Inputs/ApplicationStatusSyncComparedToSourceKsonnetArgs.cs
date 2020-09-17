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
    /// Ksonnet holds ksonnet specific options
    /// </summary>
    public class ApplicationStatusSyncComparedToSourceKsonnetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Environment is a ksonnet application environment name
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourceKsonnetParametersArgs>? _parameters;

        /// <summary>
        /// Parameters are a list of ksonnet component parameter override values
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourceKsonnetParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourceKsonnetParametersArgs>());
            set => _parameters = value;
        }

        public ApplicationStatusSyncComparedToSourceKsonnetArgs()
        {
        }
    }
}
