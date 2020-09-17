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
    'CacheSpec',
    'CacheSpecAdminAuth',
    'CacheSpecAdminAuthPassword',
    'CacheSpecAdminAuthUsername',
    'CacheStatus',
    'CacheStatusConditions',
]

@pulumi.output_type
class CacheSpec(dict):
    """
    CacheSpec defines the desired state of Cache
    """
    def __init__(__self__, *,
                 admin_auth: Optional['outputs.CacheSpecAdminAuth'] = None,
                 cluster_name: Optional[str] = None,
                 name: Optional[str] = None,
                 template: Optional[str] = None,
                 template_name: Optional[str] = None):
        """
        CacheSpec defines the desired state of Cache
        :param 'CacheSpecAdminAuthArgs' admin_auth: Authentication info
        :param str cluster_name: Name of the cluster where to create the cache
        :param str name: Name of the cache to be created. If empty ObjectMeta.Name will be used
        :param str template: Cache template in XML format
        :param str template_name: Name of the template to be used to create this cache
        """
        if admin_auth is not None:
            pulumi.set(__self__, "admin_auth", admin_auth)
        if cluster_name is not None:
            pulumi.set(__self__, "cluster_name", cluster_name)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if template is not None:
            pulumi.set(__self__, "template", template)
        if template_name is not None:
            pulumi.set(__self__, "template_name", template_name)

    @property
    @pulumi.getter(name="adminAuth")
    def admin_auth(self) -> Optional['outputs.CacheSpecAdminAuth']:
        """
        Authentication info
        """
        return pulumi.get(self, "admin_auth")

    @property
    @pulumi.getter(name="clusterName")
    def cluster_name(self) -> Optional[str]:
        """
        Name of the cluster where to create the cache
        """
        return pulumi.get(self, "cluster_name")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Name of the cache to be created. If empty ObjectMeta.Name will be used
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def template(self) -> Optional[str]:
        """
        Cache template in XML format
        """
        return pulumi.get(self, "template")

    @property
    @pulumi.getter(name="templateName")
    def template_name(self) -> Optional[str]:
        """
        Name of the template to be used to create this cache
        """
        return pulumi.get(self, "template_name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CacheSpecAdminAuth(dict):
    """
    Authentication info
    """
    def __init__(__self__, *,
                 password: Optional['outputs.CacheSpecAdminAuthPassword'] = None,
                 secret_name: Optional[str] = None,
                 username: Optional['outputs.CacheSpecAdminAuthUsername'] = None):
        """
        Authentication info
        :param 'CacheSpecAdminAuthPasswordArgs' password: Secret and key containing the admin password for authentication.
        :param str secret_name: name of the secret containing both admin username and password
        :param 'CacheSpecAdminAuthUsernameArgs' username: Secret and key containing the admin username for authentication.
        """
        if password is not None:
            pulumi.set(__self__, "password", password)
        if secret_name is not None:
            pulumi.set(__self__, "secret_name", secret_name)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def password(self) -> Optional['outputs.CacheSpecAdminAuthPassword']:
        """
        Secret and key containing the admin password for authentication.
        """
        return pulumi.get(self, "password")

    @property
    @pulumi.getter(name="secretName")
    def secret_name(self) -> Optional[str]:
        """
        name of the secret containing both admin username and password
        """
        return pulumi.get(self, "secret_name")

    @property
    @pulumi.getter
    def username(self) -> Optional['outputs.CacheSpecAdminAuthUsername']:
        """
        Secret and key containing the admin username for authentication.
        """
        return pulumi.get(self, "username")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CacheSpecAdminAuthPassword(dict):
    """
    Secret and key containing the admin password for authentication.
    """
    def __init__(__self__, *,
                 key: str,
                 name: Optional[str] = None,
                 optional: Optional[bool] = None):
        """
        Secret and key containing the admin password for authentication.
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
class CacheSpecAdminAuthUsername(dict):
    """
    Secret and key containing the admin username for authentication.
    """
    def __init__(__self__, *,
                 key: str,
                 name: Optional[str] = None,
                 optional: Optional[bool] = None):
        """
        Secret and key containing the admin username for authentication.
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
class CacheStatus(dict):
    """
    CacheStatus defines the observed state of Cache
    """
    def __init__(__self__, *,
                 conditions: Optional[Sequence['outputs.CacheStatusConditions']] = None,
                 service_name: Optional[str] = None):
        """
        CacheStatus defines the observed state of Cache
        :param Sequence['CacheStatusConditionsArgs'] conditions: Conditions list for this cache
        :param str service_name: Service name that exposes the cache inside the cluster
        """
        if conditions is not None:
            pulumi.set(__self__, "conditions", conditions)
        if service_name is not None:
            pulumi.set(__self__, "service_name", service_name)

    @property
    @pulumi.getter
    def conditions(self) -> Optional[Sequence['outputs.CacheStatusConditions']]:
        """
        Conditions list for this cache
        """
        return pulumi.get(self, "conditions")

    @property
    @pulumi.getter(name="serviceName")
    def service_name(self) -> Optional[str]:
        """
        Service name that exposes the cache inside the cluster
        """
        return pulumi.get(self, "service_name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class CacheStatusConditions(dict):
    """
    CacheCondition define a condition of the cluster
    """
    def __init__(__self__, *,
                 status: str,
                 type: str,
                 message: Optional[str] = None):
        """
        CacheCondition define a condition of the cluster
        :param str status: Status is the status of the condition.
        :param str type: Type is the type of the condition.
        :param str message: Human-readable message indicating details about last transition.
        """
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "type", type)
        if message is not None:
            pulumi.set(__self__, "message", message)

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status is the status of the condition.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type is the type of the condition.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        """
        Human-readable message indicating details about last transition.
        """
        return pulumi.get(self, "message")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


