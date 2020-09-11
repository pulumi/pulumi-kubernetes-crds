import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class AddressDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"labels": {
					"app": "enmasse",
					"enmasse-component": "tenant-api"
				},
				"name": "addresses.enmasse.io"
			},
			"spec": {
				"additionalPrinterColumns": [
					{
						"JSONPath": ".spec.address",
						"description": "The address",
						"name": "Address",
						"priority": 0,
						"type": "string"
					},
					{
						"JSONPath": ".spec.type",
						"description": "The address type",
						"name": "Type",
						"priority": 1,
						"type": "string"
					},
					{
						"JSONPath": ".spec.plan",
						"description": "The address plan",
						"name": "Plan",
						"priority": 1,
						"type": "string"
					},
					{
						"JSONPath": ".status.isReady",
						"description": "The readiness of the address",
						"name": "Ready",
						"priority": 0,
						"type": "boolean"
					},
					{
						"JSONPath": ".status.phase",
						"description": "The phase of the address",
						"name": "Phase",
						"priority": 0,
						"type": "string"
					},
					{
						"JSONPath": ".status.messages",
						"description": "The status of the address",
						"name": "Status",
						"priority": 1,
						"type": "string"
					},
					{
						"JSONPath": ".metadata.creationTimestamp",
						"name": "Age",
						"priority": 0,
						"type": "date"
					}
				],
				"group": "enmasse.io",
				"names": {
					"categories": [
						"enmasse"
					],
					"kind": "Address",
					"listKind": "AddressList",
					"plural": "addresses",
					"singular": "address"
				},
				"scope": "Namespaced",
				"validation": {
					"openAPIV3Schema": {
						"description": "Address describes a destination for sending and receiving messages. An Address has a type, which defines the semantics of sending messages to and receiving messages from that address. This resource is created by messaging tenants.",
						"properties": {
							"spec": {
								"properties": {
									"address": {
										"description": "Messaging address.",
										"pattern": "^[^\\s]+$",
										"type": "string"
									},
									"forwarders": {
										"description": "Address forwarders for this address.",
										"items": {
											"properties": {
												"direction": {
													"enum": [
														"in",
														"out"
													],
													"type": "string"
												},
												"name": {
													"description": "Forwarder name.",
													"type": "string"
												},
												"remoteAddress": {
													"description": "Remote address to forward to. Must be prefixed with connector name.",
													"type": "string"
												}
											},
											"required": [
												"name",
												"remoteAddress",
												"direction"
											],
											"type": "object"
										},
										"type": "array"
									},
									"messageTtl": {
										"description": "Further restricts message time-to-live (TTL). Applies to address types queue and topic only. The maximum and minimum values must fall with the minimum/maximum range described by the plan's TTL settings.",
										"properties": {
											"maximum": {
												"description": "Imposes a maximum TTL value (in milliseconds) for messages arriving at the address.  Messages arriving with TTL values greater than this value (or no TTL value) will have their expiration adjusted.",
												"type": "integer"
											},
											"minimum": {
												"description": "Imposes a minimum TTL value (in milliseconds) for messages arriving at the address.  Messages arriving with TTL values less than this value will have their expiration adjusted.",
												"type": "integer"
											}
										},
										"type": "object"
									},
									"plan": {
										"description": "Plan referenced by this address.",
										"type": "string"
									},
									"subscription": {
										"description": "Properties that can be set for subscription type addresses.",
										"properties": {
											"maxConsumers": {
												"description": "Maximum number of concurrent consumers that can be attached to this subscription. If unspecified, 1 consumer is allowed per subscription",
												"type": "integer"
											}
										},
										"type": "object"
									},
									"topic": {
										"description": "Address of topic that this subscription refers to (only applicable to subscription types).",
										"type": "string"
									},
									"type": {
										"description": "Address type for this address.",
										"enum": [
											"anycast",
											"multicast",
											"queue",
											"topic",
											"subscription"
										],
										"type": "string"
									}
								},
								"required": [
									"address",
									"type",
									"plan"
								],
								"type": "object"
							},
							"status": {
								"properties": {
									"brokerStatuses": {
										"description": "The status of this address in brokers.",
										"items": {
											"properties": {
												"brokerId": {
													"type": "string"
												},
												"clusterId": {
													"type": "string"
												},
												"state": {
													"enum": [
														"Active",
														"Migrating",
														"Draining"
													],
													"type": "string"
												}
											},
											"type": "object"
										},
										"type": "array"
									},
									"forwarders": {
										"description": "Forwarder status for this address.",
										"items": {
											"properties": {
												"isReady": {
													"type": "boolean"
												},
												"messages": {
													"items": {
														"type": "string"
													},
													"type": "array"
												},
												"name": {
													"pattern": "[a-zA-Z0-9]+",
													"type": "string"
												}
											},
											"type": "object"
										},
										"type": "array"
									},
									"isReady": {
										"description": "Whether address is ready to use or not.",
										"type": "boolean"
									},
									"messageTtl": {
										"description": "Applied message TTL properties.",
										"properties": {
											"maximum": {
												"description": "Maximum TTL value",
												"type": "integer"
											},
											"minimum": {
												"description": "Minimum TTL value",
												"type": "integer"
											}
										},
										"type": "object"
									},
									"messages": {
										"description": "Status and error messages for address.",
										"items": {
											"type": "string"
										},
										"type": "array"
									},
									"phase": {
										"description": "Phase of address.",
										"type": "string"
									},
									"planStatus": {
										"properties": {
											"name": {
												"type": "string"
											},
											"partitions": {
												"type": "integer"
											},
											"resources": {
												"type": "object"
											}
										},
										"required": [
											"name",
											"partitions",
											"resources"
										],
										"type": "object"
									},
									"subscription": {
										"description": "Applied properties for subscription type addresses.",
										"properties": {
											"maxConsumers": {
												"description": "Maximum number of concurrent consumers that can be attached to this subscription.",
												"type": "integer"
											}
										},
										"type": "object"
									}
								},
								"type": "object"
							}
						},
						"type": "object"
					}
				},
				"version": "v1beta1",
				"versions": [
					{
						"name": "v1beta1",
						"served": true,
						"storage": true
					}
				]
			}
		}, opts)
	}
}
