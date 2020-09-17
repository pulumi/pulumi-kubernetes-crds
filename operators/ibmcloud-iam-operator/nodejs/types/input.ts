// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace ibmcloud {
    export namespace v1alpha1 {
        /**
         * AccessGroupSpec defines the desired state of AccessGroup
         */
        export interface AccessGroupSpec {
            description: pulumi.Input<string>;
            name: pulumi.Input<string>;
            serviceIDs?: pulumi.Input<pulumi.Input<string>[]>;
            userEmails?: pulumi.Input<pulumi.Input<string>[]>;
        }

        /**
         * AccessGroupStatus defines the observed state of AccessGroup
         */
        export interface AccessGroupStatus {
            GroupID?: pulumi.Input<string>;
            description?: pulumi.Input<string>;
            message?: pulumi.Input<string>;
            name?: pulumi.Input<string>;
            serviceIDs?: pulumi.Input<pulumi.Input<string>[]>;
            state?: pulumi.Input<string>;
            userEmails?: pulumi.Input<pulumi.Input<string>[]>;
        }

        /**
         * AccessPolicySpec defines the desired state of AccessPolicy
         */
        export interface AccessPolicySpec {
            roles: pulumi.Input<inputs.ibmcloud.v1alpha1.AccessPolicySpecRoles>;
            subject: pulumi.Input<inputs.ibmcloud.v1alpha1.AccessPolicySpecSubject>;
            target: pulumi.Input<inputs.ibmcloud.v1alpha1.AccessPolicySpecTarget>;
        }

        export interface AccessPolicySpecRoles {
            customRolesDName?: pulumi.Input<pulumi.Input<string>[]>;
            customRolesDef?: pulumi.Input<pulumi.Input<inputs.ibmcloud.v1alpha1.AccessPolicySpecRolesCustomRolesDef>[]>;
            definedRoles?: pulumi.Input<pulumi.Input<string>[]>;
        }

        export interface AccessPolicySpecRolesCustomRolesDef {
            customRoleName: pulumi.Input<string>;
            customRoleNamespace: pulumi.Input<string>;
        }

        export interface AccessPolicySpecSubject {
            accessGroupDef?: pulumi.Input<inputs.ibmcloud.v1alpha1.AccessPolicySpecSubjectAccessGroupDef>;
            accessGroupID?: pulumi.Input<string>;
            serviceID?: pulumi.Input<string>;
            userEmail?: pulumi.Input<string>;
        }

        export interface AccessPolicySpecSubjectAccessGroupDef {
            accessGroupName: pulumi.Input<string>;
            accessGroupNamespace: pulumi.Input<string>;
        }

        export interface AccessPolicySpecTarget {
            resourceGroup?: pulumi.Input<string>;
            resourceID?: pulumi.Input<string>;
            resourceKey?: pulumi.Input<string>;
            resourceName?: pulumi.Input<string>;
            resourceValue?: pulumi.Input<string>;
            serviceClass?: pulumi.Input<string>;
            serviceID?: pulumi.Input<string>;
        }

        /**
         * AccessPolicyStatus defines the observed state of AccessPolicy
         */
        export interface AccessPolicyStatus {
            message?: pulumi.Input<string>;
            policyID?: pulumi.Input<string>;
            roles?: pulumi.Input<inputs.ibmcloud.v1alpha1.AccessPolicyStatusRoles>;
            state?: pulumi.Input<string>;
            subject?: pulumi.Input<inputs.ibmcloud.v1alpha1.AccessPolicyStatusSubject>;
            target?: pulumi.Input<inputs.ibmcloud.v1alpha1.AccessPolicyStatusTarget>;
        }

        export interface AccessPolicyStatusRoles {
            customRolesDName?: pulumi.Input<pulumi.Input<string>[]>;
            customRolesDef?: pulumi.Input<pulumi.Input<inputs.ibmcloud.v1alpha1.AccessPolicyStatusRolesCustomRolesDef>[]>;
            definedRoles?: pulumi.Input<pulumi.Input<string>[]>;
        }

        export interface AccessPolicyStatusRolesCustomRolesDef {
            customRoleName: pulumi.Input<string>;
            customRoleNamespace: pulumi.Input<string>;
        }

        export interface AccessPolicyStatusSubject {
            accessGroupDef?: pulumi.Input<inputs.ibmcloud.v1alpha1.AccessPolicyStatusSubjectAccessGroupDef>;
            accessGroupID?: pulumi.Input<string>;
            serviceID?: pulumi.Input<string>;
            userEmail?: pulumi.Input<string>;
        }

        export interface AccessPolicyStatusSubjectAccessGroupDef {
            accessGroupName: pulumi.Input<string>;
            accessGroupNamespace: pulumi.Input<string>;
        }

        export interface AccessPolicyStatusTarget {
            resourceGroup?: pulumi.Input<string>;
            resourceID?: pulumi.Input<string>;
            resourceKey?: pulumi.Input<string>;
            resourceName?: pulumi.Input<string>;
            resourceValue?: pulumi.Input<string>;
            serviceClass?: pulumi.Input<string>;
            serviceID?: pulumi.Input<string>;
        }

        /**
         * AuthorizationPolicySpec defines the desired state of AuthorizationPolicy
         */
        export interface AuthorizationPolicySpec {
            roles: pulumi.Input<pulumi.Input<string>[]>;
            source: pulumi.Input<inputs.ibmcloud.v1alpha1.AuthorizationPolicySpecSource>;
            target: pulumi.Input<inputs.ibmcloud.v1alpha1.AuthorizationPolicySpecTarget>;
        }

        export interface AuthorizationPolicySpecSource {
            resourceGroup?: pulumi.Input<string>;
            resourceID?: pulumi.Input<string>;
            resourceKey?: pulumi.Input<string>;
            resourceName?: pulumi.Input<string>;
            resourceValue?: pulumi.Input<string>;
            serviceClass: pulumi.Input<string>;
            serviceID?: pulumi.Input<string>;
        }

        export interface AuthorizationPolicySpecTarget {
            resourceGroup?: pulumi.Input<string>;
            resourceID?: pulumi.Input<string>;
            resourceKey?: pulumi.Input<string>;
            resourceName?: pulumi.Input<string>;
            resourceValue?: pulumi.Input<string>;
            serviceClass: pulumi.Input<string>;
            serviceID?: pulumi.Input<string>;
        }

        /**
         * AuthorizationPolicyStatus defines the observed state of AuthorizationPolicy
         */
        export interface AuthorizationPolicyStatus {
            message?: pulumi.Input<string>;
            policyID?: pulumi.Input<string>;
            roles?: pulumi.Input<pulumi.Input<string>[]>;
            source?: pulumi.Input<inputs.ibmcloud.v1alpha1.AuthorizationPolicyStatusSource>;
            state?: pulumi.Input<string>;
            target?: pulumi.Input<inputs.ibmcloud.v1alpha1.AuthorizationPolicyStatusTarget>;
        }

        export interface AuthorizationPolicyStatusSource {
            resourceGroup?: pulumi.Input<string>;
            resourceID?: pulumi.Input<string>;
            resourceKey?: pulumi.Input<string>;
            resourceName?: pulumi.Input<string>;
            resourceValue?: pulumi.Input<string>;
            serviceClass: pulumi.Input<string>;
            serviceID?: pulumi.Input<string>;
        }

        export interface AuthorizationPolicyStatusTarget {
            resourceGroup?: pulumi.Input<string>;
            resourceID?: pulumi.Input<string>;
            resourceKey?: pulumi.Input<string>;
            resourceName?: pulumi.Input<string>;
            resourceValue?: pulumi.Input<string>;
            serviceClass: pulumi.Input<string>;
            serviceID?: pulumi.Input<string>;
        }

        /**
         * CustomRoleSpec defines the desired state of CustomRole
         */
        export interface CustomRoleSpec {
            actions: pulumi.Input<pulumi.Input<string>[]>;
            description: pulumi.Input<string>;
            displayName: pulumi.Input<string>;
            roleName: pulumi.Input<string>;
            serviceClass: pulumi.Input<string>;
        }

        /**
         * CustomRoleStatus defines the observed state of CustomRole
         */
        export interface CustomRoleStatus {
            actions?: pulumi.Input<pulumi.Input<string>[]>;
            description?: pulumi.Input<string>;
            displayName?: pulumi.Input<string>;
            message?: pulumi.Input<string>;
            roleCRN?: pulumi.Input<string>;
            roleID?: pulumi.Input<string>;
            roleName?: pulumi.Input<string>;
            serviceClass?: pulumi.Input<string>;
            state?: pulumi.Input<string>;
        }
    }
}
