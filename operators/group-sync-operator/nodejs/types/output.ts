// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace redhatcop {
    export namespace v1alpha1 {
        /**
         * GroupSyncSpec defines the desired state of GroupSync
         */
        export interface GroupSyncSpec {
            /**
             * List of Providers that can be mounted by containers belonging to the pod.
             */
            providers?: outputs.redhatcop.v1alpha1.GroupSyncSpecProviders[];
            schedule?: string;
        }

        /**
         * Provider represents the container for a single provider
         */
        export interface GroupSyncSpecProviders {
            /**
             * Azure represents the Azure provider
             */
            azure?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersAzure;
            /**
             * GitHub represents the GitHub provider
             */
            github?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersGithub;
            /**
             * GitLab represents the GitLab provider
             */
            gitlab?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersGitlab;
            /**
             * Keycloak represents the Keycloak provider
             */
            keycloak?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersKeycloak;
            /**
             * Ldap represents the LDAP provider
             */
            ldap?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdap;
            /**
             * Name represents the name of the provider
             */
            name?: string;
        }

        /**
         * Azure represents the Azure provider
         */
        export interface GroupSyncSpecProvidersAzure {
            /**
             * CredentialsSecret is a reference to a secret containing authentication details for communicating to Azure
             */
            credentialsSecret: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersAzureCredentialsSecret;
            /**
             * Groups represents a filtered list of groups to synchronize
             */
            groups?: string[];
            /**
             * Insecure specifies whether to allow for unverified certificates to be used when communicating to Azure
             */
            insecure?: boolean;
            /**
             * URL is the location of the Azure platform
             */
            url?: string;
        }

        /**
         * CredentialsSecret is a reference to a secret containing authentication details for communicating to Azure
         */
        export interface GroupSyncSpecProvidersAzureCredentialsSecret {
            /**
             * Key represents the specific key to reference from the secret
             */
            key?: string;
            /**
             * Name represents the name of the secret
             */
            name: string;
            /**
             * Namespace represents the namespace containing the secret
             */
            namespace: string;
        }

        /**
         * GitHub represents the GitHub provider
         */
        export interface GroupSyncSpecProvidersGithub {
            /**
             * CaSecret is a reference to a secret containing a CA certificate to communicate to the GitHub server
             */
            caSecret?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersGithubCaSecret;
            /**
             * CredentialsSecret is a reference to a secret containing authentication details for the GitHub server
             */
            credentialsSecret: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersGithubCredentialsSecret;
            /**
             * Insecure specifies whether to allow for unverified certificates to be used when communicating to GitHab
             */
            insecure?: boolean;
            /**
             * Organization represents the location to source teams to synchronize
             */
            organization?: string;
            /**
             * Teams represents a filtered list of teams to synchronize
             */
            teams?: string[];
            /**
             * URL is the location of the GitHub server
             */
            url?: string;
        }

        /**
         * CaSecret is a reference to a secret containing a CA certificate to communicate to the GitHub server
         */
        export interface GroupSyncSpecProvidersGithubCaSecret {
            /**
             * Key represents the specific key to reference from the secret
             */
            key?: string;
            /**
             * Name represents the name of the secret
             */
            name: string;
            /**
             * Namespace represents the namespace containing the secret
             */
            namespace: string;
        }

        /**
         * CredentialsSecret is a reference to a secret containing authentication details for the GitHub server
         */
        export interface GroupSyncSpecProvidersGithubCredentialsSecret {
            /**
             * Key represents the specific key to reference from the secret
             */
            key?: string;
            /**
             * Name represents the name of the secret
             */
            name: string;
            /**
             * Namespace represents the namespace containing the secret
             */
            namespace: string;
        }

        /**
         * GitLab represents the GitLab provider
         */
        export interface GroupSyncSpecProvidersGitlab {
            /**
             * CaSecret is a reference to a secret containing a CA certificate to communicate to the GitLab server
             */
            caSecret?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersGitlabCaSecret;
            /**
             * CredentialsSecret is a reference to a secret containing authentication details for the GitLab server
             */
            credentialsSecret: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersGitlabCredentialsSecret;
            /**
             * Groups represents a filtered list of groups to synchronize
             */
            groups?: string[];
            /**
             * Insecure specifies whether to allow for unverified certificates to be used when communicating to GitLab
             */
            insecure?: boolean;
            /**
             * URL is the location of the GitLub server
             */
            url?: string;
        }

        /**
         * CaSecret is a reference to a secret containing a CA certificate to communicate to the GitLab server
         */
        export interface GroupSyncSpecProvidersGitlabCaSecret {
            /**
             * Key represents the specific key to reference from the secret
             */
            key?: string;
            /**
             * Name represents the name of the secret
             */
            name: string;
            /**
             * Namespace represents the namespace containing the secret
             */
            namespace: string;
        }

        /**
         * CredentialsSecret is a reference to a secret containing authentication details for the GitLab server
         */
        export interface GroupSyncSpecProvidersGitlabCredentialsSecret {
            /**
             * Key represents the specific key to reference from the secret
             */
            key?: string;
            /**
             * Name represents the name of the secret
             */
            name: string;
            /**
             * Namespace represents the namespace containing the secret
             */
            namespace: string;
        }

        /**
         * Keycloak represents the Keycloak provider
         */
        export interface GroupSyncSpecProvidersKeycloak {
            /**
             * CaSecret is a reference to a secret containing a CA certificate to communicate to the Keycloak server
             */
            caSecret?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersKeycloakCaSecret;
            /**
             * CredentialsSecret is a reference to a secret containing authentication details for the Keycloak server
             */
            credentialsSecret: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersKeycloakCredentialsSecret;
            /**
             * Groups represents a filtered list of groups to synchronize
             */
            groups?: string[];
            /**
             * Insecure specifies whether to allow for unverified certificates to be used when communicating to Keycloak
             */
            insecure?: boolean;
            /**
             * LoginRealm is the Keycloak realm to authenticate against
             */
            loginRealm?: string;
            /**
             * Realm is the realm containing the groups to synchronize against
             */
            realm: string;
            /**
             * Scope represents the depth for which groups will be synchronized
             */
            scope?: string;
            /**
             * URL is the location of the Keycloak server
             */
            url: string;
        }

        /**
         * CaSecret is a reference to a secret containing a CA certificate to communicate to the Keycloak server
         */
        export interface GroupSyncSpecProvidersKeycloakCaSecret {
            /**
             * Key represents the specific key to reference from the secret
             */
            key?: string;
            /**
             * Name represents the name of the secret
             */
            name: string;
            /**
             * Namespace represents the namespace containing the secret
             */
            namespace: string;
        }

        /**
         * CredentialsSecret is a reference to a secret containing authentication details for the Keycloak server
         */
        export interface GroupSyncSpecProvidersKeycloakCredentialsSecret {
            /**
             * Key represents the specific key to reference from the secret
             */
            key?: string;
            /**
             * Name represents the name of the secret
             */
            name: string;
            /**
             * Namespace represents the namespace containing the secret
             */
            namespace: string;
        }

        /**
         * Ldap represents the LDAP provider
         */
        export interface GroupSyncSpecProvidersLdap {
            /**
             * ActiveDirectoryConfig represents the configuration for Active Directory
             */
            activeDirectory?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdapActiveDirectory;
            /**
             * ActiveDirectoryConfig represents the configuration for Augmented Active Directory
             */
            augmentedActiveDirectory?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdapAugmentedActiveDirectory;
            /**
             * Black represents a list of groups to not synchronize
             */
            blacklist?: string[];
            /**
             * CaSecret is a reference to a secret containing a CA certificate to communicate to the GitLab server
             */
            caSecret?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdapCaSecret;
            /**
             * CredentialsSecret is a reference to a secret containing authentication details for communicating to LDAP
             */
            credentialsSecret?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdapCredentialsSecret;
            /**
             * / LDAPGroupUIDToOpenShiftGroupNameMapping is an optional direct mapping of LDAP group UIDs to OpenShift group names
             */
            groupUIDNameMapping?: {[key: string]: string};
            /**
             * Insecure specifies whether to allow for unverified certificates to be used when communicating to LDAP
             */
            insecure?: boolean;
            /**
             * RFC2307Config represents the configuration for a RFC2307 schema
             */
            rfc2307?: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdapRfc2307;
            /**
             * URL is the location of the LDAP Server
             */
            url: string;
            /**
             * Whitelist represents a list of groups to synchronize
             */
            whitelist?: string[];
        }

        /**
         * ActiveDirectoryConfig represents the configuration for Active Directory
         */
        export interface GroupSyncSpecProvidersLdapActiveDirectory {
            /**
             * GroupMembershipAttributes defines which attributes on an LDAP user entry will be interpreted as the groups it is a member of
             */
            groupMembershipAttributes: string[];
            /**
             * UserNameAttributes defines which attributes on an LDAP user entry will be interpreted as its OpenShift user name.
             */
            userNameAttributes: string[];
            /**
             * AllUsersQuery holds the template for an LDAP query that returns user entries.
             */
            usersQuery: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdapActiveDirectoryUsersQuery;
        }

        /**
         * AllUsersQuery holds the template for an LDAP query that returns user entries.
         */
        export interface GroupSyncSpecProvidersLdapActiveDirectoryUsersQuery {
            /**
             * The DN of the branch of the directory where all searches should start from
             */
            baseDN: string;
            /**
             * The (optional) behavior of the search with regards to alisases. Can be: never:  never dereference aliases, search: only dereference in searching, base:   only dereference in finding the base object, always: always dereference Defaults to always dereferencing if not set
             */
            derefAliases?: string;
            /**
             * Filter is a valid LDAP search filter that retrieves all relevant entries from the LDAP server with the base DN
             */
            filter?: string;
            /**
             * PageSize is the maximum preferred page size, measured in LDAP entries. A page size of 0 means no paging will be done.
             */
            pageSize?: number;
            /**
             * The (optional) scope of the search. Can be: base: only the base object, one:  all object on the base level, sub:  the entire subtree Defaults to the entire subtree if not set
             */
            scope?: string;
            /**
             * TimeLimit holds the limit of time in seconds that any request to the server can remain outstanding before the wait for a response is given up. If this is 0, no client-side limit is imposed
             */
            timeout?: number;
        }

        /**
         * ActiveDirectoryConfig represents the configuration for Augmented Active Directory
         */
        export interface GroupSyncSpecProvidersLdapAugmentedActiveDirectory {
            /**
             * GroupMembershipAttributes defines which attributes on an LDAP user entry will be interpreted as the groups it is a member of
             */
            groupMembershipAttributes: string[];
            /**
             * GroupNameAttributes defines which attributes on an LDAP group entry will be interpreted as its name to use for an OpenShift group
             */
            groupNameAttributes: string[];
            /**
             * GroupUIDAttributes defines which attribute on an LDAP group entry will be interpreted as its unique identifier. (ldapGroupUID)
             */
            groupUIDAttribute: string;
            /**
             * AllGroupsQuery holds the template for an LDAP query that returns group entries.
             */
            groupsQuery: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdapAugmentedActiveDirectoryGroupsQuery;
            /**
             * UserNameAttributes defines which attributes on an LDAP user entry will be interpreted as its OpenShift user name.
             */
            userNameAttributes: string[];
            /**
             * AllUsersQuery holds the template for an LDAP query that returns user entries.
             */
            usersQuery: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdapAugmentedActiveDirectoryUsersQuery;
        }

        /**
         * AllGroupsQuery holds the template for an LDAP query that returns group entries.
         */
        export interface GroupSyncSpecProvidersLdapAugmentedActiveDirectoryGroupsQuery {
            /**
             * The DN of the branch of the directory where all searches should start from
             */
            baseDN: string;
            /**
             * The (optional) behavior of the search with regards to alisases. Can be: never:  never dereference aliases, search: only dereference in searching, base:   only dereference in finding the base object, always: always dereference Defaults to always dereferencing if not set
             */
            derefAliases?: string;
            /**
             * Filter is a valid LDAP search filter that retrieves all relevant entries from the LDAP server with the base DN
             */
            filter?: string;
            /**
             * PageSize is the maximum preferred page size, measured in LDAP entries. A page size of 0 means no paging will be done.
             */
            pageSize?: number;
            /**
             * The (optional) scope of the search. Can be: base: only the base object, one:  all object on the base level, sub:  the entire subtree Defaults to the entire subtree if not set
             */
            scope?: string;
            /**
             * TimeLimit holds the limit of time in seconds that any request to the server can remain outstanding before the wait for a response is given up. If this is 0, no client-side limit is imposed
             */
            timeout?: number;
        }

        /**
         * AllUsersQuery holds the template for an LDAP query that returns user entries.
         */
        export interface GroupSyncSpecProvidersLdapAugmentedActiveDirectoryUsersQuery {
            /**
             * The DN of the branch of the directory where all searches should start from
             */
            baseDN: string;
            /**
             * The (optional) behavior of the search with regards to alisases. Can be: never:  never dereference aliases, search: only dereference in searching, base:   only dereference in finding the base object, always: always dereference Defaults to always dereferencing if not set
             */
            derefAliases?: string;
            /**
             * Filter is a valid LDAP search filter that retrieves all relevant entries from the LDAP server with the base DN
             */
            filter?: string;
            /**
             * PageSize is the maximum preferred page size, measured in LDAP entries. A page size of 0 means no paging will be done.
             */
            pageSize?: number;
            /**
             * The (optional) scope of the search. Can be: base: only the base object, one:  all object on the base level, sub:  the entire subtree Defaults to the entire subtree if not set
             */
            scope?: string;
            /**
             * TimeLimit holds the limit of time in seconds that any request to the server can remain outstanding before the wait for a response is given up. If this is 0, no client-side limit is imposed
             */
            timeout?: number;
        }

        /**
         * CaSecret is a reference to a secret containing a CA certificate to communicate to the GitLab server
         */
        export interface GroupSyncSpecProvidersLdapCaSecret {
            /**
             * Key represents the specific key to reference from the secret
             */
            key?: string;
            /**
             * Name represents the name of the secret
             */
            name: string;
            /**
             * Namespace represents the namespace containing the secret
             */
            namespace: string;
        }

        /**
         * CredentialsSecret is a reference to a secret containing authentication details for communicating to LDAP
         */
        export interface GroupSyncSpecProvidersLdapCredentialsSecret {
            /**
             * Key represents the specific key to reference from the secret
             */
            key?: string;
            /**
             * Name represents the name of the secret
             */
            name: string;
            /**
             * Namespace represents the namespace containing the secret
             */
            namespace: string;
        }

        /**
         * RFC2307Config represents the configuration for a RFC2307 schema
         */
        export interface GroupSyncSpecProvidersLdapRfc2307 {
            /**
             * GroupMembershipAttributes defines which attributes on an LDAP group entry will be interpreted  as its members. The values contained in those attributes must be queryable by your UserUIDAttribute
             */
            groupMembershipAttributes: string[];
            /**
             * GroupNameAttributes defines which attributes on an LDAP group entry will be interpreted as its name to use for an OpenShift group
             */
            groupNameAttributes: string[];
            /**
             * GroupUIDAttributes defines which attribute on an LDAP group entry will be interpreted as its unique identifier. (ldapGroupUID)
             */
            groupUIDAttribute: string;
            /**
             * AllGroupsQuery holds the template for an LDAP query that returns group entries.
             */
            groupsQuery: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdapRfc2307GroupsQuery;
            /**
             * TolerateMemberNotFoundErrors determines the behavior of the LDAP sync job when missing user entries are encountered. If 'true', an LDAP query for users that doesn't find any will be tolerated and an only and error will be logged. If 'false', the LDAP sync job will fail if a query for users doesn't find any. The default value is 'false'. Misconfigured LDAP sync jobs with this flag set to 'true' can cause group membership to be removed, so it is recommended to use this flag with caution.
             */
            tolerateMemberNotFoundErrors?: boolean;
            /**
             * TolerateMemberOutOfScopeErrors determines the behavior of the LDAP sync job when out-of-scope user entries are encountered. If 'true', an LDAP query for a user that falls outside of the base DN given for the all user query will be tolerated and only an error will be logged. If 'false', the LDAP sync job will fail if a user query would search outside of the base DN specified by the all user query. Misconfigured LDAP sync jobs with this flag set to 'true' can result in groups missing users, so it is recommended to use this flag with caution.
             */
            tolerateMemberOutOfScopeErrors?: boolean;
            /**
             * UserNameAttributes defines which attributes on an LDAP user entry will be used, in order, as its OpenShift user name. The first attribute with a non-empty value is used. This should match your PreferredUsername setting for your LDAPPasswordIdentityProvider
             */
            userNameAttributes: string[];
            /**
             * UserUIDAttribute defines which attribute on an LDAP user entry will be interpreted as its unique identifier. It must correspond to values that will be found from the GroupMembershipAttributes
             */
            userUIDAttribute: string;
            /**
             * AllUsersQuery holds the template for an LDAP query that returns user entries.
             */
            usersQuery: outputs.redhatcop.v1alpha1.GroupSyncSpecProvidersLdapRfc2307UsersQuery;
        }

        /**
         * AllGroupsQuery holds the template for an LDAP query that returns group entries.
         */
        export interface GroupSyncSpecProvidersLdapRfc2307GroupsQuery {
            /**
             * The DN of the branch of the directory where all searches should start from
             */
            baseDN: string;
            /**
             * The (optional) behavior of the search with regards to alisases. Can be: never:  never dereference aliases, search: only dereference in searching, base:   only dereference in finding the base object, always: always dereference Defaults to always dereferencing if not set
             */
            derefAliases?: string;
            /**
             * Filter is a valid LDAP search filter that retrieves all relevant entries from the LDAP server with the base DN
             */
            filter?: string;
            /**
             * PageSize is the maximum preferred page size, measured in LDAP entries. A page size of 0 means no paging will be done.
             */
            pageSize?: number;
            /**
             * The (optional) scope of the search. Can be: base: only the base object, one:  all object on the base level, sub:  the entire subtree Defaults to the entire subtree if not set
             */
            scope?: string;
            /**
             * TimeLimit holds the limit of time in seconds that any request to the server can remain outstanding before the wait for a response is given up. If this is 0, no client-side limit is imposed
             */
            timeout?: number;
        }

        /**
         * AllUsersQuery holds the template for an LDAP query that returns user entries.
         */
        export interface GroupSyncSpecProvidersLdapRfc2307UsersQuery {
            /**
             * The DN of the branch of the directory where all searches should start from
             */
            baseDN: string;
            /**
             * The (optional) behavior of the search with regards to alisases. Can be: never:  never dereference aliases, search: only dereference in searching, base:   only dereference in finding the base object, always: always dereference Defaults to always dereferencing if not set
             */
            derefAliases?: string;
            /**
             * Filter is a valid LDAP search filter that retrieves all relevant entries from the LDAP server with the base DN
             */
            filter?: string;
            /**
             * PageSize is the maximum preferred page size, measured in LDAP entries. A page size of 0 means no paging will be done.
             */
            pageSize?: number;
            /**
             * The (optional) scope of the search. Can be: base: only the base object, one:  all object on the base level, sub:  the entire subtree Defaults to the entire subtree if not set
             */
            scope?: string;
            /**
             * TimeLimit holds the limit of time in seconds that any request to the server can remain outstanding before the wait for a response is given up. If this is 0, no client-side limit is imposed
             */
            timeout?: number;
        }

        /**
         * GroupSyncStatus defines the observed state of GroupSync
         */
        export interface GroupSyncStatus {
            /**
             * Conditions is a set of Condition instances.
             */
            conditions?: outputs.redhatcop.v1alpha1.GroupSyncStatusConditions[];
            /**
             * LastSyncSuccessTime represents the time last synchronization completed successfully
             */
            lastSyncSuccessTime?: string;
        }

        /**
         * Condition represents an observation of an object's state. Conditions are an extension mechanism intended to be used when the details of an observation are not a priori known or would not apply to all instances of a given Kind. 
         *  Conditions should be added to explicitly convey properties that users and components care about rather than requiring those properties to be inferred from other observations. Once defined, the meaning of a Condition can not be changed arbitrarily - it becomes part of the API, and has the same backwards- and forwards-compatibility concerns of any other part of the API.
         */
        export interface GroupSyncStatusConditions {
            lastTransitionTime?: string;
            message?: string;
            /**
             * ConditionReason is intended to be a one-word, CamelCase representation of the category of cause of the current status. It is intended to be used in concise output, such as one-line kubectl get output, and in summarizing occurrences of causes.
             */
            reason?: string;
            status: string;
            /**
             * ConditionType is the type of the condition and is typically a CamelCased word or short phrase. 
             *  Condition types should indicate state in the "abnormal-true" polarity. For example, if the condition indicates when a policy is invalid, the "is valid" case is probably the norm, so the condition should be called "Invalid".
             */
            type: string;
        }
    }
}
