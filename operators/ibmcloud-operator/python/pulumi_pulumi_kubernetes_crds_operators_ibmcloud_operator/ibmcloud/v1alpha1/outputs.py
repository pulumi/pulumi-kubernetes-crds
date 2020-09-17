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
    'BindingSpec',
    'BindingSpecParameters',
    'BindingSpecParametersValueFrom',
    'BindingStatus',
    'ServiceSpec',
    'ServiceSpecContext',
    'ServiceSpecParameters',
    'ServiceSpecParametersValueFrom',
    'ServiceStatus',
    'ServiceStatusContext',
    'ServiceStatusParameters',
    'ServiceStatusParametersValueFrom',
]

@pulumi.output_type
class BindingSpec(dict):
    def __init__(__self__, *,
                 service_name: str,
                 alias: Optional[str] = None,
                 parameters: Optional[Sequence['outputs.BindingSpecParameters']] = None,
                 role: Optional[str] = None,
                 secret_name: Optional[str] = None,
                 service_namespace: Optional[str] = None):
        pulumi.set(__self__, "service_name", service_name)
        if alias is not None:
            pulumi.set(__self__, "alias", alias)
        if parameters is not None:
            pulumi.set(__self__, "parameters", parameters)
        if role is not None:
            pulumi.set(__self__, "role", role)
        if secret_name is not None:
            pulumi.set(__self__, "secret_name", secret_name)
        if service_namespace is not None:
            pulumi.set(__self__, "service_namespace", service_namespace)

    @property
    @pulumi.getter(name="serviceName")
    def service_name(self) -> str:
        return pulumi.get(self, "service_name")

    @property
    @pulumi.getter
    def alias(self) -> Optional[str]:
        return pulumi.get(self, "alias")

    @property
    @pulumi.getter
    def parameters(self) -> Optional[Sequence['outputs.BindingSpecParameters']]:
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter
    def role(self) -> Optional[str]:
        return pulumi.get(self, "role")

    @property
    @pulumi.getter(name="secretName")
    def secret_name(self) -> Optional[str]:
        return pulumi.get(self, "secret_name")

    @property
    @pulumi.getter(name="serviceNamespace")
    def service_namespace(self) -> Optional[str]:
        return pulumi.get(self, "service_namespace")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BindingSpecParameters(dict):
    def __init__(__self__, *,
                 name: str,
                 attributes: Optional[Mapping[str, Any]] = None,
                 value: Optional[Any] = None,
                 value_from: Optional['outputs.BindingSpecParametersValueFrom'] = None):
        """
        :param str name: Name representing the key.
        :param Mapping[str, Any] attributes: A parameter may have attributes (e.g. message hub topic might have partitions)
        :param Any value: Defaults to null.
        :param 'BindingSpecParametersValueFromArgs' value_from: Source for the value. Cannot be used if value is not empty.
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
    def name(self) -> str:
        """
        Name representing the key.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def attributes(self) -> Optional[Mapping[str, Any]]:
        """
        A parameter may have attributes (e.g. message hub topic might have partitions)
        """
        return pulumi.get(self, "attributes")

    @property
    @pulumi.getter
    def value(self) -> Optional[Any]:
        """
        Defaults to null.
        """
        return pulumi.get(self, "value")

    @property
    @pulumi.getter(name="valueFrom")
    def value_from(self) -> Optional['outputs.BindingSpecParametersValueFrom']:
        """
        Source for the value. Cannot be used if value is not empty.
        """
        return pulumi.get(self, "value_from")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BindingSpecParametersValueFrom(dict):
    """
    Source for the value. Cannot be used if value is not empty.
    """
    def __init__(__self__, *,
                 config_map_key_ref: Optional[Mapping[str, Any]] = None,
                 secret_key_ref: Optional[Mapping[str, Any]] = None):
        """
        Source for the value. Cannot be used if value is not empty.
        :param Mapping[str, Any] config_map_key_ref: Selects a key of a ConfigMap.
        :param Mapping[str, Any] secret_key_ref: Selects a key of a secret in the resource namespace
        """
        if config_map_key_ref is not None:
            pulumi.set(__self__, "config_map_key_ref", config_map_key_ref)
        if secret_key_ref is not None:
            pulumi.set(__self__, "secret_key_ref", secret_key_ref)

    @property
    @pulumi.getter(name="configMapKeyRef")
    def config_map_key_ref(self) -> Optional[Mapping[str, Any]]:
        """
        Selects a key of a ConfigMap.
        """
        return pulumi.get(self, "config_map_key_ref")

    @property
    @pulumi.getter(name="secretKeyRef")
    def secret_key_ref(self) -> Optional[Mapping[str, Any]]:
        """
        Selects a key of a secret in the resource namespace
        """
        return pulumi.get(self, "secret_key_ref")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BindingStatus(dict):
    def __init__(__self__, *,
                 generation: Optional[int] = None,
                 instance_id: Optional[str] = None,
                 key_instance_id: Optional[str] = None,
                 message: Optional[str] = None,
                 secret_name: Optional[str] = None,
                 state: Optional[str] = None):
        if generation is not None:
            pulumi.set(__self__, "generation", generation)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if key_instance_id is not None:
            pulumi.set(__self__, "key_instance_id", key_instance_id)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if secret_name is not None:
            pulumi.set(__self__, "secret_name", secret_name)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def generation(self) -> Optional[int]:
        return pulumi.get(self, "generation")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[str]:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="keyInstanceId")
    def key_instance_id(self) -> Optional[str]:
        return pulumi.get(self, "key_instance_id")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        return pulumi.get(self, "message")

    @property
    @pulumi.getter(name="secretName")
    def secret_name(self) -> Optional[str]:
        return pulumi.get(self, "secret_name")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        return pulumi.get(self, "state")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceSpec(dict):
    def __init__(__self__, *,
                 plan: str,
                 service_class: str,
                 context: Optional['outputs.ServiceSpecContext'] = None,
                 external_name: Optional[str] = None,
                 parameters: Optional[Sequence['outputs.ServiceSpecParameters']] = None,
                 service_class_type: Optional[str] = None,
                 tags: Optional[Sequence[str]] = None):
        pulumi.set(__self__, "plan", plan)
        pulumi.set(__self__, "service_class", service_class)
        if context is not None:
            pulumi.set(__self__, "context", context)
        if external_name is not None:
            pulumi.set(__self__, "external_name", external_name)
        if parameters is not None:
            pulumi.set(__self__, "parameters", parameters)
        if service_class_type is not None:
            pulumi.set(__self__, "service_class_type", service_class_type)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def plan(self) -> str:
        return pulumi.get(self, "plan")

    @property
    @pulumi.getter(name="serviceClass")
    def service_class(self) -> str:
        return pulumi.get(self, "service_class")

    @property
    @pulumi.getter
    def context(self) -> Optional['outputs.ServiceSpecContext']:
        return pulumi.get(self, "context")

    @property
    @pulumi.getter(name="externalName")
    def external_name(self) -> Optional[str]:
        return pulumi.get(self, "external_name")

    @property
    @pulumi.getter
    def parameters(self) -> Optional[Sequence['outputs.ServiceSpecParameters']]:
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="serviceClassType")
    def service_class_type(self) -> Optional[str]:
        return pulumi.get(self, "service_class_type")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "tags")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceSpecContext(dict):
    def __init__(__self__, *,
                 org: Optional[str] = None,
                 region: Optional[str] = None,
                 resourcegroup: Optional[str] = None,
                 resourcegroupid: Optional[str] = None,
                 resourcelocation: Optional[str] = None,
                 space: Optional[str] = None,
                 user: Optional[str] = None):
        if org is not None:
            pulumi.set(__self__, "org", org)
        if region is not None:
            pulumi.set(__self__, "region", region)
        if resourcegroup is not None:
            pulumi.set(__self__, "resourcegroup", resourcegroup)
        if resourcegroupid is not None:
            pulumi.set(__self__, "resourcegroupid", resourcegroupid)
        if resourcelocation is not None:
            pulumi.set(__self__, "resourcelocation", resourcelocation)
        if space is not None:
            pulumi.set(__self__, "space", space)
        if user is not None:
            pulumi.set(__self__, "user", user)

    @property
    @pulumi.getter
    def org(self) -> Optional[str]:
        return pulumi.get(self, "org")

    @property
    @pulumi.getter
    def region(self) -> Optional[str]:
        return pulumi.get(self, "region")

    @property
    @pulumi.getter
    def resourcegroup(self) -> Optional[str]:
        return pulumi.get(self, "resourcegroup")

    @property
    @pulumi.getter
    def resourcegroupid(self) -> Optional[str]:
        return pulumi.get(self, "resourcegroupid")

    @property
    @pulumi.getter
    def resourcelocation(self) -> Optional[str]:
        return pulumi.get(self, "resourcelocation")

    @property
    @pulumi.getter
    def space(self) -> Optional[str]:
        return pulumi.get(self, "space")

    @property
    @pulumi.getter
    def user(self) -> Optional[str]:
        return pulumi.get(self, "user")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceSpecParameters(dict):
    def __init__(__self__, *,
                 name: str,
                 attributes: Optional[Mapping[str, Any]] = None,
                 value: Optional[Any] = None,
                 value_from: Optional['outputs.ServiceSpecParametersValueFrom'] = None):
        """
        :param str name: Name representing the key.
        :param Mapping[str, Any] attributes: A parameter may have attributes (e.g. message hub topic might have partitions)
        :param Any value: Defaults to null.
        :param 'ServiceSpecParametersValueFromArgs' value_from: Source for the value. Cannot be used if value is not empty.
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
    def name(self) -> str:
        """
        Name representing the key.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def attributes(self) -> Optional[Mapping[str, Any]]:
        """
        A parameter may have attributes (e.g. message hub topic might have partitions)
        """
        return pulumi.get(self, "attributes")

    @property
    @pulumi.getter
    def value(self) -> Optional[Any]:
        """
        Defaults to null.
        """
        return pulumi.get(self, "value")

    @property
    @pulumi.getter(name="valueFrom")
    def value_from(self) -> Optional['outputs.ServiceSpecParametersValueFrom']:
        """
        Source for the value. Cannot be used if value is not empty.
        """
        return pulumi.get(self, "value_from")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceSpecParametersValueFrom(dict):
    """
    Source for the value. Cannot be used if value is not empty.
    """
    def __init__(__self__, *,
                 config_map_key_ref: Optional[Mapping[str, Any]] = None,
                 secret_key_ref: Optional[Mapping[str, Any]] = None):
        """
        Source for the value. Cannot be used if value is not empty.
        :param Mapping[str, Any] config_map_key_ref: Selects a key of a ConfigMap.
        :param Mapping[str, Any] secret_key_ref: Selects a key of a secret in the resource namespace
        """
        if config_map_key_ref is not None:
            pulumi.set(__self__, "config_map_key_ref", config_map_key_ref)
        if secret_key_ref is not None:
            pulumi.set(__self__, "secret_key_ref", secret_key_ref)

    @property
    @pulumi.getter(name="configMapKeyRef")
    def config_map_key_ref(self) -> Optional[Mapping[str, Any]]:
        """
        Selects a key of a ConfigMap.
        """
        return pulumi.get(self, "config_map_key_ref")

    @property
    @pulumi.getter(name="secretKeyRef")
    def secret_key_ref(self) -> Optional[Mapping[str, Any]]:
        """
        Selects a key of a secret in the resource namespace
        """
        return pulumi.get(self, "secret_key_ref")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceStatus(dict):
    def __init__(__self__, *,
                 plan: str,
                 service_class: str,
                 service_class_type: str,
                 context: Optional['outputs.ServiceStatusContext'] = None,
                 dashboard_url: Optional[str] = None,
                 external_name: Optional[str] = None,
                 generation: Optional[int] = None,
                 instance_id: Optional[str] = None,
                 message: Optional[str] = None,
                 parameters: Optional[Sequence['outputs.ServiceStatusParameters']] = None,
                 state: Optional[str] = None,
                 tags: Optional[Sequence[str]] = None):
        pulumi.set(__self__, "plan", plan)
        pulumi.set(__self__, "service_class", service_class)
        pulumi.set(__self__, "service_class_type", service_class_type)
        if context is not None:
            pulumi.set(__self__, "context", context)
        if dashboard_url is not None:
            pulumi.set(__self__, "dashboard_url", dashboard_url)
        if external_name is not None:
            pulumi.set(__self__, "external_name", external_name)
        if generation is not None:
            pulumi.set(__self__, "generation", generation)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if parameters is not None:
            pulumi.set(__self__, "parameters", parameters)
        if state is not None:
            pulumi.set(__self__, "state", state)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def plan(self) -> str:
        return pulumi.get(self, "plan")

    @property
    @pulumi.getter(name="serviceClass")
    def service_class(self) -> str:
        return pulumi.get(self, "service_class")

    @property
    @pulumi.getter(name="serviceClassType")
    def service_class_type(self) -> str:
        return pulumi.get(self, "service_class_type")

    @property
    @pulumi.getter
    def context(self) -> Optional['outputs.ServiceStatusContext']:
        return pulumi.get(self, "context")

    @property
    @pulumi.getter(name="dashboardURL")
    def dashboard_url(self) -> Optional[str]:
        return pulumi.get(self, "dashboard_url")

    @property
    @pulumi.getter(name="externalName")
    def external_name(self) -> Optional[str]:
        return pulumi.get(self, "external_name")

    @property
    @pulumi.getter
    def generation(self) -> Optional[int]:
        return pulumi.get(self, "generation")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[str]:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def parameters(self) -> Optional[Sequence['outputs.ServiceStatusParameters']]:
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        return pulumi.get(self, "state")

    @property
    @pulumi.getter
    def tags(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "tags")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceStatusContext(dict):
    def __init__(__self__, *,
                 org: Optional[str] = None,
                 region: Optional[str] = None,
                 resourcegroup: Optional[str] = None,
                 resourcegroupid: Optional[str] = None,
                 resourcelocation: Optional[str] = None,
                 space: Optional[str] = None,
                 user: Optional[str] = None):
        if org is not None:
            pulumi.set(__self__, "org", org)
        if region is not None:
            pulumi.set(__self__, "region", region)
        if resourcegroup is not None:
            pulumi.set(__self__, "resourcegroup", resourcegroup)
        if resourcegroupid is not None:
            pulumi.set(__self__, "resourcegroupid", resourcegroupid)
        if resourcelocation is not None:
            pulumi.set(__self__, "resourcelocation", resourcelocation)
        if space is not None:
            pulumi.set(__self__, "space", space)
        if user is not None:
            pulumi.set(__self__, "user", user)

    @property
    @pulumi.getter
    def org(self) -> Optional[str]:
        return pulumi.get(self, "org")

    @property
    @pulumi.getter
    def region(self) -> Optional[str]:
        return pulumi.get(self, "region")

    @property
    @pulumi.getter
    def resourcegroup(self) -> Optional[str]:
        return pulumi.get(self, "resourcegroup")

    @property
    @pulumi.getter
    def resourcegroupid(self) -> Optional[str]:
        return pulumi.get(self, "resourcegroupid")

    @property
    @pulumi.getter
    def resourcelocation(self) -> Optional[str]:
        return pulumi.get(self, "resourcelocation")

    @property
    @pulumi.getter
    def space(self) -> Optional[str]:
        return pulumi.get(self, "space")

    @property
    @pulumi.getter
    def user(self) -> Optional[str]:
        return pulumi.get(self, "user")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceStatusParameters(dict):
    def __init__(__self__, *,
                 name: str,
                 attributes: Optional[Mapping[str, Any]] = None,
                 value: Optional[Any] = None,
                 value_from: Optional['outputs.ServiceStatusParametersValueFrom'] = None):
        """
        :param str name: Name representing the key.
        :param Mapping[str, Any] attributes: A parameter may have attributes (e.g. message hub topic might have partitions)
        :param Any value: Defaults to null.
        :param 'ServiceStatusParametersValueFromArgs' value_from: Source for the value. Cannot be used if value is not empty.
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
    def name(self) -> str:
        """
        Name representing the key.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def attributes(self) -> Optional[Mapping[str, Any]]:
        """
        A parameter may have attributes (e.g. message hub topic might have partitions)
        """
        return pulumi.get(self, "attributes")

    @property
    @pulumi.getter
    def value(self) -> Optional[Any]:
        """
        Defaults to null.
        """
        return pulumi.get(self, "value")

    @property
    @pulumi.getter(name="valueFrom")
    def value_from(self) -> Optional['outputs.ServiceStatusParametersValueFrom']:
        """
        Source for the value. Cannot be used if value is not empty.
        """
        return pulumi.get(self, "value_from")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceStatusParametersValueFrom(dict):
    """
    Source for the value. Cannot be used if value is not empty.
    """
    def __init__(__self__, *,
                 config_map_key_ref: Optional[Mapping[str, Any]] = None,
                 secret_key_ref: Optional[Mapping[str, Any]] = None):
        """
        Source for the value. Cannot be used if value is not empty.
        :param Mapping[str, Any] config_map_key_ref: Selects a key of a ConfigMap.
        :param Mapping[str, Any] secret_key_ref: Selects a key of a secret in the resource namespace
        """
        if config_map_key_ref is not None:
            pulumi.set(__self__, "config_map_key_ref", config_map_key_ref)
        if secret_key_ref is not None:
            pulumi.set(__self__, "secret_key_ref", secret_key_ref)

    @property
    @pulumi.getter(name="configMapKeyRef")
    def config_map_key_ref(self) -> Optional[Mapping[str, Any]]:
        """
        Selects a key of a ConfigMap.
        """
        return pulumi.get(self, "config_map_key_ref")

    @property
    @pulumi.getter(name="secretKeyRef")
    def secret_key_ref(self) -> Optional[Mapping[str, Any]]:
        """
        Selects a key of a secret in the resource namespace
        """
        return pulumi.get(self, "secret_key_ref")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


