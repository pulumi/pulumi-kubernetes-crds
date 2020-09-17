// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Operator.V1
{

    /// <summary>
    /// GenerationStatus keeps track of the generation for a given resource so that decisions about forced updates can be made. the definition matches the GenerationStatus defined in github.com/openshift/api/v1
    /// </summary>
    public class KlusterletStatusGenerationsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// group is the group of the thing you're tracking
        /// </summary>
        [Input("group")]
        public Input<string>? Group { get; set; }

        /// <summary>
        /// lastGeneration is the last generation of the thing that controller applies
        /// </summary>
        [Input("lastGeneration")]
        public Input<int>? LastGeneration { get; set; }

        /// <summary>
        /// name is the name of the thing you're tracking
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// namespace is where the thing you're tracking is
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// resource is the resource type of the thing you're tracking
        /// </summary>
        [Input("resource")]
        public Input<string>? Resource { get; set; }

        /// <summary>
        /// version is the version of the thing you're tracking
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public KlusterletStatusGenerationsArgs()
        {
        }
    }
}