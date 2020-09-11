import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class KlusterletDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"creationTimestamp": null,
				"name": "klusterlets.operator.open-cluster-management.io"
			},
			"spec": {
				"group": "operator.open-cluster-management.io",
				"names": {
					"kind": "Klusterlet",
					"listKind": "KlusterletList",
					"plural": "klusterlets",
					"singular": "klusterlet"
				},
				"preserveUnknownFields": false,
				"scope": "Cluster",
				"subresources": {
					"status": {}
				},
				"validation": {
					"openAPIV3Schema": {
						"description": "Klusterlet represents controllers on the managed cluster. When configured, the Klusterlet requires a secret named of bootstrap-hub-kubeconfig in the same namespace to allow API requests to the hub for the registration protocol.",
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
								"description": "Spec represents the desired deployment configuration of Klusterlet agent.",
								"properties": {
									"clusterName": {
										"description": "ClusterName is the name of the managed cluster to be created on hub. The Klusterlet agent generates a random name if it is not set, or discovers the appropriate cluster name on openshift.",
										"type": "string"
									},
									"externalServerURLs": {
										"description": "ExternalServerURLs represents the a list of apiserver urls and ca bundles that is accessible externally If it is set empty, managed cluster has no externally accessible url that hub cluster can visit.",
										"items": {
											"description": "ServerURL represents the apiserver url and ca bundle that is accessible externally",
											"properties": {
												"caBundle": {
													"description": "CABundle is the ca bundle to connect to apiserver of the managed cluster. System certs are used if it is not set.",
													"format": "byte",
													"type": "string"
												},
												"url": {
													"description": "URL is the url of apiserver endpoint of the managed cluster.",
													"type": "string"
												}
											},
											"type": "object"
										},
										"type": "array"
									},
									"namespace": {
										"description": "Namespace is the namespace to deploy the agent. The namespace must have a prefix of \"open-cluster-management-\", and if it is not set, the namespace of \"open-cluster-management-agent\" is used to deploy agent.",
										"type": "string"
									},
									"registrationImagePullSpec": {
										"description": "RegistrationImagePullSpec represents the desired image configuration of registration agent.",
										"type": "string"
									},
									"workImagePullSpec": {
										"description": "WorkImagePullSpec represents the desired image configuration of work agent.",
										"type": "string"
									}
								},
								"type": "object"
							},
							"status": {
								"description": "Status represents the current status of Klusterlet agent.",
								"properties": {
									"conditions": {
										"description": "Conditions contain the different condition statuses for this Klusterlet. Valid condition types are: Applied: components have been applied in the managed cluster. Available: components in the managed cluster are available and ready to serve. Progressing: components in the managed cluster are in a transitioning state. Degraded: components in the managed cluster do not match the desired configuration and only provide degraded service.",
										"items": {
											"description": "StatusCondition contains condition information.",
											"properties": {
												"lastTransitionTime": {
													"description": "LastTransitionTime is the last time the condition changed from one status to another.",
													"format": "date-time",
													"type": "string"
												},
												"message": {
													"description": "Message is a human-readable message indicating details about the last status change.",
													"type": "string"
												},
												"reason": {
													"description": "Reason is a (brief) reason for the condition's last status change.",
													"type": "string"
												},
												"status": {
													"description": "Status is the status of the condition. One of True, False, Unknown.",
													"type": "string"
												},
												"type": {
													"description": "Type is the type of the cluster condition.",
													"type": "string"
												}
											},
											"type": "object"
										},
										"type": "array"
									},
									"generations": {
										"description": "Generations are used to determine when an item needs to be reconciled or has changed in a way that needs a reaction.",
										"items": {
											"description": "GenerationStatus keeps track of the generation for a given resource so that decisions about forced updates can be made. the definition matches the GenerationStatus defined in github.com/openshift/api/v1",
											"properties": {
												"group": {
													"description": "group is the group of the thing you're tracking",
													"type": "string"
												},
												"lastGeneration": {
													"description": "lastGeneration is the last generation of the thing that controller applies",
													"format": "int64",
													"type": "integer"
												},
												"name": {
													"description": "name is the name of the thing you're tracking",
													"type": "string"
												},
												"namespace": {
													"description": "namespace is where the thing you're tracking is",
													"type": "string"
												},
												"resource": {
													"description": "resource is the resource type of the thing you're tracking",
													"type": "string"
												},
												"version": {
													"description": "version is the version of the thing you're tracking",
													"type": "string"
												}
											},
											"type": "object"
										},
										"type": "array"
									},
									"observedGeneration": {
										"description": "ObservedGeneration is the last generation change you've dealt with",
										"format": "int64",
										"type": "integer"
									},
									"relatedResources": {
										"description": "RelatedResources are used to track the resources that are related to this Klusterlet",
										"items": {
											"description": "RelatedResourceMeta represents the resource that is managed by an operator",
											"properties": {
												"group": {
													"description": "group is the group of the thing you're tracking",
													"type": "string"
												},
												"name": {
													"description": "name is the name of the thing you're tracking",
													"type": "string"
												},
												"namespace": {
													"description": "namespace is where the thing you're tracking is",
													"type": "string"
												},
												"resource": {
													"description": "resource is the resource type of the thing you're tracking",
													"type": "string"
												},
												"version": {
													"description": "version is the version of the thing you're tracking",
													"type": "string"
												}
											},
											"type": "object"
										},
										"type": "array"
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
