# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'AtlasMapSpecArgs',
    'AtlasMapStatusArgs',
]

@pulumi.input_type
class AtlasMapSpecArgs:
    def __init__(__self__, *,
                 limit_cpu: Optional[pulumi.Input[str]] = None,
                 limit_memory: Optional[pulumi.Input[str]] = None,
                 replicas: Optional[pulumi.Input[int]] = None,
                 request_cpu: Optional[pulumi.Input[str]] = None,
                 request_memory: Optional[pulumi.Input[str]] = None,
                 route_host_name: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        AtlasMapSpec defines the desired state of AtlasMap
        :param pulumi.Input[str] limit_cpu: The amount of CPU to limit
        :param pulumi.Input[str] limit_memory: The amount of memory to request
        :param pulumi.Input[int] replicas: Replicas determines the desired number of running AtlasMap pods
        :param pulumi.Input[str] request_cpu: The amount of CPU to request
        :param pulumi.Input[str] request_memory: The amount of memory to request
        :param pulumi.Input[str] route_host_name: RouteHostName sets the host name to use on the Ingress or OpenShift Route
        :param pulumi.Input[str] version: Version sets the version of the container image used for AtlasMap
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
    def limit_cpu(self) -> Optional[pulumi.Input[str]]:
        """
        The amount of CPU to limit
        """
        return pulumi.get(self, "limit_cpu")

    @limit_cpu.setter
    def limit_cpu(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "limit_cpu", value)

    @property
    @pulumi.getter(name="limitMemory")
    def limit_memory(self) -> Optional[pulumi.Input[str]]:
        """
        The amount of memory to request
        """
        return pulumi.get(self, "limit_memory")

    @limit_memory.setter
    def limit_memory(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "limit_memory", value)

    @property
    @pulumi.getter
    def replicas(self) -> Optional[pulumi.Input[int]]:
        """
        Replicas determines the desired number of running AtlasMap pods
        """
        return pulumi.get(self, "replicas")

    @replicas.setter
    def replicas(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "replicas", value)

    @property
    @pulumi.getter(name="requestCPU")
    def request_cpu(self) -> Optional[pulumi.Input[str]]:
        """
        The amount of CPU to request
        """
        return pulumi.get(self, "request_cpu")

    @request_cpu.setter
    def request_cpu(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "request_cpu", value)

    @property
    @pulumi.getter(name="requestMemory")
    def request_memory(self) -> Optional[pulumi.Input[str]]:
        """
        The amount of memory to request
        """
        return pulumi.get(self, "request_memory")

    @request_memory.setter
    def request_memory(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "request_memory", value)

    @property
    @pulumi.getter(name="routeHostName")
    def route_host_name(self) -> Optional[pulumi.Input[str]]:
        """
        RouteHostName sets the host name to use on the Ingress or OpenShift Route
        """
        return pulumi.get(self, "route_host_name")

    @route_host_name.setter
    def route_host_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "route_host_name", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Version sets the version of the container image used for AtlasMap
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


@pulumi.input_type
class AtlasMapStatusArgs:
    def __init__(__self__, *,
                 url: Optional[pulumi.Input[str]] = None,
                 image: Optional[pulumi.Input[str]] = None,
                 phase: Optional[pulumi.Input[str]] = None):
        """
        AtlasMapStatus defines the observed state of AtlasMap
        :param pulumi.Input[str] url: The URL where AtlasMap can be accessed
        :param pulumi.Input[str] image: The container image that AtlasMap is using
        :param pulumi.Input[str] phase: The current phase that the AtlasMap resource is in
        """
        if url is not None:
            pulumi.set(__self__, "url", url)
        if image is not None:
            pulumi.set(__self__, "image", image)
        if phase is not None:
            pulumi.set(__self__, "phase", phase)

    @property
    @pulumi.getter(name="URL")
    def url(self) -> Optional[pulumi.Input[str]]:
        """
        The URL where AtlasMap can be accessed
        """
        return pulumi.get(self, "url")

    @url.setter
    def url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "url", value)

    @property
    @pulumi.getter
    def image(self) -> Optional[pulumi.Input[str]]:
        """
        The container image that AtlasMap is using
        """
        return pulumi.get(self, "image")

    @image.setter
    def image(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "image", value)

    @property
    @pulumi.getter
    def phase(self) -> Optional[pulumi.Input[str]]:
        """
        The current phase that the AtlasMap resource is in
        """
        return pulumi.get(self, "phase")

    @phase.setter
    def phase(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "phase", value)

