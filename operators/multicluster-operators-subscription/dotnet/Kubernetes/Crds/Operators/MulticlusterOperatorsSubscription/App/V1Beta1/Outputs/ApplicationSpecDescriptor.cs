// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.App.V1Beta1
{

    [OutputType]
    public sealed class ApplicationSpecDescriptor
    {
        /// <summary>
        /// Description is a brief string description of the Application.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Icons is an optional list of icons for an application. Icon information includes the source, size, and mime type.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.ApplicationSpecDescriptorIcons> Icons;
        /// <summary>
        /// Keywords is an optional list of key words associated with the application (e.g. MySQL, RDBMS, database).
        /// </summary>
        public readonly ImmutableArray<string> Keywords;
        /// <summary>
        /// Links are a list of descriptive URLs intended to be used to surface additional documentation, dashboards, etc.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.ApplicationSpecDescriptorLinks> Links;
        /// <summary>
        /// Maintainers is an optional list of maintainers of the application. The maintainers in this list maintain the the source code, images, and package for the application.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.ApplicationSpecDescriptorMaintainers> Maintainers;
        /// <summary>
        /// Notes contain a human readable snippets intended as a quick start for the users of the Application. CommonMark markdown syntax may be used for rich text representation.
        /// </summary>
        public readonly string Notes;
        /// <summary>
        /// Owners is an optional list of the owners of the installed application. The owners of the application should be contacted in the event of a planned or unplanned disruption affecting the application.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.ApplicationSpecDescriptorOwners> Owners;
        /// <summary>
        /// Type is the type of the application (e.g. WordPress, MySQL, Cassandra).
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Version is an optional version indicator for the Application.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private ApplicationSpecDescriptor(
            string description,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.ApplicationSpecDescriptorIcons> icons,

            ImmutableArray<string> keywords,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.ApplicationSpecDescriptorLinks> links,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.ApplicationSpecDescriptorMaintainers> maintainers,

            string notes,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.App.V1Beta1.ApplicationSpecDescriptorOwners> owners,

            string type,

            string version)
        {
            Description = description;
            Icons = icons;
            Keywords = keywords;
            Links = links;
            Maintainers = maintainers;
            Notes = notes;
            Owners = owners;
            Type = type;
            Version = version;
        }
    }
}