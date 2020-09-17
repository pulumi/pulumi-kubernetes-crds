// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Machinelearning.V1
{

    /// <summary>
    /// The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime.
    /// </summary>
    public class SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersSecurityContextCapabilitiesArgs : Pulumi.ResourceArgs
    {
        [Input("add")]
        private InputList<string>? _add;

        /// <summary>
        /// Added capabilities
        /// </summary>
        public InputList<string> Add
        {
            get => _add ?? (_add = new InputList<string>());
            set => _add = value;
        }

        [Input("drop")]
        private InputList<string>? _drop;

        /// <summary>
        /// Removed capabilities
        /// </summary>
        public InputList<string> Drop
        {
            get => _drop ?? (_drop = new InputList<string>());
            set => _drop = value;
        }

        public SeldonDeploymentSpecPredictorsComponentSpecsSpecContainersSecurityContextCapabilitiesArgs()
        {
        }
    }
}
