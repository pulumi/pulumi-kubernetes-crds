// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace hyperfoil {
    export namespace v1alpha1 {
        /**
         * HorreumSpec defines the desired state of Horreum
         */
        export interface HorreumSpec {
            /**
             * Database coordinates for Horreum data. Besides `username` and `password` the secret must also contain key `dbsecret` that will be used to sign access to the database.
             */
            database?: pulumi.Input<inputs.hyperfoil.v1alpha1.HorreumSpecDatabase>;
            /**
             * Horreum image. Defaults to quay.io/hyperfoil/horreum:latest
             */
            image?: pulumi.Input<string>;
            /**
             * Keycloak specification
             */
            keycloak?: pulumi.Input<inputs.hyperfoil.v1alpha1.HorreumSpecKeycloak>;
            /**
             * PostgreSQL specification
             */
            postgres?: pulumi.Input<inputs.hyperfoil.v1alpha1.HorreumSpecPostgres>;
            /**
             * Hyperfoil report tool specification
             */
            report?: pulumi.Input<inputs.hyperfoil.v1alpha1.HorreumSpecReport>;
            /**
             * Route for external access.
             */
            route?: pulumi.Input<inputs.hyperfoil.v1alpha1.HorreumSpecRoute>;
        }

        /**
         * Database coordinates for Horreum data. Besides `username` and `password` the secret must also contain key `dbsecret` that will be used to sign access to the database.
         */
        export interface HorreumSpecDatabase {
            /**
             * Hostname for the database
             */
            host?: pulumi.Input<string>;
            /**
             * Name of the database
             */
            name?: pulumi.Input<string>;
            /**
             * Database port; defaults to 5432
             */
            port?: pulumi.Input<number>;
            /**
             * Name of secret resource with data `username` and `password`. Created if does not exist.
             */
            secret?: pulumi.Input<string>;
        }

        /**
         * Keycloak specification
         */
        export interface HorreumSpecKeycloak {
            /**
             * Secret used for admin access to the deployed Keycloak instance. Created if does not exist. Must contain keys `username` and `password`.
             */
            adminSecret?: pulumi.Input<string>;
            /**
             * Database coordinates Keycloak should use
             */
            database?: pulumi.Input<inputs.hyperfoil.v1alpha1.HorreumSpecKeycloakDatabase>;
            /**
             * Set to true if the Keycloak instance should not be deployed
             */
            external?: pulumi.Input<boolean>;
            /**
             * Image that should be used for Keycloak deployment. Defaults to docker.io/jboss/keycloak:latest
             */
            image?: pulumi.Input<string>;
            /**
             * Route to be used for external access to the Keycloak instance. When `external` is set to true, this will be used for internal access as well.
             */
            route?: pulumi.Input<inputs.hyperfoil.v1alpha1.HorreumSpecKeycloakRoute>;
        }

        /**
         * Database coordinates Keycloak should use
         */
        export interface HorreumSpecKeycloakDatabase {
            /**
             * Hostname for the database
             */
            host?: pulumi.Input<string>;
            /**
             * Name of the database
             */
            name?: pulumi.Input<string>;
            /**
             * Database port; defaults to 5432
             */
            port?: pulumi.Input<number>;
            /**
             * Name of secret resource with data `username` and `password`. Created if does not exist.
             */
            secret?: pulumi.Input<string>;
        }

        /**
         * Route to be used for external access to the Keycloak instance. When `external` is set to true, this will be used for internal access as well.
         */
        export interface HorreumSpecKeycloakRoute {
            /**
             * Hostname for external access.
             */
            host?: pulumi.Input<string>;
            /**
             * Optional; Name of the secret hosting `tls.crt`, `tls.key` and optionally `ca.crt`
             */
            tls?: pulumi.Input<string>;
        }

        /**
         * PostgreSQL specification
         */
        export interface HorreumSpecPostgres {
            /**
             * Secret used for unrestricted access to the database. Created if does not exist. Must contain keys `username` and `password`.
             */
            adminSecret?: pulumi.Input<string>;
            /**
             * Hostname of the external database. If empty, database will be deployed by this operator.
             */
            externalHost?: pulumi.Input<string>;
            /**
             * Port of the external database. Defaults to 5432.
             */
            externalPort?: pulumi.Input<number>;
            /**
             * Image used for PostgreSQL deployment. Defaults to docker.io/postgres:12
             */
            image?: pulumi.Input<string>;
            /**
             * Name of PVC where the database will store the data. If empty, ephemeral storage will be used.
             */
            persistentVolumeClaim?: pulumi.Input<string>;
        }

        /**
         * Hyperfoil report tool specification
         */
        export interface HorreumSpecReport {
            /**
             * True (or omitted) to deploy report pod.
             */
            enabled?: pulumi.Input<boolean>;
            /**
             * Image of the report tool. Defaults to quay.io/hyperfoil/hyperfoil-report:latest
             */
            image?: pulumi.Input<string>;
            /**
             * Name of PVC where the reports will be stored. If empty, ephemeral storage will be used.
             */
            persistentVolumeClaim?: pulumi.Input<string>;
            /**
             * Route for external access.
             */
            route?: pulumi.Input<inputs.hyperfoil.v1alpha1.HorreumSpecReportRoute>;
        }

        /**
         * Route for external access.
         */
        export interface HorreumSpecReportRoute {
            /**
             * Hostname for external access.
             */
            host?: pulumi.Input<string>;
            /**
             * Optional; Name of the secret hosting `tls.crt`, `tls.key` and optionally `ca.crt`
             */
            tls?: pulumi.Input<string>;
        }

        /**
         * Route for external access.
         */
        export interface HorreumSpecRoute {
            /**
             * Hostname for external access.
             */
            host?: pulumi.Input<string>;
            /**
             * Optional; Name of the secret hosting `tls.crt`, `tls.key` and optionally `ca.crt`
             */
            tls?: pulumi.Input<string>;
        }

        /**
         * HorreumStatus defines the observed state of Horreum
         */
        export interface HorreumStatus {
            /**
             * Last time state has changed.
             */
            lastUpdate?: pulumi.Input<string>;
            /**
             * Explanation for the current status.
             */
            reason?: pulumi.Input<string>;
            /**
             * Ready, Pending or Error.
             */
            status?: pulumi.Input<string>;
        }
    }
}
