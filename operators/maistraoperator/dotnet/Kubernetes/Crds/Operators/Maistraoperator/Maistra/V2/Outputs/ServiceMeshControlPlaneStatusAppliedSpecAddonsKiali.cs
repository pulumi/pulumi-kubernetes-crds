// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Maistra.V2
{

    [OutputType]
    public sealed class ServiceMeshControlPlaneStatusAppliedSpecAddonsKiali
    {
        public readonly bool Enabled;
        public readonly Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiInstall Install;
        public readonly string Name;

        [OutputConstructor]
        private ServiceMeshControlPlaneStatusAppliedSpecAddonsKiali(
            bool enabled,

            Pulumi.Kubernetes.Types.Outputs.Maistra.V2.ServiceMeshControlPlaneStatusAppliedSpecAddonsKialiInstall install,

            string name)
        {
            Enabled = enabled;
            Install = install;
            Name = name;
        }
    }
}
