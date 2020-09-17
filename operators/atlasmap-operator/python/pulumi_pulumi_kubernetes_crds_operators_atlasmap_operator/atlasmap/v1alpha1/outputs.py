# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'AtlasMapSpec',
    'AtlasMapStatus',
]

@pulumi.output_type
class AtlasMapSpec(dict):
    """
    AtlasMapSpec defines the desired state of AtlasMap
    """
    def __init__(__self__, *,
                 limit_cpu: Optional[str] = None,
                 limit_memory: Optional[str] = None,
                 replicas: Optional[int] = None,
                 request_cpu: Optional[str] = None,
                 request_memory: Optional[str] = None,
                 route_host_name: Optional[str] = None,
                 version: Optional[str] = None):
        """
        AtlasMapSpec defines the desired state of AtlasMap
        :param str limit_cpu: The amount of CPU to limit
        :param str limit_memory: The amount of memory to request
        :param int replicas: Replicas determines the desired number of running AtlasMap pods
        :param str request_cpu: The amount of CPU to request
        :param str request_memory: The amount of memory to request
        :param str route_host_name: RouteHostName sets the host name to use on the Ingress or OpenShift Route
        :param str version: Version sets the version of the container image used for AtlasMap
        """
        if limit_cpu is not None:
            pulumi.set(__self__, "limit_cpu", limit_cpu)
        if limit_memory is not None:
            pulumi.set(__self__, "limit_memory", limit_memory)
        if replicas is not None:
            pulumi.set(__self__, "replicas", replicas)
        if request_cpu is not None:
            pulumi.set(__self__, "request_cpu", request_cpu)
        if request_memory is not None:
            pulumi.set(__self__, "request_memory", request_memory)
        if route_host_name is not None:
            pulumi.set(__self__, "route_host_name", route_host_name)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="limitCPU")
    def limit_cpu(self) -> Optional[str]:
        """
        The amount of CPU to limit
        """
        return pulumi.get(self, "limit_cpu")

    @property
    @pulumi.getter(name="limitMemory")
    def limit_memory(self) -> Optional[str]:
        """
        The amount of memory to request
        """
        return pulumi.get(self, "limit_memory")

    @property
    @pulumi.getter
    def replicas(self) -> Optional[int]:
        """
        Replicas determines the desired number of running AtlasMap pods
        """
        return pulumi.get(self, "replicas")

    @property
    @pulumi.getter(name="requestCPU")
    def request_cpu(self) -> Optional[str]:
        """
        The amount of CPU to request
        """
        return pulumi.get(self, "request_cpu")

    @property
    @pulumi.getter(name="requestMemory")
    def request_memory(self) -> Optional[str]:
        """
        The amount of memory to request
        """
        return pulumi.get(self, "request_memory")

    @property
    @pulumi.getter(name="routeHostName")
    def route_host_name(self) -> Optional[str]:
        """
        RouteHostName sets the host name to use on the Ingress or OpenShift Route
        """
        return pulumi.get(self, "route_host_name")

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        """
        Version sets the version of the container image used for AtlasMap
        """
        return pulumi.get(self, "version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AtlasMapStatus(dict):
    """
    AtlasMapStatus defines the observed state of AtlasMap
    """
    def __init__(__self__, *,
                 url: Optional[str] = None,
                 image: Optional[str] = None,
                 phase: Optional[str] = None):
        """
        AtlasMapStatus defines the observed state of AtlasMap
        :param str url: The URL where AtlasMap can be accessed
        :param str image: The container image that AtlasMap is using
        :param str phase: The current phase that the AtlasMap resource is in
        """
        if url is not None:
            pulumi.set(__self__, "url", url)
        if image is not None:
            pulumi.set(__self__, "image", image)
        if phase is not None:
            pulumi.set(__self__, "phase", phase)

    @property
    @pulumi.getter(name="URL")
    def url(self) -> Optional[str]:
        """
        The URL where AtlasMap can be accessed
        """
        return pulumi.get(self, "url")

    @property
    @pulumi.getter
    def image(self) -> Optional[str]:
        """
        The container image that AtlasMap is using
        """
        return pulumi.get(self, "image")

    @property
    @pulumi.getter
    def phase(self) -> Optional[str]:
        """
        The current phase that the AtlasMap resource is in
        """
        return pulumi.get(self, "phase")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

