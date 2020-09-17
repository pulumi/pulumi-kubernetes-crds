# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'TopicSpecArgs',
    'TopicSpecApiKeyArgs',
    'TopicSpecBindingFromArgs',
    'TopicSpecConfigsArgs',
    'TopicSpecConfigsValueFromArgs',
    'TopicSpecKafkaAdminUrlArgs',
    'TopicStatusArgs',
]

@pulumi.input_type
class TopicSpecArgs:
    def __init__(__self__, *,
                 topic_name: pulumi.Input[str],
                 api_key: Optional[pulumi.Input['TopicSpecApiKeyArgs']] = None,
                 binding_from: Optional[pulumi.Input['TopicSpecBindingFromArgs']] = None,
                 configs: Optional[pulumi.Input[Sequence[pulumi.Input['TopicSpecConfigsArgs']]]] = None,
                 kafka_admin_url: Optional[pulumi.Input['TopicSpecKafkaAdminUrlArgs']] = None,
                 num_partitions: Optional[pulumi.Input[int]] = None,
                 replication_factor: Optional[pulumi.Input[int]] = None):
        pulumi.set(__self__, "topic_name", topic_name)
        if api_key is not None:
            pulumi.set(__self__, "api_key", api_key)
        if binding_from is not None:
            pulumi.set(__self__, "binding_from", binding_from)
        if configs is not None:
            pulumi.set(__self__, "configs", configs)
        if kafka_admin_url is not None:
            pulumi.set(__self__, "kafka_admin_url", kafka_admin_url)
        if num_partitions is not None:
            pulumi.set(__self__, "num_partitions", num_partitions)
        if replication_factor is not None:
            pulumi.set(__self__, "replication_factor", replication_factor)

    @property
    @pulumi.getter(name="topicName")
    def topic_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "topic_name")

    @topic_name.setter
    def topic_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "topic_name", value)

    @property
    @pulumi.getter(name="apiKey")
    def api_key(self) -> Optional[pulumi.Input['TopicSpecApiKeyArgs']]:
        return pulumi.get(self, "api_key")

    @api_key.setter
    def api_key(self, value: Optional[pulumi.Input['TopicSpecApiKeyArgs']]):
        pulumi.set(self, "api_key", value)

    @property
    @pulumi.getter(name="bindingFrom")
    def binding_from(self) -> Optional[pulumi.Input['TopicSpecBindingFromArgs']]:
        return pulumi.get(self, "binding_from")

    @binding_from.setter
    def binding_from(self, value: Optional[pulumi.Input['TopicSpecBindingFromArgs']]):
        pulumi.set(self, "binding_from", value)

    @property
    @pulumi.getter
    def configs(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TopicSpecConfigsArgs']]]]:
        return pulumi.get(self, "configs")

    @configs.setter
    def configs(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TopicSpecConfigsArgs']]]]):
        pulumi.set(self, "configs", value)

    @property
    @pulumi.getter(name="kafkaAdminUrl")
    def kafka_admin_url(self) -> Optional[pulumi.Input['TopicSpecKafkaAdminUrlArgs']]:
        return pulumi.get(self, "kafka_admin_url")

    @kafka_admin_url.setter
    def kafka_admin_url(self, value: Optional[pulumi.Input['TopicSpecKafkaAdminUrlArgs']]):
        pulumi.set(self, "kafka_admin_url", value)

    @property
    @pulumi.getter(name="numPartitions")
    def num_partitions(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "num_partitions")

    @num_partitions.setter
    def num_partitions(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "num_partitions", value)

    @property
    @pulumi.getter(name="replicationFactor")
    def replication_factor(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "replication_factor")

    @replication_factor.setter
    def replication_factor(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "replication_factor", value)


@pulumi.input_type
class TopicSpecApiKeyArgs:
    def __init__(__self__, *,
                 config_map_key_ref: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 secret_key_ref: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        :param pulumi.Input[Mapping[str, Any]] config_map_key_ref: Selects a key of a ConfigMap.
        :param pulumi.Input[Mapping[str, Any]] secret_key_ref: Selects a key of a secret in the resource namespace
        """
        if config_map_key_ref is not None:
            pulumi.set(__self__, "config_map_key_ref", config_map_key_ref)
        if secret_key_ref is not None:
            pulumi.set(__self__, "secret_key_ref", secret_key_ref)

    @property
    @pulumi.getter(name="configMapKeyRef")
    def config_map_key_ref(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Selects a key of a ConfigMap.
        """
        return pulumi.get(self, "config_map_key_ref")

    @config_map_key_ref.setter
    def config_map_key_ref(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "config_map_key_ref", value)

    @property
    @pulumi.getter(name="secretKeyRef")
    def secret_key_ref(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Selects a key of a secret in the resource namespace
        """
        return pulumi.get(self, "secret_key_ref")

    @secret_key_ref.setter
    def secret_key_ref(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "secret_key_ref", value)


@pulumi.input_type
class TopicSpecBindingFromArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 namespace: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "name", name)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def namespace(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "namespace", value)


@pulumi.input_type
class TopicSpecConfigsArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 attributes: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 value: Optional[Any] = None,
                 value_from: Optional[pulumi.Input['TopicSpecConfigsValueFromArgs']] = None):
        """
        :param pulumi.Input[str] name: Name representing the key.
        :param pulumi.Input[Mapping[str, Any]] attributes: A parameter may have attributes (e.g. message hub topic might have partitions)
        :param Any value: Defaults to null.
        :param pulumi.Input['TopicSpecConfigsValueFromArgs'] value_from: Source for the value. Cannot be used if value is not empty.
        """
        pulumi.set(__self__, "name", name)
        if attributes is not None:
            pulumi.set(__self__, "attributes", attributes)
        if value is not None:
            pulumi.set(__self__, "value", value)
        if value_from is not None:
            pulumi.set(__self__, "value_from", value_from)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        Name representing the key.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def attributes(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        A parameter may have attributes (e.g. message hub topic might have partitions)
        """
        return pulumi.get(self, "attributes")

    @attributes.setter
    def attributes(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "attributes", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[Any]:
        """
        Defaults to null.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[Any]):
        pulumi.set(self, "value", value)

    @property
    @pulumi.getter(name="valueFrom")
    def value_from(self) -> Optional[pulumi.Input['TopicSpecConfigsValueFromArgs']]:
        """
        Source for the value. Cannot be used if value is not empty.
        """
        return pulumi.get(self, "value_from")

    @value_from.setter
    def value_from(self, value: Optional[pulumi.Input['TopicSpecConfigsValueFromArgs']]):
        pulumi.set(self, "value_from", value)


@pulumi.input_type
class TopicSpecConfigsValueFromArgs:
    def __init__(__self__, *,
                 config_map_key_ref: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 secret_key_ref: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        Source for the value. Cannot be used if value is not empty.
        :param pulumi.Input[Mapping[str, Any]] config_map_key_ref: Selects a key of a ConfigMap.
        :param pulumi.Input[Mapping[str, Any]] secret_key_ref: Selects a key of a secret in the resource namespace
        """
        if config_map_key_ref is not None:
            pulumi.set(__self__, "config_map_key_ref", config_map_key_ref)
        if secret_key_ref is not None:
            pulumi.set(__self__, "secret_key_ref", secret_key_ref)

    @property
    @pulumi.getter(name="configMapKeyRef")
    def config_map_key_ref(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Selects a key of a ConfigMap.
        """
        return pulumi.get(self, "config_map_key_ref")

    @config_map_key_ref.setter
    def config_map_key_ref(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "config_map_key_ref", value)

    @property
    @pulumi.getter(name="secretKeyRef")
    def secret_key_ref(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Selects a key of a secret in the resource namespace
        """
        return pulumi.get(self, "secret_key_ref")

    @secret_key_ref.setter
    def secret_key_ref(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "secret_key_ref", value)


@pulumi.input_type
class TopicSpecKafkaAdminUrlArgs:
    def __init__(__self__, *,
                 config_map_key_ref: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 secret_key_ref: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        :param pulumi.Input[Mapping[str, Any]] config_map_key_ref: Selects a key of a ConfigMap.
        :param pulumi.Input[Mapping[str, Any]] secret_key_ref: Selects a key of a secret in the resource namespace
        """
        if config_map_key_ref is not None:
            pulumi.set(__self__, "config_map_key_ref", config_map_key_ref)
        if secret_key_ref is not None:
            pulumi.set(__self__, "secret_key_ref", secret_key_ref)

    @property
    @pulumi.getter(name="configMapKeyRef")
    def config_map_key_ref(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Selects a key of a ConfigMap.
        """
        return pulumi.get(self, "config_map_key_ref")

    @config_map_key_ref.setter
    def config_map_key_ref(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "config_map_key_ref", value)

    @property
    @pulumi.getter(name="secretKeyRef")
    def secret_key_ref(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Selects a key of a secret in the resource namespace
        """
        return pulumi.get(self, "secret_key_ref")

    @secret_key_ref.setter
    def secret_key_ref(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "secret_key_ref", value)


@pulumi.input_type
class TopicStatusArgs:
    def __init__(__self__, *,
                 message: Optional[pulumi.Input[str]] = None,
                 state: Optional[pulumi.Input[str]] = None):
        if message is not None:
            pulumi.set(__self__, "message", message)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def message(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "message")

    @message.setter
    def message(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "message", value)

    @property
    @pulumi.getter
    def state(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "state")

    @state.setter
    def state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "state", value)


