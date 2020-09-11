import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class BuildDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"labels": {
					"app": "camel-k"
				},
				"name": "builds.camel.apache.org"
			},
			"spec": {
				"additionalPrinterColumns": [
					{
						"JSONPath": ".status.phase",
						"description": "The build phase",
						"name": "Phase",
						"type": "string"
					},
					{
						"JSONPath": ".metadata.creationTimestamp",
						"description": "The time at which the build was created",
						"name": "Age",
						"type": "date"
					},
					{
						"JSONPath": ".status.startedAt",
						"description": "The time at which the build was last (re-)started",
						"name": "Started",
						"type": "date"
					},
					{
						"JSONPath": ".status.duration",
						"description": "The build last execution duration",
						"name": "Duration",
						"type": "string"
					},
					{
						"JSONPath": ".status.failure.recovery.attempt",
						"description": "The number of execution attempts",
						"name": "Attempts",
						"type": "integer"
					}
				],
				"group": "camel.apache.org",
				"names": {
					"kind": "Build",
					"listKind": "BuildList",
					"plural": "builds",
					"shortNames": [
						"ikb"
					],
					"singular": "build"
				},
				"scope": "Namespaced",
				"subresources": {
					"status": {}
				},
				"validation": {
					"openAPIV3Schema": {
						"description": "Build is the Schema for the builds API",
						"properties": {
							"apiVersion": {
								"description": "APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources",
								"type": "string"
							},
							"kind": {
								"description": "Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds",
								"type": "string"
							},
							"metadata": {
								"type": "object"
							},
							"spec": {
								"description": "BuildSpec defines the desired state of Build",
								"properties": {
									"tasks": {
										"description": "INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run \"operator-sdk generate k8s\" to regenerate code after modifying this file",
										"items": {
											"description": "Task --",
											"properties": {
												"builder": {
													"description": "BuilderTask --",
													"properties": {
														"affinity": {
															"description": "Affinity is a group of affinity scheduling rules.",
															"properties": {
																"nodeAffinity": {
																	"description": "Describes node affinity scheduling rules for the pod.",
																	"properties": {
																		"preferredDuringSchedulingIgnoredDuringExecution": {
																			"description": "The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \"weight\" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.",
																			"items": {
																				"description": "An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).",
																				"properties": {
																					"preference": {
																						"description": "A node selector term, associated with the corresponding weight.",
																						"properties": {
																							"matchExpressions": {
																								"description": "A list of node selector requirements by node's labels.",
																								"items": {
																									"description": "A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "The label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.",
																											"type": "string"
																										},
																										"values": {
																											"description": "An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							},
																							"matchFields": {
																								"description": "A list of node selector requirements by node's fields.",
																								"items": {
																									"description": "A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "The label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.",
																											"type": "string"
																										},
																										"values": {
																											"description": "An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							}
																						},
																						"type": "object"
																					},
																					"weight": {
																						"description": "Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.",
																						"format": "int32",
																						"type": "integer"
																					}
																				},
																				"required": [
																					"preference",
																					"weight"
																				],
																				"type": "object"
																			},
																			"type": "array"
																		},
																		"requiredDuringSchedulingIgnoredDuringExecution": {
																			"description": "If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.",
																			"properties": {
																				"nodeSelectorTerms": {
																					"description": "Required. A list of node selector terms. The terms are ORed.",
																					"items": {
																						"description": "A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.",
																						"properties": {
																							"matchExpressions": {
																								"description": "A list of node selector requirements by node's labels.",
																								"items": {
																									"description": "A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "The label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.",
																											"type": "string"
																										},
																										"values": {
																											"description": "An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							},
																							"matchFields": {
																								"description": "A list of node selector requirements by node's fields.",
																								"items": {
																									"description": "A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "The label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.",
																											"type": "string"
																										},
																										"values": {
																											"description": "An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							}
																						},
																						"type": "object"
																					},
																					"type": "array"
																				}
																			},
																			"required": [
																				"nodeSelectorTerms"
																			],
																			"type": "object"
																		}
																	},
																	"type": "object"
																},
																"podAffinity": {
																	"description": "Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).",
																	"properties": {
																		"preferredDuringSchedulingIgnoredDuringExecution": {
																			"description": "The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \"weight\" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.",
																			"items": {
																				"description": "The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)",
																				"properties": {
																					"podAffinityTerm": {
																						"description": "Required. A pod affinity term, associated with the corresponding weight.",
																						"properties": {
																							"labelSelector": {
																								"description": "A label query over a set of resources, in this case pods.",
																								"properties": {
																									"matchExpressions": {
																										"description": "matchExpressions is a list of label selector requirements. The requirements are ANDed.",
																										"items": {
																											"description": "A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																											"properties": {
																												"key": {
																													"description": "key is the label key that the selector applies to.",
																													"type": "string"
																												},
																												"operator": {
																													"description": "operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.",
																													"type": "string"
																												},
																												"values": {
																													"description": "values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.",
																													"items": {
																														"type": "string"
																													},
																													"type": "array"
																												}
																											},
																											"required": [
																												"key",
																												"operator"
																											],
																											"type": "object"
																										},
																										"type": "array"
																									},
																									"matchLabels": {
																										"additionalProperties": {
																											"type": "string"
																										},
																										"description": "matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed.",
																										"type": "object"
																									}
																								},
																								"type": "object"
																							},
																							"namespaces": {
																								"description": "namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \"this pod's namespace\"",
																								"items": {
																									"type": "string"
																								},
																								"type": "array"
																							},
																							"topologyKey": {
																								"description": "This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.",
																								"type": "string"
																							}
																						},
																						"required": [
																							"topologyKey"
																						],
																						"type": "object"
																					},
																					"weight": {
																						"description": "weight associated with matching the corresponding podAffinityTerm, in the range 1-100.",
																						"format": "int32",
																						"type": "integer"
																					}
																				},
																				"required": [
																					"podAffinityTerm",
																					"weight"
																				],
																				"type": "object"
																			},
																			"type": "array"
																		},
																		"requiredDuringSchedulingIgnoredDuringExecution": {
																			"description": "If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.",
																			"items": {
																				"description": "Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key \u003ctopologyKey\u003e matches that of any node on which a pod of the set of pods is running",
																				"properties": {
																					"labelSelector": {
																						"description": "A label query over a set of resources, in this case pods.",
																						"properties": {
																							"matchExpressions": {
																								"description": "matchExpressions is a list of label selector requirements. The requirements are ANDed.",
																								"items": {
																									"description": "A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "key is the label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.",
																											"type": "string"
																										},
																										"values": {
																											"description": "values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							},
																							"matchLabels": {
																								"additionalProperties": {
																									"type": "string"
																								},
																								"description": "matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed.",
																								"type": "object"
																							}
																						},
																						"type": "object"
																					},
																					"namespaces": {
																						"description": "namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \"this pod's namespace\"",
																						"items": {
																							"type": "string"
																						},
																						"type": "array"
																					},
																					"topologyKey": {
																						"description": "This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.",
																						"type": "string"
																					}
																				},
																				"required": [
																					"topologyKey"
																				],
																				"type": "object"
																			},
																			"type": "array"
																		}
																	},
																	"type": "object"
																},
																"podAntiAffinity": {
																	"description": "Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).",
																	"properties": {
																		"preferredDuringSchedulingIgnoredDuringExecution": {
																			"description": "The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \"weight\" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.",
																			"items": {
																				"description": "The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)",
																				"properties": {
																					"podAffinityTerm": {
																						"description": "Required. A pod affinity term, associated with the corresponding weight.",
																						"properties": {
																							"labelSelector": {
																								"description": "A label query over a set of resources, in this case pods.",
																								"properties": {
																									"matchExpressions": {
																										"description": "matchExpressions is a list of label selector requirements. The requirements are ANDed.",
																										"items": {
																											"description": "A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																											"properties": {
																												"key": {
																													"description": "key is the label key that the selector applies to.",
																													"type": "string"
																												},
																												"operator": {
																													"description": "operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.",
																													"type": "string"
																												},
																												"values": {
																													"description": "values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.",
																													"items": {
																														"type": "string"
																													},
																													"type": "array"
																												}
																											},
																											"required": [
																												"key",
																												"operator"
																											],
																											"type": "object"
																										},
																										"type": "array"
																									},
																									"matchLabels": {
																										"additionalProperties": {
																											"type": "string"
																										},
																										"description": "matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed.",
																										"type": "object"
																									}
																								},
																								"type": "object"
																							},
																							"namespaces": {
																								"description": "namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \"this pod's namespace\"",
																								"items": {
																									"type": "string"
																								},
																								"type": "array"
																							},
																							"topologyKey": {
																								"description": "This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.",
																								"type": "string"
																							}
																						},
																						"required": [
																							"topologyKey"
																						],
																						"type": "object"
																					},
																					"weight": {
																						"description": "weight associated with matching the corresponding podAffinityTerm, in the range 1-100.",
																						"format": "int32",
																						"type": "integer"
																					}
																				},
																				"required": [
																					"podAffinityTerm",
																					"weight"
																				],
																				"type": "object"
																			},
																			"type": "array"
																		},
																		"requiredDuringSchedulingIgnoredDuringExecution": {
																			"description": "If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.",
																			"items": {
																				"description": "Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key \u003ctopologyKey\u003e matches that of any node on which a pod of the set of pods is running",
																				"properties": {
																					"labelSelector": {
																						"description": "A label query over a set of resources, in this case pods.",
																						"properties": {
																							"matchExpressions": {
																								"description": "matchExpressions is a list of label selector requirements. The requirements are ANDed.",
																								"items": {
																									"description": "A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "key is the label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.",
																											"type": "string"
																										},
																										"values": {
																											"description": "values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							},
																							"matchLabels": {
																								"additionalProperties": {
																									"type": "string"
																								},
																								"description": "matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed.",
																								"type": "object"
																							}
																						},
																						"type": "object"
																					},
																					"namespaces": {
																						"description": "namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \"this pod's namespace\"",
																						"items": {
																							"type": "string"
																						},
																						"type": "array"
																					},
																					"topologyKey": {
																						"description": "This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.",
																						"type": "string"
																					}
																				},
																				"required": [
																					"topologyKey"
																				],
																				"type": "object"
																			},
																			"type": "array"
																		}
																	},
																	"type": "object"
																}
															},
															"type": "object"
														},
														"baseImage": {
															"type": "string"
														},
														"buildDir": {
															"type": "string"
														},
														"dependencies": {
															"items": {
																"type": "string"
															},
															"type": "array"
														},
														"image": {
															"type": "string"
														},
														"maven": {
															"description": "MavenSpec --",
															"properties": {
																"localRepository": {
																	"type": "string"
																},
																"settings": {
																	"description": "ValueSource --",
																	"properties": {
																		"configMapKeyRef": {
																			"description": "Selects a key of a ConfigMap.",
																			"properties": {
																				"key": {
																					"description": "The key to select.",
																					"type": "string"
																				},
																				"name": {
																					"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																					"type": "string"
																				},
																				"optional": {
																					"description": "Specify whether the ConfigMap or its key must be defined",
																					"type": "boolean"
																				}
																			},
																			"required": [
																				"key"
																			],
																			"type": "object"
																		},
																		"secretKeyRef": {
																			"description": "Selects a key of a secret.",
																			"properties": {
																				"key": {
																					"description": "The key of the secret to select from.  Must be a valid secret key.",
																					"type": "string"
																				},
																				"name": {
																					"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																					"type": "string"
																				},
																				"optional": {
																					"description": "Specify whether the Secret or its key must be defined",
																					"type": "boolean"
																				}
																			},
																			"required": [
																				"key"
																			],
																			"type": "object"
																		}
																	},
																	"type": "object"
																},
																"timeout": {
																	"type": "string"
																}
															},
															"type": "object"
														},
														"meta": {
															"description": "This is required until https://github.com/kubernetes-sigs/controller-tools/pull/395 gets merged",
															"type": "object",
															"x_kubernetes_preserve_unknown_fields": true
														},
														"name": {
															"type": "string"
														},
														"properties": {
															"additionalProperties": {
																"type": "string"
															},
															"type": "object"
														},
														"resources": {
															"items": {
																"description": "ResourceSpec --",
																"properties": {
																	"compression": {
																		"type": "boolean"
																	},
																	"content": {
																		"type": "string"
																	},
																	"contentKey": {
																		"type": "string"
																	},
																	"contentRef": {
																		"type": "string"
																	},
																	"mountPath": {
																		"type": "string"
																	},
																	"name": {
																		"type": "string"
																	},
																	"type": {
																		"description": "ResourceType --",
																		"type": "string"
																	}
																},
																"type": "object"
															},
															"type": "array"
														},
														"runtime": {
															"description": "RuntimeSpec --",
															"properties": {
																"applicationClass": {
																	"type": "string"
																},
																"capabilities": {
																	"additionalProperties": {
																		"description": "Capability --",
																		"properties": {
																			"dependencies": {
																				"items": {
																					"description": "MavenArtifact --",
																					"properties": {
																						"artifactId": {
																							"type": "string"
																						},
																						"groupId": {
																							"type": "string"
																						},
																						"version": {
																							"type": "string"
																						}
																					},
																					"required": [
																						"artifactId",
																						"groupId"
																					],
																					"type": "object"
																				},
																				"type": "array"
																			},
																			"metadata": {
																				"additionalProperties": {
																					"type": "string"
																				},
																				"type": "object"
																			}
																		},
																		"required": [
																			"dependencies"
																		],
																		"type": "object"
																	},
																	"type": "object"
																},
																"dependencies": {
																	"items": {
																		"description": "MavenArtifact --",
																		"properties": {
																			"artifactId": {
																				"type": "string"
																			},
																			"groupId": {
																				"type": "string"
																			},
																			"version": {
																				"type": "string"
																			}
																		},
																		"required": [
																			"artifactId",
																			"groupId"
																		],
																		"type": "object"
																	},
																	"type": "array"
																},
																"metadata": {
																	"additionalProperties": {
																		"type": "string"
																	},
																	"type": "object"
																},
																"provider": {
																	"description": "RuntimeProvider --",
																	"type": "string"
																},
																"version": {
																	"type": "string"
																}
															},
															"required": [
																"applicationClass",
																"dependencies",
																"provider",
																"version"
															],
															"type": "object"
														},
														"sources": {
															"items": {
																"description": "SourceSpec --",
																"properties": {
																	"compression": {
																		"type": "boolean"
																	},
																	"content": {
																		"type": "string"
																	},
																	"contentKey": {
																		"type": "string"
																	},
																	"contentRef": {
																		"type": "string"
																	},
																	"interceptors": {
																		"description": "Interceptors are optional identifiers the org.apache.camel.k.RoutesLoader uses to pre/post process sources",
																		"items": {
																			"type": "string"
																		},
																		"type": "array"
																	},
																	"language": {
																		"description": "Language --",
																		"type": "string"
																	},
																	"loader": {
																		"description": "Loader is an optional id of the org.apache.camel.k.RoutesLoader that will interpret this source at runtime",
																		"type": "string"
																	},
																	"name": {
																		"type": "string"
																	}
																},
																"type": "object"
															},
															"type": "array"
														},
														"steps": {
															"items": {
																"type": "string"
															},
															"type": "array"
														},
														"timeout": {
															"type": "string"
														},
														"volumeMounts": {
															"items": {
																"description": "VolumeMount describes a mounting of a Volume within a container.",
																"properties": {
																	"mountPath": {
																		"description": "Path within the container at which the volume should be mounted.  Must not contain ':'.",
																		"type": "string"
																	},
																	"mountPropagation": {
																		"description": "mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10.",
																		"type": "string"
																	},
																	"name": {
																		"description": "This must match the Name of a Volume.",
																		"type": "string"
																	},
																	"readOnly": {
																		"description": "Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.",
																		"type": "boolean"
																	},
																	"subPath": {
																		"description": "Path within the volume from which the container's volume should be mounted. Defaults to \"\" (volume's root).",
																		"type": "string"
																	},
																	"subPathExpr": {
																		"description": "Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to \"\" (volume's root). SubPathExpr and SubPath are mutually exclusive.",
																		"type": "string"
																	}
																},
																"required": [
																	"mountPath",
																	"name"
																],
																"type": "object"
															},
															"type": "array"
														},
														"volumes": {
															"items": {
																"description": "Volume represents a named volume in a pod that may be accessed by any container in the pod.",
																"properties": {
																	"awsElasticBlockStore": {
																		"description": "AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore TODO: how do we prevent errors in the filesystem from compromising the machine",
																				"type": "string"
																			},
																			"partition": {
																				"description": "The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \"1\". Similarly, the volume partition for /dev/sda is \"0\" (or you can leave the property empty).",
																				"format": "int32",
																				"type": "integer"
																			},
																			"readOnly": {
																				"description": "Specify \"true\" to force and set the ReadOnly property in VolumeMounts to \"true\". If omitted, the default is \"false\". More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore",
																				"type": "boolean"
																			},
																			"volumeID": {
																				"description": "Unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore",
																				"type": "string"
																			}
																		},
																		"required": [
																			"volumeID"
																		],
																		"type": "object"
																	},
																	"azureDisk": {
																		"description": "AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.",
																		"properties": {
																			"cachingMode": {
																				"description": "Host Caching mode: None, Read Only, Read Write.",
																				"type": "string"
																			},
																			"diskName": {
																				"description": "The Name of the data disk in the blob storage",
																				"type": "string"
																			},
																			"diskURI": {
																				"description": "The URI the data disk in the blob storage",
																				"type": "string"
																			},
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.",
																				"type": "string"
																			},
																			"kind": {
																				"description": "Expected values Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			}
																		},
																		"required": [
																			"diskName",
																			"diskURI"
																		],
																		"type": "object"
																	},
																	"azureFile": {
																		"description": "AzureFile represents an Azure File Service mount on the host and bind mount to the pod.",
																		"properties": {
																			"readOnly": {
																				"description": "Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"secretName": {
																				"description": "the name of secret that contains Azure Storage Account Name and Key",
																				"type": "string"
																			},
																			"shareName": {
																				"description": "Share Name",
																				"type": "string"
																			}
																		},
																		"required": [
																			"secretName",
																			"shareName"
																		],
																		"type": "object"
																	},
																	"cephfs": {
																		"description": "CephFS represents a Ceph FS mount on the host that shares a pod's lifetime",
																		"properties": {
																			"monitors": {
																				"description": "Required: Monitors is a collection of Ceph monitors More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			},
																			"path": {
																				"description": "Optional: Used as the mounted root, rather than the full Ceph tree, default is /",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it",
																				"type": "boolean"
																			},
																			"secretFile": {
																				"description": "Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it",
																				"type": "string"
																			},
																			"secretRef": {
																				"description": "Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"user": {
																				"description": "Optional: User is the rados user name, default is admin More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it",
																				"type": "string"
																			}
																		},
																		"required": [
																			"monitors"
																		],
																		"type": "object"
																	},
																	"cinder": {
																		"description": "Cinder represents a cinder volume attached and mounted on kubelets host machine. More info: https://examples.k8s.io/mysql-cinder-pd/README.md",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://examples.k8s.io/mysql-cinder-pd/README.md",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/mysql-cinder-pd/README.md",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "Optional: points to a secret object containing parameters used to connect to OpenStack.",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"volumeID": {
																				"description": "volume id used to identify the volume in cinder. More info: https://examples.k8s.io/mysql-cinder-pd/README.md",
																				"type": "string"
																			}
																		},
																		"required": [
																			"volumeID"
																		],
																		"type": "object"
																	},
																	"configMap": {
																		"description": "ConfigMap represents a configMap that should populate this volume",
																		"properties": {
																			"defaultMode": {
																				"description": "Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																				"format": "int32",
																				"type": "integer"
																			},
																			"items": {
																				"description": "If unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.",
																				"items": {
																					"description": "Maps a string key to a path within a volume.",
																					"properties": {
																						"key": {
																							"description": "The key to project.",
																							"type": "string"
																						},
																						"mode": {
																							"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																							"format": "int32",
																							"type": "integer"
																						},
																						"path": {
																							"description": "The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.",
																							"type": "string"
																						}
																					},
																					"required": [
																						"key",
																						"path"
																					],
																					"type": "object"
																				},
																				"type": "array"
																			},
																			"name": {
																				"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																				"type": "string"
																			},
																			"optional": {
																				"description": "Specify whether the ConfigMap or its keys must be defined",
																				"type": "boolean"
																			}
																		},
																		"type": "object"
																	},
																	"csi": {
																		"description": "CSI (Container Storage Interface) represents storage that is handled by an external CSI driver (Alpha feature).",
																		"properties": {
																			"driver": {
																				"description": "Driver is the name of the CSI driver that handles this volume. Consult with your admin for the correct name as registered in the cluster.",
																				"type": "string"
																			},
																			"fsType": {
																				"description": "Filesystem type to mount. Ex. \"ext4\", \"xfs\", \"ntfs\". If not provided, the empty value is passed to the associated CSI driver which will determine the default filesystem to apply.",
																				"type": "string"
																			},
																			"nodePublishSecretRef": {
																				"description": "NodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls. This field is optional, and  may be empty if no secret is required. If the secret object contains more than one secret, all secret references are passed.",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"readOnly": {
																				"description": "Specifies a read-only configuration for the volume. Defaults to false (read/write).",
																				"type": "boolean"
																			},
																			"volumeAttributes": {
																				"additionalProperties": {
																					"type": "string"
																				},
																				"description": "VolumeAttributes stores driver-specific properties that are passed to the CSI driver. Consult your driver's documentation for supported values.",
																				"type": "object"
																			}
																		},
																		"required": [
																			"driver"
																		],
																		"type": "object"
																	},
																	"downwardAPI": {
																		"description": "DownwardAPI represents downward API about the pod that should populate this volume",
																		"properties": {
																			"defaultMode": {
																				"description": "Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																				"format": "int32",
																				"type": "integer"
																			},
																			"items": {
																				"description": "Items is a list of downward API volume file",
																				"items": {
																					"description": "DownwardAPIVolumeFile represents information to create the file containing the pod field",
																					"properties": {
																						"fieldRef": {
																							"description": "Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.",
																							"properties": {
																								"apiVersion": {
																									"description": "Version of the schema the FieldPath is written in terms of, defaults to \"v1\".",
																									"type": "string"
																								},
																								"fieldPath": {
																									"description": "Path of the field to select in the specified API version.",
																									"type": "string"
																								}
																							},
																							"required": [
																								"fieldPath"
																							],
																							"type": "object"
																						},
																						"mode": {
																							"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																							"format": "int32",
																							"type": "integer"
																						},
																						"path": {
																							"description": "Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'",
																							"type": "string"
																						},
																						"resourceFieldRef": {
																							"description": "Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.",
																							"properties": {
																								"containerName": {
																									"description": "Container name: required for volumes, optional for env vars",
																									"type": "string"
																								},
																								"divisor": {
																									"anyOf": [
																										{
																											"type": "integer"
																										},
																										{
																											"type": "string"
																										}
																									],
																									"description": "Specifies the output format of the exposed resources, defaults to \"1\"",
																									"pattern": "^(\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))))?$",
																									"x_kubernetes_int_or_string": true
																								},
																								"resource": {
																									"description": "Required: resource to select",
																									"type": "string"
																								}
																							},
																							"required": [
																								"resource"
																							],
																							"type": "object"
																						}
																					},
																					"required": [
																						"path"
																					],
																					"type": "object"
																				},
																				"type": "array"
																			}
																		},
																		"type": "object"
																	},
																	"emptyDir": {
																		"description": "EmptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir",
																		"properties": {
																			"medium": {
																				"description": "What type of storage medium should back this directory. The default is \"\" which means to use the node's default medium. Must be an empty string (default) or Memory. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir",
																				"type": "string"
																			},
																			"sizeLimit": {
																				"anyOf": [
																					{
																						"type": "integer"
																					},
																					{
																						"type": "string"
																					}
																				],
																				"description": "Total amount of local storage required for this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. The default is nil which means that the limit is undefined. More info: http://kubernetes.io/docs/user-guide/volumes#emptydir",
																				"pattern": "^(\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))))?$",
																				"x_kubernetes_int_or_string": true
																			}
																		},
																		"type": "object"
																	},
																	"fc": {
																		"description": "FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. TODO: how do we prevent errors in the filesystem from compromising the machine",
																				"type": "string"
																			},
																			"lun": {
																				"description": "Optional: FC target lun number",
																				"format": "int32",
																				"type": "integer"
																			},
																			"readOnly": {
																				"description": "Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"targetWWNs": {
																				"description": "Optional: FC target worldwide names (WWNs)",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			},
																			"wwids": {
																				"description": "Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			}
																		},
																		"type": "object"
																	},
																	"flexVolume": {
																		"description": "FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.",
																		"properties": {
																			"driver": {
																				"description": "Driver is the name of the driver to use for this volume.",
																				"type": "string"
																			},
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". The default filesystem depends on FlexVolume script.",
																				"type": "string"
																			},
																			"options": {
																				"additionalProperties": {
																					"type": "string"
																				},
																				"description": "Optional: Extra command options if any.",
																				"type": "object"
																			},
																			"readOnly": {
																				"description": "Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "Optional: SecretRef is reference to the secret object containing sensitive information to pass to the plugin scripts. This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			}
																		},
																		"required": [
																			"driver"
																		],
																		"type": "object"
																	},
																	"flocker": {
																		"description": "Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running",
																		"properties": {
																			"datasetName": {
																				"description": "Name of the dataset stored as metadata -\u003e name on the dataset for Flocker should be considered as deprecated",
																				"type": "string"
																			},
																			"datasetUUID": {
																				"description": "UUID of the dataset. This is unique identifier of a Flocker dataset",
																				"type": "string"
																			}
																		},
																		"type": "object"
																	},
																	"gcePersistentDisk": {
																		"description": "GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk TODO: how do we prevent errors in the filesystem from compromising the machine",
																				"type": "string"
																			},
																			"partition": {
																				"description": "The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \"1\". Similarly, the volume partition for /dev/sda is \"0\" (or you can leave the property empty). More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk",
																				"format": "int32",
																				"type": "integer"
																			},
																			"pdName": {
																				"description": "Unique name of the PD resource in GCE. Used to identify the disk in GCE. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk",
																				"type": "boolean"
																			}
																		},
																		"required": [
																			"pdName"
																		],
																		"type": "object"
																	},
																	"gitRepo": {
																		"description": "GitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.",
																		"properties": {
																			"directory": {
																				"description": "Target directory name. Must not contain or start with '..'.  If '.' is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.",
																				"type": "string"
																			},
																			"repository": {
																				"description": "Repository URL",
																				"type": "string"
																			},
																			"revision": {
																				"description": "Commit hash for the specified revision.",
																				"type": "string"
																			}
																		},
																		"required": [
																			"repository"
																		],
																		"type": "object"
																	},
																	"glusterfs": {
																		"description": "Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/glusterfs/README.md",
																		"properties": {
																			"endpoints": {
																				"description": "EndpointsName is the endpoint name that details Glusterfs topology. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod",
																				"type": "string"
																			},
																			"path": {
																				"description": "Path is the Glusterfs volume path. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the Glusterfs volume to be mounted with read-only permissions. Defaults to false. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod",
																				"type": "boolean"
																			}
																		},
																		"required": [
																			"endpoints",
																			"path"
																		],
																		"type": "object"
																	},
																	"hostPath": {
																		"description": "HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath --- TODO(jonesdl) We need to restrict who can use host directory mounts and who can/can not mount host directories as read/write.",
																		"properties": {
																			"path": {
																				"description": "Path of the directory on the host. If the path is a symlink, it will follow the link to the real path. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath",
																				"type": "string"
																			},
																			"type": {
																				"description": "Type for HostPath Volume Defaults to \"\" More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath",
																				"type": "string"
																			}
																		},
																		"required": [
																			"path"
																		],
																		"type": "object"
																	},
																	"iscsi": {
																		"description": "ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://examples.k8s.io/volumes/iscsi/README.md",
																		"properties": {
																			"chapAuthDiscovery": {
																				"description": "whether support iSCSI Discovery CHAP authentication",
																				"type": "boolean"
																			},
																			"chapAuthSession": {
																				"description": "whether support iSCSI Session CHAP authentication",
																				"type": "boolean"
																			},
																			"fsType": {
																				"description": "Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi TODO: how do we prevent errors in the filesystem from compromising the machine",
																				"type": "string"
																			},
																			"initiatorName": {
																				"description": "Custom iSCSI Initiator Name. If initiatorName is specified with iscsiInterface simultaneously, new iSCSI interface \u003ctarget portal\u003e:\u003cvolume name\u003e will be created for the connection.",
																				"type": "string"
																			},
																			"iqn": {
																				"description": "Target iSCSI Qualified Name.",
																				"type": "string"
																			},
																			"iscsiInterface": {
																				"description": "iSCSI Interface Name that uses an iSCSI transport. Defaults to 'default' (tcp).",
																				"type": "string"
																			},
																			"lun": {
																				"description": "iSCSI Target Lun number.",
																				"format": "int32",
																				"type": "integer"
																			},
																			"portals": {
																				"description": "iSCSI Target Portal List. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "CHAP Secret for iSCSI target and initiator authentication",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"targetPortal": {
																				"description": "iSCSI Target Portal. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).",
																				"type": "string"
																			}
																		},
																		"required": [
																			"iqn",
																			"lun",
																			"targetPortal"
																		],
																		"type": "object"
																	},
																	"name": {
																		"description": "Volume's name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names",
																		"type": "string"
																	},
																	"nfs": {
																		"description": "NFS represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs",
																		"properties": {
																			"path": {
																				"description": "Path that is exported by the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the NFS export to be mounted with read-only permissions. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs",
																				"type": "boolean"
																			},
																			"server": {
																				"description": "Server is the hostname or IP address of the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs",
																				"type": "string"
																			}
																		},
																		"required": [
																			"path",
																			"server"
																		],
																		"type": "object"
																	},
																	"persistentVolumeClaim": {
																		"description": "PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims",
																		"properties": {
																			"claimName": {
																				"description": "ClaimName is the name of a PersistentVolumeClaim in the same namespace as the pod using this volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Will force the ReadOnly setting in VolumeMounts. Default false.",
																				"type": "boolean"
																			}
																		},
																		"required": [
																			"claimName"
																		],
																		"type": "object"
																	},
																	"photonPersistentDisk": {
																		"description": "PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.",
																				"type": "string"
																			},
																			"pdID": {
																				"description": "ID that identifies Photon Controller persistent disk",
																				"type": "string"
																			}
																		},
																		"required": [
																			"pdID"
																		],
																		"type": "object"
																	},
																	"portworxVolume": {
																		"description": "PortworxVolume represents a portworx volume attached and mounted on kubelets host machine",
																		"properties": {
																			"fsType": {
																				"description": "FSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\". Implicitly inferred to be \"ext4\" if unspecified.",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"volumeID": {
																				"description": "VolumeID uniquely identifies a Portworx volume",
																				"type": "string"
																			}
																		},
																		"required": [
																			"volumeID"
																		],
																		"type": "object"
																	},
																	"projected": {
																		"description": "Items for all in one resources secrets, configmaps, and downward API",
																		"properties": {
																			"defaultMode": {
																				"description": "Mode bits to use on created files by default. Must be a value between 0 and 0777. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																				"format": "int32",
																				"type": "integer"
																			},
																			"sources": {
																				"description": "list of volume projections",
																				"items": {
																					"description": "Projection that may be projected along with other supported volume types",
																					"properties": {
																						"configMap": {
																							"description": "information about the configMap data to project",
																							"properties": {
																								"items": {
																									"description": "If unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.",
																									"items": {
																										"description": "Maps a string key to a path within a volume.",
																										"properties": {
																											"key": {
																												"description": "The key to project.",
																												"type": "string"
																											},
																											"mode": {
																												"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																												"format": "int32",
																												"type": "integer"
																											},
																											"path": {
																												"description": "The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.",
																												"type": "string"
																											}
																										},
																										"required": [
																											"key",
																											"path"
																										],
																										"type": "object"
																									},
																									"type": "array"
																								},
																								"name": {
																									"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																									"type": "string"
																								},
																								"optional": {
																									"description": "Specify whether the ConfigMap or its keys must be defined",
																									"type": "boolean"
																								}
																							},
																							"type": "object"
																						},
																						"downwardAPI": {
																							"description": "information about the downwardAPI data to project",
																							"properties": {
																								"items": {
																									"description": "Items is a list of DownwardAPIVolume file",
																									"items": {
																										"description": "DownwardAPIVolumeFile represents information to create the file containing the pod field",
																										"properties": {
																											"fieldRef": {
																												"description": "Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.",
																												"properties": {
																													"apiVersion": {
																														"description": "Version of the schema the FieldPath is written in terms of, defaults to \"v1\".",
																														"type": "string"
																													},
																													"fieldPath": {
																														"description": "Path of the field to select in the specified API version.",
																														"type": "string"
																													}
																												},
																												"required": [
																													"fieldPath"
																												],
																												"type": "object"
																											},
																											"mode": {
																												"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																												"format": "int32",
																												"type": "integer"
																											},
																											"path": {
																												"description": "Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'",
																												"type": "string"
																											},
																											"resourceFieldRef": {
																												"description": "Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.",
																												"properties": {
																													"containerName": {
																														"description": "Container name: required for volumes, optional for env vars",
																														"type": "string"
																													},
																													"divisor": {
																														"anyOf": [
																															{
																																"type": "integer"
																															},
																															{
																																"type": "string"
																															}
																														],
																														"description": "Specifies the output format of the exposed resources, defaults to \"1\"",
																														"pattern": "^(\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))))?$",
																														"x_kubernetes_int_or_string": true
																													},
																													"resource": {
																														"description": "Required: resource to select",
																														"type": "string"
																													}
																												},
																												"required": [
																													"resource"
																												],
																												"type": "object"
																											}
																										},
																										"required": [
																											"path"
																										],
																										"type": "object"
																									},
																									"type": "array"
																								}
																							},
																							"type": "object"
																						},
																						"secret": {
																							"description": "information about the secret data to project",
																							"properties": {
																								"items": {
																									"description": "If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.",
																									"items": {
																										"description": "Maps a string key to a path within a volume.",
																										"properties": {
																											"key": {
																												"description": "The key to project.",
																												"type": "string"
																											},
																											"mode": {
																												"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																												"format": "int32",
																												"type": "integer"
																											},
																											"path": {
																												"description": "The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.",
																												"type": "string"
																											}
																										},
																										"required": [
																											"key",
																											"path"
																										],
																										"type": "object"
																									},
																									"type": "array"
																								},
																								"name": {
																									"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																									"type": "string"
																								},
																								"optional": {
																									"description": "Specify whether the Secret or its key must be defined",
																									"type": "boolean"
																								}
																							},
																							"type": "object"
																						},
																						"serviceAccountToken": {
																							"description": "information about the serviceAccountToken data to project",
																							"properties": {
																								"audience": {
																									"description": "Audience is the intended audience of the token. A recipient of a token must identify itself with an identifier specified in the audience of the token, and otherwise should reject the token. The audience defaults to the identifier of the apiserver.",
																									"type": "string"
																								},
																								"expirationSeconds": {
																									"description": "ExpirationSeconds is the requested duration of validity of the service account token. As the token approaches expiration, the kubelet volume plugin will proactively rotate the service account token. The kubelet will start trying to rotate the token if the token is older than 80 percent of its time to live or if the token is older than 24 hours.Defaults to 1 hour and must be at least 10 minutes.",
																									"format": "int64",
																									"type": "integer"
																								},
																								"path": {
																									"description": "Path is the path relative to the mount point of the file to project the token into.",
																									"type": "string"
																								}
																							},
																							"required": [
																								"path"
																							],
																							"type": "object"
																						}
																					},
																					"type": "object"
																				},
																				"type": "array"
																			}
																		},
																		"required": [
																			"sources"
																		],
																		"type": "object"
																	},
																	"quobyte": {
																		"description": "Quobyte represents a Quobyte mount on the host that shares a pod's lifetime",
																		"properties": {
																			"group": {
																				"description": "Group to map volume access to Default is no group",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.",
																				"type": "boolean"
																			},
																			"registry": {
																				"description": "Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes",
																				"type": "string"
																			},
																			"tenant": {
																				"description": "Tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin",
																				"type": "string"
																			},
																			"user": {
																				"description": "User to map volume access to Defaults to serivceaccount user",
																				"type": "string"
																			},
																			"volume": {
																				"description": "Volume is a string that references an already created Quobyte volume by name.",
																				"type": "string"
																			}
																		},
																		"required": [
																			"registry",
																			"volume"
																		],
																		"type": "object"
																	},
																	"rbd": {
																		"description": "RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/rbd/README.md",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd TODO: how do we prevent errors in the filesystem from compromising the machine",
																				"type": "string"
																			},
																			"image": {
																				"description": "The rados image name. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"type": "string"
																			},
																			"keyring": {
																				"description": "Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"type": "string"
																			},
																			"monitors": {
																				"description": "A collection of Ceph monitors. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			},
																			"pool": {
																				"description": "The rados pool name. Default is rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "SecretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"user": {
																				"description": "The rados user name. Default is admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"type": "string"
																			}
																		},
																		"required": [
																			"image",
																			"monitors"
																		],
																		"type": "object"
																	},
																	"scaleIO": {
																		"description": "ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Default is \"xfs\".",
																				"type": "string"
																			},
																			"gateway": {
																				"description": "The host address of the ScaleIO API Gateway.",
																				"type": "string"
																			},
																			"protectionDomain": {
																				"description": "The name of the ScaleIO Protection Domain for the configured storage.",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"sslEnabled": {
																				"description": "Flag to enable/disable SSL communication with Gateway, default false",
																				"type": "boolean"
																			},
																			"storageMode": {
																				"description": "Indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned. Default is ThinProvisioned.",
																				"type": "string"
																			},
																			"storagePool": {
																				"description": "The ScaleIO Storage Pool associated with the protection domain.",
																				"type": "string"
																			},
																			"system": {
																				"description": "The name of the storage system as configured in ScaleIO.",
																				"type": "string"
																			},
																			"volumeName": {
																				"description": "The name of a volume already created in the ScaleIO system that is associated with this volume source.",
																				"type": "string"
																			}
																		},
																		"required": [
																			"gateway",
																			"secretRef",
																			"system"
																		],
																		"type": "object"
																	},
																	"secret": {
																		"description": "Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret",
																		"properties": {
																			"defaultMode": {
																				"description": "Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																				"format": "int32",
																				"type": "integer"
																			},
																			"items": {
																				"description": "If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.",
																				"items": {
																					"description": "Maps a string key to a path within a volume.",
																					"properties": {
																						"key": {
																							"description": "The key to project.",
																							"type": "string"
																						},
																						"mode": {
																							"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																							"format": "int32",
																							"type": "integer"
																						},
																						"path": {
																							"description": "The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.",
																							"type": "string"
																						}
																					},
																					"required": [
																						"key",
																						"path"
																					],
																					"type": "object"
																				},
																				"type": "array"
																			},
																			"optional": {
																				"description": "Specify whether the Secret or its keys must be defined",
																				"type": "boolean"
																			},
																			"secretName": {
																				"description": "Name of the secret in the pod's namespace to use. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret",
																				"type": "string"
																			}
																		},
																		"type": "object"
																	},
																	"storageos": {
																		"description": "StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "SecretRef specifies the secret to use for obtaining the StorageOS API credentials.  If not specified, default values will be attempted.",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"volumeName": {
																				"description": "VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.",
																				"type": "string"
																			},
																			"volumeNamespace": {
																				"description": "VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to \"default\" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.",
																				"type": "string"
																			}
																		},
																		"type": "object"
																	},
																	"vsphereVolume": {
																		"description": "VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.",
																				"type": "string"
																			},
																			"storagePolicyID": {
																				"description": "Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.",
																				"type": "string"
																			},
																			"storagePolicyName": {
																				"description": "Storage Policy Based Management (SPBM) profile name.",
																				"type": "string"
																			},
																			"volumePath": {
																				"description": "Path that identifies vSphere volume vmdk",
																				"type": "string"
																			}
																		},
																		"required": [
																			"volumePath"
																		],
																		"type": "object"
																	}
																},
																"required": [
																	"name"
																],
																"type": "object"
															},
															"type": "array"
														}
													},
													"type": "object"
												},
												"image": {
													"description": "ImageTask --",
													"properties": {
														"affinity": {
															"description": "Affinity is a group of affinity scheduling rules.",
															"properties": {
																"nodeAffinity": {
																	"description": "Describes node affinity scheduling rules for the pod.",
																	"properties": {
																		"preferredDuringSchedulingIgnoredDuringExecution": {
																			"description": "The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \"weight\" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.",
																			"items": {
																				"description": "An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).",
																				"properties": {
																					"preference": {
																						"description": "A node selector term, associated with the corresponding weight.",
																						"properties": {
																							"matchExpressions": {
																								"description": "A list of node selector requirements by node's labels.",
																								"items": {
																									"description": "A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "The label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.",
																											"type": "string"
																										},
																										"values": {
																											"description": "An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							},
																							"matchFields": {
																								"description": "A list of node selector requirements by node's fields.",
																								"items": {
																									"description": "A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "The label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.",
																											"type": "string"
																										},
																										"values": {
																											"description": "An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							}
																						},
																						"type": "object"
																					},
																					"weight": {
																						"description": "Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.",
																						"format": "int32",
																						"type": "integer"
																					}
																				},
																				"required": [
																					"preference",
																					"weight"
																				],
																				"type": "object"
																			},
																			"type": "array"
																		},
																		"requiredDuringSchedulingIgnoredDuringExecution": {
																			"description": "If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.",
																			"properties": {
																				"nodeSelectorTerms": {
																					"description": "Required. A list of node selector terms. The terms are ORed.",
																					"items": {
																						"description": "A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.",
																						"properties": {
																							"matchExpressions": {
																								"description": "A list of node selector requirements by node's labels.",
																								"items": {
																									"description": "A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "The label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.",
																											"type": "string"
																										},
																										"values": {
																											"description": "An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							},
																							"matchFields": {
																								"description": "A list of node selector requirements by node's fields.",
																								"items": {
																									"description": "A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "The label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "Represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.",
																											"type": "string"
																										},
																										"values": {
																											"description": "An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							}
																						},
																						"type": "object"
																					},
																					"type": "array"
																				}
																			},
																			"required": [
																				"nodeSelectorTerms"
																			],
																			"type": "object"
																		}
																	},
																	"type": "object"
																},
																"podAffinity": {
																	"description": "Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).",
																	"properties": {
																		"preferredDuringSchedulingIgnoredDuringExecution": {
																			"description": "The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \"weight\" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.",
																			"items": {
																				"description": "The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)",
																				"properties": {
																					"podAffinityTerm": {
																						"description": "Required. A pod affinity term, associated with the corresponding weight.",
																						"properties": {
																							"labelSelector": {
																								"description": "A label query over a set of resources, in this case pods.",
																								"properties": {
																									"matchExpressions": {
																										"description": "matchExpressions is a list of label selector requirements. The requirements are ANDed.",
																										"items": {
																											"description": "A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																											"properties": {
																												"key": {
																													"description": "key is the label key that the selector applies to.",
																													"type": "string"
																												},
																												"operator": {
																													"description": "operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.",
																													"type": "string"
																												},
																												"values": {
																													"description": "values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.",
																													"items": {
																														"type": "string"
																													},
																													"type": "array"
																												}
																											},
																											"required": [
																												"key",
																												"operator"
																											],
																											"type": "object"
																										},
																										"type": "array"
																									},
																									"matchLabels": {
																										"additionalProperties": {
																											"type": "string"
																										},
																										"description": "matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed.",
																										"type": "object"
																									}
																								},
																								"type": "object"
																							},
																							"namespaces": {
																								"description": "namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \"this pod's namespace\"",
																								"items": {
																									"type": "string"
																								},
																								"type": "array"
																							},
																							"topologyKey": {
																								"description": "This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.",
																								"type": "string"
																							}
																						},
																						"required": [
																							"topologyKey"
																						],
																						"type": "object"
																					},
																					"weight": {
																						"description": "weight associated with matching the corresponding podAffinityTerm, in the range 1-100.",
																						"format": "int32",
																						"type": "integer"
																					}
																				},
																				"required": [
																					"podAffinityTerm",
																					"weight"
																				],
																				"type": "object"
																			},
																			"type": "array"
																		},
																		"requiredDuringSchedulingIgnoredDuringExecution": {
																			"description": "If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.",
																			"items": {
																				"description": "Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key \u003ctopologyKey\u003e matches that of any node on which a pod of the set of pods is running",
																				"properties": {
																					"labelSelector": {
																						"description": "A label query over a set of resources, in this case pods.",
																						"properties": {
																							"matchExpressions": {
																								"description": "matchExpressions is a list of label selector requirements. The requirements are ANDed.",
																								"items": {
																									"description": "A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "key is the label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.",
																											"type": "string"
																										},
																										"values": {
																											"description": "values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							},
																							"matchLabels": {
																								"additionalProperties": {
																									"type": "string"
																								},
																								"description": "matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed.",
																								"type": "object"
																							}
																						},
																						"type": "object"
																					},
																					"namespaces": {
																						"description": "namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \"this pod's namespace\"",
																						"items": {
																							"type": "string"
																						},
																						"type": "array"
																					},
																					"topologyKey": {
																						"description": "This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.",
																						"type": "string"
																					}
																				},
																				"required": [
																					"topologyKey"
																				],
																				"type": "object"
																			},
																			"type": "array"
																		}
																	},
																	"type": "object"
																},
																"podAntiAffinity": {
																	"description": "Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).",
																	"properties": {
																		"preferredDuringSchedulingIgnoredDuringExecution": {
																			"description": "The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions. The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding \"weight\" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.",
																			"items": {
																				"description": "The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)",
																				"properties": {
																					"podAffinityTerm": {
																						"description": "Required. A pod affinity term, associated with the corresponding weight.",
																						"properties": {
																							"labelSelector": {
																								"description": "A label query over a set of resources, in this case pods.",
																								"properties": {
																									"matchExpressions": {
																										"description": "matchExpressions is a list of label selector requirements. The requirements are ANDed.",
																										"items": {
																											"description": "A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																											"properties": {
																												"key": {
																													"description": "key is the label key that the selector applies to.",
																													"type": "string"
																												},
																												"operator": {
																													"description": "operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.",
																													"type": "string"
																												},
																												"values": {
																													"description": "values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.",
																													"items": {
																														"type": "string"
																													},
																													"type": "array"
																												}
																											},
																											"required": [
																												"key",
																												"operator"
																											],
																											"type": "object"
																										},
																										"type": "array"
																									},
																									"matchLabels": {
																										"additionalProperties": {
																											"type": "string"
																										},
																										"description": "matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed.",
																										"type": "object"
																									}
																								},
																								"type": "object"
																							},
																							"namespaces": {
																								"description": "namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \"this pod's namespace\"",
																								"items": {
																									"type": "string"
																								},
																								"type": "array"
																							},
																							"topologyKey": {
																								"description": "This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.",
																								"type": "string"
																							}
																						},
																						"required": [
																							"topologyKey"
																						],
																						"type": "object"
																					},
																					"weight": {
																						"description": "weight associated with matching the corresponding podAffinityTerm, in the range 1-100.",
																						"format": "int32",
																						"type": "integer"
																					}
																				},
																				"required": [
																					"podAffinityTerm",
																					"weight"
																				],
																				"type": "object"
																			},
																			"type": "array"
																		},
																		"requiredDuringSchedulingIgnoredDuringExecution": {
																			"description": "If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node. If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.",
																			"items": {
																				"description": "Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key \u003ctopologyKey\u003e matches that of any node on which a pod of the set of pods is running",
																				"properties": {
																					"labelSelector": {
																						"description": "A label query over a set of resources, in this case pods.",
																						"properties": {
																							"matchExpressions": {
																								"description": "matchExpressions is a list of label selector requirements. The requirements are ANDed.",
																								"items": {
																									"description": "A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.",
																									"properties": {
																										"key": {
																											"description": "key is the label key that the selector applies to.",
																											"type": "string"
																										},
																										"operator": {
																											"description": "operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.",
																											"type": "string"
																										},
																										"values": {
																											"description": "values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.",
																											"items": {
																												"type": "string"
																											},
																											"type": "array"
																										}
																									},
																									"required": [
																										"key",
																										"operator"
																									],
																									"type": "object"
																								},
																								"type": "array"
																							},
																							"matchLabels": {
																								"additionalProperties": {
																									"type": "string"
																								},
																								"description": "matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed.",
																								"type": "object"
																							}
																						},
																						"type": "object"
																					},
																					"namespaces": {
																						"description": "namespaces specifies which namespaces the labelSelector applies to (matches against); null or empty list means \"this pod's namespace\"",
																						"items": {
																							"type": "string"
																						},
																						"type": "array"
																					},
																					"topologyKey": {
																						"description": "This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running. Empty topologyKey is not allowed.",
																						"type": "string"
																					}
																				},
																				"required": [
																					"topologyKey"
																				],
																				"type": "object"
																			},
																			"type": "array"
																		}
																	},
																	"type": "object"
																}
															},
															"type": "object"
														},
														"args": {
															"items": {
																"type": "string"
															},
															"type": "array"
														},
														"builtImage": {
															"type": "string"
														},
														"command": {
															"items": {
																"type": "string"
															},
															"type": "array"
														},
														"env": {
															"items": {
																"description": "EnvVar represents an environment variable present in a Container.",
																"properties": {
																	"name": {
																		"description": "Name of the environment variable. Must be a C_IDENTIFIER.",
																		"type": "string"
																	},
																	"value": {
																		"description": "Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to \"\".",
																		"type": "string"
																	},
																	"valueFrom": {
																		"description": "Source for the environment variable's value. Cannot be used if value is not empty.",
																		"properties": {
																			"configMapKeyRef": {
																				"description": "Selects a key of a ConfigMap.",
																				"properties": {
																					"key": {
																						"description": "The key to select.",
																						"type": "string"
																					},
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					},
																					"optional": {
																						"description": "Specify whether the ConfigMap or its key must be defined",
																						"type": "boolean"
																					}
																				},
																				"required": [
																					"key"
																				],
																				"type": "object"
																			},
																			"fieldRef": {
																				"description": "Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.",
																				"properties": {
																					"apiVersion": {
																						"description": "Version of the schema the FieldPath is written in terms of, defaults to \"v1\".",
																						"type": "string"
																					},
																					"fieldPath": {
																						"description": "Path of the field to select in the specified API version.",
																						"type": "string"
																					}
																				},
																				"required": [
																					"fieldPath"
																				],
																				"type": "object"
																			},
																			"resourceFieldRef": {
																				"description": "Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.",
																				"properties": {
																					"containerName": {
																						"description": "Container name: required for volumes, optional for env vars",
																						"type": "string"
																					},
																					"divisor": {
																						"anyOf": [
																							{
																								"type": "integer"
																							},
																							{
																								"type": "string"
																							}
																						],
																						"description": "Specifies the output format of the exposed resources, defaults to \"1\"",
																						"pattern": "^(\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))))?$",
																						"x_kubernetes_int_or_string": true
																					},
																					"resource": {
																						"description": "Required: resource to select",
																						"type": "string"
																					}
																				},
																				"required": [
																					"resource"
																				],
																				"type": "object"
																			},
																			"secretKeyRef": {
																				"description": "Selects a key of a secret in the pod's namespace",
																				"properties": {
																					"key": {
																						"description": "The key of the secret to select from.  Must be a valid secret key.",
																						"type": "string"
																					},
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					},
																					"optional": {
																						"description": "Specify whether the Secret or its key must be defined",
																						"type": "boolean"
																					}
																				},
																				"required": [
																					"key"
																				],
																				"type": "object"
																			}
																		},
																		"type": "object"
																	}
																},
																"required": [
																	"name"
																],
																"type": "object"
															},
															"type": "array"
														},
														"image": {
															"type": "string"
														},
														"name": {
															"type": "string"
														},
														"securityContext": {
															"description": "SecurityContext holds security configuration that will be applied to a container. Some fields are present in both SecurityContext and PodSecurityContext.  When both are set, the values in SecurityContext take precedence.",
															"properties": {
																"allowPrivilegeEscalation": {
																	"description": "AllowPrivilegeEscalation controls whether a process can gain more privileges than its parent process. This bool directly controls if the no_new_privs flag will be set on the container process. AllowPrivilegeEscalation is true always when the container is: 1) run as Privileged 2) has CAP_SYS_ADMIN",
																	"type": "boolean"
																},
																"capabilities": {
																	"description": "The capabilities to add/drop when running containers. Defaults to the default set of capabilities granted by the container runtime.",
																	"properties": {
																		"add": {
																			"description": "Added capabilities",
																			"items": {
																				"description": "Capability represent POSIX capabilities type",
																				"type": "string"
																			},
																			"type": "array"
																		},
																		"drop": {
																			"description": "Removed capabilities",
																			"items": {
																				"description": "Capability represent POSIX capabilities type",
																				"type": "string"
																			},
																			"type": "array"
																		}
																	},
																	"type": "object"
																},
																"privileged": {
																	"description": "Run container in privileged mode. Processes in privileged containers are essentially equivalent to root on the host. Defaults to false.",
																	"type": "boolean"
																},
																"procMount": {
																	"description": "procMount denotes the type of proc mount to use for the containers. The default is DefaultProcMount which uses the container runtime defaults for readonly paths and masked paths. This requires the ProcMountType feature flag to be enabled.",
																	"type": "string"
																},
																"readOnlyRootFilesystem": {
																	"description": "Whether this container has a read-only root filesystem. Default is false.",
																	"type": "boolean"
																},
																"runAsGroup": {
																	"description": "The GID to run the entrypoint of the container process. Uses runtime default if unset. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.",
																	"format": "int64",
																	"type": "integer"
																},
																"runAsNonRoot": {
																	"description": "Indicates that the container must run as a non-root user. If true, the Kubelet will validate the image at runtime to ensure that it does not run as UID 0 (root) and fail to start the container if it does. If unset or false, no such validation will be performed. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.",
																	"type": "boolean"
																},
																"runAsUser": {
																	"description": "The UID to run the entrypoint of the container process. Defaults to user specified in image metadata if unspecified. May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.",
																	"format": "int64",
																	"type": "integer"
																},
																"seLinuxOptions": {
																	"description": "The SELinux context to be applied to the container. If unspecified, the container runtime will allocate a random SELinux context for each container.  May also be set in PodSecurityContext.  If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.",
																	"properties": {
																		"level": {
																			"description": "Level is SELinux level label that applies to the container.",
																			"type": "string"
																		},
																		"role": {
																			"description": "Role is a SELinux role label that applies to the container.",
																			"type": "string"
																		},
																		"type": {
																			"description": "Type is a SELinux type label that applies to the container.",
																			"type": "string"
																		},
																		"user": {
																			"description": "User is a SELinux user label that applies to the container.",
																			"type": "string"
																		}
																	},
																	"type": "object"
																},
																"windowsOptions": {
																	"description": "The Windows specific settings applied to all containers. If unspecified, the options from the PodSecurityContext will be used. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.",
																	"properties": {
																		"gmsaCredentialSpec": {
																			"description": "GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.",
																			"type": "string"
																		},
																		"gmsaCredentialSpecName": {
																			"description": "GMSACredentialSpecName is the name of the GMSA credential spec to use.",
																			"type": "string"
																		},
																		"runAsUserName": {
																			"description": "The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.",
																			"type": "string"
																		}
																	},
																	"type": "object"
																}
															},
															"type": "object"
														},
														"volumeMounts": {
															"items": {
																"description": "VolumeMount describes a mounting of a Volume within a container.",
																"properties": {
																	"mountPath": {
																		"description": "Path within the container at which the volume should be mounted.  Must not contain ':'.",
																		"type": "string"
																	},
																	"mountPropagation": {
																		"description": "mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10.",
																		"type": "string"
																	},
																	"name": {
																		"description": "This must match the Name of a Volume.",
																		"type": "string"
																	},
																	"readOnly": {
																		"description": "Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.",
																		"type": "boolean"
																	},
																	"subPath": {
																		"description": "Path within the volume from which the container's volume should be mounted. Defaults to \"\" (volume's root).",
																		"type": "string"
																	},
																	"subPathExpr": {
																		"description": "Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to \"\" (volume's root). SubPathExpr and SubPath are mutually exclusive.",
																		"type": "string"
																	}
																},
																"required": [
																	"mountPath",
																	"name"
																],
																"type": "object"
															},
															"type": "array"
														},
														"volumes": {
															"items": {
																"description": "Volume represents a named volume in a pod that may be accessed by any container in the pod.",
																"properties": {
																	"awsElasticBlockStore": {
																		"description": "AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore TODO: how do we prevent errors in the filesystem from compromising the machine",
																				"type": "string"
																			},
																			"partition": {
																				"description": "The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \"1\". Similarly, the volume partition for /dev/sda is \"0\" (or you can leave the property empty).",
																				"format": "int32",
																				"type": "integer"
																			},
																			"readOnly": {
																				"description": "Specify \"true\" to force and set the ReadOnly property in VolumeMounts to \"true\". If omitted, the default is \"false\". More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore",
																				"type": "boolean"
																			},
																			"volumeID": {
																				"description": "Unique ID of the persistent disk resource in AWS (Amazon EBS volume). More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore",
																				"type": "string"
																			}
																		},
																		"required": [
																			"volumeID"
																		],
																		"type": "object"
																	},
																	"azureDisk": {
																		"description": "AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.",
																		"properties": {
																			"cachingMode": {
																				"description": "Host Caching mode: None, Read Only, Read Write.",
																				"type": "string"
																			},
																			"diskName": {
																				"description": "The Name of the data disk in the blob storage",
																				"type": "string"
																			},
																			"diskURI": {
																				"description": "The URI the data disk in the blob storage",
																				"type": "string"
																			},
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.",
																				"type": "string"
																			},
																			"kind": {
																				"description": "Expected values Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			}
																		},
																		"required": [
																			"diskName",
																			"diskURI"
																		],
																		"type": "object"
																	},
																	"azureFile": {
																		"description": "AzureFile represents an Azure File Service mount on the host and bind mount to the pod.",
																		"properties": {
																			"readOnly": {
																				"description": "Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"secretName": {
																				"description": "the name of secret that contains Azure Storage Account Name and Key",
																				"type": "string"
																			},
																			"shareName": {
																				"description": "Share Name",
																				"type": "string"
																			}
																		},
																		"required": [
																			"secretName",
																			"shareName"
																		],
																		"type": "object"
																	},
																	"cephfs": {
																		"description": "CephFS represents a Ceph FS mount on the host that shares a pod's lifetime",
																		"properties": {
																			"monitors": {
																				"description": "Required: Monitors is a collection of Ceph monitors More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			},
																			"path": {
																				"description": "Optional: Used as the mounted root, rather than the full Ceph tree, default is /",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it",
																				"type": "boolean"
																			},
																			"secretFile": {
																				"description": "Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it",
																				"type": "string"
																			},
																			"secretRef": {
																				"description": "Optional: SecretRef is reference to the authentication secret for User, default is empty. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"user": {
																				"description": "Optional: User is the rados user name, default is admin More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it",
																				"type": "string"
																			}
																		},
																		"required": [
																			"monitors"
																		],
																		"type": "object"
																	},
																	"cinder": {
																		"description": "Cinder represents a cinder volume attached and mounted on kubelets host machine. More info: https://examples.k8s.io/mysql-cinder-pd/README.md",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://examples.k8s.io/mysql-cinder-pd/README.md",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/mysql-cinder-pd/README.md",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "Optional: points to a secret object containing parameters used to connect to OpenStack.",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"volumeID": {
																				"description": "volume id used to identify the volume in cinder. More info: https://examples.k8s.io/mysql-cinder-pd/README.md",
																				"type": "string"
																			}
																		},
																		"required": [
																			"volumeID"
																		],
																		"type": "object"
																	},
																	"configMap": {
																		"description": "ConfigMap represents a configMap that should populate this volume",
																		"properties": {
																			"defaultMode": {
																				"description": "Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																				"format": "int32",
																				"type": "integer"
																			},
																			"items": {
																				"description": "If unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.",
																				"items": {
																					"description": "Maps a string key to a path within a volume.",
																					"properties": {
																						"key": {
																							"description": "The key to project.",
																							"type": "string"
																						},
																						"mode": {
																							"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																							"format": "int32",
																							"type": "integer"
																						},
																						"path": {
																							"description": "The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.",
																							"type": "string"
																						}
																					},
																					"required": [
																						"key",
																						"path"
																					],
																					"type": "object"
																				},
																				"type": "array"
																			},
																			"name": {
																				"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																				"type": "string"
																			},
																			"optional": {
																				"description": "Specify whether the ConfigMap or its keys must be defined",
																				"type": "boolean"
																			}
																		},
																		"type": "object"
																	},
																	"csi": {
																		"description": "CSI (Container Storage Interface) represents storage that is handled by an external CSI driver (Alpha feature).",
																		"properties": {
																			"driver": {
																				"description": "Driver is the name of the CSI driver that handles this volume. Consult with your admin for the correct name as registered in the cluster.",
																				"type": "string"
																			},
																			"fsType": {
																				"description": "Filesystem type to mount. Ex. \"ext4\", \"xfs\", \"ntfs\". If not provided, the empty value is passed to the associated CSI driver which will determine the default filesystem to apply.",
																				"type": "string"
																			},
																			"nodePublishSecretRef": {
																				"description": "NodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls. This field is optional, and  may be empty if no secret is required. If the secret object contains more than one secret, all secret references are passed.",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"readOnly": {
																				"description": "Specifies a read-only configuration for the volume. Defaults to false (read/write).",
																				"type": "boolean"
																			},
																			"volumeAttributes": {
																				"additionalProperties": {
																					"type": "string"
																				},
																				"description": "VolumeAttributes stores driver-specific properties that are passed to the CSI driver. Consult your driver's documentation for supported values.",
																				"type": "object"
																			}
																		},
																		"required": [
																			"driver"
																		],
																		"type": "object"
																	},
																	"downwardAPI": {
																		"description": "DownwardAPI represents downward API about the pod that should populate this volume",
																		"properties": {
																			"defaultMode": {
																				"description": "Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																				"format": "int32",
																				"type": "integer"
																			},
																			"items": {
																				"description": "Items is a list of downward API volume file",
																				"items": {
																					"description": "DownwardAPIVolumeFile represents information to create the file containing the pod field",
																					"properties": {
																						"fieldRef": {
																							"description": "Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.",
																							"properties": {
																								"apiVersion": {
																									"description": "Version of the schema the FieldPath is written in terms of, defaults to \"v1\".",
																									"type": "string"
																								},
																								"fieldPath": {
																									"description": "Path of the field to select in the specified API version.",
																									"type": "string"
																								}
																							},
																							"required": [
																								"fieldPath"
																							],
																							"type": "object"
																						},
																						"mode": {
																							"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																							"format": "int32",
																							"type": "integer"
																						},
																						"path": {
																							"description": "Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'",
																							"type": "string"
																						},
																						"resourceFieldRef": {
																							"description": "Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.",
																							"properties": {
																								"containerName": {
																									"description": "Container name: required for volumes, optional for env vars",
																									"type": "string"
																								},
																								"divisor": {
																									"anyOf": [
																										{
																											"type": "integer"
																										},
																										{
																											"type": "string"
																										}
																									],
																									"description": "Specifies the output format of the exposed resources, defaults to \"1\"",
																									"pattern": "^(\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))))?$",
																									"x_kubernetes_int_or_string": true
																								},
																								"resource": {
																									"description": "Required: resource to select",
																									"type": "string"
																								}
																							},
																							"required": [
																								"resource"
																							],
																							"type": "object"
																						}
																					},
																					"required": [
																						"path"
																					],
																					"type": "object"
																				},
																				"type": "array"
																			}
																		},
																		"type": "object"
																	},
																	"emptyDir": {
																		"description": "EmptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir",
																		"properties": {
																			"medium": {
																				"description": "What type of storage medium should back this directory. The default is \"\" which means to use the node's default medium. Must be an empty string (default) or Memory. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir",
																				"type": "string"
																			},
																			"sizeLimit": {
																				"anyOf": [
																					{
																						"type": "integer"
																					},
																					{
																						"type": "string"
																					}
																				],
																				"description": "Total amount of local storage required for this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. The default is nil which means that the limit is undefined. More info: http://kubernetes.io/docs/user-guide/volumes#emptydir",
																				"pattern": "^(\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))))?$",
																				"x_kubernetes_int_or_string": true
																			}
																		},
																		"type": "object"
																	},
																	"fc": {
																		"description": "FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. TODO: how do we prevent errors in the filesystem from compromising the machine",
																				"type": "string"
																			},
																			"lun": {
																				"description": "Optional: FC target lun number",
																				"format": "int32",
																				"type": "integer"
																			},
																			"readOnly": {
																				"description": "Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"targetWWNs": {
																				"description": "Optional: FC target worldwide names (WWNs)",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			},
																			"wwids": {
																				"description": "Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			}
																		},
																		"type": "object"
																	},
																	"flexVolume": {
																		"description": "FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.",
																		"properties": {
																			"driver": {
																				"description": "Driver is the name of the driver to use for this volume.",
																				"type": "string"
																			},
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". The default filesystem depends on FlexVolume script.",
																				"type": "string"
																			},
																			"options": {
																				"additionalProperties": {
																					"type": "string"
																				},
																				"description": "Optional: Extra command options if any.",
																				"type": "object"
																			},
																			"readOnly": {
																				"description": "Optional: Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "Optional: SecretRef is reference to the secret object containing sensitive information to pass to the plugin scripts. This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			}
																		},
																		"required": [
																			"driver"
																		],
																		"type": "object"
																	},
																	"flocker": {
																		"description": "Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running",
																		"properties": {
																			"datasetName": {
																				"description": "Name of the dataset stored as metadata -\u003e name on the dataset for Flocker should be considered as deprecated",
																				"type": "string"
																			},
																			"datasetUUID": {
																				"description": "UUID of the dataset. This is unique identifier of a Flocker dataset",
																				"type": "string"
																			}
																		},
																		"type": "object"
																	},
																	"gcePersistentDisk": {
																		"description": "GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk TODO: how do we prevent errors in the filesystem from compromising the machine",
																				"type": "string"
																			},
																			"partition": {
																				"description": "The partition in the volume that you want to mount. If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as \"1\". Similarly, the volume partition for /dev/sda is \"0\" (or you can leave the property empty). More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk",
																				"format": "int32",
																				"type": "integer"
																			},
																			"pdName": {
																				"description": "Unique name of the PD resource in GCE. Used to identify the disk in GCE. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk",
																				"type": "boolean"
																			}
																		},
																		"required": [
																			"pdName"
																		],
																		"type": "object"
																	},
																	"gitRepo": {
																		"description": "GitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.",
																		"properties": {
																			"directory": {
																				"description": "Target directory name. Must not contain or start with '..'.  If '.' is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.",
																				"type": "string"
																			},
																			"repository": {
																				"description": "Repository URL",
																				"type": "string"
																			},
																			"revision": {
																				"description": "Commit hash for the specified revision.",
																				"type": "string"
																			}
																		},
																		"required": [
																			"repository"
																		],
																		"type": "object"
																	},
																	"glusterfs": {
																		"description": "Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/glusterfs/README.md",
																		"properties": {
																			"endpoints": {
																				"description": "EndpointsName is the endpoint name that details Glusterfs topology. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod",
																				"type": "string"
																			},
																			"path": {
																				"description": "Path is the Glusterfs volume path. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the Glusterfs volume to be mounted with read-only permissions. Defaults to false. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod",
																				"type": "boolean"
																			}
																		},
																		"required": [
																			"endpoints",
																			"path"
																		],
																		"type": "object"
																	},
																	"hostPath": {
																		"description": "HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath --- TODO(jonesdl) We need to restrict who can use host directory mounts and who can/can not mount host directories as read/write.",
																		"properties": {
																			"path": {
																				"description": "Path of the directory on the host. If the path is a symlink, it will follow the link to the real path. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath",
																				"type": "string"
																			},
																			"type": {
																				"description": "Type for HostPath Volume Defaults to \"\" More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath",
																				"type": "string"
																			}
																		},
																		"required": [
																			"path"
																		],
																		"type": "object"
																	},
																	"iscsi": {
																		"description": "ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://examples.k8s.io/volumes/iscsi/README.md",
																		"properties": {
																			"chapAuthDiscovery": {
																				"description": "whether support iSCSI Discovery CHAP authentication",
																				"type": "boolean"
																			},
																			"chapAuthSession": {
																				"description": "whether support iSCSI Session CHAP authentication",
																				"type": "boolean"
																			},
																			"fsType": {
																				"description": "Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi TODO: how do we prevent errors in the filesystem from compromising the machine",
																				"type": "string"
																			},
																			"initiatorName": {
																				"description": "Custom iSCSI Initiator Name. If initiatorName is specified with iscsiInterface simultaneously, new iSCSI interface \u003ctarget portal\u003e:\u003cvolume name\u003e will be created for the connection.",
																				"type": "string"
																			},
																			"iqn": {
																				"description": "Target iSCSI Qualified Name.",
																				"type": "string"
																			},
																			"iscsiInterface": {
																				"description": "iSCSI Interface Name that uses an iSCSI transport. Defaults to 'default' (tcp).",
																				"type": "string"
																			},
																			"lun": {
																				"description": "iSCSI Target Lun number.",
																				"format": "int32",
																				"type": "integer"
																			},
																			"portals": {
																				"description": "iSCSI Target Portal List. The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "CHAP Secret for iSCSI target and initiator authentication",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"targetPortal": {
																				"description": "iSCSI Target Portal. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).",
																				"type": "string"
																			}
																		},
																		"required": [
																			"iqn",
																			"lun",
																			"targetPortal"
																		],
																		"type": "object"
																	},
																	"name": {
																		"description": "Volume's name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names",
																		"type": "string"
																	},
																	"nfs": {
																		"description": "NFS represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs",
																		"properties": {
																			"path": {
																				"description": "Path that is exported by the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the NFS export to be mounted with read-only permissions. Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs",
																				"type": "boolean"
																			},
																			"server": {
																				"description": "Server is the hostname or IP address of the NFS server. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs",
																				"type": "string"
																			}
																		},
																		"required": [
																			"path",
																			"server"
																		],
																		"type": "object"
																	},
																	"persistentVolumeClaim": {
																		"description": "PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims",
																		"properties": {
																			"claimName": {
																				"description": "ClaimName is the name of a PersistentVolumeClaim in the same namespace as the pod using this volume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Will force the ReadOnly setting in VolumeMounts. Default false.",
																				"type": "boolean"
																			}
																		},
																		"required": [
																			"claimName"
																		],
																		"type": "object"
																	},
																	"photonPersistentDisk": {
																		"description": "PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.",
																				"type": "string"
																			},
																			"pdID": {
																				"description": "ID that identifies Photon Controller persistent disk",
																				"type": "string"
																			}
																		},
																		"required": [
																			"pdID"
																		],
																		"type": "object"
																	},
																	"portworxVolume": {
																		"description": "PortworxVolume represents a portworx volume attached and mounted on kubelets host machine",
																		"properties": {
																			"fsType": {
																				"description": "FSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\". Implicitly inferred to be \"ext4\" if unspecified.",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"volumeID": {
																				"description": "VolumeID uniquely identifies a Portworx volume",
																				"type": "string"
																			}
																		},
																		"required": [
																			"volumeID"
																		],
																		"type": "object"
																	},
																	"projected": {
																		"description": "Items for all in one resources secrets, configmaps, and downward API",
																		"properties": {
																			"defaultMode": {
																				"description": "Mode bits to use on created files by default. Must be a value between 0 and 0777. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																				"format": "int32",
																				"type": "integer"
																			},
																			"sources": {
																				"description": "list of volume projections",
																				"items": {
																					"description": "Projection that may be projected along with other supported volume types",
																					"properties": {
																						"configMap": {
																							"description": "information about the configMap data to project",
																							"properties": {
																								"items": {
																									"description": "If unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.",
																									"items": {
																										"description": "Maps a string key to a path within a volume.",
																										"properties": {
																											"key": {
																												"description": "The key to project.",
																												"type": "string"
																											},
																											"mode": {
																												"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																												"format": "int32",
																												"type": "integer"
																											},
																											"path": {
																												"description": "The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.",
																												"type": "string"
																											}
																										},
																										"required": [
																											"key",
																											"path"
																										],
																										"type": "object"
																									},
																									"type": "array"
																								},
																								"name": {
																									"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																									"type": "string"
																								},
																								"optional": {
																									"description": "Specify whether the ConfigMap or its keys must be defined",
																									"type": "boolean"
																								}
																							},
																							"type": "object"
																						},
																						"downwardAPI": {
																							"description": "information about the downwardAPI data to project",
																							"properties": {
																								"items": {
																									"description": "Items is a list of DownwardAPIVolume file",
																									"items": {
																										"description": "DownwardAPIVolumeFile represents information to create the file containing the pod field",
																										"properties": {
																											"fieldRef": {
																												"description": "Required: Selects a field of the pod: only annotations, labels, name and namespace are supported.",
																												"properties": {
																													"apiVersion": {
																														"description": "Version of the schema the FieldPath is written in terms of, defaults to \"v1\".",
																														"type": "string"
																													},
																													"fieldPath": {
																														"description": "Path of the field to select in the specified API version.",
																														"type": "string"
																													}
																												},
																												"required": [
																													"fieldPath"
																												],
																												"type": "object"
																											},
																											"mode": {
																												"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																												"format": "int32",
																												"type": "integer"
																											},
																											"path": {
																												"description": "Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'",
																												"type": "string"
																											},
																											"resourceFieldRef": {
																												"description": "Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.",
																												"properties": {
																													"containerName": {
																														"description": "Container name: required for volumes, optional for env vars",
																														"type": "string"
																													},
																													"divisor": {
																														"anyOf": [
																															{
																																"type": "integer"
																															},
																															{
																																"type": "string"
																															}
																														],
																														"description": "Specifies the output format of the exposed resources, defaults to \"1\"",
																														"pattern": "^(\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))(([KMGTPE]i)|[numkMGTPE]|([eE](\\+|-)?(([0-9]+(\\.[0-9]*)?)|(\\.[0-9]+))))?$",
																														"x_kubernetes_int_or_string": true
																													},
																													"resource": {
																														"description": "Required: resource to select",
																														"type": "string"
																													}
																												},
																												"required": [
																													"resource"
																												],
																												"type": "object"
																											}
																										},
																										"required": [
																											"path"
																										],
																										"type": "object"
																									},
																									"type": "array"
																								}
																							},
																							"type": "object"
																						},
																						"secret": {
																							"description": "information about the secret data to project",
																							"properties": {
																								"items": {
																									"description": "If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.",
																									"items": {
																										"description": "Maps a string key to a path within a volume.",
																										"properties": {
																											"key": {
																												"description": "The key to project.",
																												"type": "string"
																											},
																											"mode": {
																												"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																												"format": "int32",
																												"type": "integer"
																											},
																											"path": {
																												"description": "The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.",
																												"type": "string"
																											}
																										},
																										"required": [
																											"key",
																											"path"
																										],
																										"type": "object"
																									},
																									"type": "array"
																								},
																								"name": {
																									"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																									"type": "string"
																								},
																								"optional": {
																									"description": "Specify whether the Secret or its key must be defined",
																									"type": "boolean"
																								}
																							},
																							"type": "object"
																						},
																						"serviceAccountToken": {
																							"description": "information about the serviceAccountToken data to project",
																							"properties": {
																								"audience": {
																									"description": "Audience is the intended audience of the token. A recipient of a token must identify itself with an identifier specified in the audience of the token, and otherwise should reject the token. The audience defaults to the identifier of the apiserver.",
																									"type": "string"
																								},
																								"expirationSeconds": {
																									"description": "ExpirationSeconds is the requested duration of validity of the service account token. As the token approaches expiration, the kubelet volume plugin will proactively rotate the service account token. The kubelet will start trying to rotate the token if the token is older than 80 percent of its time to live or if the token is older than 24 hours.Defaults to 1 hour and must be at least 10 minutes.",
																									"format": "int64",
																									"type": "integer"
																								},
																								"path": {
																									"description": "Path is the path relative to the mount point of the file to project the token into.",
																									"type": "string"
																								}
																							},
																							"required": [
																								"path"
																							],
																							"type": "object"
																						}
																					},
																					"type": "object"
																				},
																				"type": "array"
																			}
																		},
																		"required": [
																			"sources"
																		],
																		"type": "object"
																	},
																	"quobyte": {
																		"description": "Quobyte represents a Quobyte mount on the host that shares a pod's lifetime",
																		"properties": {
																			"group": {
																				"description": "Group to map volume access to Default is no group",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.",
																				"type": "boolean"
																			},
																			"registry": {
																				"description": "Registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes",
																				"type": "string"
																			},
																			"tenant": {
																				"description": "Tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin",
																				"type": "string"
																			},
																			"user": {
																				"description": "User to map volume access to Defaults to serivceaccount user",
																				"type": "string"
																			},
																			"volume": {
																				"description": "Volume is a string that references an already created Quobyte volume by name.",
																				"type": "string"
																			}
																		},
																		"required": [
																			"registry",
																			"volume"
																		],
																		"type": "object"
																	},
																	"rbd": {
																		"description": "RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/rbd/README.md",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd TODO: how do we prevent errors in the filesystem from compromising the machine",
																				"type": "string"
																			},
																			"image": {
																				"description": "The rados image name. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"type": "string"
																			},
																			"keyring": {
																				"description": "Keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"type": "string"
																			},
																			"monitors": {
																				"description": "A collection of Ceph monitors. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			},
																			"pool": {
																				"description": "The rados pool name. Default is rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "ReadOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "SecretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"user": {
																				"description": "The rados user name. Default is admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it",
																				"type": "string"
																			}
																		},
																		"required": [
																			"image",
																			"monitors"
																		],
																		"type": "object"
																	},
																	"scaleIO": {
																		"description": "ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Default is \"xfs\".",
																				"type": "string"
																			},
																			"gateway": {
																				"description": "The host address of the ScaleIO API Gateway.",
																				"type": "string"
																			},
																			"protectionDomain": {
																				"description": "The name of the ScaleIO Protection Domain for the configured storage.",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "SecretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"sslEnabled": {
																				"description": "Flag to enable/disable SSL communication with Gateway, default false",
																				"type": "boolean"
																			},
																			"storageMode": {
																				"description": "Indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned. Default is ThinProvisioned.",
																				"type": "string"
																			},
																			"storagePool": {
																				"description": "The ScaleIO Storage Pool associated with the protection domain.",
																				"type": "string"
																			},
																			"system": {
																				"description": "The name of the storage system as configured in ScaleIO.",
																				"type": "string"
																			},
																			"volumeName": {
																				"description": "The name of a volume already created in the ScaleIO system that is associated with this volume source.",
																				"type": "string"
																			}
																		},
																		"required": [
																			"gateway",
																			"secretRef",
																			"system"
																		],
																		"type": "object"
																	},
																	"secret": {
																		"description": "Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret",
																		"properties": {
																			"defaultMode": {
																				"description": "Optional: mode bits to use on created files by default. Must be a value between 0 and 0777. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																				"format": "int32",
																				"type": "integer"
																			},
																			"items": {
																				"description": "If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value. If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.",
																				"items": {
																					"description": "Maps a string key to a path within a volume.",
																					"properties": {
																						"key": {
																							"description": "The key to project.",
																							"type": "string"
																						},
																						"mode": {
																							"description": "Optional: mode bits to use on this file, must be a value between 0 and 0777. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.",
																							"format": "int32",
																							"type": "integer"
																						},
																						"path": {
																							"description": "The relative path of the file to map the key to. May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.",
																							"type": "string"
																						}
																					},
																					"required": [
																						"key",
																						"path"
																					],
																					"type": "object"
																				},
																				"type": "array"
																			},
																			"optional": {
																				"description": "Specify whether the Secret or its keys must be defined",
																				"type": "boolean"
																			},
																			"secretName": {
																				"description": "Name of the secret in the pod's namespace to use. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret",
																				"type": "string"
																			}
																		},
																		"type": "object"
																	},
																	"storageos": {
																		"description": "StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.",
																				"type": "string"
																			},
																			"readOnly": {
																				"description": "Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.",
																				"type": "boolean"
																			},
																			"secretRef": {
																				"description": "SecretRef specifies the secret to use for obtaining the StorageOS API credentials.  If not specified, default values will be attempted.",
																				"properties": {
																					"name": {
																						"description": "Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?",
																						"type": "string"
																					}
																				},
																				"type": "object"
																			},
																			"volumeName": {
																				"description": "VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.",
																				"type": "string"
																			},
																			"volumeNamespace": {
																				"description": "VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to \"default\" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.",
																				"type": "string"
																			}
																		},
																		"type": "object"
																	},
																	"vsphereVolume": {
																		"description": "VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine",
																		"properties": {
																			"fsType": {
																				"description": "Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \"ext4\", \"xfs\", \"ntfs\". Implicitly inferred to be \"ext4\" if unspecified.",
																				"type": "string"
																			},
																			"storagePolicyID": {
																				"description": "Storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.",
																				"type": "string"
																			},
																			"storagePolicyName": {
																				"description": "Storage Policy Based Management (SPBM) profile name.",
																				"type": "string"
																			},
																			"volumePath": {
																				"description": "Path that identifies vSphere volume vmdk",
																				"type": "string"
																			}
																		},
																		"required": [
																			"volumePath"
																		],
																		"type": "object"
																	}
																},
																"required": [
																	"name"
																],
																"type": "object"
															},
															"type": "array"
														},
														"workingDir": {
															"type": "string"
														}
													},
													"type": "object"
												}
											},
											"type": "object"
										},
										"type": "array"
									}
								},
								"type": "object"
							},
							"status": {
								"description": "BuildStatus defines the observed state of Build",
								"properties": {
									"artifacts": {
										"items": {
											"description": "Artifact --",
											"properties": {
												"checksum": {
													"type": "string"
												},
												"id": {
													"type": "string"
												},
												"location": {
													"type": "string"
												},
												"target": {
													"type": "string"
												}
											},
											"required": [
												"id"
											],
											"type": "object"
										},
										"type": "array"
									},
									"baseImage": {
										"type": "string"
									},
									"conditions": {
										"items": {
											"description": "BuildCondition describes the state of a resource at a certain point.",
											"properties": {
												"lastTransitionTime": {
													"description": "Last time the condition transitioned from one status to another.",
													"format": "date-time",
													"type": "string"
												},
												"lastUpdateTime": {
													"description": "The last time this condition was updated.",
													"format": "date-time",
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
												"status": {
													"description": "Status of the condition, one of True, False, Unknown.",
													"type": "string"
												},
												"type": {
													"description": "Type of integration condition.",
													"type": "string"
												}
											},
											"required": [
												"status",
												"type"
											],
											"type": "object"
										},
										"type": "array"
									},
									"digest": {
										"type": "string"
									},
									"duration": {
										"description": "Change to Duration / ISO 8601 when CRD uses OpenAPI spec v3 https://github.com/OAI/OpenAPI-Specification/issues/845",
										"type": "string"
									},
									"error": {
										"type": "string"
									},
									"failure": {
										"description": "Failure --",
										"properties": {
											"reason": {
												"type": "string"
											},
											"recovery": {
												"description": "FailureRecovery --",
												"properties": {
													"attempt": {
														"type": "integer"
													},
													"attemptMax": {
														"type": "integer"
													},
													"attemptTime": {
														"format": "date-time",
														"type": "string"
													}
												},
												"required": [
													"attempt",
													"attemptMax"
												],
												"type": "object"
											},
											"time": {
												"format": "date-time",
												"type": "string"
											}
										},
										"required": [
											"reason",
											"recovery",
											"time"
										],
										"type": "object"
									},
									"image": {
										"type": "string"
									},
									"phase": {
										"description": "BuildPhase --",
										"type": "string"
									},
									"platform": {
										"type": "string"
									},
									"startedAt": {
										"format": "date-time",
										"type": "string"
									}
								},
								"type": "object"
							}
						},
						"type": "object"
					}
				},
				"version": "v1",
				"versions": [
					{
						"name": "v1",
						"served": true,
						"storage": true
					}
				]
			}
		}, opts)
	}
}