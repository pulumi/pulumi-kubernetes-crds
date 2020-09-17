// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Eunomia.V1Alpha1
{

    public class GitOpsConfigSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ParameterSource is the location of the parameters, only contextDir is mandatory, if other filed are left blank they are assumed to be the same as ParameterSource
        /// </summary>
        [Input("parameterSource")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Eunomia.V1Alpha1.GitOpsConfigSpecParameterSourceArgs>? ParameterSource { get; set; }

        /// <summary>
        /// ResourceDeletionMode represents how resource deletion should be handled. Supported values are Retain,Delete,None. Default is Delete
        /// </summary>
        [Input("resourceDeletionMode")]
        public Input<string>? ResourceDeletionMode { get; set; }

        /// <summary>
        /// ResourceHandlingMode represents how resource creation/update should be handled. Supported values are Apply,Create,Delete,Patch,Replace,None. Default is Apply.
        /// </summary>
        [Input("resourceHandlingMode")]
        public Input<string>? ResourceHandlingMode { get; set; }

        /// <summary>
        /// ServiceAccountRef references to the service account under which the template engine job will run, it must exists in the namespace in which this CR is created
        /// </summary>
        [Input("serviceAccountRef")]
        public Input<string>? ServiceAccountRef { get; set; }

        /// <summary>
        /// TemplateProcessorArgs references to the run time parameters, we can pass additional arguments/flags to the template processor.
        /// </summary>
        [Input("templateProcessorArgs")]
        public Input<string>? TemplateProcessorArgs { get; set; }

        /// <summary>
        /// TemplateEngine, the gitops operator config map contains the list of available template engines, the value used here must exist in that list. Identity (i.e. no resource processing) is the default
        /// </summary>
        [Input("templateProcessorImage")]
        public Input<string>? TemplateProcessorImage { get; set; }

        /// <summary>
        /// TemplateSource is the location of the templated resources
        /// </summary>
        [Input("templateSource")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Eunomia.V1Alpha1.GitOpsConfigSpecTemplateSourceArgs>? TemplateSource { get; set; }

        [Input("triggers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Eunomia.V1Alpha1.GitOpsConfigSpecTriggersArgs>? _triggers;

        /// <summary>
        /// Triggers is an array of triggers that will lanuch this configuration
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Eunomia.V1Alpha1.GitOpsConfigSpecTriggersArgs> Triggers
        {
            get => _triggers ?? (_triggers = new InputList<Pulumi.Kubernetes.Types.Inputs.Eunomia.V1Alpha1.GitOpsConfigSpecTriggersArgs>());
            set => _triggers = value;
        }

        public GitOpsConfigSpecArgs()
        {
        }
    }
}
