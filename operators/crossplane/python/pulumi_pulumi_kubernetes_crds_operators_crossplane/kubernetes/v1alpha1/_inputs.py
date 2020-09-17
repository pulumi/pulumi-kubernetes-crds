# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ProviderSpecArgs',
    'ProviderSpecCredentialsSecretRefArgs',
]

@pulumi.input_type
class ProviderSpecArgs:
    def __init__(__self__, *,
                 credentials_secret_ref: pulumi.Input['ProviderSpecCredentialsSecretRefArgs']):
        """
        A ProviderSpec defines the desired state of a Provider.
        :param pulumi.Input['ProviderSpecCredentialsSecretRefArgs'] credentials_secret_ref: A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
        """
        pulumi.set(__self__, "credentials_secret_ref", credentials_secret_ref)

    @property
    @pulumi.getter(name="credentialsSecretRef")
    def credentials_secret_ref(self) -> pulumi.Input['ProviderSpecCredentialsSecretRefArgs']:
        """
        A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
        """
        return pulumi.get(self, "credentials_secret_ref")

    @credentials_secret_ref.setter
    def credentials_secret_ref(self, value: pulumi.Input['ProviderSpecCredentialsSecretRefArgs']):
        pulumi.set(self, "credentials_secret_ref", value)


@pulumi.input_type
class ProviderSpecCredentialsSecretRefArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 namespace: pulumi.Input[str]):
        """
        A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
        :param pulumi.Input[str] name: Name of the secret.
        :param pulumi.Input[str] namespace: Namespace of the secret.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "namespace", namespace)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        Name of the secret.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def namespace(self) -> pulumi.Input[str]:
        """
        Namespace of the secret.
        """
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: pulumi.Input[str]):
        pulumi.set(self, "namespace", value)

