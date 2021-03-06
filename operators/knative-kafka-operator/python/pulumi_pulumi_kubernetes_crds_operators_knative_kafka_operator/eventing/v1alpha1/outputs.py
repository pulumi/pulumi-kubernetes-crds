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
    'KnativeEventingKafkaSpec',
    'KnativeEventingKafkaStatus',
    'KnativeEventingKafkaStatusConditions',
]

@pulumi.output_type
class KnativeEventingKafkaSpec(dict):
    def __init__(__self__, *,
                 bootstrap_servers: str,
                 set_as_default_channel_provisioner: Optional[bool] = None):
        """
        :param str bootstrap_servers: URI(s) of Apache Kafka broker(s)
        :param bool set_as_default_channel_provisioner: Flag that controls whether Kafka channel provisioner is configured as the cluster default. Defaults to false.
        """
        pulumi.set(__self__, "bootstrap_servers", bootstrap_servers)
        if set_as_default_channel_provisioner is not None:
            pulumi.set(__self__, "set_as_default_channel_provisioner", set_as_default_channel_provisioner)

    @property
    @pulumi.getter(name="bootstrapServers")
    def bootstrap_servers(self) -> str:
        """
        URI(s) of Apache Kafka broker(s)
        """
        return pulumi.get(self, "bootstrap_servers")

    @property
    @pulumi.getter(name="setAsDefaultChannelProvisioner")
    def set_as_default_channel_provisioner(self) -> Optional[bool]:
        """
        Flag that controls whether Kafka channel provisioner is configured as the cluster default. Defaults to false.
        """
        return pulumi.get(self, "set_as_default_channel_provisioner")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class KnativeEventingKafkaStatus(dict):
    def __init__(__self__, *,
                 conditions: Optional[Sequence['outputs.KnativeEventingKafkaStatusConditions']] = None,
                 version: Optional[str] = None):
        """
        :param Sequence['KnativeEventingKafkaStatusConditionsArgs'] conditions: The latest available observations of a resource's current state. +patchMergeKey=type +patchStrategy=merge
        :param str version: The version of the installed release
        """
        if conditions is not None:
            pulumi.set(__self__, "conditions", conditions)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def conditions(self) -> Optional[Sequence['outputs.KnativeEventingKafkaStatusConditions']]:
        """
        The latest available observations of a resource's current state. +patchMergeKey=type +patchStrategy=merge
        """
        return pulumi.get(self, "conditions")

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
class KnativeEventingKafkaStatusConditions(dict):
    def __init__(__self__, *,
                 status: str,
                 type: str,
                 last_transition_time: Optional[str] = None,
                 message: Optional[str] = None,
                 reason: Optional[str] = None,
                 severity: Optional[str] = None):
        """
        :param str status: Status of the condition, one of True, False, Unknown. +required
        :param str type: Type of condition. +required
        :param str last_transition_time: LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).
        :param str message: A human readable message indicating details about the transition.
        :param str reason: The reason for the condition's last transition.
        :param str severity: Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.
        """
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "type", type)
        if last_transition_time is not None:
            pulumi.set(__self__, "last_transition_time", last_transition_time)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if reason is not None:
            pulumi.set(__self__, "reason", reason)
        if severity is not None:
            pulumi.set(__self__, "severity", severity)

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of the condition, one of True, False, Unknown. +required
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type of condition. +required
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="lastTransitionTime")
    def last_transition_time(self) -> Optional[str]:
        """
        LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).
        """
        return pulumi.get(self, "last_transition_time")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        """
        A human readable message indicating details about the transition.
        """
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def reason(self) -> Optional[str]:
        """
        The reason for the condition's last transition.
        """
        return pulumi.get(self, "reason")

    @property
    @pulumi.getter
    def severity(self) -> Optional[str]:
        """
        Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.
        """
        return pulumi.get(self, "severity")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


