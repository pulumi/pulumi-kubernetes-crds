// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hive.V1
{

    [OutputType]
    public sealed class SelectorSyncSetSpecPatches
    {
        /// <summary>
        /// APIVersion is the Group and Version of the object to be patched.
        /// </summary>
        public readonly string ApiVersion;
        /// <summary>
        /// Kind is the Kind of the object to be patched.
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Name is the name of the object to be patched.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Namespace is the Namespace in which the object to patch exists. Defaults to the SyncSet's Namespace.
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// Patch is the patch to apply.
        /// </summary>
        public readonly string Patch;
        /// <summary>
        /// PatchType indicates the PatchType as "strategic" (default), "json", or "merge".
        /// </summary>
        public readonly string PatchType;

        [OutputConstructor]
        private SelectorSyncSetSpecPatches(
            string apiVersion,

            string kind,

            string name,

            string @namespace,

            string patch,

            string patchType)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Name = name;
            Namespace = @namespace;
            Patch = patch;
            PatchType = patchType;
        }
    }
}
