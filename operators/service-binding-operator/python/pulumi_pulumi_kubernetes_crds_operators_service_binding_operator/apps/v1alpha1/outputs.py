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
    'ServiceBindingRequestSpec',
    'ServiceBindingRequestSpecApplicationSelector',
    'ServiceBindingRequestSpecApplicationSelectorBindingPath',
    'ServiceBindingRequestSpecApplicationSelectorLabelSelector',
    'ServiceBindingRequestSpecApplicationSelectorLabelSelectorMatchExpressions',
    'ServiceBindingRequestSpecBackingServiceSelector',
    'ServiceBindingRequestSpecBackingServiceSelectors',
    'ServiceBindingRequestSpecCustomEnvVar',
    'ServiceBindingRequestSpecCustomEnvVarValueFrom',
    'ServiceBindingRequestSpecCustomEnvVarValueFromConfigMapKeyRef',
    'ServiceBindingRequestSpecCustomEnvVarValueFromFieldRef',
    'ServiceBindingRequestSpecCustomEnvVarValueFromResourceFieldRef',
    'ServiceBindingRequestSpecCustomEnvVarValueFromSecretKeyRef',
    'ServiceBindingRequestStatus',
    'ServiceBindingRequestStatusApplications',
    'ServiceBindingRequestStatusConditions',
]

