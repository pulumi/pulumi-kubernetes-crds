import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class NodeFeatureDiscoveryDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"name": "nodefeaturediscoveries.nfd.openshift.io"
			},
			"spec": {
				"group": "nfd.openshift.io",
				"names": {
					"kind": "NodeFeatureDiscovery",
					"listKind": "NodeFeatureDiscoveryList",
					"plural": "nodefeaturediscoveries",
					"singular": "nodefeaturediscovery"
				},
				"preserveUnknownFields": false,
				"scope": "Namespaced",
				"subresources": {
					"status": {}
				},
				"validation": {
					"openAPIV3Schema": {
						"description": "The Cluster Node Feature Discovery operator manages detection of hardware features and configuration in a Openshift cluster. The operator orchestrates all resources needed to run the NFD DaemonSet (Upstream: https://github.com/kubernetes-sigs/node-feature-discovery)",
						"properties": {
							"apiVersion": {
								"description": "APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#resources",
								"type": "string"
							},
							"kind": {
								"description": "Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds",
								"type": "string"
							},
							"metadata": {
								"type": "object"
							},
							"spec": {
								"type": "object"
							},
							"status": {
								"type": "object"
							}
						},
						"type": "object"
					}
				},
				"version": "v1alpha1",
				"versions": [
					{
						"name": "v1alpha1",
						"served": true,
						"storage": true
					}
				]
			}
		}, opts)
	}
}
