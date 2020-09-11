import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class ServiceDiscoveryDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"name": "servicediscoveries.submariner.io"
			},
			"spec": {
				"group": "submariner.io",
				"names": {
					"kind": "ServiceDiscovery",
					"listKind": "ServiceDiscoveryList",
					"plural": "servicediscoveries",
					"singular": "servicediscovery"
				},
				"scope": "Namespaced",
				"subresources": {
					"status": {}
				},
				"validation": {
					"openAPIV3Schema": {
						"description": "ServiceDiscovery is the Schema for the servicediscoveries API",
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
								"description": "ServiceDiscoverySpec defines the desired state of ServiceDiscovery",
								"properties": {
									"brokerK8sApiServer": {
										"type": "string"
									},
									"brokerK8sApiServerToken": {
										"type": "string"
									},
									"brokerK8sCA": {
										"type": "string"
									},
									"brokerK8sRemoteNamespace": {
										"type": "string"
									},
									"clusterID": {
										"type": "string"
									},
									"debug": {
										"type": "boolean"
									},
									"globalnetEnabled": {
										"type": "boolean"
									},
									"namespace": {
										"type": "string"
									},
									"repository": {
										"type": "string"
									},
									"version": {
										"type": "string"
									}
								},
								"required": [
									"brokerK8sApiServer",
									"brokerK8sApiServerToken",
									"brokerK8sCA",
									"brokerK8sRemoteNamespace",
									"clusterID",
									"debug",
									"namespace"
								],
								"type": "object"
							},
							"status": {
								"description": "ServiceDiscoveryStatus defines the observed state of ServiceDiscovery",
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
