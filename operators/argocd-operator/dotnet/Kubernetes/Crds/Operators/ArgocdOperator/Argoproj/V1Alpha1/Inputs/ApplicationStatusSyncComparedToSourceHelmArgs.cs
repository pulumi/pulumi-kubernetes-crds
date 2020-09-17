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
    /// Helm holds helm specific options
    /// </summary>
    public class ApplicationStatusSyncComparedToSourceHelmArgs : Pulumi.ResourceArgs
    {
        [Input("fileParameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourceHelmFileParametersArgs>? _fileParameters;

        /// <summary>
        /// FileParameters are file parameters to the helm template
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourceHelmFileParametersArgs> FileParameters
        {
            get => _fileParameters ?? (_fileParameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourceHelmFileParametersArgs>());
            set => _fileParameters = value;
        }

        [Input("parameters")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourceHelmParametersArgs>? _parameters;

        /// <summary>
        /// Parameters are parameters to the helm template
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourceHelmParametersArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputList<Pulumi.Kubernetes.Types.Inputs.Argoproj.V1Alpha1.ApplicationStatusSyncComparedToSourceHelmParametersArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// The Helm release name. If omitted it will use the application name
        /// </summary>
        [Input("releaseName")]
        public Input<string>? ReleaseName { get; set; }

        [Input("valueFiles")]
        private InputList<string>? _valueFiles;

        /// <summary>
        /// ValuesFiles is a list of Helm value files to use when generating a template
        /// </summary>
        public InputList<string> ValueFiles
        {
            get => _valueFiles ?? (_valueFiles = new InputList<string>());
            set => _valueFiles = value;
        }

        /// <summary>
        /// Values is Helm values, typically defined as a block
        /// </summary>
        [Input("values")]
        public Input<string>? Values { get; set; }

        public ApplicationStatusSyncComparedToSourceHelmArgs()
        {
        }
    }
}
