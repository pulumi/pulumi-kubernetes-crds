# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'APIcastSpecArgs',
    'APIcastStatusArgs',
    'APIcastStatusConditionsArgs',
]

@pulumi.input_type
class APIcastSpecArgs:
    def __init__(__self__, *,
                 admin_portal_credentials_ref: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 embedded_configuration_secret_ref: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        if admin_portal_credentials_ref is not None:
            pulumi.set(__self__, "admin_portal_credentials_ref", admin_portal_credentials_ref)
        if embedded_configuration_secret_ref is not None:
            pulumi.set(__self__, "embedded_configuration_secret_ref", embedded_configuration_secret_ref)

    @property
    @pulumi.getter(name="adminPortalCredentialsRef")
    def admin_portal_credentials_ref(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        return pulumi.get(self, "admin_portal_credentials_ref")

    @admin_portal_credentials_ref.setter
    def admin_portal_credentials_ref(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "admin_portal_credentials_ref", value)

    @property
    @pulumi.getter(name="embeddedConfigurationSecretRef")
    def embedded_configuration_secret_ref(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        return pulumi.get(self, "embedded_configuration_secret_ref")

    @embedded_configuration_secret_ref.setter
    def embedded_configuration_secret_ref(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "embedded_configuration_secret_ref", value)


@pulumi.input_type
class APIcastStatusArgs:
    def __init__(__self__, *,
                 conditions: Optional[pulumi.Input[Sequence[pulumi.Input['APIcastStatusConditionsArgs']]]] = None,
                 image: Optional[pulumi.Input[str]] = None):
        """
        APIcastStatus defines the observed state of APIcast
        :param pulumi.Input[Sequence[pulumi.Input['APIcastStatusConditionsArgs']]] conditions: Represents the latest available observations of a replica set's current state.
        :param pulumi.Input[str] image: The image being used in the APIcast deployment
        """
        if conditions is not None:
            pulumi.set(__self__, "conditions", conditions)
        if image is not None:
            pulumi.set(__self__, "image", image)

    @property
    @pulumi.getter
    def conditions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['APIcastStatusConditionsArgs']]]]:
        """
        Represents the latest available observations of a replica set's current state.
        """
        return pulumi.get(self, "conditions")

    @conditions.setter
    def conditions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['APIcastStatusConditionsArgs']]]]):
        pulumi.set(self, "conditions", value)

    @property
    @pulumi.getter
    def image(self) -> Optional[pulumi.Input[str]]:
        """
        The image being used in the APIcast deployment
        """
        return pulumi.get(self, "image")

    @image.setter
    def image(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "image", value)


@pulumi.input_type
class APIcastStatusConditionsArgs:
    def __init__(__self__, *,
                 status: pulumi.Input[str],
                 type: pulumi.Input[str]):
        """
        :param pulumi.Input[str] status: Status of the condition, one of True, False, Unknown.
        :param pulumi.Input[str] type: Type of replica set condition.
        """
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def status(self) -> pulumi.Input[str]:
        """
        Status of the condition, one of True, False, Unknown.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: pulumi.Input[str]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Type of replica set condition.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)


