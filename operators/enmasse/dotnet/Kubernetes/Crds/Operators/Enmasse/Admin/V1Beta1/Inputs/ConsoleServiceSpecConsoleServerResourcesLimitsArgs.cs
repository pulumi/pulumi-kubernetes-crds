// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Admin.V1Beta1
{

    public class ConsoleServiceSpecConsoleServerResourcesLimitsArgs : Pulumi.ResourceArgs
    {
        [Input("cpu")]
        public Input<string>? Cpu { get; set; }

        [Input("memory")]
        public Input<string>? Memory { get; set; }

        public ConsoleServiceSpecConsoleServerResourcesLimitsArgs()
        {
        }
    }
}
