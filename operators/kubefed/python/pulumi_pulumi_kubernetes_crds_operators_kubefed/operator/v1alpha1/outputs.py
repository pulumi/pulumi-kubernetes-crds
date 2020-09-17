# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'KubeFedSpec',
    'KubeFedStatus',
    'KubeFedWebHookSpec',
    'KubeFedWebHookStatus',
]

@pulumi.output_type
class KubeFedSpec(dict):
    def __init__(__self__, *,
                 scope: str):
        """
        :param str scope: The scope of the installed release
        """
        pulumi.set(__self__, "scope", scope)

    @property
    @pulumi.getter
    def scope(self) -> str:
        """
        The scope of the installed release
        """
        return pulumi.get(self, "scope")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class KubeFedStatus(dict):
    def __init__(__self__, *,
                 version: Optional[str] = None):
        """
        :param str version: The version of the installed release
        """
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        """
        The version of the installed release
        """
        return pulumi.get(self, "version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class KubeFedWebHookSpec(dict):
    def __init__(__self__):
        pass

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class KubeFedWebHookStatus(dict):
    def __init__(__self__, *,
                 version: Optional[str] = None):
        """
        :param str version: The version of the installed release
        """
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        """
        The version of the installed release
        """
        return pulumi.get(self, "version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


