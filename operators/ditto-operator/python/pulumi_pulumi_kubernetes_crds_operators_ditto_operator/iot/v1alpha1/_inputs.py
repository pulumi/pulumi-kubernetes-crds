# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'DittoSpecArgs',
]

@pulumi.input_type
class DittoSpecArgs:
    def __init__(__self__, *,
                 create_default_user: Optional[pulumi.Input[bool]] = None,
                 devops_secure_status: Optional[pulumi.Input[bool]] = None,
                 enable_dummy_auth: Optional[pulumi.Input[bool]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[bool] create_default_user: Create the default "ditto" user when initially deploying.
        :param pulumi.Input[bool] devops_secure_status: Secure the devops status information.
        :param pulumi.Input[bool] enable_dummy_auth: Enable the "dummy authentication" mode.
        :param pulumi.Input[str] version: Override the image version of the Ditto images.
        """
        if create_default_user is not None:
            pulumi.set(__self__, "create_default_user", create_default_user)
        if devops_secure_status is not None:
            pulumi.set(__self__, "devops_secure_status", devops_secure_status)
        if enable_dummy_auth is not None:
            pulumi.set(__self__, "enable_dummy_auth", enable_dummy_auth)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="createDefaultUser")
    def create_default_user(self) -> Optional[pulumi.Input[bool]]:
        """
        Create the default "ditto" user when initially deploying.
        """
        return pulumi.get(self, "create_default_user")

    @create_default_user.setter
    def create_default_user(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "create_default_user", value)

    @property
    @pulumi.getter(name="devopsSecureStatus")
    def devops_secure_status(self) -> Optional[pulumi.Input[bool]]:
        """
        Secure the devops status information.
        """
        return pulumi.get(self, "devops_secure_status")

    @devops_secure_status.setter
    def devops_secure_status(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "devops_secure_status", value)

    @property
    @pulumi.getter(name="enableDummyAuth")
    def enable_dummy_auth(self) -> Optional[pulumi.Input[bool]]:
        """
        Enable the "dummy authentication" mode.
        """
        return pulumi.get(self, "enable_dummy_auth")

    @enable_dummy_auth.setter
    def enable_dummy_auth(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_dummy_auth", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Override the image version of the Ditto images.
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


