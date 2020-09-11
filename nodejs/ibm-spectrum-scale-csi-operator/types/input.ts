// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace csi {
    export namespace v1 {
        export interface CSIScaleOperatorSpec {
            /**
             * Attacher image for csi (actually attaches to the storage).
             */
            attacher?: pulumi.Input<string>;
            /**
             * Node selector for attacher sidecar.
             */
            attacherNodeSelector?: pulumi.Input<pulumi.Input<inputs.csi.v1.CSIScaleOperatorSpecAttacherNodeSelector>[]>;
            /**
             * A collection of gpfs cluster properties for the csi driver to mount.
             */
            clusters?: pulumi.Input<pulumi.Input<inputs.csi.v1.CSIScaleOperatorSpecClusters>[]>;
            /**
             * Sidecar container image for the csi spectrum scale plugin pods.
             */
            driverRegistrar?: pulumi.Input<string>;
            /**
             * Mapping of K8s node with SpectrumScale node.
             */
            nodeMapping?: pulumi.Input<pulumi.Input<inputs.csi.v1.CSIScaleOperatorSpecNodeMapping>[]>;
            /**
             * Node selector for SpectrumScale CSI Plugin.
             */
            pluginNodeSelector?: pulumi.Input<pulumi.Input<inputs.csi.v1.CSIScaleOperatorSpecPluginNodeSelector>[]>;
            /**
             * Provisioner image for csi (actually issues provision requests).
             */
            provisioner?: pulumi.Input<string>;
            /**
             * Node selector for provisioner sidecar.
             */
            provisionerNodeSelector?: pulumi.Input<pulumi.Input<inputs.csi.v1.CSIScaleOperatorSpecProvisionerNodeSelector>[]>;
            /**
             * The path to the gpfs file system mounted on the host machine.
             */
            scaleHostpath: pulumi.Input<string>;
            /**
             * An internal counter used by the operator to trigger reloads on secret change.
             */
            secretCounter?: pulumi.Input<number>;
            /**
             * Image name for the csi spectrum scale plugin container.
             */
            spectrumScale?: pulumi.Input<string>;
            /**
             * A generic trigger to be used in kickin off the ansible operator.
             */
            trigger?: pulumi.Input<string>;
        }

        export interface CSIScaleOperatorSpecAttacherNodeSelector {
            /**
             * Key for node selector.
             */
            key?: pulumi.Input<string>;
            /**
             * Value for key.
             */
            value?: pulumi.Input<string>;
        }

        export interface CSIScaleOperatorSpecClusters {
            /**
             * A string specifying a cacert resource name.
             */
            cacert?: pulumi.Input<string>;
            /**
             * The cluster id of the gpfs cluster specified (mandatory).
             */
            id?: pulumi.Input<string>;
            /**
             * The primary file system for the GPFS cluster.
             */
            primary?: pulumi.Input<inputs.csi.v1.CSIScaleOperatorSpecClustersPrimary>;
            /**
             * A collection of targets for REST calls.
             */
            restApi?: pulumi.Input<pulumi.Input<inputs.csi.v1.CSIScaleOperatorSpecClustersRestApi>[]>;
            /**
             * A string specifying a secret resource name.
             */
            secrets?: pulumi.Input<string>;
            /**
             * Require a secure SSL connection to connect to GPFS.
             */
            secureSslMode?: pulumi.Input<boolean>;
        }

        /**
         * The primary file system for the GPFS cluster.
         */
        export interface CSIScaleOperatorSpecClustersPrimary {
            /**
             * Inode limit for Primary Fileset.
             */
            inodeLimit?: pulumi.Input<string>;
            /**
             * The name of the primary filesystem.
             */
            primaryFs?: pulumi.Input<string>;
            /**
             * The name of the primary fileset, created in primaryFs.
             */
            primaryFset?: pulumi.Input<string>;
            /**
             * Remote cluster ID.
             */
            remoteCluster?: pulumi.Input<string>;
        }

        export interface CSIScaleOperatorSpecClustersRestApi {
            /**
             * The hostname of the REST server.
             */
            guiHost?: pulumi.Input<string>;
            /**
             * The port number running the REST server.
             */
            guiPort?: pulumi.Input<number>;
        }

        export interface CSIScaleOperatorSpecNodeMapping {
            /**
             * K8s node name.
             */
            k8sNode?: pulumi.Input<string>;
            /**
             * SpectrumScale node name.
             */
            spectrumscaleNode?: pulumi.Input<string>;
        }

        export interface CSIScaleOperatorSpecPluginNodeSelector {
            /**
             * Key for node selector.
             */
            key?: pulumi.Input<string>;
            /**
             * Value for key.
             */
            value?: pulumi.Input<string>;
        }

        export interface CSIScaleOperatorSpecProvisionerNodeSelector {
            /**
             * Key for node selector.
             */
            key?: pulumi.Input<string>;
            /**
             * Value for key.
             */
            value?: pulumi.Input<string>;
        }

        export interface CSIScaleOperatorStatus {
            /**
             * The active status of the operator
             */
            conditions?: pulumi.Input<pulumi.Input<inputs.csi.v1.CSIScaleOperatorStatusConditions>[]>;
        }

        export interface CSIScaleOperatorStatusConditions {
            /**
             * Indicates that the plugin is running.
             */
            Ready?: pulumi.Input<boolean>;
        }
    }
}