// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace perf {
    export namespace v1alpha1 {
        /**
         * DrillSpec defines benchmark run for drill load tester The benchmarkFile, and options is passed to drill as follows: drill [OPTIONS] --benchmark <benchmarkFile>
         */
        export interface DrillSpec {
            /**
             * BenchmarkFile is the entry point file (passed to --benchmark) specified to drill.
             */
            benchmarkFile: string;
            /**
             * BenchmarksVolume holds the content of benchmark files. The key of the map specifies the filename and the value is the content of the file. ConfigMap is created from the map which is mounted as benchmarks directory to the benchmark pod.
             */
            benchmarksVolume: {[key: string]: string};
            /**
             * Image defines the drill docker image used for the benchmark
             */
            image: outputs.perf.v1alpha1.DrillSpecImage;
            /**
             * Options are appended to the options parameter set of drill
             */
            options?: string;
            /**
             * PodConfig contains the configuration for the benchmark pod, including pod labels and scheduling policies (affinity, toleration, node selector...)
             */
            podConfig?: outputs.perf.v1alpha1.DrillSpecPodConfig;
        }

        /**
         * Image defines the drill docker image used for the benchmark
         */
        export interface DrillSpecImage {
            /**
             * Name is the Docker Image location including the tag
             */
            name: string;
            /**
             * PullPolicy controls how the docker images are downloaded Defaults to Always if :latest tag is specified, or IfNotPresent otherwise.
             */
            pullPolicy?: string;
            /**
             * PullSecret is an optional list of references to secrets in the same namespace to use for pulling any of the images
             */
            pullSecret?: string;
        }

        /**
         * PodConfig contains the configuration for the benchmark pod, including pod labels and scheduling policies (affinity, toleration, node selector...)
         */
        export interface DrillSpecPodConfig {
            /**
             * PodLabels are added to the pod as labels.
             */
            podLabels?: {[key: string]: string};
            /**
             * PodScheduling contains options to determine which node the pod should be scheduled on
             */
            podScheduling?: outputs.perf.v1alpha1.DrillSpecPodConfigPodScheduling;
            /**
             * Resources required by the benchmark pod container More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
             */
            resources?: outputs.perf.v1alpha1.DrillSpecPodConfigResources;
        }

        /**
         * PodScheduling contains options to determine which node the pod should be scheduled on
         */
        export interface DrillSpecPodConfigPodScheduling {
            /**
             * Affinity is a group of affinity scheduling rules.
             */
            affinity?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinity;
            /**
             * NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.
             */
            nodeName?: string;
            /**
             * A node selector represents the union of the results of one or more label queries over a set of nodes; that is, it represents the OR of the selectors represented by the node selector terms.
             */
            nodeSelector?: {[key: string]: string};
            /**
             * If specified, the pod's tolerations.
             */
            tolerations?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingTolerations[];
        }

        /**
         * Affinity is a group of affinity scheduling rules.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinity {
            /**
             * Describes node affinity scheduling rules for the pod.
             */
            nodeAffinity?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityNodeAffinity;
            /**
             * Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
             */
            podAffinity?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAffinity;
            /**
             * Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
             */
            podAntiAffinity?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinity;
        }

        /**
         * Describes node affinity scheduling rules for the pod.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityNodeAffinity {
            /**
             * The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.
             */
            preferredDuringSchedulingIgnoredDuringExecution?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution[];
            /**
             * If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
             */
            requiredDuringSchedulingIgnoredDuringExecution?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution;
        }

        /**
         * An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution {
            /**
             * A node selector term, associated with the corresponding weight.
             */
            preference: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference;
            /**
             * Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
             */
            weight: number;
        }

        /**
         * A node selector term, associated with the corresponding weight.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference {
            /**
             * A list of node selector requirements by node's labels.
             */
            matchExpressions?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions[];
            /**
             * A list of node selector requirements by node's fields.
             */
            matchFields?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields[];
        }

        /**
         * A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions {
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
        export interface DrillSpecPodConfigPodSchedulingAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields {
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
        export interface DrillSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution {
            /**
             * Required. A list of node selector terms. The terms are ORed.
             */
            nodeSelectorTerms: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms[];
        }

        /**
         * A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms {
            /**
             * A list of node selector requirements by node's labels.
             */
            matchExpressions?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions[];
            /**
             * A list of node selector requirements by node's fields.
             */
            matchFields?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields[];
        }

        /**
         * A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions {
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
        export interface DrillSpecPodConfigPodSchedulingAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields {
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
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAffinity {
            /**
             * The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.
             */
            preferredDuringSchedulingIgnoredDuringExecution?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution[];
            /**
             * If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.
             */
            requiredDuringSchedulingIgnoredDuringExecution?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution[];
        }

        /**
         * The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution {
            /**
             * Required. A pod affinity term, associated with the corresponding weight.
             */
            podAffinityTerm: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm;
            /**
             * weight associated with matching the corresponding podAffinityTerm, in the range 1-100.
             */
            weight: number;
        }

        /**
         * Required. A pod affinity term, associated with the corresponding weight.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm {
            /**
             * A label query over a set of resources, in this case pods.
             */
            labelSelector?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector;
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
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions[];
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: {[key: string]: string};
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions {
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
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution {
            /**
             * A label query over a set of resources, in this case pods.
             */
            labelSelector?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector;
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
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions[];
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: {[key: string]: string};
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions {
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
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinity {
            /**
             * The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.
             */
            preferredDuringSchedulingIgnoredDuringExecution?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution[];
            /**
             * If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.
             */
            requiredDuringSchedulingIgnoredDuringExecution?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution[];
        }

        /**
         * The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution {
            /**
             * Required. A pod affinity term, associated with the corresponding weight.
             */
            podAffinityTerm: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm;
            /**
             * weight associated with matching the corresponding podAffinityTerm, in the range 1-100.
             */
            weight: number;
        }

        /**
         * Required. A pod affinity term, associated with the corresponding weight.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm {
            /**
             * A label query over a set of resources, in this case pods.
             */
            labelSelector?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector;
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
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions[];
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: {[key: string]: string};
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions {
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
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution {
            /**
             * A label query over a set of resources, in this case pods.
             */
            labelSelector?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector;
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
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector {
            /**
             * matchExpressions is a list of label selector requirements. The requirements are ANDed.
             */
            matchExpressions?: outputs.perf.v1alpha1.DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions[];
            /**
             * matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
             */
            matchLabels?: {[key: string]: string};
        }

        /**
         * A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
         */
        export interface DrillSpecPodConfigPodSchedulingAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions {
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
        export interface DrillSpecPodConfigPodSchedulingTolerations {
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

        /**
         * Resources required by the benchmark pod container More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
         */
        export interface DrillSpecPodConfigResources {
            /**
             * Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
             */
            limits?: {[key: string]: string};
            /**
             * Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/
             */
            requests?: {[key: string]: string};
        }

        /**
         * BenchmarkStatus describes the current state of the benchmark
         */
        export interface DrillStatus {
            /**
             * Completed shows the state of completion
             */
            completed: boolean;
            /**
             * Running shows the state of execution
             */
            running: boolean;
        }
    }
}
