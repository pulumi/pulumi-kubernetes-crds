// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace apicur {
    export namespace v1alpha1 {
        /**
         * ApicurioRegistrySpec defines the desired state of ApicurioRegistry
         */
        export interface ApicurioRegistrySpec {
            configuration?: outputs.apicur.v1alpha1.ApicurioRegistrySpecConfiguration;
            deployment?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeployment;
            image?: outputs.apicur.v1alpha1.ApicurioRegistrySpecImage;
        }

        export interface ApicurioRegistrySpecConfiguration {
            dataSource?: outputs.apicur.v1alpha1.ApicurioRegistrySpecConfigurationDataSource;
            infinispan?: outputs.apicur.v1alpha1.ApicurioRegistrySpecConfigurationInfinispan;
            kafka?: outputs.apicur.v1alpha1.ApicurioRegistrySpecConfigurationKafka;
            logLevel?: string;
            persistence?: string;
            streams?: outputs.apicur.v1alpha1.ApicurioRegistrySpecConfigurationStreams;
            ui?: outputs.apicur.v1alpha1.ApicurioRegistrySpecConfigurationUi;
        }

        export interface ApicurioRegistrySpecConfigurationDataSource {
            password?: string;
            url?: string;
            userName?: string;
        }

        export interface ApicurioRegistrySpecConfigurationInfinispan {
            clusterName?: string;
        }

        export interface ApicurioRegistrySpecConfigurationKafka {
            bootstrapServers?: string;
        }

        export interface ApicurioRegistrySpecConfigurationStreams {
            applicationId?: string;
            applicationServerPort?: string;
            bootstrapServers?: string;
            security?: outputs.apicur.v1alpha1.ApicurioRegistrySpecConfigurationStreamsSecurity;
        }

        export interface ApicurioRegistrySpecConfigurationStreamsSecurity {
            scram?: outputs.apicur.v1alpha1.ApicurioRegistrySpecConfigurationStreamsSecurityScram;
            tls?: outputs.apicur.v1alpha1.ApicurioRegistrySpecConfigurationStreamsSecurityTls;
        }

        export interface ApicurioRegistrySpecConfigurationStreamsSecurityScram {
            mechanism?: string;
            passwordSecretName?: string;
            truststoreSecretName?: string;
            user?: string;
        }

        export interface ApicurioRegistrySpecConfigurationStreamsSecurityTls {
            keystoreSecretName?: string;
            truststoreSecretName?: string;
        }

        export interface ApicurioRegistrySpecConfigurationUi {
            readOnly?: boolean;
        }

        export interface ApicurioRegistrySpecDeployment {
            /**
             * Affinity is a group of affinity scheduling rules.
             */
            affinity?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinity;
            host?: string;
            replicas?: number;
            tolerations?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentTolerations[];
        }

        /**
         * Affinity is a group of affinity scheduling rules.
         */
        export interface ApicurioRegistrySpecDeploymentAffinity {
            /**
             * Describes node affinity scheduling rules for the pod.
             */
            nodeAffinity?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityNodeAffinity;
            /**
             * Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
             */
            podAffinity?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAffinity;
            /**
             * Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
             */
            podAntiAffinity?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAntiAffinity;
        }

        /**
         * Describes node affinity scheduling rules for the pod.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityNodeAffinity {
            /**
             * The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.
             */
            preferredDuringSchedulingIgnoredDuringExecution?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution[];
            /**
             * If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
             */
            requiredDuringSchedulingIgnoredDuringExecution?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution;
        }

        /**
         * An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
         */
        export interface ApicurioRegistrySpecDeploymentAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution {
            /**
             * A node selector term, associated with the corresponding weight.
             */
            preference: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference;
            /**
             * Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
             */
            weight: number;
        }

        /**
         * A node selector term, associated with the corresponding weight.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference {
            /**
             * A list of node selector requirements by node's labels.
             */
            matchExpressions?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions[];
            /**
             * A list of node selector requirements by node's fields.
             */
            matchFields?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields[];
        }

        /**
         * A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions {
            /**
             * The label key that the selector applies to.
             */
            key: string;
            /**
             * Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
             */
            operator: string;
            /**
             * An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.
             */
            values?: string[];
        }

        /**
         * A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields {
            /**
             * The label key that the selector applies to.
             */
            key: string;
            /**
             * Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
             */
            operator: string;
            /**
             * An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.
             */
            values?: string[];
        }

        /**
         * If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution {
            /**
             * Required. A list of node selector terms. The terms are ORed.
             */
            nodeSelectorTerms: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms[];
        }

        /**
         * A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms {
            /**
             * A list of node selector requirements by node's labels.
             */
            matchExpressions?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions[];
            /**
             * A list of node selector requirements by node's fields.
             */
            matchFields?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields[];
        }

        /**
         * A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions {
            /**
             * The label key that the selector applies to.
             */
            key: string;
            /**
             * Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
             */
            operator: string;
            /**
             * An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.
             */
            values?: string[];
        }

        /**
         * A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields {
            /**
             * The label key that the selector applies to.
             */
            key: string;
            /**
             * Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
             */
            operator: string;
            /**
             * An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.
             */
            values?: string[];
        }

        /**
         * Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAffinity {
            /**
             * The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.
             */
            preferredDuringSchedulingIgnoredDuringExecution?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution[];
            /**
             * If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.
             */
            requiredDuringSchedulingIgnoredDuringExecution?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution[];
        }

        /**
         * The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution {
            /**
             * Required. A pod affinity term, associated with the corresponding weight.
             */
            podAffinityTerm: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm;
            /**
             * weight associated with matching the corresponding podAffinityTerm, in the range 1-100.
             */
            weight: number;
        }

        /**
         * Required. A pod affinity term, associated with the corresponding weight.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm {
            /**
             * A label query over a set of resources, in this case pods.
             */
            labelSelector?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector;
            /**
             * namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means "this pod's namespace"
             */
            namespaces?: string[];
            /**
             * This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.
             */
            topologyKey: string;
        }

        /**
         * A label query over a set of resources, in this case pods.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions[];
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: {[key: string]: string};
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions {
            /**
             * key is the label key that the selector applies to.
             */
            key: string;
            /**
             * operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.
             */
            operator: string;
            /**
             * values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
             */
            values?: string[];
        }

        /**
         * Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key <topologyKey> matches that of any node on which a pod of the set of pods is running
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution {
            /**
             * A label query over a set of resources, in this case pods.
             */
            labelSelector?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector;
            /**
             * namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means "this pod's namespace"
             */
            namespaces?: string[];
            /**
             * This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.
             */
            topologyKey: string;
        }

        /**
         * A label query over a set of resources, in this case pods.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions[];
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: {[key: string]: string};
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions {
            /**
             * key is the label key that the selector applies to.
             */
            key: string;
            /**
             * operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.
             */
            operator: string;
            /**
             * values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
             */
            values?: string[];
        }

        /**
         * Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAntiAffinity {
            /**
             * The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.
             */
            preferredDuringSchedulingIgnoredDuringExecution?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution[];
            /**
             * If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.
             */
            requiredDuringSchedulingIgnoredDuringExecution?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution[];
        }

        /**
         * The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution {
            /**
             * Required. A pod affinity term, associated with the corresponding weight.
             */
            podAffinityTerm: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm;
            /**
             * weight associated with matching the corresponding podAffinityTerm, in the range 1-100.
             */
            weight: number;
        }

        /**
         * Required. A pod affinity term, associated with the corresponding weight.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm {
            /**
             * A label query over a set of resources, in this case pods.
             */
            labelSelector?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector;
            /**
             * namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means "this pod's namespace"
             */
            namespaces?: string[];
            /**
             * This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.
             */
            topologyKey: string;
        }

        /**
         * A label query over a set of resources, in this case pods.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions[];
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: {[key: string]: string};
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions {
            /**
             * key is the label key that the selector applies to.
             */
            key: string;
            /**
             * operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.
             */
            operator: string;
            /**
             * values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
             */
            values?: string[];
        }

        /**
         * Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key <topologyKey> matches that of any node on which a pod of the set of pods is running
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution {
            /**
             * A label query over a set of resources, in this case pods.
             */
            labelSelector?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector;
            /**
             * namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means "this pod's namespace"
             */
            namespaces?: string[];
            /**
             * This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.
             */
            topologyKey: string;
        }

        /**
         * A label query over a set of resources, in this case pods.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: outputs.apicur.v1alpha1.ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions[];
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: {[key: string]: string};
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface ApicurioRegistrySpecDeploymentAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions {
            /**
             * key is the label key that the selector applies to.
             */
            key: string;
            /**
             * operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.
             */
            operator: string;
            /**
             * values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
             */
            values?: string[];
        }

        /**
         * The pod this Toleration is attached to tolerates any taint that matches the triple <key,value,effect> using the matching operator <operator>.
         */
        export interface ApicurioRegistrySpecDeploymentTolerations {
            /**
             * Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
             */
            effect?: string;
            /**
             * Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.
             */
            key?: string;
            /**
             * Operator represents a key's relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.
             */
            operator?: string;
            /**
             * TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.
             */
            tolerationSeconds?: number;
            /**
             * Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.
             */
            value?: string;
        }

        export interface ApicurioRegistrySpecImage {
            /**
             * Registry string `json:"registry,omitempty"` Version  string `json:"version,omitempty"` Override string `json:"override,omitempty"`
             */
            name?: string;
        }

        /**
         * ApicurioRegistryStatus defines the observed state of ApicurioRegistry
         */
        export interface ApicurioRegistryStatus {
            deploymentName?: string;
            host?: string;
            image?: string;
            ingressName?: string;
            replicaCount?: number;
            serviceName?: string;
        }
    }
}