@pulumi.output_type
class ServiceBindingRequestSpec(dict):
    """
    ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
    """
    def __init__(__self__, *,
                 application_selector: Optional['outputs.ServiceBindingRequestSpecApplicationSelector'] = None,
                 backing_service_selector: Optional['outputs.ServiceBindingRequestSpecBackingServiceSelector'] = None,
                 backing_service_selectors: Optional[Sequence['outputs.ServiceBindingRequestSpecBackingServiceSelectors']] = None,
                 custom_env_var: Optional[Sequence['outputs.ServiceBindingRequestSpecCustomEnvVar']] = None,
                 detect_binding_resources: Optional[bool] = None,
                 env_var_prefix: Optional[str] = None,
                 mount_path_prefix: Optional[str] = None):
        """
        ServiceBindingRequestSpec defines the desired state of ServiceBindingRequest
        :param 'ServiceBindingRequestSpecApplicationSelectorArgs' application_selector: ApplicationSelector is used to identify the application connecting to the backing service operator.
        :param 'ServiceBindingRequestSpecBackingServiceSelectorArgs' backing_service_selector: BackingServiceSelector is used to identify the backing service operator. Deprecation Notice: In the upcoming release, this field would be depcreated. It would be mandatory to set "backingServiceSelectors".
        :param Sequence['ServiceBindingRequestSpecBackingServiceSelectorsArgs'] backing_service_selectors: BackingServiceSelectors is used to identify multiple backing services. This would be made a required field after 'BackingServiceSelector' is removed.
        :param Sequence['ServiceBindingRequestSpecCustomEnvVarArgs'] custom_env_var: Custom env variables
        :param bool detect_binding_resources: DetectBindingResources is flag used to bind all non-bindable variables from different subresources owned by backing operator CR.
        :param str env_var_prefix: EnvVarPrefix is the prefix for environment variables
        :param str mount_path_prefix: MountPathPrefix is the prefix for volume mount
        """
        if application_selector is not None:
            pulumi.set(__self__, "application_selector", application_selector)
        if backing_service_selector is not None:
            pulumi.set(__self__, "backing_service_selector", backing_service_selector)
        if backing_service_selectors is not None:
            pulumi.set(__self__, "backing_service_selectors", backing_service_selectors)
        if custom_env_var is not None:
            pulumi.set(__self__, "custom_env_var", custom_env_var)
        if detect_binding_resources is not None:
            pulumi.set(__self__, "detect_binding_resources", detect_binding_resources)
        if env_var_prefix is not None:
            pulumi.set(__self__, "env_var_prefix", env_var_prefix)
        if mount_path_prefix is not None:
            pulumi.set(__self__, "mount_path_prefix", mount_path_prefix)

    @property
    @pulumi.getter(name="applicationSelector")
    def application_selector(self) -> Optional['outputs.ServiceBindingRequestSpecApplicationSelector']:
        """
        ApplicationSelector is used to identify the application connecting to the backing service operator.
        """
        return pulumi.get(self, "application_selector")

    @property
    @pulumi.getter(name="backingServiceSelector")
    def backing_service_selector(self) -> Optional['outputs.ServiceBindingRequestSpecBackingServiceSelector']:
        """
        BackingServiceSelector is used to identify the backing service operator. Deprecation Notice: In the upcoming release, this field would be depcreated. It would be mandatory to set "backingServiceSelectors".
        """
        return pulumi.get(self, "backing_service_selector")

    @property
    @pulumi.getter(name="backingServiceSelectors")
    def backing_service_selectors(self) -> Optional[Sequence['outputs.ServiceBindingRequestSpecBackingServiceSelectors']]:
        """
        BackingServiceSelectors is used to identify multiple backing services. This would be made a required field after 'BackingServiceSelector' is removed.
        """
        return pulumi.get(self, "backing_service_selectors")

    @property
    @pulumi.getter(name="customEnvVar")
    def custom_env_var(self) -> Optional[Sequence['outputs.ServiceBindingRequestSpecCustomEnvVar']]:
        """
        Custom env variables
        """
        return pulumi.get(self, "custom_env_var")

    @property
    @pulumi.getter(name="detectBindingResources")
    def detect_binding_resources(self) -> Optional[bool]:
        """
        DetectBindingResources is flag used to bind all non-bindable variables from different subresources owned by backing operator CR.
        """
        return pulumi.get(self, "detect_binding_resources")

    @property
    @pulumi.getter(name="envVarPrefix")
    def env_var_prefix(self) -> Optional[str]:
        """
        EnvVarPrefix is the prefix for environment variables
        """
        return pulumi.get(self, "env_var_prefix")

    @property
    @pulumi.getter(name="mountPathPrefix")
    def mount_path_prefix(self) -> Optional[str]:
        """
        MountPathPrefix is the prefix for volume mount
        """
        return pulumi.get(self, "mount_path_prefix")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecApplicationSelector(dict):
    """
    ApplicationSelector is used to identify the application connecting to the backing service operator.
    """
    def __init__(__self__, *,
                 group: str,
                 resource: str,
                 version: str,
                 binding_path: Optional['outputs.ServiceBindingRequestSpecApplicationSelectorBindingPath'] = None,
                 label_selector: Optional['outputs.ServiceBindingRequestSpecApplicationSelectorLabelSelector'] = None,
                 resource_ref: Optional[str] = None):
        """
        ApplicationSelector is used to identify the application connecting to the backing service operator.
        :param 'ServiceBindingRequestSpecApplicationSelectorBindingPathArgs' binding_path: BindingPath refers to the path in the application workload's schema where the binding workload would be referenced.
        :param 'ServiceBindingRequestSpecApplicationSelectorLabelSelectorArgs' label_selector: A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
        """
        pulumi.set(__self__, "group", group)
        pulumi.set(__self__, "resource", resource)
        pulumi.set(__self__, "version", version)
        if binding_path is not None:
            pulumi.set(__self__, "binding_path", binding_path)
        if label_selector is not None:
            pulumi.set(__self__, "label_selector", label_selector)
        if resource_ref is not None:
            pulumi.set(__self__, "resource_ref", resource_ref)

    @property
    @pulumi.getter
    def group(self) -> str:
        return pulumi.get(self, "group")

    @property
    @pulumi.getter
    def resource(self) -> str:
        return pulumi.get(self, "resource")

    @property
    @pulumi.getter
    def version(self) -> str:
        return pulumi.get(self, "version")

    @property
    @pulumi.getter(name="bindingPath")
    def binding_path(self) -> Optional['outputs.ServiceBindingRequestSpecApplicationSelectorBindingPath']:
        """
        BindingPath refers to the path in the application workload's schema where the binding workload would be referenced.
        """
        return pulumi.get(self, "binding_path")

    @property
    @pulumi.getter(name="labelSelector")
    def label_selector(self) -> Optional['outputs.ServiceBindingRequestSpecApplicationSelectorLabelSelector']:
        """
        A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
        """
        return pulumi.get(self, "label_selector")

    @property
    @pulumi.getter(name="resourceRef")
    def resource_ref(self) -> Optional[str]:
        return pulumi.get(self, "resource_ref")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecApplicationSelectorBindingPath(dict):
    """
    BindingPath refers to the path in the application workload's schema where the binding workload would be referenced.
    """
    def __init__(__self__, *,
                 containers_path: Optional[str] = None,
                 secret_path: Optional[str] = None):
        """
        BindingPath refers to the path in the application workload's schema where the binding workload would be referenced.
        :param str containers_path: ContainersPath defines the path to the corev1.Containers reference The default location is going to this: "spec.template.spec.containers"
        :param str secret_path: SecretPath defines the path to a string field where the secret needs to be assigned. The default name is going to the value of the name of SBR CR (metadata.name)
        """
        if containers_path is not None:
            pulumi.set(__self__, "containers_path", containers_path)
        if secret_path is not None:
            pulumi.set(__self__, "secret_path", secret_path)

    @property
    @pulumi.getter(name="containersPath")
    def containers_path(self) -> Optional[str]:
        """
        ContainersPath defines the path to the corev1.Containers reference The default location is going to this: "spec.template.spec.containers"
        """
        return pulumi.get(self, "containers_path")

    @property
    @pulumi.getter(name="secretPath")
    def secret_path(self) -> Optional[str]:
        """
        SecretPath defines the path to a string field where the secret needs to be assigned. The default name is going to the value of the name of SBR CR (metadata.name)
        """
        return pulumi.get(self, "secret_path")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecApplicationSelectorLabelSelector(dict):
    """
    A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
    """
    def __init__(__self__, *,
                 match_expressions: Optional[Sequence['outputs.ServiceBindingRequestSpecApplicationSelectorLabelSelectorMatchExpressions']] = None,
                 match_labels: Optional[Mapping[str, str]] = None):
        """
        A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
        :param Sequence['ServiceBindingRequestSpecApplicationSelectorLabelSelectorMatchExpressionsArgs'] match_expressions: matchExpressions is a list of label selector requirements. The requirements are ANDed.
        :param Mapping[str, str] match_labels: matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
        """
        if match_expressions is not None:
            pulumi.set(__self__, "match_expressions", match_expressions)
        if match_labels is not None:
            pulumi.set(__self__, "match_labels", match_labels)

    @property
    @pulumi.getter(name="matchExpressions")
    def match_expressions(self) -> Optional[Sequence['outputs.ServiceBindingRequestSpecApplicationSelectorLabelSelectorMatchExpressions']]:
        """
        matchExpressions is a list of label selector requirements. The requirements are ANDed.
        """
        return pulumi.get(self, "match_expressions")

    @property
    @pulumi.getter(name="matchLabels")
    def match_labels(self) -> Optional[Mapping[str, str]]:
        """
        matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
        """
        return pulumi.get(self, "match_labels")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecApplicationSelectorLabelSelectorMatchExpressions(dict):
    """
    A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
    """
    def __init__(__self__, *,
                 key: str,
                 operator: str,
                 values: Optional[Sequence[str]] = None):
        """
        A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.
        :param str key: key is the label key that the selector applies to.
        :param str operator: operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.
        :param Sequence[str] values: values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "operator", operator)
        if values is not None:
            pulumi.set(__self__, "values", values)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        key is the label key that the selector applies to.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def operator(self) -> str:
        """
        operator represents a key's relationship to a set of values. Valid operators are In, NotIn, Exists and DoesNotExist.
        """
        return pulumi.get(self, "operator")

    @property
    @pulumi.getter
    def values(self) -> Optional[Sequence[str]]:
        """
        values is an array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
        """
        return pulumi.get(self, "values")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecBackingServiceSelector(dict):
    """
    BackingServiceSelector is used to identify the backing service operator. Deprecation Notice: In the upcoming release, this field would be depcreated. It would be mandatory to set "backingServiceSelectors".
    """
    def __init__(__self__, *,
                 group: str,
                 kind: str,
                 resource_ref: str,
                 version: str,
                 env_var_prefix: Optional[str] = None,
                 id: Optional[str] = None,
                 namespace: Optional[str] = None):
        """
        BackingServiceSelector is used to identify the backing service operator. Deprecation Notice: In the upcoming release, this field would be depcreated. It would be mandatory to set "backingServiceSelectors".
        """
        pulumi.set(__self__, "group", group)
        pulumi.set(__self__, "kind", kind)
        pulumi.set(__self__, "resource_ref", resource_ref)
        pulumi.set(__self__, "version", version)
        if env_var_prefix is not None:
            pulumi.set(__self__, "env_var_prefix", env_var_prefix)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)

    @property
    @pulumi.getter
    def group(self) -> str:
        return pulumi.get(self, "group")

    @property
    @pulumi.getter
    def kind(self) -> str:
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter(name="resourceRef")
    def resource_ref(self) -> str:
        return pulumi.get(self, "resource_ref")

    @property
    @pulumi.getter
    def version(self) -> str:
        return pulumi.get(self, "version")

    @property
    @pulumi.getter(name="envVarPrefix")
    def env_var_prefix(self) -> Optional[str]:
        return pulumi.get(self, "env_var_prefix")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def namespace(self) -> Optional[str]:
        return pulumi.get(self, "namespace")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecBackingServiceSelectors(dict):
    """
    BackingServiceSelector defines the selector based on resource name, version, and resource kind
    """
    def __init__(__self__, *,
                 group: str,
                 kind: str,
                 resource_ref: str,
                 version: str,
                 env_var_prefix: Optional[str] = None,
                 id: Optional[str] = None,
                 namespace: Optional[str] = None):
        """
        BackingServiceSelector defines the selector based on resource name, version, and resource kind
        """
        pulumi.set(__self__, "group", group)
        pulumi.set(__self__, "kind", kind)
        pulumi.set(__self__, "resource_ref", resource_ref)
        pulumi.set(__self__, "version", version)
        if env_var_prefix is not None:
            pulumi.set(__self__, "env_var_prefix", env_var_prefix)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)

    @property
    @pulumi.getter
    def group(self) -> str:
        return pulumi.get(self, "group")

    @property
    @pulumi.getter
    def kind(self) -> str:
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter(name="resourceRef")
    def resource_ref(self) -> str:
        return pulumi.get(self, "resource_ref")

    @property
    @pulumi.getter
    def version(self) -> str:
        return pulumi.get(self, "version")

    @property
    @pulumi.getter(name="envVarPrefix")
    def env_var_prefix(self) -> Optional[str]:
        return pulumi.get(self, "env_var_prefix")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def namespace(self) -> Optional[str]:
        return pulumi.get(self, "namespace")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecCustomEnvVar(dict):
    """
    EnvVar represents an environment variable present in a Container.
    """
    def __init__(__self__, *,
                 name: str,
                 value: Optional[str] = None,
                 value_from: Optional['outputs.ServiceBindingRequestSpecCustomEnvVarValueFrom'] = None):
        """
        EnvVar represents an environment variable present in a Container.
        :param str name: Name of the environment variable. Must be a C_IDENTIFIER.
        :param str value: Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".
        :param 'ServiceBindingRequestSpecCustomEnvVarValueFromArgs' value_from: Source for the environment variable's value. Cannot be used if value is not empty.
        """
        pulumi.set(__self__, "name", name)
        if value is not None:
            pulumi.set(__self__, "value", value)
        if value_from is not None:
            pulumi.set(__self__, "value_from", value_from)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the environment variable. Must be a C_IDENTIFIER.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        """
        Variable references $(VAR_NAME) are expanded using the previous defined environment variables in the container and any service environment variables. If a variable cannot be resolved, the reference in the input string will be unchanged. The $(VAR_NAME) syntax can be escaped with a double $$, ie: $$(VAR_NAME). Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".
        """
        return pulumi.get(self, "value")

    @property
    @pulumi.getter(name="valueFrom")
    def value_from(self) -> Optional['outputs.ServiceBindingRequestSpecCustomEnvVarValueFrom']:
        """
        Source for the environment variable's value. Cannot be used if value is not empty.
        """
        return pulumi.get(self, "value_from")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecCustomEnvVarValueFrom(dict):
    """
    Source for the environment variable's value. Cannot be used if value is not empty.
    """
    def __init__(__self__, *,
                 config_map_key_ref: Optional['outputs.ServiceBindingRequestSpecCustomEnvVarValueFromConfigMapKeyRef'] = None,
                 field_ref: Optional['outputs.ServiceBindingRequestSpecCustomEnvVarValueFromFieldRef'] = None,
                 resource_field_ref: Optional['outputs.ServiceBindingRequestSpecCustomEnvVarValueFromResourceFieldRef'] = None,
                 secret_key_ref: Optional['outputs.ServiceBindingRequestSpecCustomEnvVarValueFromSecretKeyRef'] = None):
        """
        Source for the environment variable's value. Cannot be used if value is not empty.
        :param 'ServiceBindingRequestSpecCustomEnvVarValueFromConfigMapKeyRefArgs' config_map_key_ref: Selects a key of a ConfigMap.
        :param 'ServiceBindingRequestSpecCustomEnvVarValueFromFieldRefArgs' field_ref: Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.
        :param 'ServiceBindingRequestSpecCustomEnvVarValueFromResourceFieldRefArgs' resource_field_ref: Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
        :param 'ServiceBindingRequestSpecCustomEnvVarValueFromSecretKeyRefArgs' secret_key_ref: Selects a key of a secret in the pod's namespace
        """
        if config_map_key_ref is not None:
            pulumi.set(__self__, "config_map_key_ref", config_map_key_ref)
        if field_ref is not None:
            pulumi.set(__self__, "field_ref", field_ref)
        if resource_field_ref is not None:
            pulumi.set(__self__, "resource_field_ref", resource_field_ref)
        if secret_key_ref is not None:
            pulumi.set(__self__, "secret_key_ref", secret_key_ref)

    @property
    @pulumi.getter(name="configMapKeyRef")
    def config_map_key_ref(self) -> Optional['outputs.ServiceBindingRequestSpecCustomEnvVarValueFromConfigMapKeyRef']:
        """
        Selects a key of a ConfigMap.
        """
        return pulumi.get(self, "config_map_key_ref")

    @property
    @pulumi.getter(name="fieldRef")
    def field_ref(self) -> Optional['outputs.ServiceBindingRequestSpecCustomEnvVarValueFromFieldRef']:
        """
        Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.
        """
        return pulumi.get(self, "field_ref")

    @property
    @pulumi.getter(name="resourceFieldRef")
    def resource_field_ref(self) -> Optional['outputs.ServiceBindingRequestSpecCustomEnvVarValueFromResourceFieldRef']:
        """
        Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
        """
        return pulumi.get(self, "resource_field_ref")

    @property
    @pulumi.getter(name="secretKeyRef")
    def secret_key_ref(self) -> Optional['outputs.ServiceBindingRequestSpecCustomEnvVarValueFromSecretKeyRef']:
        """
        Selects a key of a secret in the pod's namespace
        """
        return pulumi.get(self, "secret_key_ref")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecCustomEnvVarValueFromConfigMapKeyRef(dict):
    """
    Selects a key of a ConfigMap.
    """
    def __init__(__self__, *,
                 key: str,
                 name: Optional[str] = None,
                 optional: Optional[bool] = None):
        """
        Selects a key of a ConfigMap.
        :param str key: The key to select.
        :param str name: Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        :param bool optional: Specify whether the ConfigMap or its key must be defined
        """
        pulumi.set(__self__, "key", key)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if optional is not None:
            pulumi.set(__self__, "optional", optional)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        The key to select.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def optional(self) -> Optional[bool]:
        """
        Specify whether the ConfigMap or its key must be defined
        """
        return pulumi.get(self, "optional")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecCustomEnvVarValueFromFieldRef(dict):
    """
    Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.
    """
    def __init__(__self__, *,
                 field_path: str,
                 api_version: Optional[str] = None):
        """
        Selects a field of the pod: supports metadata.name, metadata.namespace, metadata.labels, metadata.annotations, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP.
        :param str field_path: Path of the field to select in the specified API version.
        :param str api_version: Version of the schema the FieldPath is written in terms of, defaults to "v1".
        """
        pulumi.set(__self__, "field_path", field_path)
        if api_version is not None:
            pulumi.set(__self__, "api_version", api_version)

    @property
    @pulumi.getter(name="fieldPath")
    def field_path(self) -> str:
        """
        Path of the field to select in the specified API version.
        """
        return pulumi.get(self, "field_path")

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> Optional[str]:
        """
        Version of the schema the FieldPath is written in terms of, defaults to "v1".
        """
        return pulumi.get(self, "api_version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecCustomEnvVarValueFromResourceFieldRef(dict):
    """
    Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
    """
    def __init__(__self__, *,
                 resource: str,
                 container_name: Optional[str] = None,
                 divisor: Optional[str] = None):
        """
        Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
        :param str resource: Required: resource to select
        :param str container_name: Container name: required for volumes, optional for env vars
        :param str divisor: Specifies the output format of the exposed resources, defaults to "1"
        """
        pulumi.set(__self__, "resource", resource)
        if container_name is not None:
            pulumi.set(__self__, "container_name", container_name)
        if divisor is not None:
            pulumi.set(__self__, "divisor", divisor)

    @property
    @pulumi.getter
    def resource(self) -> str:
        """
        Required: resource to select
        """
        return pulumi.get(self, "resource")

    @property
    @pulumi.getter(name="containerName")
    def container_name(self) -> Optional[str]:
        """
        Container name: required for volumes, optional for env vars
        """
        return pulumi.get(self, "container_name")

    @property
    @pulumi.getter
    def divisor(self) -> Optional[str]:
        """
        Specifies the output format of the exposed resources, defaults to "1"
        """
        return pulumi.get(self, "divisor")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestSpecCustomEnvVarValueFromSecretKeyRef(dict):
    """
    Selects a key of a secret in the pod's namespace
    """
    def __init__(__self__, *,
                 key: str,
                 name: Optional[str] = None,
                 optional: Optional[bool] = None):
        """
        Selects a key of a secret in the pod's namespace
        :param str key: The key of the secret to select from.  Must be a valid secret key.
        :param str name: Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        :param bool optional: Specify whether the Secret or its key must be defined
        """
        pulumi.set(__self__, "key", key)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if optional is not None:
            pulumi.set(__self__, "optional", optional)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        The key of the secret to select from.  Must be a valid secret key.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def optional(self) -> Optional[bool]:
        """
        Specify whether the Secret or its key must be defined
        """
        return pulumi.get(self, "optional")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestStatus(dict):
    """
    ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
    """
    def __init__(__self__, *,
                 conditions: Sequence['outputs.ServiceBindingRequestStatusConditions'],
                 secret: str,
                 applications: Optional[Sequence['outputs.ServiceBindingRequestStatusApplications']] = None):
        """
        ServiceBindingRequestStatus defines the observed state of ServiceBindingRequest
        :param Sequence['ServiceBindingRequestStatusConditionsArgs'] conditions: Conditions describes the state of the operator's reconciliation functionality.
        :param str secret: Secret is the name of the intermediate secret
        :param Sequence['ServiceBindingRequestStatusApplicationsArgs'] applications: Applications contain all the applications filtered by name or label
        """
        pulumi.set(__self__, "conditions", conditions)
        pulumi.set(__self__, "secret", secret)
        if applications is not None:
            pulumi.set(__self__, "applications", applications)

    @property
    @pulumi.getter
    def conditions(self) -> Sequence['outputs.ServiceBindingRequestStatusConditions']:
        """
        Conditions describes the state of the operator's reconciliation functionality.
        """
        return pulumi.get(self, "conditions")

    @property
    @pulumi.getter
    def secret(self) -> str:
        """
        Secret is the name of the intermediate secret
        """
        return pulumi.get(self, "secret")

    @property
    @pulumi.getter
    def applications(self) -> Optional[Sequence['outputs.ServiceBindingRequestStatusApplications']]:
        """
        Applications contain all the applications filtered by name or label
        """
        return pulumi.get(self, "applications")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestStatusApplications(dict):
    """
    BoundApplication defines the application workloads to which the binding secret has injected.
    """
    def __init__(__self__, *,
                 group: str,
                 kind: str,
                 version: str,
                 name: Optional[str] = None):
        """
        BoundApplication defines the application workloads to which the binding secret has injected.
        :param str name: Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        """
        pulumi.set(__self__, "group", group)
        pulumi.set(__self__, "kind", kind)
        pulumi.set(__self__, "version", version)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def group(self) -> str:
        return pulumi.get(self, "group")

    @property
    @pulumi.getter
    def kind(self) -> str:
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def version(self) -> str:
        return pulumi.get(self, "version")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names TODO: Add other useful fields. apiVersion, kind, uid?
        """
        return pulumi.get(self, "name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ServiceBindingRequestStatusConditions(dict):
    """
    Condition represents the state of the operator's reconciliation functionality.
    """
    def __init__(__self__, *,
                 status: str,
                 type: str,
                 last_heartbeat_time: Optional[str] = None,
                 last_transition_time: Optional[str] = None,
                 message: Optional[str] = None,
                 reason: Optional[str] = None):
        """
        Condition represents the state of the operator's reconciliation functionality.
        :param str type: ConditionType is the state of the operator's reconciliation functionality.
        """
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "type", type)
        if last_heartbeat_time is not None:
            pulumi.set(__self__, "last_heartbeat_time", last_heartbeat_time)
        if last_transition_time is not None:
            pulumi.set(__self__, "last_transition_time", last_transition_time)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if reason is not None:
            pulumi.set(__self__, "reason", reason)

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        ConditionType is the state of the operator's reconciliation functionality.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="lastHeartbeatTime")
    def last_heartbeat_time(self) -> Optional[str]:
        return pulumi.get(self, "last_heartbeat_time")

    @property
    @pulumi.getter(name="lastTransitionTime")
    def last_transition_time(self) -> Optional[str]:
        return pulumi.get(self, "last_transition_time")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def reason(self) -> Optional[str]:
        return pulumi.get(self, "reason")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


