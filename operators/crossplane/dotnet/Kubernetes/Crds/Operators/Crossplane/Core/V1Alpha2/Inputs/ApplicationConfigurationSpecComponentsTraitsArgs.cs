// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1Alpha2
{

    /// <summary>
    /// A ComponentTrait specifies a trait that should be applied to a component.
    /// </summary>
    public class ApplicationConfigurationSpecComponentsTraitsArgs : Pulumi.ResourceArgs
    {
        [Input("trait", required: true)]
        private InputMap<object>? _trait;

        /// <summary>
        /// A Trait that will be created for the component
        /// </summary>
        public InputMap<object> Trait
        {
            get => _trait ?? (_trait = new InputMap<object>());
            set => _trait = value;
        }

        public ApplicationConfigurationSpecComponentsTraitsArgs()
        {
        }
    }
}
