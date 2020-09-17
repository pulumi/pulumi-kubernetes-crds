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
    'ClusterInstallationSpec',
    'ClusterInstallationSpecDatabase',
    'ClusterInstallationSpecElasticSearch',
    'ClusterInstallationSpecMinio',
    'ClusterInstallationStatus',
]

@pulumi.output_type
class ClusterInstallationSpec(dict):
    """
    Specification of the desired behavior of the Mattermost cluster. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/api-conventions.md#spec-and-status
    """
    def __init__(__self__, *,
                 ingress_name: str,
                 affinity: Optional[Mapping[str, Any]] = None,
                 database: Optional['outputs.ClusterInstallationSpecDatabase'] = None,
                 elastic_search: Optional['outputs.ClusterInstallationSpecElasticSearch'] = None,
                 image: Optional[str] = None,
                 ingress_annotations: Optional[Mapping[str, str]] = None,
                 mattermost_license_secret: Optional[str] = None,
                 minio: Optional['outputs.ClusterInstallationSpecMinio'] = None,
                 node_selector: Optional[Mapping[str, str]] = None,
                 replicas: Optional[int] = None,
                 resources: Optional[Mapping[str, Any]] = None,
                 service_annotations: Optional[Mapping[str, str]] = None,
                 size: Optional[str] = None,
                 use_service_load_balancer: Optional[bool] = None,
                 version: Optional[str] = None):
        """
        Specification of the desired behavior of the Mattermost cluster. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/api-conventions.md#spec-and-status
        :param str ingress_name: IngressName defines the name to be used when creating the ingress rules
        :param Mapping[str, Any] affinity: If specified, affinity will define the pod's scheduling constraints
        :param str image: Image defines the ClusterInstallation Docker image.
        :param str mattermost_license_secret: Secret that contains the mattermost license
        :param Mapping[str, str] node_selector: NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        :param int replicas: Replicas defines the number of replicas to use for the Mattermost app servers. Setting this will override the number of replicas set by 'Size'.
        :param Mapping[str, Any] resources: Defines the resource requests and limits for the Mattermost app server pods.
        :param str size: Size defines the size of the ClusterInstallation. This is typically specified in number of users. This will set replica and resource requests/limits appropriately for the provided number of users. Accepted values are: 100users, 1000users, 5000users, 10000users, 250000users. Defaults to 5000users. Setting 'Replicas', 'Resources', 'Minio.Replicas', 'Minio.Resource', 'Database.Replicas', or 'Database.Resources' will override the values set by Size.
        :param str version: Version defines the ClusterInstallation Docker image version.
        """
        pulumi.set(__self__, "ingress_name", ingress_name)
        if affinity is not None:
            pulumi.set(__self__, "affinity", affinity)
        if database is not None:
            pulumi.set(__self__, "database", database)
        if elastic_search is not None:
            pulumi.set(__self__, "elastic_search", elastic_search)
        if image is not None:
            pulumi.set(__self__, "image", image)
        if ingress_annotations is not None:
            pulumi.set(__self__, "ingress_annotations", ingress_annotations)
        if mattermost_license_secret is not None:
            pulumi.set(__self__, "mattermost_license_secret", mattermost_license_secret)
        if minio is not None:
            pulumi.set(__self__, "minio", minio)
        if node_selector is not None:
            pulumi.set(__self__, "node_selector", node_selector)
        if replicas is not None:
            pulumi.set(__self__, "replicas", replicas)
        if resources is not None:
            pulumi.set(__self__, "resources", resources)
        if service_annotations is not None:
            pulumi.set(__self__, "service_annotations", service_annotations)
        if size is not None:
            pulumi.set(__self__, "size", size)
        if use_service_load_balancer is not None:
            pulumi.set(__self__, "use_service_load_balancer", use_service_load_balancer)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="ingressName")
    def ingress_name(self) -> str:
        """
        IngressName defines the name to be used when creating the ingress rules
        """
        return pulumi.get(self, "ingress_name")

    @property
    @pulumi.getter
    def affinity(self) -> Optional[Mapping[str, Any]]:
        """
        If specified, affinity will define the pod's scheduling constraints
        """
        return pulumi.get(self, "affinity")

    @property
    @pulumi.getter
    def database(self) -> Optional['outputs.ClusterInstallationSpecDatabase']:
        return pulumi.get(self, "database")

    @property
    @pulumi.getter(name="elasticSearch")
    def elastic_search(self) -> Optional['outputs.ClusterInstallationSpecElasticSearch']:
        return pulumi.get(self, "elastic_search")

    @property
    @pulumi.getter
    def image(self) -> Optional[str]:
        """
        Image defines the ClusterInstallation Docker image.
        """
        return pulumi.get(self, "image")

    @property
    @pulumi.getter(name="ingressAnnotations")
    def ingress_annotations(self) -> Optional[Mapping[str, str]]:
        return pulumi.get(self, "ingress_annotations")

    @property
    @pulumi.getter(name="mattermostLicenseSecret")
    def mattermost_license_secret(self) -> Optional[str]:
        """
        Secret that contains the mattermost license
        """
        return pulumi.get(self, "mattermost_license_secret")

    @property
    @pulumi.getter
    def minio(self) -> Optional['outputs.ClusterInstallationSpecMinio']:
        return pulumi.get(self, "minio")

    @property
    @pulumi.getter(name="nodeSelector")
    def node_selector(self) -> Optional[Mapping[str, str]]:
        """
        NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        """
        return pulumi.get(self, "node_selector")

    @property
    @pulumi.getter
    def replicas(self) -> Optional[int]:
        """
        Replicas defines the number of replicas to use for the Mattermost app servers. Setting this will override the number of replicas set by 'Size'.
        """
        return pulumi.get(self, "replicas")

    @property
    @pulumi.getter
    def resources(self) -> Optional[Mapping[str, Any]]:
        """
        Defines the resource requests and limits for the Mattermost app server pods.
        """
        return pulumi.get(self, "resources")

    @property
    @pulumi.getter(name="serviceAnnotations")
    def service_annotations(self) -> Optional[Mapping[str, str]]:
        return pulumi.get(self, "service_annotations")

    @property
    @pulumi.getter
    def size(self) -> Optional[str]:
        """
        Size defines the size of the ClusterInstallation. This is typically specified in number of users. This will set replica and resource requests/limits appropriately for the provided number of users. Accepted values are: 100users, 1000users, 5000users, 10000users, 250000users. Defaults to 5000users. Setting 'Replicas', 'Resources', 'Minio.Replicas', 'Minio.Resource', 'Database.Replicas', or 'Database.Resources' will override the values set by Size.
        """
        return pulumi.get(self, "size")

    @property
    @pulumi.getter(name="useServiceLoadBalancer")
    def use_service_load_balancer(self) -> Optional[bool]:
        return pulumi.get(self, "use_service_load_balancer")

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        """
        Version defines the ClusterInstallation Docker image version.
        """
        return pulumi.get(self, "version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterInstallationSpecDatabase(dict):
    def __init__(__self__, *,
                 external_secret: Optional[str] = None,
                 replicas: Optional[int] = None,
                 resources: Optional[Mapping[str, Any]] = None,
                 storage_size: Optional[str] = None,
                 type: Optional[str] = None):
        """
        :param str external_secret: If the user want to use an external DB. This can be inside the same k8s cluster or outside like AWS RDS.
        :param int replicas: Defines the number of database replicas. For redundancy use at least 2 replicas. Setting this will override the number of replicas set by 'Size'.
        :param Mapping[str, Any] resources: Defines the resource requests and limits for the database pods.
        :param str storage_size: Defines the storage size for the database. ie 50Gi
        """
        if external_secret is not None:
            pulumi.set(__self__, "external_secret", external_secret)
        if replicas is not None:
            pulumi.set(__self__, "replicas", replicas)
        if resources is not None:
            pulumi.set(__self__, "resources", resources)
        if storage_size is not None:
            pulumi.set(__self__, "storage_size", storage_size)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="externalSecret")
    def external_secret(self) -> Optional[str]:
        """
        If the user want to use an external DB. This can be inside the same k8s cluster or outside like AWS RDS.
        """
        return pulumi.get(self, "external_secret")

    @property
    @pulumi.getter
    def replicas(self) -> Optional[int]:
        """
        Defines the number of database replicas. For redundancy use at least 2 replicas. Setting this will override the number of replicas set by 'Size'.
        """
        return pulumi.get(self, "replicas")

    @property
    @pulumi.getter
    def resources(self) -> Optional[Mapping[str, Any]]:
        """
        Defines the resource requests and limits for the database pods.
        """
        return pulumi.get(self, "resources")

    @property
    @pulumi.getter(name="storageSize")
    def storage_size(self) -> Optional[str]:
        """
        Defines the storage size for the database. ie 50Gi
        """
        return pulumi.get(self, "storage_size")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterInstallationSpecElasticSearch(dict):
    def __init__(__self__, *,
                 host: Optional[str] = None,
                 password: Optional[str] = None,
                 username: Optional[str] = None):
        if host is not None:
            pulumi.set(__self__, "host", host)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def host(self) -> Optional[str]:
        return pulumi.get(self, "host")

    @property
    @pulumi.getter
    def password(self) -> Optional[str]:
        return pulumi.get(self, "password")

    @property
    @pulumi.getter
    def username(self) -> Optional[str]:
        return pulumi.get(self, "username")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterInstallationSpecMinio(dict):
    def __init__(__self__, *,
                 replicas: Optional[int] = None,
                 resources: Optional[Mapping[str, Any]] = None,
                 storage_size: Optional[str] = None):
        """
        :param int replicas: Defines the number of Minio replicas. Supply 1 to run Minio in standalone mode with no redundancy. Supply 4 or more to run Minio in distributed mode. Note that it is not possible to upgrade Minio from standalone to distributed mode. Setting this will override the number of replicas set by 'Size'. More info: https://docs.min.io/docs/distributed-minio-quickstart-guide.html
        :param Mapping[str, Any] resources: Defines the resource requests and limits for the Minio pods.
        :param str storage_size: Defines the storage size for Minio. ie 50Gi
        """
        if replicas is not None:
            pulumi.set(__self__, "replicas", replicas)
        if resources is not None:
            pulumi.set(__self__, "resources", resources)
        if storage_size is not None:
            pulumi.set(__self__, "storage_size", storage_size)

    @property
    @pulumi.getter
    def replicas(self) -> Optional[int]:
        """
        Defines the number of Minio replicas. Supply 1 to run Minio in standalone mode with no redundancy. Supply 4 or more to run Minio in distributed mode. Note that it is not possible to upgrade Minio from standalone to distributed mode. Setting this will override the number of replicas set by 'Size'. More info: https://docs.min.io/docs/distributed-minio-quickstart-guide.html
        """
        return pulumi.get(self, "replicas")

    @property
    @pulumi.getter
    def resources(self) -> Optional[Mapping[str, Any]]:
        """
        Defines the resource requests and limits for the Minio pods.
        """
        return pulumi.get(self, "resources")

    @property
    @pulumi.getter(name="storageSize")
    def storage_size(self) -> Optional[str]:
        """
        Defines the storage size for Minio. ie 50Gi
        """
        return pulumi.get(self, "storage_size")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ClusterInstallationStatus(dict):
    """
    Most recent observed status of the Mattermost cluster. Read-only. Not included when requesting from the apiserver, only from the Mattermost Operator API itself. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/api-conventions.md#spec-and-status
    """
    def __init__(__self__, *,
                 endpoint: Optional[str] = None,
                 image: Optional[str] = None,
                 replicas: Optional[int] = None,
                 state: Optional[str] = None,
                 updated_replicas: Optional[int] = None,
                 version: Optional[str] = None):
        """
        Most recent observed status of the Mattermost cluster. Read-only. Not included when requesting from the apiserver, only from the Mattermost Operator API itself. More info: https://github.com/kubernetes/community/blob/master/contributors/devel/api-conventions.md#spec-and-status
        :param str endpoint: The endpoint to access the Mattermost instance
        :param str image: The image running on the pods in the Mattermost instance
        :param int replicas: Total number of non-terminated pods targeted by this Mattermost deployment
        :param str state: Represents the running state of the Mattermost instance
        :param int updated_replicas: Total number of non-terminated pods targeted by this Mattermost deployment that are running with the desired image.
        :param str version: The version currently running in the Mattermost instance
        """
        if endpoint is not None:
            pulumi.set(__self__, "endpoint", endpoint)
        if image is not None:
            pulumi.set(__self__, "image", image)
        if replicas is not None:
            pulumi.set(__self__, "replicas", replicas)
        if state is not None:
            pulumi.set(__self__, "state", state)
        if updated_replicas is not None:
            pulumi.set(__self__, "updated_replicas", updated_replicas)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def endpoint(self) -> Optional[str]:
        """
        The endpoint to access the Mattermost instance
        """
        return pulumi.get(self, "endpoint")

    @property
    @pulumi.getter
    def image(self) -> Optional[str]:
        """
        The image running on the pods in the Mattermost instance
        """
        return pulumi.get(self, "image")

    @property
    @pulumi.getter
    def replicas(self) -> Optional[int]:
        """
        Total number of non-terminated pods targeted by this Mattermost deployment
        """
        return pulumi.get(self, "replicas")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        """
        Represents the running state of the Mattermost instance
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="updatedReplicas")
    def updated_replicas(self) -> Optional[int]:
        """
        Total number of non-terminated pods targeted by this Mattermost deployment that are running with the desired image.
        """
        return pulumi.get(self, "updated_replicas")

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        """
        The version currently running in the Mattermost instance
        """
        return pulumi.get(self, "version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

