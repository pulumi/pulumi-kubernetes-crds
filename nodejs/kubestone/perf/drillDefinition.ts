import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class DrillDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"creationTimestamp": null,
				"name": "drills.perf.kubestone.xridge.io"
			},
			"spec": {
				"additionalPrinterColumns": [
					{
						"JSONPath": ".status.running",
						"name": "Running",
						"type": "boolean"
					},
					{
						"JSONPath": ".status.completed",
						"name": "Completed",
						"type": "boolean"
					}
				],
				"group": "perf.kubestone.xridge.io",
				"names": {
					"kind": "Drill",
					"plural": "drills"
				},
				"scope": "",
				"subresources": {
					"status": {}
				},
				"validation": {
					"openAPIV3Schema": {
						"description": "Drill is the Schema for the drills API",
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
								"description": "DrillSpec defines benchmark run for drill load tester The benchmarkFile, and options is passed to drill as follows: drill [OPTIONS] --benchmark \u003cbenchmarkFile\u003e",
								"properties": {
									"benchmarkFile": {
										"description": "BenchmarkFile is the entry point file (passed to --benchmark) specified to drill.",
										"type": "string"
									},
									"benchmarksVolume": {
										"additionalProperties": {
											"type": "string"
										},
										"description": "BenchmarksVolume holds the content of benchmark files. The key of the map specifies the filename and the value is the content of the file. ConfigMap is created from the map which is mounted as benchmarks directory to the benchmark pod.",
										"type": "object"
									},
									"image": {
										"description": "Image defines the drill docker image used for the benchmark",
										"properties": {
											"name": {
												"description": "Name is the Docker Image location including the tag",
												"type": "string"
											},
											"pullPolicy": {
												"description": "PullPolicy controls how the docker images are downloaded Defaults to Always if :latest tag is specified, or IfNotPresent otherwise.",
												"enum": [
													"Always",
													"Never",
													"IfNotPresent"
												],
												"type": "string"
											},
											"pullSecret": {
												"description": "PullSecret is an optional list of references to secrets in the same namespace to use for pulling any of the images",
												"type": "string"
											}
										},
										"required": [
											"name"
										],
										"type": "object"
									},
									"options": {
										"description": "Options are appended to the options parameter set of drill",
										"type": "string"
									},
									"podConfig": {
										"description": "PodConfig contains the configuration for the benchmark pod, including pod labels and scheduling policies (affinity, toleration, node selector...)",
										"properties": {
											"podLabels": {
												"additionalProperties": {
													"type": "string"
												},
												"description": "PodLabels are added to the pod as labels.",
												"type": "object"
											},
											"podScheduling": {
												"description": "PodScheduling contains options to determine which node the pod should be scheduled on",
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
													"nodeName": {
														"description": "NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.",
														"type": "string"
													},
													"nodeSelector": {
														"additionalProperties": {
															"type": "string"
														},
														"description": "A node selector represents the union of the results of one or more label queries over a set of nodes; that is, it represents the OR of the selectors represented by the node selector terms.",
														"type": "object"
													},
													"tolerations": {
														"description": "If specified, the pod's tolerations.",
														"items": {
															"description": "The pod this Toleration is attached to tolerates any taint that matches the triple \u003ckey,value,effect\u003e using the matching operator \u003coperator\u003e.",
															"properties": {
																"effect": {
																	"description": "Effect indicates the taint effect to match. Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.",
																	"type": "string"
																},
																"key": {
																	"description": "Key is the taint key that the toleration applies to. Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.",
																	"type": "string"
																},
																"operator": {
																	"description": "Operator represents a key's relationship to the value. Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.",
																	"type": "string"
																},
																"tolerationSeconds": {
																	"description": "TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint. By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.",
																	"format": "int64",
																	"type": "integer"
																},
																"value": {
																	"description": "Value is the taint value the toleration matches to. If the operator is Exists, the value should be empty, otherwise just a regular string.",
																	"type": "string"
																}
															},
															"type": "object"
														},
														"type": "array"
													}
												},
												"type": "object"
											},
											"resources": {
												"description": "Resources required by the benchmark pod container More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/",
												"properties": {
													"limits": {
														"additionalProperties": {
															"type": "string"
														},
														"description": "Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/",
														"type": "object"
													},
													"requests": {
														"additionalProperties": {
															"type": "string"
														},
														"description": "Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/",
														"type": "object"
													}
												},
												"type": "object"
											}
										},
										"type": "object"
									}
								},
								"required": [
									"benchmarkFile",
									"benchmarksVolume",
									"image"
								],
								"type": "object"
							},
							"status": {
								"description": "BenchmarkStatus describes the current state of the benchmark",
								"properties": {
									"completed": {
										"description": "Completed shows the state of completion",
										"type": "boolean"
									},
									"running": {
										"description": "Running shows the state of execution",
										"type": "boolean"
									}
								},
								"required": [
									"completed",
									"running"
								],
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
			},
			"status": {
				"acceptedNames": {
					"kind": "",
					"plural": ""
				},
				"conditions": [],
				"storedVersions": []
			}
		}, opts)
	}
}
