// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.App.V1Alpha1
{

    /// <summary>
    /// Image definition for the service. Example: Domain: quay.io, Namespace: kiegroup, Name: kogito-service, Tag: latest. On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
    /// </summary>
    public class KogitoDataIndexSpecImageArgs : Pulumi.ResourceArgs
    {
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("tag")]
        public Input<string>? Tag { get; set; }

        public KogitoDataIndexSpecImageArgs()
        {
        }
    }
}
