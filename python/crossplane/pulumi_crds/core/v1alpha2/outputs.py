# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables
from . import outputs

__all__ = [
    'ApplicationConfigurationSpec',
    'ApplicationConfigurationSpecComponents',
    'ApplicationConfigurationSpecComponentsParameterValues',
    'ApplicationConfigurationSpecComponentsParameterValuesValue',
    'ApplicationConfigurationSpecComponentsScopes',
    'ApplicationConfigurationSpecComponentsScopesScopeRef',
    'ApplicationConfigurationSpecComponentsTraits',
    'ApplicationConfigurationStatus',
    'ApplicationConfigurationStatusConditions',
    'ApplicationConfigurationStatusWorkloads',
    'ApplicationConfigurationStatusWorkloadsTraits',
    'ApplicationConfigurationStatusWorkloadsTraitsTraitRef',
    'ApplicationConfigurationStatusWorkloadsWorkloadRef',
]

@pulumi.output_type
class ApplicationConfigurationSpec(dict):
    """
    An ApplicationConfigurationSpec defines the desired state of a ApplicationConfiguration.
    """
    def __init__(__self__, *,
                 components: List['outputs.ApplicationConfigurationSpecComponents']):
        """
        An ApplicationConfigurationSpec defines the desired state of a ApplicationConfiguration.
        :param List['ApplicationConfigurationSpecComponentsArgs'] components: Components of which this ApplicationConfiguration consists. Each component will be used to instantiate a workload.
        """
        pulumi.set(__self__, "components", components)

    @property
    @pulumi.getter
    def components(self) -> List['outputs.ApplicationConfigurationSpecComponents']:
        """
        Components of which this ApplicationConfiguration consists. Each component will be used to instantiate a workload.
        """
        return pulumi.get(self, "components")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationSpecComponents(dict):
    """
    An ApplicationConfigurationComponent specifies a component of an ApplicationConfiguration. Each component is used to instantiate a workload.
    """
    def __init__(__self__, *,
                 component_name: str,
                 parameter_values: Optional[List['outputs.ApplicationConfigurationSpecComponentsParameterValues']] = None,
                 scopes: Optional[List['outputs.ApplicationConfigurationSpecComponentsScopes']] = None,
                 traits: Optional[List['outputs.ApplicationConfigurationSpecComponentsTraits']] = None):
        """
        An ApplicationConfigurationComponent specifies a component of an ApplicationConfiguration. Each component is used to instantiate a workload.
        :param str component_name: ComponentName specifies a component of which an ApplicationConfiguration should consist. The named component must exist.
        :param List['ApplicationConfigurationSpecComponentsParameterValuesArgs'] parameter_values: ParameterValues specify values for the the specified component's parameters. Any parameter required by the component must be specified.
        :param List['ApplicationConfigurationSpecComponentsScopesArgs'] scopes: Scopes in which the specified component should exist.
        :param List['ApplicationConfigurationSpecComponentsTraitsArgs'] traits: Traits of the specified component.
        """
        pulumi.set(__self__, "component_name", component_name)
        if parameter_values is not None:
            pulumi.set(__self__, "parameter_values", parameter_values)
        if scopes is not None:
            pulumi.set(__self__, "scopes", scopes)
        if traits is not None:
            pulumi.set(__self__, "traits", traits)

    @property
    @pulumi.getter(name="componentName")
    def component_name(self) -> str:
        """
        ComponentName specifies a component of which an ApplicationConfiguration should consist. The named component must exist.
        """
        return pulumi.get(self, "component_name")

    @property
    @pulumi.getter(name="parameterValues")
    def parameter_values(self) -> Optional[List['outputs.ApplicationConfigurationSpecComponentsParameterValues']]:
        """
        ParameterValues specify values for the the specified component's parameters. Any parameter required by the component must be specified.
        """
        return pulumi.get(self, "parameter_values")

    @property
    @pulumi.getter
    def scopes(self) -> Optional[List['outputs.ApplicationConfigurationSpecComponentsScopes']]:
        """
        Scopes in which the specified component should exist.
        """
        return pulumi.get(self, "scopes")

    @property
    @pulumi.getter
    def traits(self) -> Optional[List['outputs.ApplicationConfigurationSpecComponentsTraits']]:
        """
        Traits of the specified component.
        """
        return pulumi.get(self, "traits")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationSpecComponentsParameterValues(dict):
    """
    A ComponentParameterValue specifies a value for a named parameter. The associated component must publish a parameter with this name.
    """
    def __init__(__self__, *,
                 name: str,
                 value: 'outputs.ApplicationConfigurationSpecComponentsParameterValuesValue'):
        """
        A ComponentParameterValue specifies a value for a named parameter. The associated component must publish a parameter with this name.
        :param str name: Name of the component parameter to set.
        :param 'ApplicationConfigurationSpecComponentsParameterValuesValueArgs' value: Value to set.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the component parameter to set.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def value(self) -> 'outputs.ApplicationConfigurationSpecComponentsParameterValuesValue':
        """
        Value to set.
        """
        return pulumi.get(self, "value")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationSpecComponentsParameterValuesValue(dict):
    def __init__(__self__):
        pass

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationSpecComponentsScopes(dict):
    """
    A ComponentScope specifies a scope in which a component should exist.
    """
    def __init__(__self__, *,
                 scope_ref: 'outputs.ApplicationConfigurationSpecComponentsScopesScopeRef'):
        """
        A ComponentScope specifies a scope in which a component should exist.
        :param 'ApplicationConfigurationSpecComponentsScopesScopeRefArgs' scope_ref: A ScopeReference must refer to an OAM scope resource.
        """
        pulumi.set(__self__, "scope_ref", scope_ref)

    @property
    @pulumi.getter(name="scopeRef")
    def scope_ref(self) -> 'outputs.ApplicationConfigurationSpecComponentsScopesScopeRef':
        """
        A ScopeReference must refer to an OAM scope resource.
        """
        return pulumi.get(self, "scope_ref")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationSpecComponentsScopesScopeRef(dict):
    """
    A ScopeReference must refer to an OAM scope resource.
    """
    def __init__(__self__, *,
                 api_version: str,
                 kind: str,
                 name: str,
                 uid: Optional[str] = None):
        """
        A ScopeReference must refer to an OAM scope resource.
        :param str api_version: APIVersion of the referenced object.
        :param str kind: Kind of the referenced object.
        :param str name: Name of the referenced object.
        :param str uid: UID of the referenced object.
        """
        pulumi.set(__self__, "api_version", api_version)
        pulumi.set(__self__, "kind", kind)
        pulumi.set(__self__, "name", name)
        if uid is not None:
            pulumi.set(__self__, "uid", uid)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> str:
        """
        APIVersion of the referenced object.
        """
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def kind(self) -> str:
        """
        Kind of the referenced object.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the referenced object.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def uid(self) -> Optional[str]:
        """
        UID of the referenced object.
        """
        return pulumi.get(self, "uid")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationSpecComponentsTraits(dict):
    """
    A ComponentTrait specifies a trait that should be applied to a component.
    """
    def __init__(__self__, *,
                 trait: Mapping[str, Any]):
        """
        A ComponentTrait specifies a trait that should be applied to a component.
        :param Mapping[str, Any] trait: A Trait that will be created for the component
        """
        pulumi.set(__self__, "trait", trait)

    @property
    @pulumi.getter
    def trait(self) -> Mapping[str, Any]:
        """
        A Trait that will be created for the component
        """
        return pulumi.get(self, "trait")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationStatus(dict):
    """
    An ApplicationConfigurationStatus represents the observed state of a ApplicationConfiguration.
    """
    def __init__(__self__, *,
                 conditions: Optional[List['outputs.ApplicationConfigurationStatusConditions']] = None,
                 workloads: Optional[List['outputs.ApplicationConfigurationStatusWorkloads']] = None):
        """
        An ApplicationConfigurationStatus represents the observed state of a ApplicationConfiguration.
        :param List['ApplicationConfigurationStatusConditionsArgs'] conditions: Conditions of the resource.
        :param List['ApplicationConfigurationStatusWorkloadsArgs'] workloads: Workloads created by this ApplicationConfiguration.
        """
        if conditions is not None:
            pulumi.set(__self__, "conditions", conditions)
        if workloads is not None:
            pulumi.set(__self__, "workloads", workloads)

    @property
    @pulumi.getter
    def conditions(self) -> Optional[List['outputs.ApplicationConfigurationStatusConditions']]:
        """
        Conditions of the resource.
        """
        return pulumi.get(self, "conditions")

    @property
    @pulumi.getter
    def workloads(self) -> Optional[List['outputs.ApplicationConfigurationStatusWorkloads']]:
        """
        Workloads created by this ApplicationConfiguration.
        """
        return pulumi.get(self, "workloads")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationStatusConditions(dict):
    """
    A Condition that may apply to a resource.
    """
    def __init__(__self__, *,
                 last_transition_time: str,
                 reason: str,
                 status: str,
                 type: str,
                 message: Optional[str] = None):
        """
        A Condition that may apply to a resource.
        :param str last_transition_time: LastTransitionTime is the last time this condition transitioned from one status to another.
        :param str reason: A Reason for this condition's last transition from one status to another.
        :param str status: Status of this condition; is it currently True, False, or Unknown?
        :param str type: Type of this condition. At most one of each condition type may apply to a resource at any point in time.
        :param str message: A Message containing details about this condition's last transition from one status to another, if any.
        """
        pulumi.set(__self__, "last_transition_time", last_transition_time)
        pulumi.set(__self__, "reason", reason)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "type", type)
        if message is not None:
            pulumi.set(__self__, "message", message)

    @property
    @pulumi.getter(name="lastTransitionTime")
    def last_transition_time(self) -> str:
        """
        LastTransitionTime is the last time this condition transitioned from one status to another.
        """
        return pulumi.get(self, "last_transition_time")

    @property
    @pulumi.getter
    def reason(self) -> str:
        """
        A Reason for this condition's last transition from one status to another.
        """
        return pulumi.get(self, "reason")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of this condition; is it currently True, False, or Unknown?
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type of this condition. At most one of each condition type may apply to a resource at any point in time.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        """
        A Message containing details about this condition's last transition from one status to another, if any.
        """
        return pulumi.get(self, "message")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationStatusWorkloads(dict):
    """
    A WorkloadStatus represents the status of a workload.
    """
    def __init__(__self__, *,
                 component_name: Optional[str] = None,
                 traits: Optional[List['outputs.ApplicationConfigurationStatusWorkloadsTraits']] = None,
                 workload_ref: Optional['outputs.ApplicationConfigurationStatusWorkloadsWorkloadRef'] = None):
        """
        A WorkloadStatus represents the status of a workload.
        :param str component_name: ComponentName that produced this workload.
        :param List['ApplicationConfigurationStatusWorkloadsTraitsArgs'] traits: Traits associated with this workload.
        :param 'ApplicationConfigurationStatusWorkloadsWorkloadRefArgs' workload_ref: Reference to a workload created by an ApplicationConfiguration.
        """
        if component_name is not None:
            pulumi.set(__self__, "component_name", component_name)
        if traits is not None:
            pulumi.set(__self__, "traits", traits)
        if workload_ref is not None:
            pulumi.set(__self__, "workload_ref", workload_ref)

    @property
    @pulumi.getter(name="componentName")
    def component_name(self) -> Optional[str]:
        """
        ComponentName that produced this workload.
        """
        return pulumi.get(self, "component_name")

    @property
    @pulumi.getter
    def traits(self) -> Optional[List['outputs.ApplicationConfigurationStatusWorkloadsTraits']]:
        """
        Traits associated with this workload.
        """
        return pulumi.get(self, "traits")

    @property
    @pulumi.getter(name="workloadRef")
    def workload_ref(self) -> Optional['outputs.ApplicationConfigurationStatusWorkloadsWorkloadRef']:
        """
        Reference to a workload created by an ApplicationConfiguration.
        """
        return pulumi.get(self, "workload_ref")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationStatusWorkloadsTraits(dict):
    """
    A WorkloadTrait represents a trait associated with a workload.
    """
    def __init__(__self__, *,
                 trait_ref: 'outputs.ApplicationConfigurationStatusWorkloadsTraitsTraitRef'):
        """
        A WorkloadTrait represents a trait associated with a workload.
        :param 'ApplicationConfigurationStatusWorkloadsTraitsTraitRefArgs' trait_ref: Reference to a trait created by an ApplicationConfiguration.
        """
        pulumi.set(__self__, "trait_ref", trait_ref)

    @property
    @pulumi.getter(name="traitRef")
    def trait_ref(self) -> 'outputs.ApplicationConfigurationStatusWorkloadsTraitsTraitRef':
        """
        Reference to a trait created by an ApplicationConfiguration.
        """
        return pulumi.get(self, "trait_ref")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationStatusWorkloadsTraitsTraitRef(dict):
    """
    Reference to a trait created by an ApplicationConfiguration.
    """
    def __init__(__self__, *,
                 api_version: str,
                 kind: str,
                 name: str,
                 uid: Optional[str] = None):
        """
        Reference to a trait created by an ApplicationConfiguration.
        :param str api_version: APIVersion of the referenced object.
        :param str kind: Kind of the referenced object.
        :param str name: Name of the referenced object.
        :param str uid: UID of the referenced object.
        """
        pulumi.set(__self__, "api_version", api_version)
        pulumi.set(__self__, "kind", kind)
        pulumi.set(__self__, "name", name)
        if uid is not None:
            pulumi.set(__self__, "uid", uid)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> str:
        """
        APIVersion of the referenced object.
        """
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def kind(self) -> str:
        """
        Kind of the referenced object.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the referenced object.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def uid(self) -> Optional[str]:
        """
        UID of the referenced object.
        """
        return pulumi.get(self, "uid")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ApplicationConfigurationStatusWorkloadsWorkloadRef(dict):
    """
    Reference to a workload created by an ApplicationConfiguration.
    """
    def __init__(__self__, *,
                 api_version: str,
                 kind: str,
                 name: str,
                 uid: Optional[str] = None):
        """
        Reference to a workload created by an ApplicationConfiguration.
        :param str api_version: APIVersion of the referenced object.
        :param str kind: Kind of the referenced object.
        :param str name: Name of the referenced object.
        :param str uid: UID of the referenced object.
        """
        pulumi.set(__self__, "api_version", api_version)
        pulumi.set(__self__, "kind", kind)
        pulumi.set(__self__, "name", name)
        if uid is not None:
            pulumi.set(__self__, "uid", uid)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> str:
        """
        APIVersion of the referenced object.
        """
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def kind(self) -> str:
        """
        Kind of the referenced object.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the referenced object.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def uid(self) -> Optional[str]:
        """
        UID of the referenced object.
        """
        return pulumi.get(self, "uid")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


