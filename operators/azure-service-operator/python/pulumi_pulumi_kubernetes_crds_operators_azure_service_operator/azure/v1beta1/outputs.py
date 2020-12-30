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
    'AzureSqlDatabaseSpec',
    'AzureSqlDatabaseSpecMaxSize',
    'AzureSqlDatabaseSpecSku',
    'AzureSqlDatabaseStatus',
    'AzureSqlFailoverGroupSpec',
    'AzureSqlFailoverGroupStatus',
    'AzureSqlFirewallRuleSpec',
    'AzureSqlFirewallRuleStatus',
    'AzureSqlServerSpec',
    'AzureSqlServerStatus',
]

@pulumi.output_type
class AzureSqlDatabaseSpec(dict):
    """
    AzureSqlDatabaseSpec defines the desired state of AzureSqlDatabase
    """
    def __init__(__self__, *,
                 location: str,
                 resource_group: str,
                 server: str,
                 db_name: Optional[str] = None,
                 edition: Optional[int] = None,
                 max_size: Optional['outputs.AzureSqlDatabaseSpecMaxSize'] = None,
                 monthly_retention: Optional[str] = None,
                 sku: Optional['outputs.AzureSqlDatabaseSpecSku'] = None,
                 week_of_year: Optional[int] = None,
                 weekly_retention: Optional[str] = None,
                 yearly_retention: Optional[str] = None):
        """
        AzureSqlDatabaseSpec defines the desired state of AzureSqlDatabase
        :param str location: INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        """
        pulumi.set(__self__, "location", location)
        pulumi.set(__self__, "resource_group", resource_group)
        pulumi.set(__self__, "server", server)
        if db_name is not None:
            pulumi.set(__self__, "db_name", db_name)
        if edition is not None:
            pulumi.set(__self__, "edition", edition)
        if max_size is not None:
            pulumi.set(__self__, "max_size", max_size)
        if monthly_retention is not None:
            pulumi.set(__self__, "monthly_retention", monthly_retention)
        if sku is not None:
            pulumi.set(__self__, "sku", sku)
        if week_of_year is not None:
            pulumi.set(__self__, "week_of_year", week_of_year)
        if weekly_retention is not None:
            pulumi.set(__self__, "weekly_retention", weekly_retention)
        if yearly_retention is not None:
            pulumi.set(__self__, "yearly_retention", yearly_retention)

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="resourceGroup")
    def resource_group(self) -> str:
        return pulumi.get(self, "resource_group")

    @property
    @pulumi.getter
    def server(self) -> str:
        return pulumi.get(self, "server")

    @property
    @pulumi.getter(name="dbName")
    def db_name(self) -> Optional[str]:
        return pulumi.get(self, "db_name")

    @property
    @pulumi.getter
    def edition(self) -> Optional[int]:
        return pulumi.get(self, "edition")

    @property
    @pulumi.getter(name="maxSize")
    def max_size(self) -> Optional['outputs.AzureSqlDatabaseSpecMaxSize']:
        return pulumi.get(self, "max_size")

    @property
    @pulumi.getter(name="monthlyRetention")
    def monthly_retention(self) -> Optional[str]:
        return pulumi.get(self, "monthly_retention")

    @property
    @pulumi.getter
    def sku(self) -> Optional['outputs.AzureSqlDatabaseSpecSku']:
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter(name="weekOfYear")
    def week_of_year(self) -> Optional[int]:
        return pulumi.get(self, "week_of_year")

    @property
    @pulumi.getter(name="weeklyRetention")
    def weekly_retention(self) -> Optional[str]:
        return pulumi.get(self, "weekly_retention")

    @property
    @pulumi.getter(name="yearlyRetention")
    def yearly_retention(self) -> Optional[str]:
        return pulumi.get(self, "yearly_retention")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AzureSqlDatabaseSpecMaxSize(dict):
    def __init__(__self__):
        pass

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AzureSqlDatabaseSpecSku(dict):
    def __init__(__self__, *,
                 name: str,
                 capacity: Optional[int] = None,
                 family: Optional[str] = None,
                 size: Optional[str] = None,
                 tier: Optional[str] = None):
        """
        :param str name: Name - The name of the SKU, typically, a letter + Number code, e.g. P3.
        :param int capacity: Capacity - Capacity of the particular SKU.
        :param str family: Family - If the service has different generations of hardware, for the same SKU, then that can be captured here.
        :param str size: Size - Size of the particular SKU
        :param str tier: optional Tier - The tier or edition of the particular SKU, e.g. Basic, Premium.
        """
        pulumi.set(__self__, "name", name)
        if capacity is not None:
            pulumi.set(__self__, "capacity", capacity)
        if family is not None:
            pulumi.set(__self__, "family", family)
        if size is not None:
            pulumi.set(__self__, "size", size)
        if tier is not None:
            pulumi.set(__self__, "tier", tier)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name - The name of the SKU, typically, a letter + Number code, e.g. P3.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def capacity(self) -> Optional[int]:
        """
        Capacity - Capacity of the particular SKU.
        """
        return pulumi.get(self, "capacity")

    @property
    @pulumi.getter
    def family(self) -> Optional[str]:
        """
        Family - If the service has different generations of hardware, for the same SKU, then that can be captured here.
        """
        return pulumi.get(self, "family")

    @property
    @pulumi.getter
    def size(self) -> Optional[str]:
        """
        Size - Size of the particular SKU
        """
        return pulumi.get(self, "size")

    @property
    @pulumi.getter
    def tier(self) -> Optional[str]:
        """
        optional Tier - The tier or edition of the particular SKU, e.g. Basic, Premium.
        """
        return pulumi.get(self, "tier")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AzureSqlDatabaseStatus(dict):
    """
    ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
    """
    def __init__(__self__, *,
                 completed: Optional[str] = None,
                 contains_update: Optional[bool] = None,
                 failed_provisioning: Optional[bool] = None,
                 flattened_secrets: Optional[bool] = None,
                 message: Optional[str] = None,
                 output: Optional[str] = None,
                 polling_url: Optional[str] = None,
                 provisioned: Optional[bool] = None,
                 provisioning: Optional[bool] = None,
                 requested: Optional[str] = None,
                 resource_id: Optional[str] = None,
                 spec_hash: Optional[str] = None,
                 state: Optional[str] = None):
        """
        ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
        """
        if completed is not None:
            pulumi.set(__self__, "completed", completed)
        if contains_update is not None:
            pulumi.set(__self__, "contains_update", contains_update)
        if failed_provisioning is not None:
            pulumi.set(__self__, "failed_provisioning", failed_provisioning)
        if flattened_secrets is not None:
            pulumi.set(__self__, "flattened_secrets", flattened_secrets)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if output is not None:
            pulumi.set(__self__, "output", output)
        if polling_url is not None:
            pulumi.set(__self__, "polling_url", polling_url)
        if provisioned is not None:
            pulumi.set(__self__, "provisioned", provisioned)
        if provisioning is not None:
            pulumi.set(__self__, "provisioning", provisioning)
        if requested is not None:
            pulumi.set(__self__, "requested", requested)
        if resource_id is not None:
            pulumi.set(__self__, "resource_id", resource_id)
        if spec_hash is not None:
            pulumi.set(__self__, "spec_hash", spec_hash)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def completed(self) -> Optional[str]:
        return pulumi.get(self, "completed")

    @property
    @pulumi.getter(name="containsUpdate")
    def contains_update(self) -> Optional[bool]:
        return pulumi.get(self, "contains_update")

    @property
    @pulumi.getter(name="failedProvisioning")
    def failed_provisioning(self) -> Optional[bool]:
        return pulumi.get(self, "failed_provisioning")

    @property
    @pulumi.getter(name="flattenedSecrets")
    def flattened_secrets(self) -> Optional[bool]:
        return pulumi.get(self, "flattened_secrets")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def output(self) -> Optional[str]:
        return pulumi.get(self, "output")

    @property
    @pulumi.getter(name="pollingUrl")
    def polling_url(self) -> Optional[str]:
        return pulumi.get(self, "polling_url")

    @property
    @pulumi.getter
    def provisioned(self) -> Optional[bool]:
        return pulumi.get(self, "provisioned")

    @property
    @pulumi.getter
    def provisioning(self) -> Optional[bool]:
        return pulumi.get(self, "provisioning")

    @property
    @pulumi.getter
    def requested(self) -> Optional[str]:
        return pulumi.get(self, "requested")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> Optional[str]:
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="specHash")
    def spec_hash(self) -> Optional[str]:
        return pulumi.get(self, "spec_hash")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        return pulumi.get(self, "state")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AzureSqlFailoverGroupSpec(dict):
    """
    AzureSqlFailoverGroupSpec defines the desired state of AzureSqlFailoverGroup
    """
    def __init__(__self__, *,
                 database_list: Sequence[str],
                 failover_grace_period: int,
                 failover_policy: str,
                 location: str,
                 resource_group: str,
                 secondary_server: str,
                 secondary_server_resource_group: str,
                 server: str,
                 key_vault_to_store_secrets: Optional[str] = None):
        """
        AzureSqlFailoverGroupSpec defines the desired state of AzureSqlFailoverGroup
        :param str failover_policy: NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized.
        :param str location: Important: Run "make" to regenerate code after modifying this file
        """
        pulumi.set(__self__, "database_list", database_list)
        pulumi.set(__self__, "failover_grace_period", failover_grace_period)
        pulumi.set(__self__, "failover_policy", failover_policy)
        pulumi.set(__self__, "location", location)
        pulumi.set(__self__, "resource_group", resource_group)
        pulumi.set(__self__, "secondary_server", secondary_server)
        pulumi.set(__self__, "secondary_server_resource_group", secondary_server_resource_group)
        pulumi.set(__self__, "server", server)
        if key_vault_to_store_secrets is not None:
            pulumi.set(__self__, "key_vault_to_store_secrets", key_vault_to_store_secrets)

    @property
    @pulumi.getter(name="databaseList")
    def database_list(self) -> Sequence[str]:
        return pulumi.get(self, "database_list")

    @property
    @pulumi.getter(name="failoverGracePeriod")
    def failover_grace_period(self) -> int:
        return pulumi.get(self, "failover_grace_period")

    @property
    @pulumi.getter(name="failoverPolicy")
    def failover_policy(self) -> str:
        """
        NOTE: json tags are required.  Any new fields you add must have json tags for the fields to be serialized.
        """
        return pulumi.get(self, "failover_policy")

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        Important: Run "make" to regenerate code after modifying this file
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="resourceGroup")
    def resource_group(self) -> str:
        return pulumi.get(self, "resource_group")

    @property
    @pulumi.getter(name="secondaryServer")
    def secondary_server(self) -> str:
        return pulumi.get(self, "secondary_server")

    @property
    @pulumi.getter(name="secondaryServerResourceGroup")
    def secondary_server_resource_group(self) -> str:
        return pulumi.get(self, "secondary_server_resource_group")

    @property
    @pulumi.getter
    def server(self) -> str:
        return pulumi.get(self, "server")

    @property
    @pulumi.getter(name="keyVaultToStoreSecrets")
    def key_vault_to_store_secrets(self) -> Optional[str]:
        return pulumi.get(self, "key_vault_to_store_secrets")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AzureSqlFailoverGroupStatus(dict):
    """
    ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
    """
    def __init__(__self__, *,
                 completed: Optional[str] = None,
                 contains_update: Optional[bool] = None,
                 failed_provisioning: Optional[bool] = None,
                 flattened_secrets: Optional[bool] = None,
                 message: Optional[str] = None,
                 output: Optional[str] = None,
                 polling_url: Optional[str] = None,
                 provisioned: Optional[bool] = None,
                 provisioning: Optional[bool] = None,
                 requested: Optional[str] = None,
                 resource_id: Optional[str] = None,
                 spec_hash: Optional[str] = None,
                 state: Optional[str] = None):
        """
        ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
        """
        if completed is not None:
            pulumi.set(__self__, "completed", completed)
        if contains_update is not None:
            pulumi.set(__self__, "contains_update", contains_update)
        if failed_provisioning is not None:
            pulumi.set(__self__, "failed_provisioning", failed_provisioning)
        if flattened_secrets is not None:
            pulumi.set(__self__, "flattened_secrets", flattened_secrets)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if output is not None:
            pulumi.set(__self__, "output", output)
        if polling_url is not None:
            pulumi.set(__self__, "polling_url", polling_url)
        if provisioned is not None:
            pulumi.set(__self__, "provisioned", provisioned)
        if provisioning is not None:
            pulumi.set(__self__, "provisioning", provisioning)
        if requested is not None:
            pulumi.set(__self__, "requested", requested)
        if resource_id is not None:
            pulumi.set(__self__, "resource_id", resource_id)
        if spec_hash is not None:
            pulumi.set(__self__, "spec_hash", spec_hash)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def completed(self) -> Optional[str]:
        return pulumi.get(self, "completed")

    @property
    @pulumi.getter(name="containsUpdate")
    def contains_update(self) -> Optional[bool]:
        return pulumi.get(self, "contains_update")

    @property
    @pulumi.getter(name="failedProvisioning")
    def failed_provisioning(self) -> Optional[bool]:
        return pulumi.get(self, "failed_provisioning")

    @property
    @pulumi.getter(name="flattenedSecrets")
    def flattened_secrets(self) -> Optional[bool]:
        return pulumi.get(self, "flattened_secrets")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def output(self) -> Optional[str]:
        return pulumi.get(self, "output")

    @property
    @pulumi.getter(name="pollingUrl")
    def polling_url(self) -> Optional[str]:
        return pulumi.get(self, "polling_url")

    @property
    @pulumi.getter
    def provisioned(self) -> Optional[bool]:
        return pulumi.get(self, "provisioned")

    @property
    @pulumi.getter
    def provisioning(self) -> Optional[bool]:
        return pulumi.get(self, "provisioning")

    @property
    @pulumi.getter
    def requested(self) -> Optional[str]:
        return pulumi.get(self, "requested")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> Optional[str]:
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="specHash")
    def spec_hash(self) -> Optional[str]:
        return pulumi.get(self, "spec_hash")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        return pulumi.get(self, "state")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AzureSqlFirewallRuleSpec(dict):
    """
    AzureSqlFirewallRuleSpec defines the desired state of AzureSqlFirewallRule
    """
    def __init__(__self__, *,
                 resource_group: str,
                 server: str,
                 end_ip_address: Optional[str] = None,
                 start_ip_address: Optional[str] = None):
        """
        AzureSqlFirewallRuleSpec defines the desired state of AzureSqlFirewallRule
        :param str resource_group: INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        """
        pulumi.set(__self__, "resource_group", resource_group)
        pulumi.set(__self__, "server", server)
        if end_ip_address is not None:
            pulumi.set(__self__, "end_ip_address", end_ip_address)
        if start_ip_address is not None:
            pulumi.set(__self__, "start_ip_address", start_ip_address)

    @property
    @pulumi.getter(name="resourceGroup")
    def resource_group(self) -> str:
        """
        INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        """
        return pulumi.get(self, "resource_group")

    @property
    @pulumi.getter
    def server(self) -> str:
        return pulumi.get(self, "server")

    @property
    @pulumi.getter(name="endIpAddress")
    def end_ip_address(self) -> Optional[str]:
        return pulumi.get(self, "end_ip_address")

    @property
    @pulumi.getter(name="startIpAddress")
    def start_ip_address(self) -> Optional[str]:
        return pulumi.get(self, "start_ip_address")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AzureSqlFirewallRuleStatus(dict):
    """
    ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
    """
    def __init__(__self__, *,
                 completed: Optional[str] = None,
                 contains_update: Optional[bool] = None,
                 failed_provisioning: Optional[bool] = None,
                 flattened_secrets: Optional[bool] = None,
                 message: Optional[str] = None,
                 output: Optional[str] = None,
                 polling_url: Optional[str] = None,
                 provisioned: Optional[bool] = None,
                 provisioning: Optional[bool] = None,
                 requested: Optional[str] = None,
                 resource_id: Optional[str] = None,
                 spec_hash: Optional[str] = None,
                 state: Optional[str] = None):
        """
        ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
        """
        if completed is not None:
            pulumi.set(__self__, "completed", completed)
        if contains_update is not None:
            pulumi.set(__self__, "contains_update", contains_update)
        if failed_provisioning is not None:
            pulumi.set(__self__, "failed_provisioning", failed_provisioning)
        if flattened_secrets is not None:
            pulumi.set(__self__, "flattened_secrets", flattened_secrets)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if output is not None:
            pulumi.set(__self__, "output", output)
        if polling_url is not None:
            pulumi.set(__self__, "polling_url", polling_url)
        if provisioned is not None:
            pulumi.set(__self__, "provisioned", provisioned)
        if provisioning is not None:
            pulumi.set(__self__, "provisioning", provisioning)
        if requested is not None:
            pulumi.set(__self__, "requested", requested)
        if resource_id is not None:
            pulumi.set(__self__, "resource_id", resource_id)
        if spec_hash is not None:
            pulumi.set(__self__, "spec_hash", spec_hash)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def completed(self) -> Optional[str]:
        return pulumi.get(self, "completed")

    @property
    @pulumi.getter(name="containsUpdate")
    def contains_update(self) -> Optional[bool]:
        return pulumi.get(self, "contains_update")

    @property
    @pulumi.getter(name="failedProvisioning")
    def failed_provisioning(self) -> Optional[bool]:
        return pulumi.get(self, "failed_provisioning")

    @property
    @pulumi.getter(name="flattenedSecrets")
    def flattened_secrets(self) -> Optional[bool]:
        return pulumi.get(self, "flattened_secrets")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def output(self) -> Optional[str]:
        return pulumi.get(self, "output")

    @property
    @pulumi.getter(name="pollingUrl")
    def polling_url(self) -> Optional[str]:
        return pulumi.get(self, "polling_url")

    @property
    @pulumi.getter
    def provisioned(self) -> Optional[bool]:
        return pulumi.get(self, "provisioned")

    @property
    @pulumi.getter
    def provisioning(self) -> Optional[bool]:
        return pulumi.get(self, "provisioning")

    @property
    @pulumi.getter
    def requested(self) -> Optional[str]:
        return pulumi.get(self, "requested")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> Optional[str]:
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="specHash")
    def spec_hash(self) -> Optional[str]:
        return pulumi.get(self, "spec_hash")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        return pulumi.get(self, "state")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AzureSqlServerSpec(dict):
    """
    AzureSqlServerSpec defines the desired state of AzureSqlServer
    """
    def __init__(__self__, *,
                 location: str,
                 resource_group: str,
                 key_vault_to_store_secrets: Optional[str] = None):
        """
        AzureSqlServerSpec defines the desired state of AzureSqlServer
        :param str location: INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        """
        pulumi.set(__self__, "location", location)
        pulumi.set(__self__, "resource_group", resource_group)
        if key_vault_to_store_secrets is not None:
            pulumi.set(__self__, "key_vault_to_store_secrets", key_vault_to_store_secrets)

    @property
    @pulumi.getter
    def location(self) -> str:
        """
        INSERT ADDITIONAL SPEC FIELDS - desired state of cluster Important: Run "make" to regenerate code after modifying this file
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="resourceGroup")
    def resource_group(self) -> str:
        return pulumi.get(self, "resource_group")

    @property
    @pulumi.getter(name="keyVaultToStoreSecrets")
    def key_vault_to_store_secrets(self) -> Optional[str]:
        return pulumi.get(self, "key_vault_to_store_secrets")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class AzureSqlServerStatus(dict):
    """
    ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
    """
    def __init__(__self__, *,
                 completed: Optional[str] = None,
                 contains_update: Optional[bool] = None,
                 failed_provisioning: Optional[bool] = None,
                 flattened_secrets: Optional[bool] = None,
                 message: Optional[str] = None,
                 output: Optional[str] = None,
                 polling_url: Optional[str] = None,
                 provisioned: Optional[bool] = None,
                 provisioning: Optional[bool] = None,
                 requested: Optional[str] = None,
                 resource_id: Optional[str] = None,
                 spec_hash: Optional[str] = None,
                 state: Optional[str] = None):
        """
        ASOStatus (AzureServiceOperatorsStatus) defines the observed state of resource actions
        """
        if completed is not None:
            pulumi.set(__self__, "completed", completed)
        if contains_update is not None:
            pulumi.set(__self__, "contains_update", contains_update)
        if failed_provisioning is not None:
            pulumi.set(__self__, "failed_provisioning", failed_provisioning)
        if flattened_secrets is not None:
            pulumi.set(__self__, "flattened_secrets", flattened_secrets)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if output is not None:
            pulumi.set(__self__, "output", output)
        if polling_url is not None:
            pulumi.set(__self__, "polling_url", polling_url)
        if provisioned is not None:
            pulumi.set(__self__, "provisioned", provisioned)
        if provisioning is not None:
            pulumi.set(__self__, "provisioning", provisioning)
        if requested is not None:
            pulumi.set(__self__, "requested", requested)
        if resource_id is not None:
            pulumi.set(__self__, "resource_id", resource_id)
        if spec_hash is not None:
            pulumi.set(__self__, "spec_hash", spec_hash)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter
    def completed(self) -> Optional[str]:
        return pulumi.get(self, "completed")

    @property
    @pulumi.getter(name="containsUpdate")
    def contains_update(self) -> Optional[bool]:
        return pulumi.get(self, "contains_update")

    @property
    @pulumi.getter(name="failedProvisioning")
    def failed_provisioning(self) -> Optional[bool]:
        return pulumi.get(self, "failed_provisioning")

    @property
    @pulumi.getter(name="flattenedSecrets")
    def flattened_secrets(self) -> Optional[bool]:
        return pulumi.get(self, "flattened_secrets")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        return pulumi.get(self, "message")

    @property
    @pulumi.getter
    def output(self) -> Optional[str]:
        return pulumi.get(self, "output")

    @property
    @pulumi.getter(name="pollingUrl")
    def polling_url(self) -> Optional[str]:
        return pulumi.get(self, "polling_url")

    @property
    @pulumi.getter
    def provisioned(self) -> Optional[bool]:
        return pulumi.get(self, "provisioned")

    @property
    @pulumi.getter
    def provisioning(self) -> Optional[bool]:
        return pulumi.get(self, "provisioning")

    @property
    @pulumi.getter
    def requested(self) -> Optional[str]:
        return pulumi.get(self, "requested")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> Optional[str]:
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="specHash")
    def spec_hash(self) -> Optional[str]:
        return pulumi.get(self, "spec_hash")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        return pulumi.get(self, "state")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

