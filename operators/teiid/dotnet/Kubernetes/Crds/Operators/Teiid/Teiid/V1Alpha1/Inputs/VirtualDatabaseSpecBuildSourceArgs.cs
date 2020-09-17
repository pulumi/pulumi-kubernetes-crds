// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Teiid.V1Alpha1
{

    /// <summary>
    /// VDB Source details
    /// </summary>
    public class VirtualDatabaseSpecBuildSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// DDL based VDB
        /// </summary>
        [Input("ddl")]
        public Input<string>? Ddl { get; set; }

        [Input("dependencies")]
        private InputList<string>? _dependencies;

        /// <summary>
        /// List of maven dependencies for the build in GAV format
        /// </summary>
        public InputList<string> Dependencies
        {
            get => _dependencies ?? (_dependencies = new InputList<string>());
            set => _dependencies = value;
        }

        /// <summary>
        /// A VDB defined in GAV format
        /// </summary>
        [Input("maven")]
        public Input<string>? Maven { get; set; }

        [Input("mavenRepositories")]
        private InputMap<string>? _mavenRepositories;

        /// <summary>
        /// Custom maven repositories that need to be used for the S2I build
        /// </summary>
        public InputMap<string> MavenRepositories
        {
            get => _mavenRepositories ?? (_mavenRepositories = new InputMap<string>());
            set => _mavenRepositories = value;
        }

        /// <summary>
        /// Open API contract that is exposed by the VDB
        /// </summary>
        [Input("openapi")]
        public Input<string>? Openapi { get; set; }

        /// <summary>
        /// Deployed vdb version. For embedded DDL version this will be implicitly provided when ignored, for maven based vdb the maven version is always
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public VirtualDatabaseSpecBuildSourceArgs()
        {
        }
    }
}