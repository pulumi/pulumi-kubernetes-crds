import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class AlamedaServiceDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"name": "alamedaservices.federatorai.containers.ai"
			},
			"spec": {
				"additionalPrinterColumns": [
					{
						"JSONPath": ".spec.enableExecution",
						"description": "The enable of execution",
						"name": "Execution",
						"type": "boolean"
					},
					{
						"JSONPath": ".spec.version",
						"description": "The type of alameda service",
						"name": "Version",
						"type": "string"
					},
					{
						"JSONPath": ".metadata.creationTimestamp",
						"description": "The time of creation",
						"name": "Age",
						"type": "date"
					}
				],
				"group": "federatorai.containers.ai",
				"names": {
					"kind": "AlamedaService",
					"listKind": "AlamedaServiceList",
					"plural": "alamedaservices",
					"singular": "alamedaservice"
				},
				"scope": "Namespaced",
				"validation": {
					"openAPIV3Schema": {
						"properties": {
							"apiVersion": {
								"type": "string"
							},
							"kind": {
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
