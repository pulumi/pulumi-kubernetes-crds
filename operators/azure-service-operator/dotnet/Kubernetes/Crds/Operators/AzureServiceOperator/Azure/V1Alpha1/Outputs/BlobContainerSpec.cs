// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1
{

    [OutputType]
    public sealed class BlobContainerSpec
    {
        /// <summary>
        /// PublicAccess enumerates the values for public access.
        /// </summary>
        public readonly string Accesslevel;
        public readonly string Accountname;
        /// <summary>
        /// INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        /// </summary>
        public readonly string Location;
        public readonly string Resourcegroup;

        [OutputConstructor]
        private BlobContainerSpec(
            string accesslevel,

            string accountname,

            string location,

            string resourcegroup)
        {
            Accesslevel = accesslevel;
            Accountname = accountname;
            Location = location;
            Resourcegroup = resourcegroup;
        }
    }
}
