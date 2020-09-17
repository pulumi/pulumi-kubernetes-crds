# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'KubernetesImagePullerSpec',
]

@pulumi.output_type
class KubernetesImagePullerSpec(dict):
    """
    KubernetesImagePullerSpec defines the desired state of KubernetesImagePuller
    """
    def __init__(__self__, *,
                 caching_cpu_limit: Optional[str] = None,
                 caching_cpu_request: Optional[str] = None,
                 caching_interval_hours: Optional[str] = None,
                 caching_memory_limit: Optional[str] = None,
                 caching_memory_request: Optional[str] = None,
                 config_map_name: Optional[str] = None,
                 daemonset_name: Optional[str] = None,
                 deployment_name: Optional[str] = None,
                 images: Optional[str] = None,
                 node_selector: Optional[str] = None):
        """
        KubernetesImagePullerSpec defines the desired state of KubernetesImagePuller
        """
        if caching_cpu_limit is not None:
            pulumi.set(__self__, "caching_cpu_limit", caching_cpu_limit)
        if caching_cpu_request is not None:
            pulumi.set(__self__, "caching_cpu_request", caching_cpu_request)
        if caching_interval_hours is not None:
            pulumi.set(__self__, "caching_interval_hours", caching_interval_hours)
        if caching_memory_limit is not None:
            pulumi.set(__self__, "caching_memory_limit", caching_memory_limit)
        if caching_memory_request is not None:
            pulumi.set(__self__, "caching_memory_request", caching_memory_request)
        if config_map_name is not None:
            pulumi.set(__self__, "config_map_name", config_map_name)
        if daemonset_name is not None:
            pulumi.set(__self__, "daemonset_name", daemonset_name)
        if deployment_name is not None:
            pulumi.set(__self__, "deployment_name", deployment_name)
        if images is not None:
            pulumi.set(__self__, "images", images)
        if node_selector is not None:
            pulumi.set(__self__, "node_selector", node_selector)

    @property
    @pulumi.getter(name="cachingCPULimit")
    def caching_cpu_limit(self) -> Optional[str]:
        return pulumi.get(self, "caching_cpu_limit")

    @property
    @pulumi.getter(name="cachingCPURequest")
    def caching_cpu_request(self) -> Optional[str]:
        return pulumi.get(self, "caching_cpu_request")

    @property
    @pulumi.getter(name="cachingIntervalHours")
    def caching_interval_hours(self) -> Optional[str]:
        return pulumi.get(self, "caching_interval_hours")

    @property
    @pulumi.getter(name="cachingMemoryLimit")
    def caching_memory_limit(self) -> Optional[str]:
        return pulumi.get(self, "caching_memory_limit")

    @property
    @pulumi.getter(name="cachingMemoryRequest")
    def caching_memory_request(self) -> Optional[str]:
        return pulumi.get(self, "caching_memory_request")

    @property
    @pulumi.getter(name="configMapName")
    def config_map_name(self) -> Optional[str]:
        return pulumi.get(self, "config_map_name")

    @property
    @pulumi.getter(name="daemonsetName")
    def daemonset_name(self) -> Optional[str]:
        return pulumi.get(self, "daemonset_name")

    @property
    @pulumi.getter(name="deploymentName")
    def deployment_name(self) -> Optional[str]:
        return pulumi.get(self, "deployment_name")

    @property
    @pulumi.getter
    def images(self) -> Optional[str]:
        return pulumi.get(self, "images")

    @property
    @pulumi.getter(name="nodeSelector")
    def node_selector(self) -> Optional[str]:
        return pulumi.get(self, "node_selector")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

