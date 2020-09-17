# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'SpecialResourceStatus',
]

@pulumi.output_type
class SpecialResourceStatus(dict):
    """
    SpecialResourceStatus defines the observed state of SpecialResource
    """
    def __init__(__self__, *,
                 state: str):
        """
        SpecialResourceStatus defines the observed state of SpecialResource
        :param str state: INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
        """
        pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def state(self) -> str:
        """
        INSERT ADDITIONAL STATUS FIELD - define observed state of cluster Important: Run "operator-sdk generate k8s" to regenerate code after modifying this file Add custom validation using kubebuilder tags: https://book-v1.book.kubebuilder.io/beyond_basics/generating_crd.html
        """
        return pulumi.get(self, "state")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


