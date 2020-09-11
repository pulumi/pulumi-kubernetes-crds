import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class KialiDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"labels": {
					"app": "kiali-operator"
				},
				"name": "kialis.kiali.io"
			},
			"spec": {
				"group": "kiali.io",
				"names": {
					"kind": "Kiali",
					"listKind": "KialiList",
					"plural": "kialis",
					"singular": "kiali"
				},
				"scope": "Namespaced",
				"subresources": {
					"status": {}
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
