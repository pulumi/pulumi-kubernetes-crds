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
    /// Image used as the base image for the final Kogito service. This image only has the required packages to run the application. For example: quarkus based services will have only JVM installed, native services only the packages required by the OS. The operator will use the one provided by the Kogito Team based on the "Runtime" field. Example: Domain: quay.io, Namespace: kiegroup, Name: kogito-jvm-builder, Tag: latest. On OpenShift an ImageStream will be created in the current namespace pointing to the given image.
    /// </summary>
    public class KogitoBuildSpecRuntimeImageArgs : Pulumi.ResourceArgs
    {
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("tag")]
        public Input<string>? Tag { get; set; }

        public KogitoBuildSpecRuntimeImageArgs()
        {
        }
    }
}
