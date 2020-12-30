// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Org.V1
{

    [OutputType]
    public sealed class CheClusterSpecServerCheServerRoute
    {
        /// <summary>
        /// Comma separated list of labels that can be used to organize and categorize (scope and select) objects.
        /// </summary>
        public readonly string Labels;

        [OutputConstructor]
        private CheClusterSpecServerCheServerRoute(string labels)
        {
            Labels = labels;
        }
    }
}
