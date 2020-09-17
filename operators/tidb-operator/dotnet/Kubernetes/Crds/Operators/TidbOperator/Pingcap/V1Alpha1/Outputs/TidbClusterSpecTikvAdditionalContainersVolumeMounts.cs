// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Pingcap.V1Alpha1
{

    [OutputType]
    public sealed class TidbClusterSpecTikvAdditionalContainersVolumeMounts
    {
        public readonly string MountPath;
        public readonly string MountPropagation;
        public readonly string Name;
        public readonly bool ReadOnly;
        public readonly string SubPath;
        public readonly string SubPathExpr;

        [OutputConstructor]
        private TidbClusterSpecTikvAdditionalContainersVolumeMounts(
            string mountPath,

            string mountPropagation,

            string name,

            bool readOnly,

            string subPath,

            string subPathExpr)
        {
            MountPath = mountPath;
            MountPropagation = mountPropagation;
            Name = name;
            ReadOnly = readOnly;
            SubPath = subPath;
            SubPathExpr = subPathExpr;
        }
    }
}
