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
    /// MavenSpec --
    /// </summary>
    public class IntegrationPlatformSpecBuildMavenArgs : Pulumi.ResourceArgs
    {
        [Input("localRepository")]
        public Input<string>? LocalRepository { get; set; }

        /// <summary>
        /// ValueSource --
        /// </summary>
        [Input("settings")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Camel.V1.IntegrationPlatformSpecBuildMavenSettingsArgs>? Settings { get; set; }

        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        public IntegrationPlatformSpecBuildMavenArgs()
        {
        }
    }
}
