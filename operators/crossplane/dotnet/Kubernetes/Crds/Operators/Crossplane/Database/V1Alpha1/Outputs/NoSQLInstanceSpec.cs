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
    public sealed class NoSQLInstanceSpec
    {
        /// <summary>
        /// A ClassReference specifies a resource class that will be used to dynamically provision a managed resource when the resource claim is created.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.NoSQLInstanceSpecClassRef ClassRef;
        /// <summary>
        /// A ClassSelector specifies labels that will be used to select a resource class for this claim. If multiple classes match the labels one will be chosen at random.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.NoSQLInstanceSpecClassSelector ClassSelector;
        /// <summary>
        /// A ResourceReference specifies an existing managed resource, in any namespace, to which this resource claim should attempt to bind. Omit the resource reference to enable dynamic provisioning using a resource class; the resource reference will be automatically populated by Crossplane.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.NoSQLInstanceSpecResourceRef ResourceRef;
        /// <summary>
        /// WriteConnectionSecretToReference specifies the name of a Secret, in the same namespace as this resource claim, to which any connection details for this resource claim should be written. Connection details frequently include the endpoint, username, and password required to connect to the managed resource bound to this resource claim.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.NoSQLInstanceSpecWriteConnectionSecretToRef WriteConnectionSecretToRef;

        [OutputConstructor]
        private NoSQLInstanceSpec(
            Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.NoSQLInstanceSpecClassRef classRef,

            Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.NoSQLInstanceSpecClassSelector classSelector,

            Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.NoSQLInstanceSpecResourceRef resourceRef,

            Pulumi.Kubernetes.Types.Outputs.Database.V1Alpha1.NoSQLInstanceSpecWriteConnectionSecretToRef writeConnectionSecretToRef)
        {
            ClassRef = classRef;
            ClassSelector = classSelector;
            ResourceRef = resourceRef;
            WriteConnectionSecretToRef = writeConnectionSecretToRef;
        }
    }
}
