// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1
{

    [OutputType]
    public sealed class ConsoleServiceSpecConsoleServer
    {
        /// <summary>
        /// Overrides for the periodic probe of container liveness.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecConsoleServerLivenessProbe LivenessProbe;
        /// <summary>
        /// Overrides for the periodic probe of container liveness.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecConsoleServerReadinessProbe ReadinessProbe;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecConsoleServerResources Resources;
        public readonly Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecConsoleServerSession Session;

        [OutputConstructor]
        private ConsoleServiceSpecConsoleServer(
            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecConsoleServerLivenessProbe livenessProbe,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecConsoleServerReadinessProbe readinessProbe,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecConsoleServerResources resources,

            Pulumi.Kubernetes.Types.Outputs.Admin.V1Beta1.ConsoleServiceSpecConsoleServerSession session)
        {
            LivenessProbe = livenessProbe;
            ReadinessProbe = readinessProbe;
            Resources = resources;
            Session = session;
        }
    }
}
