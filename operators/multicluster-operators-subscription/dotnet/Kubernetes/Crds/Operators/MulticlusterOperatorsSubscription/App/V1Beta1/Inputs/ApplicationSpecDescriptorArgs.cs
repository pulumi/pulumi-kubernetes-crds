// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.App.V1Beta1
{

    /// <summary>
    /// Descriptor regroups information and metadata about an application.
    /// </summary>
    public class ApplicationSpecDescriptorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description is a brief string description of the Application.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("icons")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorIconsArgs>? _icons;

        /// <summary>
        /// Icons is an optional list of icons for an application. Icon information includes the source, size, and mime type.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorIconsArgs> Icons
        {
            get => _icons ?? (_icons = new InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorIconsArgs>());
            set => _icons = value;
        }

        [Input("keywords")]
        private InputList<string>? _keywords;

        /// <summary>
        /// Keywords is an optional list of key words associated with the application (e.g. MySQL, RDBMS, database).
        /// </summary>
        public InputList<string> Keywords
        {
            get => _keywords ?? (_keywords = new InputList<string>());
            set => _keywords = value;
        }

        [Input("links")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorLinksArgs>? _links;

        /// <summary>
        /// Links are a list of descriptive URLs intended to be used to surface additional documentation, dashboards, etc.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorLinksArgs> Links
        {
            get => _links ?? (_links = new InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorLinksArgs>());
            set => _links = value;
        }

        [Input("maintainers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorMaintainersArgs>? _maintainers;

        /// <summary>
        /// Maintainers is an optional list of maintainers of the application. The maintainers in this list maintain the the source code, images, and package for the application.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorMaintainersArgs> Maintainers
        {
            get => _maintainers ?? (_maintainers = new InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorMaintainersArgs>());
            set => _maintainers = value;
        }

        /// <summary>
        /// Notes contain a human readable snippets intended as a quick start for the users of the Application. CommonMark markdown syntax may be used for rich text representation.
        /// </summary>
        [Input("notes")]
        public Input<string>? Notes { get; set; }

        [Input("owners")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorOwnersArgs>? _owners;

        /// <summary>
        /// Owners is an optional list of the owners of the installed application. The owners of the application should be contacted in the event of a planned or unplanned disruption affecting the application.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorOwnersArgs> Owners
        {
            get => _owners ?? (_owners = new InputList<Pulumi.Kubernetes.Types.Inputs.App.V1Beta1.ApplicationSpecDescriptorOwnersArgs>());
            set => _owners = value;
        }

        /// <summary>
        /// Type is the type of the application (e.g. WordPress, MySQL, Cassandra).
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Version is an optional version indicator for the Application.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public ApplicationSpecDescriptorArgs()
        {
        }
    }
}
