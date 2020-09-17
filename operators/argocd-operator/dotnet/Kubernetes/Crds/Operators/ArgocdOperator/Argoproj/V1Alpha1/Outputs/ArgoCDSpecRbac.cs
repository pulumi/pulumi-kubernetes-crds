// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ArgoCDSpecRbac
    {
        /// <summary>
        /// DefaultPolicy is the name of the default role which Argo CD will falls back to, when authorizing API requests (optional). If omitted or empty, users may be still be able to login, but will see no apps, projects, etc...
        /// </summary>
        public readonly string DefaultPolicy;
        /// <summary>
        /// Policy is CSV containing user-defined RBAC policies and role definitions. Policy rules are in the form:   p, subject, resource, action, object, effect Role definitions and bindings are in the form:   g, subject, inherited-subject See https://github.com/argoproj/argo-cd/blob/master/docs/operator-manual/rbac.md for additional information.
        /// </summary>
        public readonly string Policy;
        /// <summary>
        /// Scopes controls which OIDC scopes to examine during rbac enforcement (in addition to `sub` scope). If omitted, defaults to: '[groups]'.
        /// </summary>
        public readonly string Scopes;

        [OutputConstructor]
        private ArgoCDSpecRbac(
            string defaultPolicy,

            string policy,

            string scopes)
        {
            DefaultPolicy = defaultPolicy;
            Policy = policy;
            Scopes = scopes;
        }
    }
}