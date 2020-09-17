// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1
{

    [OutputType]
    public sealed class GroupSyncSpecProvidersLdapRfc2307GroupsQuery
    {
        /// <summary>
        /// The DN of the branch of the directory where all searches should start from
        /// </summary>
        public readonly string BaseDN;
        /// <summary>
        /// The (optional) behavior of the search with regards to alisases. Can be: never:  never dereference aliases, search: only dereference in searching, base:   only dereference in finding the base object, always: always dereference Defaults to always dereferencing if not set
        /// </summary>
        public readonly string DerefAliases;
        /// <summary>
        /// Filter is a valid LDAP search filter that retrieves all relevant entries from the LDAP server with the base DN
        /// </summary>
        public readonly string Filter;
        /// <summary>
        /// PageSize is the maximum preferred page size, measured in LDAP entries. A page size of 0 means no paging will be done.
        /// </summary>
        public readonly int PageSize;
        /// <summary>
        /// The (optional) scope of the search. Can be: base: only the base object, one:  all object on the base level, sub:  the entire subtree Defaults to the entire subtree if not set
        /// </summary>
        public readonly string Scope;
        /// <summary>
        /// TimeLimit holds the limit of time in seconds that any request to the server can remain outstanding before the wait for a response is given up. If this is 0, no client-side limit is imposed
        /// </summary>
        public readonly int Timeout;

        [OutputConstructor]
        private GroupSyncSpecProvidersLdapRfc2307GroupsQuery(
            string baseDN,

            string derefAliases,

            string filter,

            int pageSize,

            string scope,

            int timeout)
        {
            BaseDN = baseDN;
            DerefAliases = derefAliases;
            Filter = filter;
            PageSize = pageSize;
            Scope = scope;
            Timeout = timeout;
        }
    }
}
