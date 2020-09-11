import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class KnativeEventingKafkaDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"name": "knativeeventingkafkas.eventing.knative.dev"
			},
			"spec": {
				"group": "eventing.knative.dev",
				"names": {
					"kind": "KnativeEventingKafka",
					"listKind": "KnativeEventingKafkaList",
					"plural": "knativeeventingkafkas",
					"shortNames": [
						"kek"
					],
					"singular": "knativeeventingkafka"
				},
				"scope": "Namespaced",
				"subresources": {
					"status": {}
				},
				"validation": {
					"openAPIV3Schema": {
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
								"properties": {
									"bootstrapServers": {
										"description": "URI(s) of Apache Kafka broker(s)",
										"minLength": 1,
										"type": "string"
									},
									"setAsDefaultChannelProvisioner": {
										"description": "Flag that controls whether Kafka channel provisioner is configured as the cluster default. Defaults to false.",
										"type": "boolean"
									}
								},
								"required": [
									"bootstrapServers"
								],
								"type": "object"
							},
							"status": {
								"properties": {
									"conditions": {
										"description": "The latest available observations of a resource's current state. +patchMergeKey=type +patchStrategy=merge",
										"items": {
											"properties": {
												"lastTransitionTime": {
													"description": "LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).",
													"type": "string"
												},
												"message": {
													"description": "A human readable message indicating details about the transition.",
													"type": "string"
												},
												"reason": {
													"description": "The reason for the condition's last transition.",
													"type": "string"
												},
												"severity": {
													"description": "Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.",
													"type": "string"
												},
												"status": {
													"description": "Status of the condition, one of True, False, Unknown. +required",
													"type": "string"
												},
												"type": {
													"description": "Type of condition. +required",
													"type": "string"
												}
											},
											"required": [
												"type",
												"status"
											],
											"type": "object"
										},
										"type": "array"
									},
									"version": {
										"description": "The version of the installed release",
										"type": "string"
									}
								},
								"type": "object"
							}
						}
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
