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
    public sealed class ApplicationSpecInfoValueFromConfigMapKeyRef
    {
        /// <summary>
        /// API version of the referent.
        /// </summary>
        public readonly string ApiVersion;
        /// <summary>
        /// If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object. TODO: this design is not final and this field is subject to change in the future.
        /// </summary>
        public readonly string FieldPath;
        /// <summary>
        /// The key to select.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
        /// </summary>
        public readonly string ResourceVersion;
        /// <summary>
        /// UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
        /// </summary>
        public readonly string Uid;

        [OutputConstructor]
        private ApplicationSpecInfoValueFromConfigMapKeyRef(
            string apiVersion,

            string fieldPath,

            string key,

            string kind,

            string name,

            string @namespace,

            string resourceVersion,

            string uid)
        {
            ApiVersion = apiVersion;
            FieldPath = fieldPath;
            Key = key;
            Kind = kind;
            Name = name;
            Namespace = @namespace;
            ResourceVersion = resourceVersion;
            Uid = uid;
        }
    }
}
