// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Camel.V1Alpha1
{

    [OutputType]
    public sealed class KameletSpecSources
    {
        public readonly bool Compression;
        public readonly string Content;
        public readonly string ContentKey;
        public readonly string ContentRef;
        /// <summary>
        /// Interceptors are optional identifiers the org.apache.camel.k.RoutesLoader uses to pre/post process sources
        /// </summary>
        public readonly ImmutableArray<string> Interceptors;
        /// <summary>
        /// Language --
        /// </summary>
        public readonly string Language;
        /// <summary>
        /// Loader is an optional id of the org.apache.camel.k.RoutesLoader that will interpret this source at runtime
        /// </summary>
        public readonly string Loader;
        public readonly string Name;
        /// <summary>
        /// List of property names defined in the source (e.g. if type is "template")
        /// </summary>
        public readonly ImmutableArray<string> Property-names;
        /// <summary>
        /// Type defines the kind of source described by this object
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private KameletSpecSources(
            bool compression,

            string content,

            string contentKey,

            string contentRef,

            ImmutableArray<string> interceptors,

            string language,

            string loader,

            string name,

            ImmutableArray<string> property-names,

            string type)
        {
            Compression = compression;
            Content = content;
            ContentKey = contentKey;
            ContentRef = contentRef;
            Interceptors = interceptors;
            Language = language;
            Loader = loader;
            Name = name;
            Property-names = property-names;
            Type = type;
        }
    }
}
