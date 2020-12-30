// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace hyperfoil {
    export namespace v1alpha2 {
        /**
         * HyperfoilSpec Configures Hyperfoil Controller and related resources.
         */
        export interface HyperfoilSpec {
            /**
             * Deploy timeout for agents, in milliseconds.
             */
            agentDeployTimeout?: number;
            /**
             * Authentication/authorization settings.
             */
            auth?: outputs.hyperfoil.v1alpha2.HyperfoilSpecAuth;
            /**
             * Controller image. If 'version' is defined, too, the tag is replaced (or appended). Defaults to 'quay.io/hyperfoil/hyperfoil'
             */
            image?: string;
            /**
             * Name of the config map and optionally its entry (separated by '/': e.g myconfigmap/log4j2-superverbose.xml) storing Log4j2 configuration file. By default the Controller uses its embedded configuration.
             */
            log?: string;
            /**
             * Name of the PVC hyperfoil should mount for its workdir.
             */
            persistentVolumeClaim?: string;
            /**
             * Names of config maps and optionally keys (separated by '/') holding hooks that run after the run finishes.
             */
            postHooks?: string[];
            /**
             * Names of config maps and optionally keys (separated by '/') holding hooks that run before the run starts.
             */
            preHooks?: string[];
            /**
             * Specification of the exposed route.
             */
            route?: outputs.hyperfoil.v1alpha2.HyperfoilSpecRoute;
            /**
             * List of secrets in this namespace; each entry from those secrets will be mapped as environment variable, using the key as variable name.
             */
            secretEnvVars?: string[];
            /**
             * If this is set the controller does not start benchmark run right away after hitting /benchmark/my-benchmark/start ; instead it responds with status 301 and header Location set to concatenation of this string and 'BENCHMARK=my-benchmark&RUN_ID=xxxx'. CLI interprets that response as a request to hit CI instance on this URL, assuming that CI will trigger a new job that will eventually call /benchmark/my-benchmark/start?runId=xxxx with header 'x-trigger-job'. This is useful if the the CI has to synchronize Hyperfoil to other benchmarks that don't use this controller instance.
             */
            triggerUrl?: string;
            /**
             * Tag for controller image. Defaults to version matching the operator version.
             */
            version?: string;
        }

        /**
         * Authentication/authorization settings.
         */
        export interface HyperfoilSpecAuth {
            /**
             * Optional; Name of secret used for basic authentication. Must contain key 'password'.
             */
            secret?: string;
        }

        /**
         * Specification of the exposed route.
         */
        export interface HyperfoilSpecRoute {
            /**
             * Host for the route leading to Controller REST endpoint. Example: hyperfoil.apps.cloud.example.com
             */
            host?: string;
            /**
             * Optional for edge and reencrypt routes, required for passthrough; Name of the secret hosting `tls.crt`, `tls.key` and optionally `ca.crt`
             */
            tls?: string;
            /**
             * Either 'http' (for plain-text routes - not recommended), 'edge', 'reencrypt' or 'passthrough'
             */
            type?: string;
        }

        /**
         * HyperfoilStatus defines the observed state of Hyperfoil.
         */
        export interface HyperfoilStatus {
            /**
             * RFC 3339 date and time of the last update.
             */
            lastUpdate?: string;
            /**
             * Human readable explanation for the status.
             */
            reason?: string;
            /**
             * "One of: 'Ready', 'Pending' or 'Error'"
             */
            status?: string;
        }
    }
}
