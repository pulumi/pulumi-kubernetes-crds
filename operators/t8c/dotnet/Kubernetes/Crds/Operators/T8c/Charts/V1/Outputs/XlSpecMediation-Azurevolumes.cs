// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Charts.V1
{

    [OutputType]
    public sealed class XlSpecMediation-Azurevolumes
    {
        /// <summary>
        /// component specific pod annotations list
        /// </summary>
        public readonly ImmutableDictionary<string, object> Annotations;
        /// <summary>
        /// component debug
        /// </summary>
        public readonly bool Debug;
        /// <summary>
        /// component specific image options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecMediation-AzurevolumesImage Image;
        /// <summary>
        /// component additional java options
        /// </summary>
        public readonly string JavaComponentOptions;
        /// <summary>
        /// component resource configuration
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecMediation-AzurevolumesResources Resources;

        [OutputConstructor]
        private XlSpecMediation-Azurevolumes(
            ImmutableDictionary<string, object> annotations,

            bool debug,

            Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecMediation-AzurevolumesImage image,

            string javaComponentOptions,

            Pulumi.Kubernetes.Types.Outputs.Charts.V1.XlSpecMediation-AzurevolumesResources resources)
        {
            Annotations = annotations;
            Debug = debug;
            Image = image;
            JavaComponentOptions = javaComponentOptions;
            Resources = resources;
        }
    }
}
