# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs

__all__ = [
    'ProviderSpec',
    'ProviderSpecCredentialsSecretRef',
]

@pulumi.output_type
class ProviderSpec(dict):
    """
    A ProviderSpec defines the desired state of a Provider.
    """
    def __init__(__self__, *,
                 credentials_secret_ref: 'outputs.ProviderSpecCredentialsSecretRef'):
        """
        A ProviderSpec defines the desired state of a Provider.
        :param 'ProviderSpecCredentialsSecretRefArgs' credentials_secret_ref: A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
        """
        pulumi.set(__self__, "credentials_secret_ref", credentials_secret_ref)

    @property
    @pulumi.getter(name="credentialsSecretRef")
    def credentials_secret_ref(self) -> 'outputs.ProviderSpecCredentialsSecretRef':
        """
        A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
        """
        return pulumi.get(self, "credentials_secret_ref")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ProviderSpecCredentialsSecretRef(dict):
    """
    A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
    """
    def __init__(__self__, *,
                 name: str,
                 namespace: str):
        """
        A Secret containing connection credentials for a Kubernetes cluster client that will be used to authenticate to this Kubernetes Provider. This will typically be the connection secret of a KubernetesCluster claim, or the secret created by a Kubernetes service account, but could also be manually configured to connect to a preexisting cluster.
        :param str name: Name of the secret.
        :param str namespace: Namespace of the secret.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "namespace", namespace)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the secret.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def namespace(self) -> str:
        """
        Namespace of the secret.
        """
        return pulumi.get(self, "namespace")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


