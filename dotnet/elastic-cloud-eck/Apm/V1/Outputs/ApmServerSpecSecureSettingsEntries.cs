// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apm.V1
{

    [OutputType]
    public sealed class ApmServerSpecSecureSettingsEntries
    {
        /// <summary>
        /// Key is the key contained in the secret.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Path is the relative file path to map the key to. Path must not be an absolute file path and must not contain any ".." components.
        /// </summary>
        public readonly string Path;

        [OutputConstructor]
        private ApmServerSpecSecureSettingsEntries(
            string key,

            string path)
        {
            Key = key;
            Path = path;
        }
    }
}
