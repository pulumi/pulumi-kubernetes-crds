// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Maistra.V2
{

    public class ServiceMeshControlPlaneStatusAppliedSpecSecurityCertificateAuthorityIstiodSelfSignedArgs : Pulumi.ResourceArgs
    {
        [Input("checkPeriod")]
        public Input<string>? CheckPeriod { get; set; }

        [Input("enableJitter")]
        public Input<bool>? EnableJitter { get; set; }

        [Input("gracePeriod")]
        public Input<string>? GracePeriod { get; set; }

        [Input("ttl")]
        public Input<string>? Ttl { get; set; }

        public ServiceMeshControlPlaneStatusAppliedSpecSecurityCertificateAuthorityIstiodSelfSignedArgs()
        {
        }
    }
}
