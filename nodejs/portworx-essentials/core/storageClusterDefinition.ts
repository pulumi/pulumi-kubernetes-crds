import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class StorageClusterDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"name": "storageclusters.core.libopenstorage.org"
			},
			"spec": {
				"additionalPrinterColumns": [
					{
						"JSONPath": ".status.clusterUid",
						"description": "The unique ID of the storage cluster",
						"name": "Cluster UUID",
						"type": "string"
					},
					{
						"JSONPath": ".status.phase",
						"description": "The status of the storage cluster",
						"name": "Status",
						"type": "string"
					},
					{
						"JSONPath": ".spec.version",
						"description": "The version of the storage cluster",
						"name": "Version",
						"type": "string"
					},
					{
						"JSONPath": ".metadata.creationTimestamp",
						"description": "The age of the storage cluster",
						"name": "Age",
						"type": "date"
					}
				],
				"group": "core.libopenstorage.org",
				"names": {
					"kind": "StorageCluster",
					"listKind": "StorageClusterList",
					"plural": "storageclusters",
					"shortNames": [
						"stc"
					],
					"singular": "storagecluster"
				},
				"scope": "Namespaced",
				"subresources": {
					"status": {}
				},
				"validation": {
					"openAPIV3Schema": {
						"properties": {
							"spec": {
								"description": "The desired behavior of the storage cluster.",
								"properties": {
									"autopilot": {
										"description": "Contains spec of autopilot component for storage driver.",
										"properties": {
											"args": {
												"description": "It is a map of arguments provided to autopilot. Example: log-level: debug",
												"type": "object"
											},
											"enabled": {
												"description": "Flag indicating whether autopilot needs to be enabled.",
												"type": "boolean"
											},
											"env": {
												"description": "List of environment variables used by autopilot. This is an array of Kubernetes EnvVar where the value can be given directly or from a source like field, config map or secret.",
												"items": {
													"properties": {
														"name": {
															"type": "string"
														},
														"value": {
															"type": "string"
														},
														"valueFrom": {
															"properties": {
																"configMapKeyRef": {
																	"properties": {
																		"key": {
																			"type": "string"
																		},
																		"name": {
																			"type": "string"
																		},
																		"optional": {
																			"type": "boolean"
																		}
																	},
																	"type": "object"
																},
																"fieldRef": {
																	"properties": {
																		"apiVersion": {
																			"type": "string"
																		},
																		"fieldPath": {
																			"type": "string"
																		}
																	},
																	"type": "object"
																},
																"resourceFieldRef": {
																	"properties": {
																		"containerName": {
																			"type": "string"
																		},
																		"divisor": {
																			"type": "string"
																		},
																		"resource": {
																			"type": "string"
																		}
																	},
																	"type": "object"
																},
																"secretKeyRef": {
																	"properties": {
																		"key": {
																			"type": "string"
																		},
																		"name": {
																			"type": "string"
																		},
																		"optional": {
																			"type": "boolean"
																		}
																	},
																	"type": "object"
																}
															},
															"type": "object"
														}
													},
													"type": "object"
												},
												"type": "array"
											},
											"image": {
												"description": "Docker image of the autopilot container.",
												"type": "string"
											},
											"lockImage": {
												"description": "Flag indicating if the autopilot image needs to be locked to the given image. If the image is not locked, it can be updated by the storage driver during upgrades.",
												"type": "boolean"
											},
											"providers": {
												"description": "List of input data providers to autopilot.",
												"items": {
													"properties": {
														"name": {
															"description": "Unique name of the data provider.",
															"type": "string"
														},
														"params": {
															"description": "Map of key-value params for the provider.",
															"type": "object"
														},
														"type": {
															"description": "Type of the data provider. For instance - prometheus",
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
									"cloudStorage": {
										"description": "Details of storage used in cloud environment.",
										"properties": {
											"capacitySpecs": {
												"description": "List of cluster wide storage types and their capacities. A single capacity spec identifies a storage pool with a set of minimum requested IOPS and size. Based on the cloud provider, the total storage capacity will get divided amongst the nodes. The nodes bearing storage themselves will get uniformly distributed across all the zones.",
												"items": {
													"properties": {
														"maxCapacityInGiB": {
															"description": "Maximum capacity for this storage cluster. The total capacity of devices created by this capacity spec should not be greater than this number for the entire cluster.",
															"format": "int64",
															"minimum": 0,
															"type": "integer"
														},
														"minCapacityInGiB": {
															"description": "Minimum capacity for this storage cluster. The total capacity of devices created by this capacity spec should not be less than this number for the entire cluster.",
															"format": "int64",
															"minimum": 0,
															"type": "integer"
														},
														"minIOPS": {
															"description": "Minimum IOPS expected from the cloud drive.",
															"format": "int32",
															"minimum": 0,
															"type": "integer"
														},
														"options": {
															"description": "Additional options required to provision the drive in cloud.",
															"type": "object"
														}
													},
													"type": "object"
												},
												"type": "array"
											},
											"deviceSpecs": {
												"description": "List of storage device specs. A cloud storage device will be created for every spec in the list. The specs will be applied to all nodes in the cluster up to spec.cloudStorage.maxStorageNodes or spec.cloudStorage.maxStorageNodesPerZone. This will be ignored if spec.cloudStorage.capacitySpecs is present.",
												"items": {
													"type": "string"
												},
												"type": "array"
											},
											"journalDeviceSpec": {
												"description": "Device spec for the journal device.",
												"type": "string"
											},
											"kvdbDeviceSpec": {
												"description": "Device spec for internal KVDB device.",
												"type": "string"
											},
											"maxStorageNodes": {
												"description": "Maximum nodes that will have storage in the cluster.",
												"format": "int32",
												"minimum": 0,
												"type": "integer"
											},
											"maxStorageNodesPerZone": {
												"description": "Maximum nodes in every zone that will have storage in the cluster.",
												"format": "int32",
												"minimum": 0,
												"type": "integer"
											},
											"systemMetadataDeviceSpec": {
												"description": "Device spec for the metadata device. This device will be used to store system metadata by the driver.",
												"type": "string"
											}
										},
										"type": "object"
									},
									"customImageRegistry": {
										"description": "Custom container image registry server that will be used instead of index.docker.io to download Docker images. This may include the repository as well. (Example: myregistry.net:5443 or myregistry.com/myrepository)",
										"type": "string"
									},
									"deleteStrategy": {
										"description": "Delete strategy to uninstall and wipe the storage cluster.",
										"properties": {
											"type": {
												"description": "Type of storage cluster delete. Can be Uninstall or UninstallAndWipe. There is no default delete strategy. When no delete strategy only objects managed by the StorageCluster controller and owned by the StorageCluster object are deleted. The storage driver will be left in a state where it will not be managed by any object. Uninstall strategy ensures that the cluster is completely uninstalled even from the storage driver perspective. UninstallAndWipe strategy ensures that the cluster is completely uninstalled as well as the storage devices and metadata are wiped for reuse. This may result in data loss.",
												"enum": [
													"Uninstall",
													"UninstallAndWipe"
												],
												"type": "string"
											}
										},
										"type": "object"
									},
									"env": {
										"description": "List of environment variables used by the driver. This is an array of Kubernetes EnvVar where the value can be given directly or from a source like field, config map or secret.",
										"items": {
											"properties": {
												"name": {
													"type": "string"
												},
												"value": {
													"type": "string"
												},
												"valueFrom": {
													"properties": {
														"configMapKeyRef": {
															"properties": {
																"key": {
																	"type": "string"
																},
																"name": {
																	"type": "string"
																},
																"optional": {
																	"type": "boolean"
																}
															},
															"type": "object"
														},
														"fieldRef": {
															"properties": {
																"apiVersion": {
																	"type": "string"
																},
																"fieldPath": {
																	"type": "string"
																}
															},
															"type": "object"
														},
														"resourceFieldRef": {
															"properties": {
																"containerName": {
																	"type": "string"
																},
																"divisor": {
																	"type": "string"
																},
																"resource": {
																	"type": "string"
																}
															},
															"type": "object"
														},
														"secretKeyRef": {
															"properties": {
																"key": {
																	"type": "string"
																},
																"name": {
																	"type": "string"
																},
																"optional": {
																	"type": "boolean"
																}
															},
															"type": "object"
														}
													},
													"type": "object"
												}
											},
											"type": "object"
										},
										"type": "array"
									},
									"featureGates": {
										"description": "This is a map of feature names to string values.",
										"type": "object"
									},
									"image": {
										"description": "Docker image of the storage driver.",
										"type": "string"
									},
									"imagePullPolicy": {
										"description": "Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always.",
										"type": "string"
									},
									"imagePullSecret": {
										"description": "Image pull secret is a reference to secret in the same namespace as the StorageCluster. It is used for pulling all images used by the StorageCluster.",
										"type": "string"
									},
									"kvdb": {
										"description": "Details of KVDB that the storage driver will use.",
										"properties": {
											"authSecret": {
												"description": "Authentication secret is the name of Kubernetes secret containing information to authenticate with the external KVDB. It could have the username/password for basic auth, certificate information or an ACL token.",
												"type": "string"
											},
											"endpoints": {
												"description": "If using external KVDB, this is the list of KVDB endpoints.",
												"items": {
													"type": "string"
												},
												"type": "array"
											},
											"internal": {
												"description": "Flag indicating whether to use internal KVDB or an external KVDB.",
												"type": "boolean"
											}
										},
										"type": "object"
									},
									"monitoring": {
										"description": "Contains monitoring configuration for the storage cluster.",
										"properties": {
											"enableMetrics": {
												"description": "If this flag is enabled it will expose the storage cluster metrics to external monitoring solutions like Prometheus. DEPRECATED - use prometheus.exportMetrics instead",
												"type": "boolean"
											},
											"prometheus": {
												"description": "Contains configuration of Prometheus to monitor the storage cluster.",
												"properties": {
													"enabled": {
														"description": "Flag indicating whether Prometheus stack needs to be enabled and deployed by the Storage operator.",
														"type": "boolean"
													},
													"exportMetrics": {
														"description": "If this flag is enabled it will expose the storage cluster metrics to Prometheus.",
														"type": "boolean"
													},
													"remoteWriteEndpoint": {
														"description": "Specifies the remote write endpoint for Prometheus.",
														"type": "string"
													}
												},
												"type": "object"
											}
										},
										"type": "object"
									},
									"network": {
										"description": "Contains network information that is needed by the storage driver.",
										"properties": {
											"dataInterface": {
												"description": "Name of the network interface used by the storage driver for data traffic.",
												"type": "string"
											},
											"mgmtInterface": {
												"description": "Name of the network interface used by the storage driver for management traffic.",
												"type": "string"
											}
										},
										"type": "object"
									},
									"nodes": {
										"description": "Node level configurations that will override the configuration at cluster level. These configurations can be for individual nodes or can be grouped to override configuration of multiple nodes based on label selectors.",
										"items": {
											"properties": {
												"env": {
													"description": "List of environment variables used by the driver. This is an array of Kubernetes EnvVar where the value can be given directly or from a source like field, config map or secret. Environment variables specified here at the node level will be merged with the ones present in cluster configuration and sent to the nodes. If there is duplicate, the node level value will take precedence.",
													"items": {
														"properties": {
															"name": {
																"type": "string"
															},
															"value": {
																"type": "string"
															},
															"valueFrom": {
																"properties": {
																	"configMapKeyRef": {
																		"properties": {
																			"key": {
																				"type": "string"
																			},
																			"name": {
																				"type": "string"
																			},
																			"optional": {
																				"type": "boolean"
																			}
																		},
																		"type": "object"
																	},
																	"fieldRef": {
																		"properties": {
																			"apiVersion": {
																				"type": "string"
																			},
																			"fieldPath": {
																				"type": "string"
																			}
																		},
																		"type": "object"
																	},
																	"resourceFieldRef": {
																		"properties": {
																			"containerName": {
																				"type": "string"
																			},
																			"divisor": {
																				"type": "string"
																			},
																			"resource": {
																				"type": "string"
																			}
																		},
																		"type": "object"
																	},
																	"secretKeyRef": {
																		"properties": {
																			"key": {
																				"type": "string"
																			},
																			"name": {
																				"type": "string"
																			},
																			"optional": {
																				"type": "boolean"
																			}
																		},
																		"type": "object"
																	}
																},
																"type": "object"
															}
														},
														"type": "object"
													},
													"type": "array"
												},
												"network": {
													"description": "Contains network information that is needed by the storage driver.",
													"properties": {
														"dataInterface": {
															"description": "Name of the network interface used by the storage driver for data traffic.",
															"type": "string"
														},
														"mgmtInterface": {
															"description": "Name of the network interface used by the storage driver for management traffic.",
															"type": "string"
														}
													},
													"type": "object"
												},
												"runtimeOptions": {
													"description": "This is map of any runtime options that need to be sent to the storage driver. The value is a string. If runtime options are present here at node level, they will override the ones from cluster configuration.",
													"type": "object"
												},
												"selector": {
													"description": "Configuration in this node block is applied to nodes based on this selector. Use either nodeName of labelSelector, not both. If nodeName is used, labelSelector will be ignored.",
													"properties": {
														"labelSelector": {
															"description": "It is a label query over all the nodes. The result of matchLabels and matchExpressions is ANDed. An empty label selector matches all nodes. A null label selector matches no objects.",
															"properties": {
																"matchExpressions": {
																	"description": "It is a list of label selector requirements. The requirements are ANDed.",
																	"items": {
																		"properties": {
																			"key": {
																				"description": "It is the label key that the selector applies to.",
																				"type": "string"
																			},
																			"operator": {
																				"description": "It represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.",
																				"type": "string"
																			},
																			"values": {
																				"description": "It is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty.",
																				"items": {
																					"type": "string"
																				},
																				"type": "array"
																			}
																		},
																		"type": "object"
																	},
																	"type": "array"
																},
																"matchLabels": {
																	"description": "It is a map of key-value pairs. A single key-value in the matchLabels map is equivalent to an element of matchExpressions, whose key field is \"key\", the operator is \"In\", and the values array contains only \"value\". The requirements are ANDed.",
																	"type": "object"
																}
															},
															"type": "object"
														},
														"nodeName": {
															"description": "Name of the Kubernetes node that is to be selected. If present then the labelSelector is ignored even if the node with the given name is absent and the labelSelector matches another node.",
															"type": "string"
														}
													},
													"type": "object"
												},
												"storage": {
													"description": "Details of the storage used by the storage driver.",
													"properties": {
														"devices": {
															"description": "List of devices to be used by the storage driver.",
															"items": {
																"type": "string"
															},
															"type": "array"
														},
														"forceUseDisks": {
															"description": "Flag indicating to use the devices even if there is file system present on it. Note that the devices may be wiped before using.",
															"type": "boolean"
														},
														"journalDevice": {
															"description": "Device used for journaling.",
															"type": "string"
														},
														"kvdbDevice": {
															"description": "Device used for internal KVDB.",
															"type": "string"
														},
														"systemMetadataDevice": {
															"description": "Device that will be used to store system metadata by the driver.",
															"type": "string"
														},
														"useAll": {
															"description": "Use all available, unformatted, unpartitioned devices. This will be ignored if spec.storage.devices is not empty.",
															"type": "boolean"
														},
														"useAllWithPartitions": {
															"description": "Use all available unformatted devices. This will be ignored if spec.storage.devices is not empty.",
															"type": "boolean"
														}
													},
													"type": "object"
												}
											},
											"type": "object"
										},
										"type": "array"
									},
									"placement": {
										"description": "Describes placement configuration for the storage cluster pods.",
										"properties": {
											"nodeAffinity": {
												"description": "Describes node affinity scheduling rules for the storage cluster pods. This is exactly the same object as Kubernetes node affinity for pods.",
												"properties": {
													"preferredDuringSchedulingIgnoredDuringExecution": {
														"items": {
															"properties": {
																"preference": {
																	"properties": {
																		"matchExpressions": {
																			"items": {
																				"properties": {
																					"key": {
																						"type": "string"
																					},
																					"operator": {
																						"type": "string"
																					},
																					"values": {
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
																			"items": {
																				"properties": {
																					"key": {
																						"type": "string"
																					},
																					"operator": {
																						"type": "string"
																					},
																					"values": {
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
														"properties": {
															"nodeSelectorTerms": {
																"items": {
																	"properties": {
																		"matchExpressions": {
																			"items": {
																				"properties": {
																					"key": {
																						"type": "string"
																					},
																					"operator": {
																						"type": "string"
																					},
																					"values": {
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
																			"items": {
																				"properties": {
																					"key": {
																						"type": "string"
																					},
																					"operator": {
																						"type": "string"
																					},
																					"values": {
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
											"tolerations": {
												"description": "Tolerations for all the pods deployed by the StorageCluster controller. The pod with this toleration attached will tolerate any taint that matches the triple \u003ckey,value,effect\u003e using the matching operator \u003coperator\u003e.",
												"items": {
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
									"revisionHistoryLimit": {
										"description": "The number of old history to retain to allow rollback. This is a pointer to distinguish between an explicit zero and not specified. Defaults to 10.",
										"format": "int32",
										"type": "integer"
									},
									"runtimeOptions": {
										"description": "This is map of any runtime options that need to be sent to the storage driver. The value is a string.",
										"type": "object"
									},
									"secretsProvider": {
										"description": "Secrets provider is the name of secret provider that driver will connect to.",
										"type": "string"
									},
									"startPort": {
										"description": "Start port is the starting port in the range of ports used by the cluster.",
										"format": "int32",
										"minimum": 0,
										"type": "integer"
									},
									"storage": {
										"description": "Details of the storage used by the storage driver.",
										"properties": {
											"devices": {
												"description": "List of devices to be used by the storage driver.",
												"items": {
													"type": "string"
												},
												"type": "array"
											},
											"forceUseDisks": {
												"description": "Flag indicating to use the devices even if there is file system present on it. Note that the devices may be wiped before using.",
												"type": "boolean"
											},
											"journalDevice": {
												"description": "Device used for journaling.",
												"type": "string"
											},
											"kvdbDevice": {
												"description": "Device used for internal KVDB.",
												"type": "string"
											},
											"systemMetadataDevice": {
												"description": "Device that will be used to store system metadata by the driver.",
												"type": "string"
											},
											"useAll": {
												"description": "Use all available, unformatted, unpartitioned devices. This will be ignored if spec.storage.devices is not empty.",
												"type": "boolean"
											},
											"useAllWithPartitions": {
												"description": "Use all available unformatted devices. This will be ignored if spec.storage.devices is not empty.",
												"type": "boolean"
											}
										},
										"type": "object"
									},
									"stork": {
										"description": "Contains STORK related spec.",
										"properties": {
											"args": {
												"description": "It is map of arguments given to STORK. Example: driver: pxd",
												"type": "object"
											},
											"enabled": {
												"description": "Flag indicating whether STORK needs to be enabled.",
												"type": "boolean"
											},
											"env": {
												"description": "List of environment variables used by STORK. This is an array of Kubernetes EnvVar where the value can be given directly or from a source like field, config map or secret.",
												"items": {
													"properties": {
														"name": {
															"type": "string"
														},
														"value": {
															"type": "string"
														},
														"valueFrom": {
															"properties": {
																"configMapKeyRef": {
																	"properties": {
																		"key": {
																			"type": "string"
																		},
																		"name": {
																			"type": "string"
																		},
																		"optional": {
																			"type": "boolean"
																		}
																	},
																	"type": "object"
																},
																"fieldRef": {
																	"properties": {
																		"apiVersion": {
																			"type": "string"
																		},
																		"fieldPath": {
																			"type": "string"
																		}
																	},
																	"type": "object"
																},
																"resourceFieldRef": {
																	"properties": {
																		"containerName": {
																			"type": "string"
																		},
																		"divisor": {
																			"type": "string"
																		},
																		"resource": {
																			"type": "string"
																		}
																	},
																	"type": "object"
																},
																"secretKeyRef": {
																	"properties": {
																		"key": {
																			"type": "string"
																		},
																		"name": {
																			"type": "string"
																		},
																		"optional": {
																			"type": "boolean"
																		}
																	},
																	"type": "object"
																}
															},
															"type": "object"
														}
													},
													"type": "object"
												},
												"type": "array"
											},
											"image": {
												"description": "Docker image of the STORK container.",
												"type": "string"
											},
											"lockImage": {
												"description": "Flag indicating if the STORK image needs to be locked to the given image. If the image is not locked, it can be updated by the storage driver during upgrades.",
												"type": "boolean"
											}
										},
										"type": "object"
									},
									"updateStrategy": {
										"description": "An update strategy to replace existing StorageCluster pods with new pods.",
										"properties": {
											"rollingUpdate": {
												"description": "Spec to control the desired behavior of storage cluster rolling update.",
												"properties": {
													"maxUnavailable": {
														"description": "The maximum number of StorageCluster pods that can be unavailable during the update. Value can be an absolute number (ex: 5) or a percentage of total number of StorageCluster pods at the start of the update (ex: 10%). Absolute number is calculated from percentage by rounding up. This cannot be 0. Default value is 1. Example: when this is set to 30%, at most 30% of the total number of nodes that should be running the storage pod can have their pods stopped for an update at any given time. The update starts by stopping at most 30% of those StorageCluster pods and then brings up new StorageCluster pods in their place. Once the new pods are available, it then proceeds onto other StorageCluster pods, thus ensuring that at least 70% of original number of StorageCluster pods are available at all times during the update.",
														"oneOf": [
															{
																"type": "integer"
															},
															{
																"type": "string"
															}
														]
													}
												},
												"type": "object"
											},
											"type": {
												"description": "Type of storage cluster update. Can be RollingUpdate or OnDelete. Default is RollingUpdate.",
												"enum": [
													"RollingUpdate",
													"OnDelete"
												],
												"type": "string"
											}
										},
										"type": "object"
									},
									"userInterface": {
										"description": "Contains spec of a user interface for the storage driver.",
										"properties": {
											"enabled": {
												"description": "Flag indicating whether the user interface needs to be enabled.",
												"type": "boolean"
											},
											"env": {
												"description": "List of environment variables used by the UI components. This is an array of Kubernetes EnvVar where the value can be given directly or from a source like field, config map or secret.",
												"items": {
													"properties": {
														"name": {
															"type": "string"
														},
														"value": {
															"type": "string"
														},
														"valueFrom": {
															"properties": {
																"configMapKeyRef": {
																	"properties": {
																		"key": {
																			"type": "string"
																		},
																		"name": {
																			"type": "string"
																		},
																		"optional": {
																			"type": "boolean"
																		}
																	},
																	"type": "object"
																},
																"fieldRef": {
																	"properties": {
																		"apiVersion": {
																			"type": "string"
																		},
																		"fieldPath": {
																			"type": "string"
																		}
																	},
																	"type": "object"
																},
																"resourceFieldRef": {
																	"properties": {
																		"containerName": {
																			"type": "string"
																		},
																		"divisor": {
																			"type": "string"
																		},
																		"resource": {
																			"type": "string"
																		}
																	},
																	"type": "object"
																},
																"secretKeyRef": {
																	"properties": {
																		"key": {
																			"type": "string"
																		},
																		"name": {
																			"type": "string"
																		},
																		"optional": {
																			"type": "boolean"
																		}
																	},
																	"type": "object"
																}
															},
															"type": "object"
														}
													},
													"type": "object"
												},
												"type": "array"
											},
											"image": {
												"description": "Docker image of the user interface container.",
												"type": "string"
											},
											"lockImage": {
												"description": "Flag indicating if the user interface image needs to be locked to the given image. If the image is not locked, it can be updated by the storage driver during upgrades.",
												"type": "boolean"
											}
										},
										"type": "object"
									},
									"version": {
										"description": "Version of the storage driver. This field is read-only.",
										"type": "string"
									}
								},
								"type": "object"
							},
							"status": {
								"description": "Most recently observed status of the storage cluster. This data may not be up to date.",
								"properties": {
									"clusterName": {
										"description": "Name of the storage cluster.",
										"type": "string"
									},
									"clusterUid": {
										"description": "Unique ID of the storage cluster.",
										"type": "string"
									},
									"collisionCount": {
										"description": "Count of hash collisions for the StorageCluster. The StorageCluster controller uses this field as a collision avoidance mechanism when it needs to create the name of the newest ControllerRevision.",
										"format": "int32",
										"type": "integer"
									},
									"conditions": {
										"description": "Contains details for the current condition of this cluster.",
										"items": {
											"properties": {
												"reason": {
													"description": "Reason is human readable message indicating details about the current state of the cluster.",
													"type": "string"
												},
												"status": {
													"description": "Status of the condition.",
													"type": "string"
												},
												"type": {
													"description": "Type of the condition.",
													"type": "string"
												}
											},
											"type": "object"
										},
										"type": "array"
									},
									"phase": {
										"description": "Phase of the StorageCluster is a simple, high-level summary of where the StorageCluster is in its lifecycle. The condition array contains more detailed information about the state of the cluster.",
										"type": "string"
									},
									"storage": {
										"description": "Contains details of storage in the cluster.",
										"properties": {
											"storageNodesPerZone": {
												"description": "The number of storage nodes per zone in the cluster.",
												"format": "int32",
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
