// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Camel.V1
{

    /// <summary>
    /// IntegrationPlatformResourcesSpec contains platform related resources
    /// </summary>
    public class IntegrationPlatformSpecResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("kits")]
        private InputList<string>? _kits;
        public InputList<string> Kits
        {
            get => _kits ?? (_kits = new InputList<string>());
            set => _kits = value;
        }

        public IntegrationPlatformSpecResourcesArgs()
        {
        }
    }
}
