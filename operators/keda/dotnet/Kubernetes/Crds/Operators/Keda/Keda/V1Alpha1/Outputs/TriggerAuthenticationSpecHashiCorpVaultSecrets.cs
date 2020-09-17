// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Keda.V1Alpha1
{

    [OutputType]
    public sealed class TriggerAuthenticationSpecHashiCorpVaultSecrets
    {
        public readonly string Key;
        public readonly string Parameter;
        public readonly string Path;

        [OutputConstructor]
        private TriggerAuthenticationSpecHashiCorpVaultSecrets(
            string key,

            string parameter,

            string path)
        {
            Key = key;
            Parameter = parameter;
            Path = path;
        }
    }
}
