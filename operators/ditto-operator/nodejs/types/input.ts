// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace iot {
    export namespace v1alpha1 {
        export interface DittoSpec {
            /**
             * Create the default "ditto" user when initially deploying.
             */
            createDefaultUser?: pulumi.Input<boolean>;
            /**
             * Secure the devops status information.
             */
            devopsSecureStatus?: pulumi.Input<boolean>;
            /**
             * Enable the "dummy authentication" mode.
             */
            enableDummyAuth?: pulumi.Input<boolean>;
            /**
             * Override the image version of the Ditto images.
             */
            version?: pulumi.Input<string>;
        }
    }
}