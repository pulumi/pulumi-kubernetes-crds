// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Hyperfoil.V1Alpha1
{

    [OutputType]
    public sealed class HyperfoilSpec
    {
        /// <summary>
        /// Deploy timeout for agents, in milliseconds.
        /// </summary>
        public readonly int AgentDeployTimeout;
        /// <summary>
        /// Controller image. If 'version' is defined, too, the tag is replaced (or appended). Defaults to 'quay.io/hyperfoil/hyperfoil'
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// Name of the config map and optionally its entry (separated by '/': e.g myconfigmap/log4j2-superverbose.xml) storing Log4j2 configuration file. By default the Controller uses its embedded configuration.
        /// </summary>
        public readonly string Log;
        /// <summary>
        /// Name of the PVC hyperfoil should mount for its workdir.
        /// </summary>
        public readonly string PersistentVolumeClaim;
        /// <summary>
        /// Name of config map holding hooks that run when the run finishes.
        /// </summary>
        public readonly string PostHooks;
        /// <summary>
        /// Name of config map holding hooks that run before the run starts.
        /// </summary>
        public readonly string PreHooks;
        /// <summary>
        /// Host for the route leading to Controller REST endpoint.
        /// </summary>
        public readonly string Route;
        /// <summary>
        /// List of secrets in this namespace; each entry from those secrets will be mapped as environment variable, using the key as variable name.
        /// </summary>
        public readonly ImmutableArray<string> SecretEnvVars;
        /// <summary>
        /// If this is set the controller does not start benchmark run right away after hitting /benchmark/my-benchmark/start ; instead it responds with status 301 and header Location set to concatenation of this string and 'BENCHMARK=my-benchmark&amp;RUN_ID=xxxx'. CLI interprets that response as a request to hit CI instance on this URL, assuming that CI will trigger a new job that will eventually call /benchmark/my-benchmark/start?runId=xxxx with header 'x-trigger-job'. This is useful if the the CI has to synchronize Hyperfoil to other benchmarks that don't use this controller instance.
        /// </summary>
        public readonly string TriggerUrl;
        /// <summary>
        /// Tag for controller image. Defaults to version matching the operator version.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private HyperfoilSpec(
            int agentDeployTimeout,

            string image,

            string log,

            string persistentVolumeClaim,

            string postHooks,

            string preHooks,

            string route,

            ImmutableArray<string> secretEnvVars,

            string triggerUrl,

            string version)
        {
            AgentDeployTimeout = agentDeployTimeout;
            Image = image;
            Log = log;
            PersistentVolumeClaim = persistentVolumeClaim;
            PostHooks = postHooks;
            PreHooks = preHooks;
            Route = route;
            SecretEnvVars = secretEnvVars;
            TriggerUrl = triggerUrl;
            Version = version;
        }
    }
}