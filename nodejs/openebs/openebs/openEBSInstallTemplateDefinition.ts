import * as pulumi from "@pulumi/pulumi";
import * as k8s from "@pulumi/kubernetes";

export class OpenEBSInstallTemplateDefinition extends k8s.apiextensions.v1beta1.CustomResourceDefinition {
	constructor(name: string, opts?: pulumi.CustomResourceOptions) {
		super(name, {
			"apiVersion": "apiextensions.k8s.io/v1beta1",
			"kind": "CustomResourceDefinition",
			"metadata": {
				"name": "openebsinstalltemplates.openebs.io"
			},
			"spec": {
				"group": "openebs.io",
				"names": {
					"kind": "OpenEBSInstallTemplate",
					"listKind": "OpenEBSInstallTemplateList",
					"plural": "openebsinstalltemplates",
					"singular": "openebsinstalltemplate"
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
