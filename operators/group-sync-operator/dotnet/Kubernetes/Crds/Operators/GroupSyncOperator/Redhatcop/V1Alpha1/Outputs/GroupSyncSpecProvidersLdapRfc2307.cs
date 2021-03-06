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
    public sealed class GroupSyncSpecProvidersLdapRfc2307
    {
        /// <summary>
        /// GroupMembershipAttributes defines which attributes on an LDAP group entry will be interpreted  as its members. The values contained in those attributes must be queryable by your UserUIDAttribute
        /// </summary>
        public readonly ImmutableArray<string> GroupMembershipAttributes;
        /// <summary>
        /// GroupNameAttributes defines which attributes on an LDAP group entry will be interpreted as its name to use for an OpenShift group
        /// </summary>
        public readonly ImmutableArray<string> GroupNameAttributes;
        /// <summary>
        /// GroupUIDAttributes defines which attribute on an LDAP group entry will be interpreted as its unique identifier. (ldapGroupUID)
        /// </summary>
        public readonly string GroupUIDAttribute;
        /// <summary>
        /// AllGroupsQuery holds the template for an LDAP query that returns group entries.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersLdapRfc2307GroupsQuery GroupsQuery;
        /// <summary>
        /// TolerateMemberNotFoundErrors determines the behavior of the LDAP sync job when missing user entries are encountered. If 'true', an LDAP query for users that doesn't find any will be tolerated and an only and error will be logged. If 'false', the LDAP sync job will fail if a query for users doesn't find any. The default value is 'false'. Misconfigured LDAP sync jobs with this flag set to 'true' can cause group membership to be removed, so it is recommended to use this flag with caution.
        /// </summary>
        public readonly bool TolerateMemberNotFoundErrors;
        /// <summary>
        /// TolerateMemberOutOfScopeErrors determines the behavior of the LDAP sync job when out-of-scope user entries are encountered. If 'true', an LDAP query for a user that falls outside of the base DN given for the all user query will be tolerated and only an error will be logged. If 'false', the LDAP sync job will fail if a user query would search outside of the base DN specified by the all user query. Misconfigured LDAP sync jobs with this flag set to 'true' can result in groups missing users, so it is recommended to use this flag with caution.
        /// </summary>
        public readonly bool TolerateMemberOutOfScopeErrors;
        /// <summary>
        /// UserNameAttributes defines which attributes on an LDAP user entry will be used, in order, as its OpenShift user name. The first attribute with a non-empty value is used. This should match your PreferredUsername setting for your LDAPPasswordIdentityProvider
        /// </summary>
        public readonly ImmutableArray<string> UserNameAttributes;
        /// <summary>
        /// UserUIDAttribute defines which attribute on an LDAP user entry will be interpreted as its unique identifier. It must correspond to values that will be found from the GroupMembershipAttributes
        /// </summary>
        public readonly string UserUIDAttribute;
        /// <summary>
        /// AllUsersQuery holds the template for an LDAP query that returns user entries.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersLdapRfc2307UsersQuery UsersQuery;

        [OutputConstructor]
        private GroupSyncSpecProvidersLdapRfc2307(
            ImmutableArray<string> groupMembershipAttributes,

            ImmutableArray<string> groupNameAttributes,

            string groupUIDAttribute,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersLdapRfc2307GroupsQuery groupsQuery,

            bool tolerateMemberNotFoundErrors,

            bool tolerateMemberOutOfScopeErrors,

            ImmutableArray<string> userNameAttributes,

            string userUIDAttribute,

            Pulumi.Kubernetes.Types.Outputs.Redhatcop.V1Alpha1.GroupSyncSpecProvidersLdapRfc2307UsersQuery usersQuery)
        {
            GroupMembershipAttributes = groupMembershipAttributes;
            GroupNameAttributes = groupNameAttributes;
            GroupUIDAttribute = groupUIDAttribute;
            GroupsQuery = groupsQuery;
            TolerateMemberNotFoundErrors = tolerateMemberNotFoundErrors;
            TolerateMemberOutOfScopeErrors = tolerateMemberOutOfScopeErrors;
            UserNameAttributes = userNameAttributes;
            UserUIDAttribute = userUIDAttribute;
            UsersQuery = usersQuery;
        }
    }
}
