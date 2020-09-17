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
    public sealed class ApplicationStatusOperationStateSyncResultSourceHelm
    {
        /// <summary>
        /// FileParameters are file parameters to the helm template
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourceHelmFileParameters> FileParameters;
        /// <summary>
        /// Parameters are parameters to the helm template
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourceHelmParameters> Parameters;
        /// <summary>
        /// The Helm release name. If omitted it will use the application name
        /// </summary>
        public readonly string ReleaseName;
        /// <summary>
        /// ValuesFiles is a list of Helm value files to use when generating a template
        /// </summary>
        public readonly ImmutableArray<string> ValueFiles;
        /// <summary>
        /// Values is Helm values, typically defined as a block
        /// </summary>
        public readonly string Values;

        [OutputConstructor]
        private ApplicationStatusOperationStateSyncResultSourceHelm(
            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourceHelmFileParameters> fileParameters,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateSyncResultSourceHelmParameters> parameters,

            string releaseName,

            ImmutableArray<string> valueFiles,

            string values)
        {
            FileParameters = fileParameters;
            Parameters = parameters;
            ReleaseName = releaseName;
            ValueFiles = valueFiles;
            Values = values;
        }
    }
}
