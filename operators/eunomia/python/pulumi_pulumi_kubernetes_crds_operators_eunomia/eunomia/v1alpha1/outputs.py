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
    'GitOpsConfigSpec',
    'GitOpsConfigSpecParameterSource',
    'GitOpsConfigSpecTemplateSource',
    'GitOpsConfigSpecTriggers',
    'GitOpsConfigStatus',
]

@pulumi.output_type
class GitOpsConfigSpec(dict):
    def __init__(__self__, *,
                 parameter_source: Optional['outputs.GitOpsConfigSpecParameterSource'] = None,
                 resource_deletion_mode: Optional[str] = None,
                 resource_handling_mode: Optional[str] = None,
                 service_account_ref: Optional[str] = None,
                 template_processor_args: Optional[str] = None,
                 template_processor_image: Optional[str] = None,
                 template_source: Optional['outputs.GitOpsConfigSpecTemplateSource'] = None,
                 triggers: Optional[Sequence['outputs.GitOpsConfigSpecTriggers']] = None):
        """
        :param 'GitOpsConfigSpecParameterSourceArgs' parameter_source: ParameterSource is the location of the parameters, only contextDir is mandatory, if other filed are left blank they are assumed to be the same as ParameterSource
        :param str resource_deletion_mode: ResourceDeletionMode represents how resource deletion should be handled. Supported values are Retain,Delete,None. Default is Delete
        :param str resource_handling_mode: ResourceHandlingMode represents how resource creation/update should be handled. Supported values are Apply,Create,Delete,Patch,Replace,None. Default is Apply.
        :param str service_account_ref: ServiceAccountRef references to the service account under which the template engine job will run, it must exists in the namespace in which this CR is created
        :param str template_processor_args: TemplateProcessorArgs references to the run time parameters, we can pass additional arguments/flags to the template processor.
        :param str template_processor_image: TemplateEngine, the gitops operator config map contains the list of available template engines, the value used here must exist in that list. Identity (i.e. no resource processing) is the default
        :param 'GitOpsConfigSpecTemplateSourceArgs' template_source: TemplateSource is the location of the templated resources
        :param Sequence['GitOpsConfigSpecTriggersArgs'] triggers: Triggers is an array of triggers that will lanuch this configuration
        """
        if parameter_source is not None:
            pulumi.set(__self__, "parameter_source", parameter_source)
        if resource_deletion_mode is not None:
            pulumi.set(__self__, "resource_deletion_mode", resource_deletion_mode)
        if resource_handling_mode is not None:
            pulumi.set(__self__, "resource_handling_mode", resource_handling_mode)
        if service_account_ref is not None:
            pulumi.set(__self__, "service_account_ref", service_account_ref)
        if template_processor_args is not None:
            pulumi.set(__self__, "template_processor_args", template_processor_args)
        if template_processor_image is not None:
            pulumi.set(__self__, "template_processor_image", template_processor_image)
        if template_source is not None:
            pulumi.set(__self__, "template_source", template_source)
        if triggers is not None:
            pulumi.set(__self__, "triggers", triggers)

    @property
    @pulumi.getter(name="parameterSource")
    def parameter_source(self) -> Optional['outputs.GitOpsConfigSpecParameterSource']:
        """
        ParameterSource is the location of the parameters, only contextDir is mandatory, if other filed are left blank they are assumed to be the same as ParameterSource
        """
        return pulumi.get(self, "parameter_source")

    @property
    @pulumi.getter(name="resourceDeletionMode")
    def resource_deletion_mode(self) -> Optional[str]:
        """
        ResourceDeletionMode represents how resource deletion should be handled. Supported values are Retain,Delete,None. Default is Delete
        """
        return pulumi.get(self, "resource_deletion_mode")

    @property
    @pulumi.getter(name="resourceHandlingMode")
    def resource_handling_mode(self) -> Optional[str]:
        """
        ResourceHandlingMode represents how resource creation/update should be handled. Supported values are Apply,Create,Delete,Patch,Replace,None. Default is Apply.
        """
        return pulumi.get(self, "resource_handling_mode")

    @property
    @pulumi.getter(name="serviceAccountRef")
    def service_account_ref(self) -> Optional[str]:
        """
        ServiceAccountRef references to the service account under which the template engine job will run, it must exists in the namespace in which this CR is created
        """
        return pulumi.get(self, "service_account_ref")

    @property
    @pulumi.getter(name="templateProcessorArgs")
    def template_processor_args(self) -> Optional[str]:
        """
        TemplateProcessorArgs references to the run time parameters, we can pass additional arguments/flags to the template processor.
        """
        return pulumi.get(self, "template_processor_args")

    @property
    @pulumi.getter(name="templateProcessorImage")
    def template_processor_image(self) -> Optional[str]:
        """
        TemplateEngine, the gitops operator config map contains the list of available template engines, the value used here must exist in that list. Identity (i.e. no resource processing) is the default
        """
        return pulumi.get(self, "template_processor_image")

    @property
    @pulumi.getter(name="templateSource")
    def template_source(self) -> Optional['outputs.GitOpsConfigSpecTemplateSource']:
        """
        TemplateSource is the location of the templated resources
        """
        return pulumi.get(self, "template_source")

    @property
    @pulumi.getter
    def triggers(self) -> Optional[Sequence['outputs.GitOpsConfigSpecTriggers']]:
        """
        Triggers is an array of triggers that will lanuch this configuration
        """
        return pulumi.get(self, "triggers")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class GitOpsConfigSpecParameterSource(dict):
    """
    ParameterSource is the location of the parameters, only contextDir is mandatory, if other filed are left blank they are assumed to be the same as ParameterSource
    """
    def __init__(__self__, *,
                 context_dir: Optional[str] = None,
                 http_proxy: Optional[str] = None,
                 https_proxy: Optional[str] = None,
                 no_proxy: Optional[str] = None,
                 ref: Optional[str] = None,
                 secret_ref: Optional[str] = None,
                 uri: Optional[str] = None):
        """
        ParameterSource is the location of the parameters, only contextDir is mandatory, if other filed are left blank they are assumed to be the same as ParameterSource
        """
        if context_dir is not None:
            pulumi.set(__self__, "context_dir", context_dir)
        if http_proxy is not None:
            pulumi.set(__self__, "http_proxy", http_proxy)
        if https_proxy is not None:
            pulumi.set(__self__, "https_proxy", https_proxy)
        if no_proxy is not None:
            pulumi.set(__self__, "no_proxy", no_proxy)
        if ref is not None:
            pulumi.set(__self__, "ref", ref)
        if secret_ref is not None:
            pulumi.set(__self__, "secret_ref", secret_ref)
        if uri is not None:
            pulumi.set(__self__, "uri", uri)

    @property
    @pulumi.getter(name="contextDir")
    def context_dir(self) -> Optional[str]:
        return pulumi.get(self, "context_dir")

    @property
    @pulumi.getter(name="httpProxy")
    def http_proxy(self) -> Optional[str]:
        return pulumi.get(self, "http_proxy")

    @property
    @pulumi.getter(name="httpsProxy")
    def https_proxy(self) -> Optional[str]:
        return pulumi.get(self, "https_proxy")

    @property
    @pulumi.getter(name="noProxy")
    def no_proxy(self) -> Optional[str]:
        return pulumi.get(self, "no_proxy")

    @property
    @pulumi.getter
    def ref(self) -> Optional[str]:
        return pulumi.get(self, "ref")

    @property
    @pulumi.getter(name="secretRef")
    def secret_ref(self) -> Optional[str]:
        return pulumi.get(self, "secret_ref")

    @property
    @pulumi.getter
    def uri(self) -> Optional[str]:
        return pulumi.get(self, "uri")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class GitOpsConfigSpecTemplateSource(dict):
    """
    TemplateSource is the location of the templated resources
    """
    def __init__(__self__, *,
                 context_dir: Optional[str] = None,
                 http_proxy: Optional[str] = None,
                 https_proxy: Optional[str] = None,
                 no_proxy: Optional[str] = None,
                 ref: Optional[str] = None,
                 secret_ref: Optional[str] = None,
                 uri: Optional[str] = None):
        """
        TemplateSource is the location of the templated resources
        """
        if context_dir is not None:
            pulumi.set(__self__, "context_dir", context_dir)
        if http_proxy is not None:
            pulumi.set(__self__, "http_proxy", http_proxy)
        if https_proxy is not None:
            pulumi.set(__self__, "https_proxy", https_proxy)
        if no_proxy is not None:
            pulumi.set(__self__, "no_proxy", no_proxy)
        if ref is not None:
            pulumi.set(__self__, "ref", ref)
        if secret_ref is not None:
            pulumi.set(__self__, "secret_ref", secret_ref)
        if uri is not None:
            pulumi.set(__self__, "uri", uri)

    @property
    @pulumi.getter(name="contextDir")
    def context_dir(self) -> Optional[str]:
        return pulumi.get(self, "context_dir")

    @property
    @pulumi.getter(name="httpProxy")
    def http_proxy(self) -> Optional[str]:
        return pulumi.get(self, "http_proxy")

    @property
    @pulumi.getter(name="httpsProxy")
    def https_proxy(self) -> Optional[str]:
        return pulumi.get(self, "https_proxy")

    @property
    @pulumi.getter(name="noProxy")
    def no_proxy(self) -> Optional[str]:
        return pulumi.get(self, "no_proxy")

    @property
    @pulumi.getter
    def ref(self) -> Optional[str]:
        return pulumi.get(self, "ref")

    @property
    @pulumi.getter(name="secretRef")
    def secret_ref(self) -> Optional[str]:
        return pulumi.get(self, "secret_ref")

    @property
    @pulumi.getter
    def uri(self) -> Optional[str]:
        return pulumi.get(self, "uri")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class GitOpsConfigSpecTriggers(dict):
    def __init__(__self__, *,
                 cron: Optional[str] = None,
                 secret: Optional[str] = None,
                 type: Optional[str] = None):
        """
        :param str cron: cron expression only valid with the Periodic type
        :param str secret: webhook secret only valid with webhook type
        :param str type: Type supported types are Change, Periodic, Webhook
        """
        if cron is not None:
            pulumi.set(__self__, "cron", cron)
        if secret is not None:
            pulumi.set(__self__, "secret", secret)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def cron(self) -> Optional[str]:
        """
        cron expression only valid with the Periodic type
        """
        return pulumi.get(self, "cron")

    @property
    @pulumi.getter
    def secret(self) -> Optional[str]:
        """
        webhook secret only valid with webhook type
        """
        return pulumi.get(self, "secret")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Type supported types are Change, Periodic, Webhook
        """
        return pulumi.get(self, "type")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class GitOpsConfigStatus(dict):
    def __init__(__self__, *,
                 completion_time: Optional[str] = None,
                 last_schedule_time: Optional[str] = None,
                 message: Optional[str] = None,
                 start_time: Optional[str] = None,
                 state: Optional[str] = None):
        if completion_time is not None:
            pulumi.set(__self__, "completion_time", completion_time)
        if last_schedule_time is not None:
            pulumi.set(__self__, "last_schedule_time", last_schedule_time)
        if message is not None:
            pulumi.set(__self__, "message", message)
        if start_time is not None:
            pulumi.set(__self__, "start_time", start_time)
        if state is not None:
            pulumi.set(__self__, "state", state)

    @property
    @pulumi.getter(name="completionTime")
    def completion_time(self) -> Optional[str]:
        return pulumi.get(self, "completion_time")

    @property
    @pulumi.getter(name="lastScheduleTime")
    def last_schedule_time(self) -> Optional[str]:
        return pulumi.get(self, "last_schedule_time")

    @property
    @pulumi.getter
    def message(self) -> Optional[str]:
        return pulumi.get(self, "message")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> Optional[str]:
        return pulumi.get(self, "start_time")

    @property
    @pulumi.getter
    def state(self) -> Optional[str]:
        return pulumi.get(self, "state")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


