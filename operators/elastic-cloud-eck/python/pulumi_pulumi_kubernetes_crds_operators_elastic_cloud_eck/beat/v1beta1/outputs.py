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
    'BeatSpec',
    'BeatSpecConfigRef',
    'BeatSpecDaemonSet',
    'BeatSpecDeployment',
    'BeatSpecElasticsearchRef',
    'BeatSpecKibanaRef',
    'BeatSpecSecureSettings',
    'BeatSpecSecureSettingsEntries',
    'BeatStatus',
]

@pulumi.output_type
class BeatSpec(dict):
    """
    BeatSpec defines the desired state of a Beat.
    """
    def __init__(__self__, *,
                 type: str,
                 version: str,
                 config: Optional[Mapping[str, Any]] = None,
                 config_ref: Optional['outputs.BeatSpecConfigRef'] = None,
                 daemon_set: Optional['outputs.BeatSpecDaemonSet'] = None,
                 deployment: Optional['outputs.BeatSpecDeployment'] = None,
                 elasticsearch_ref: Optional['outputs.BeatSpecElasticsearchRef'] = None,
                 image: Optional[str] = None,
                 kibana_ref: Optional['outputs.BeatSpecKibanaRef'] = None,
                 secure_settings: Optional[Sequence['outputs.BeatSpecSecureSettings']] = None,
                 service_account_name: Optional[str] = None):
        """
        BeatSpec defines the desired state of a Beat.
        :param str type: Type is the type of the Beat to deploy (filebeat, metricbeat, heartbeat, auditbeat, journalbeat, packetbeat, etc.). Any string can be used, but well-known types will have the image field defaulted and have the appropriate Elasticsearch roles created automatically. It also allows for dashboard setup when combined with a `KibanaRef`.
        :param str version: Version of the Beat.
        :param Mapping[str, Any] config: Config holds the Beat configuration. At most one of [`Config`, `ConfigRef`] can be specified.
        :param 'BeatSpecConfigRefArgs' config_ref: ConfigRef contains a reference to an existing Kubernetes Secret holding the Beat configuration. Beat settings must be specified as yaml, under a single "beat.yml" entry. At most one of [`Config`, `ConfigRef`] can be specified.
        :param 'BeatSpecDaemonSetArgs' daemon_set: DaemonSet specifies the Beat should be deployed as a DaemonSet, and allows providing its spec. Cannot be used along with `deployment`. If both are absent a default for the Type is used.
        :param 'BeatSpecDeploymentArgs' deployment: Deployment specifies the Beat should be deployed as a Deployment, and allows providing its spec. Cannot be used along with `daemonSet`. If both are absent a default for the Type is used.
        :param 'BeatSpecElasticsearchRefArgs' elasticsearch_ref: ElasticsearchRef is a reference to an Elasticsearch cluster running in the same Kubernetes cluster.
        :param str image: Image is the Beat Docker image to deploy. Version and Type have to match the Beat in the image.
        :param 'BeatSpecKibanaRefArgs' kibana_ref: KibanaRef is a reference to a Kibana instance running in the same Kubernetes cluster. It allows automatic setup of dashboards and visualizations.
        :param Sequence['BeatSpecSecureSettingsArgs'] secure_settings: SecureSettings is a list of references to Kubernetes Secrets containing sensitive configuration options for the Beat. Secrets data can be then referenced in the Beat config using the Secret's keys or as specified in `Entries` field of each SecureSetting.
        :param str service_account_name: ServiceAccountName is used to check access from the current resource to Elasticsearch resource in a different namespace. Can only be used if ECK is enforcing RBAC on references.
        """
        pulumi.set(__self__, "type", type)
        pulumi.set(__self__, "version", version)
        if config is not None:
            pulumi.set(__self__, "config", config)
        if config_ref is not None:
            pulumi.set(__self__, "config_ref", config_ref)
        if daemon_set is not None:
            pulumi.set(__self__, "daemon_set", daemon_set)
        if deployment is not None:
            pulumi.set(__self__, "deployment", deployment)
        if elasticsearch_ref is not None:
            pulumi.set(__self__, "elasticsearch_ref", elasticsearch_ref)
        if image is not None:
            pulumi.set(__self__, "image", image)
        if kibana_ref is not None:
            pulumi.set(__self__, "kibana_ref", kibana_ref)
        if secure_settings is not None:
            pulumi.set(__self__, "secure_settings", secure_settings)
        if service_account_name is not None:
            pulumi.set(__self__, "service_account_name", service_account_name)

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type is the type of the Beat to deploy (filebeat, metricbeat, heartbeat, auditbeat, journalbeat, packetbeat, etc.). Any string can be used, but well-known types will have the image field defaulted and have the appropriate Elasticsearch roles created automatically. It also allows for dashboard setup when combined with a `KibanaRef`.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def version(self) -> str:
        """
        Version of the Beat.
        """
        return pulumi.get(self, "version")

    @property
    @pulumi.getter
    def config(self) -> Optional[Mapping[str, Any]]:
        """
        Config holds the Beat configuration. At most one of [`Config`, `ConfigRef`] can be specified.
        """
        return pulumi.get(self, "config")

    @property
    @pulumi.getter(name="configRef")
    def config_ref(self) -> Optional['outputs.BeatSpecConfigRef']:
        """
        ConfigRef contains a reference to an existing Kubernetes Secret holding the Beat configuration. Beat settings must be specified as yaml, under a single "beat.yml" entry. At most one of [`Config`, `ConfigRef`] can be specified.
        """
        return pulumi.get(self, "config_ref")

    @property
    @pulumi.getter(name="daemonSet")
    def daemon_set(self) -> Optional['outputs.BeatSpecDaemonSet']:
        """
        DaemonSet specifies the Beat should be deployed as a DaemonSet, and allows providing its spec. Cannot be used along with `deployment`. If both are absent a default for the Type is used.
        """
        return pulumi.get(self, "daemon_set")

    @property
    @pulumi.getter
    def deployment(self) -> Optional['outputs.BeatSpecDeployment']:
        """
        Deployment specifies the Beat should be deployed as a Deployment, and allows providing its spec. Cannot be used along with `daemonSet`. If both are absent a default for the Type is used.
        """
        return pulumi.get(self, "deployment")

    @property
    @pulumi.getter(name="elasticsearchRef")
    def elasticsearch_ref(self) -> Optional['outputs.BeatSpecElasticsearchRef']:
        """
        ElasticsearchRef is a reference to an Elasticsearch cluster running in the same Kubernetes cluster.
        """
        return pulumi.get(self, "elasticsearch_ref")

    @property
    @pulumi.getter
    def image(self) -> Optional[str]:
        """
        Image is the Beat Docker image to deploy. Version and Type have to match the Beat in the image.
        """
        return pulumi.get(self, "image")

    @property
    @pulumi.getter(name="kibanaRef")
    def kibana_ref(self) -> Optional['outputs.BeatSpecKibanaRef']:
        """
        KibanaRef is a reference to a Kibana instance running in the same Kubernetes cluster. It allows automatic setup of dashboards and visualizations.
        """
        return pulumi.get(self, "kibana_ref")

    @property
    @pulumi.getter(name="secureSettings")
    def secure_settings(self) -> Optional[Sequence['outputs.BeatSpecSecureSettings']]:
        """
        SecureSettings is a list of references to Kubernetes Secrets containing sensitive configuration options for the Beat. Secrets data can be then referenced in the Beat config using the Secret's keys or as specified in `Entries` field of each SecureSetting.
        """
        return pulumi.get(self, "secure_settings")

    @property
    @pulumi.getter(name="serviceAccountName")
    def service_account_name(self) -> Optional[str]:
        """
        ServiceAccountName is used to check access from the current resource to Elasticsearch resource in a different namespace. Can only be used if ECK is enforcing RBAC on references.
        """
        return pulumi.get(self, "service_account_name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BeatSpecConfigRef(dict):
    """
    ConfigRef contains a reference to an existing Kubernetes Secret holding the Beat configuration. Beat settings must be specified as yaml, under a single "beat.yml" entry. At most one of [`Config`, `ConfigRef`] can be specified.
    """
    def __init__(__self__, *,
                 secret_name: Optional[str] = None):
        """
        ConfigRef contains a reference to an existing Kubernetes Secret holding the Beat configuration. Beat settings must be specified as yaml, under a single "beat.yml" entry. At most one of [`Config`, `ConfigRef`] can be specified.
        :param str secret_name: SecretName is the name of the secret.
        """
        if secret_name is not None:
            pulumi.set(__self__, "secret_name", secret_name)

    @property
    @pulumi.getter(name="secretName")
    def secret_name(self) -> Optional[str]:
        """
        SecretName is the name of the secret.
        """
        return pulumi.get(self, "secret_name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BeatSpecDaemonSet(dict):
    """
    DaemonSet specifies the Beat should be deployed as a DaemonSet, and allows providing its spec. Cannot be used along with `deployment`. If both are absent a default for the Type is used.
    """
    def __init__(__self__):
        """
        DaemonSet specifies the Beat should be deployed as a DaemonSet, and allows providing its spec. Cannot be used along with `deployment`. If both are absent a default for the Type is used.
        """
        pass

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BeatSpecDeployment(dict):
    """
    Deployment specifies the Beat should be deployed as a Deployment, and allows providing its spec. Cannot be used along with `daemonSet`. If both are absent a default for the Type is used.
    """
    def __init__(__self__, *,
                 replicas: Optional[int] = None):
        """
        Deployment specifies the Beat should be deployed as a Deployment, and allows providing its spec. Cannot be used along with `daemonSet`. If both are absent a default for the Type is used.
        """
        if replicas is not None:
            pulumi.set(__self__, "replicas", replicas)

    @property
    @pulumi.getter
    def replicas(self) -> Optional[int]:
        return pulumi.get(self, "replicas")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BeatSpecElasticsearchRef(dict):
    """
    ElasticsearchRef is a reference to an Elasticsearch cluster running in the same Kubernetes cluster.
    """
    def __init__(__self__, *,
                 name: str,
                 namespace: Optional[str] = None):
        """
        ElasticsearchRef is a reference to an Elasticsearch cluster running in the same Kubernetes cluster.
        :param str name: Name of the Kubernetes object.
        :param str namespace: Namespace of the Kubernetes object. If empty, defaults to the current namespace.
        """
        pulumi.set(__self__, "name", name)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the Kubernetes object.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def namespace(self) -> Optional[str]:
        """
        Namespace of the Kubernetes object. If empty, defaults to the current namespace.
        """
        return pulumi.get(self, "namespace")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BeatSpecKibanaRef(dict):
    """
    KibanaRef is a reference to a Kibana instance running in the same Kubernetes cluster. It allows automatic setup of dashboards and visualizations.
    """
    def __init__(__self__, *,
                 name: str,
                 namespace: Optional[str] = None):
        """
        KibanaRef is a reference to a Kibana instance running in the same Kubernetes cluster. It allows automatic setup of dashboards and visualizations.
        :param str name: Name of the Kubernetes object.
        :param str namespace: Namespace of the Kubernetes object. If empty, defaults to the current namespace.
        """
        pulumi.set(__self__, "name", name)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the Kubernetes object.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def namespace(self) -> Optional[str]:
        """
        Namespace of the Kubernetes object. If empty, defaults to the current namespace.
        """
        return pulumi.get(self, "namespace")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BeatSpecSecureSettings(dict):
    """
    SecretSource defines a data source based on a Kubernetes Secret.
    """
    def __init__(__self__, *,
                 secret_name: str,
                 entries: Optional[Sequence['outputs.BeatSpecSecureSettingsEntries']] = None):
        """
        SecretSource defines a data source based on a Kubernetes Secret.
        :param str secret_name: SecretName is the name of the secret.
        :param Sequence['BeatSpecSecureSettingsEntriesArgs'] entries: Entries define how to project each key-value pair in the secret to filesystem paths. If not defined, all keys will be projected to similarly named paths in the filesystem. If defined, only the specified keys will be projected to the corresponding paths.
        """
        pulumi.set(__self__, "secret_name", secret_name)
        if entries is not None:
            pulumi.set(__self__, "entries", entries)

    @property
    @pulumi.getter(name="secretName")
    def secret_name(self) -> str:
        """
        SecretName is the name of the secret.
        """
        return pulumi.get(self, "secret_name")

    @property
    @pulumi.getter
    def entries(self) -> Optional[Sequence['outputs.BeatSpecSecureSettingsEntries']]:
        """
        Entries define how to project each key-value pair in the secret to filesystem paths. If not defined, all keys will be projected to similarly named paths in the filesystem. If defined, only the specified keys will be projected to the corresponding paths.
        """
        return pulumi.get(self, "entries")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BeatSpecSecureSettingsEntries(dict):
    """
    KeyToPath defines how to map a key in a Secret object to a filesystem path.
    """
    def __init__(__self__, *,
                 key: str,
                 path: Optional[str] = None):
        """
        KeyToPath defines how to map a key in a Secret object to a filesystem path.
        :param str key: Key is the key contained in the secret.
        :param str path: Path is the relative file path to map the key to. Path must not be an absolute file path and must not contain any ".." components.
        """
        pulumi.set(__self__, "key", key)
        if path is not None:
            pulumi.set(__self__, "path", path)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        Key is the key contained in the secret.
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def path(self) -> Optional[str]:
        """
        Path is the relative file path to map the key to. Path must not be an absolute file path and must not contain any ".." components.
        """
        return pulumi.get(self, "path")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class BeatStatus(dict):
    """
    BeatStatus defines the observed state of a Beat.
    """
    def __init__(__self__, *,
                 available_nodes: Optional[int] = None,
                 elasticsearch_association_status: Optional[str] = None,
                 expected_nodes: Optional[int] = None,
                 health: Optional[str] = None,
                 kibana_association_status: Optional[str] = None):
        """
        BeatStatus defines the observed state of a Beat.
        :param str elasticsearch_association_status: AssociationStatus is the status of an association resource.
        :param str kibana_association_status: AssociationStatus is the status of an association resource.
        """
        if available_nodes is not None:
            pulumi.set(__self__, "available_nodes", available_nodes)
        if elasticsearch_association_status is not None:
            pulumi.set(__self__, "elasticsearch_association_status", elasticsearch_association_status)
        if expected_nodes is not None:
            pulumi.set(__self__, "expected_nodes", expected_nodes)
        if health is not None:
            pulumi.set(__self__, "health", health)
        if kibana_association_status is not None:
            pulumi.set(__self__, "kibana_association_status", kibana_association_status)

    @property
    @pulumi.getter(name="availableNodes")
    def available_nodes(self) -> Optional[int]:
        return pulumi.get(self, "available_nodes")

    @property
    @pulumi.getter(name="elasticsearchAssociationStatus")
    def elasticsearch_association_status(self) -> Optional[str]:
        """
        AssociationStatus is the status of an association resource.
        """
        return pulumi.get(self, "elasticsearch_association_status")

    @property
    @pulumi.getter(name="expectedNodes")
    def expected_nodes(self) -> Optional[int]:
        return pulumi.get(self, "expected_nodes")

    @property
    @pulumi.getter
    def health(self) -> Optional[str]:
        return pulumi.get(self, "health")

    @property
    @pulumi.getter(name="kibanaAssociationStatus")
    def kibana_association_status(self) -> Optional[str]:
        """
        AssociationStatus is the status of an association resource.
        """
        return pulumi.get(self, "kibana_association_status")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


