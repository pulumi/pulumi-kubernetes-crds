// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1
{

    [OutputType]
    public sealed class PostgreSQLInstanceSpec
    {
        /// <summary>
        /// A ClassReference specifies a resource class that will be used to dynamically provision a managed resource when the resource claim is created.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.PostgreSQLInstanceSpecClassRef ClassRef;
        /// <summary>
        /// A ClassSelector specifies labels that will be used to select a resource class for this claim. If multiple classes match the labels one will be chosen at random.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.PostgreSQLInstanceSpecClassSelector ClassSelector;
        /// <summary>
        /// EngineVersion specifies the desired PostgreSQL engine version. Allowed Versions: 9.6 and 11.
        /// </summary>
        public readonly string EngineVersion;
        /// <summary>
        /// A ResourceReference specifies an existing managed resource, in any namespace, to which this resource claim should attempt to bind. Omit the resource reference to enable dynamic provisioning using a resource class; the resource reference will be automatically populated by Crossplane.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.PostgreSQLInstanceSpecResourceRef ResourceRef;
        /// <summary>
        /// WriteConnectionSecretToReference specifies the name of a Secret, in the same namespace as this resource claim, to which any connection details for this resource claim should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource bound to this resource claim.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.PostgreSQLInstanceSpecWriteConnectionSecretToRef WriteConnectionSecretToRef;

        [OutputConstructor]
        private PostgreSQLInstanceSpec(
            Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.PostgreSQLInstanceSpecClassRef classRef,

            Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.PostgreSQLInstanceSpecClassSelector classSelector,

            string engineVersion,

            Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.PostgreSQLInstanceSpecResourceRef resourceRef,

            Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.PostgreSQLInstanceSpecWriteConnectionSecretToRef writeConnectionSecretToRef)
        {
            ClassRef = classRef;
            ClassSelector = classSelector;
            EngineVersion = engineVersion;
            ResourceRef = resourceRef;
            WriteConnectionSecretToRef = writeConnectionSecretToRef;
        }
    }
}
