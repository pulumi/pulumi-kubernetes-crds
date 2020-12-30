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
    'TestSpec',
    'TestSpecConfig',
    'TestSpecResources',
    'TestSpecSource',
    'TestStatus',
    'TestStatusResults',
    'TestStatusResultsSummary',
    'TestStatusResultsTests',
]

@pulumi.output_type
class TestSpec(dict):
    """
    TestSpec defines the desired state of Test
    """
    def __init__(__self__, *,
                 config: Optional['outputs.TestSpecConfig'] = None,
                 env: Optional[Sequence[str]] = None,
                 resources: Optional[Sequence['outputs.TestSpecResources']] = None,
                 secret: Optional[str] = None,
                 source: Optional['outputs.TestSpecSource'] = None):
        """
        TestSpec defines the desired state of Test
        :param 'TestSpecConfigArgs' config: SettingsSpec--
        :param 'TestSpecSourceArgs' source: SourceSpec--
        """
        if config is not None:
            pulumi.set(__self__, "config", config)
        if env is not None:
            pulumi.set(__self__, "env", env)
        if resources is not None:
            pulumi.set(__self__, "resources", resources)
        if secret is not None:
            pulumi.set(__self__, "secret", secret)
        if source is not None:
            pulumi.set(__self__, "source", source)

    @property
    @pulumi.getter
    def config(self) -> Optional['outputs.TestSpecConfig']:
        """
        SettingsSpec--
        """
        return pulumi.get(self, "config")

    @property
    @pulumi.getter
    def env(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "env")

    @property
    @pulumi.getter
    def resources(self) -> Optional[Sequence['outputs.TestSpecResources']]:
        return pulumi.get(self, "resources")

    @property
    @pulumi.getter
    def secret(self) -> Optional[str]:
        return pulumi.get(self, "secret")

    @property
    @pulumi.getter
    def source(self) -> Optional['outputs.TestSpecSource']:
        """
        SourceSpec--
        """
        return pulumi.get(self, "source")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class TestSpecConfig(dict):
    """
    SettingsSpec--
    """
    def __init__(__self__, *,
                 content: Optional[str] = None,
                 name: Optional[str] = None):
        """
        SettingsSpec--
        """
        if content is not None:
            pulumi.set(__self__, "content", content)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def content(self) -> Optional[str]:
        return pulumi.get(self, "content")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class TestSpecResources(dict):
    """
    ResourceSpec--
    """
    def __init__(__self__, *,
                 content: Optional[str] = None,
                 name: Optional[str] = None):
        """
        ResourceSpec--
        """
        if content is not None:
            pulumi.set(__self__, "content", content)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def content(self) -> Optional[str]:
        return pulumi.get(self, "content")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class TestSpecSource(dict):
    """
    SourceSpec--
    """
    def __init__(__self__, *,
                 content: Optional[str] = None,
                 language: Optional[str] = None,
                 name: Optional[str] = None):
        """
        SourceSpec--
        """
        if content is not None:
            pulumi.set(__self__, "content", content)
        if language is not None:
            pulumi.set(__self__, "language", language)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def content(self) -> Optional[str]:
        return pulumi.get(self, "content")

    @property
    @pulumi.getter
    def language(self) -> Optional[str]:
        return pulumi.get(self, "language")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class TestStatus(dict):
    """
    TestStatus defines the observed state of Test
    """
    def __init__(__self__, *,
                 digest: Optional[str] = None,
                 errors: Optional[str] = None,
                 phase: Optional[str] = None,
                 results: Optional['outputs.TestStatusResults'] = None,
                 test_id: Optional[str] = None,
                 version: Optional[str] = None):
        """
        TestStatus defines the observed state of Test
        :param str phase: TestPhase
        """
        if digest is not None:
            pulumi.set(__self__, "digest", digest)
        if errors is not None:
            pulumi.set(__self__, "errors", errors)
        if phase is not None:
            pulumi.set(__self__, "phase", phase)
        if results is not None:
            pulumi.set(__self__, "results", results)
        if test_id is not None:
            pulumi.set(__self__, "test_id", test_id)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def digest(self) -> Optional[str]:
        return pulumi.get(self, "digest")

    @property
    @pulumi.getter
    def errors(self) -> Optional[str]:
        return pulumi.get(self, "errors")

    @property
    @pulumi.getter
    def phase(self) -> Optional[str]:
        """
        TestPhase
        """
        return pulumi.get(self, "phase")

    @property
    @pulumi.getter
    def results(self) -> Optional['outputs.TestStatusResults']:
        return pulumi.get(self, "results")

    @property
    @pulumi.getter(name="testID")
    def test_id(self) -> Optional[str]:
        return pulumi.get(self, "test_id")

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        return pulumi.get(self, "version")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class TestStatusResults(dict):
    def __init__(__self__, *,
                 errors: Optional[Sequence[str]] = None,
                 summary: Optional['outputs.TestStatusResultsSummary'] = None,
                 tests: Optional[Sequence['outputs.TestStatusResultsTests']] = None):
        if errors is not None:
            pulumi.set(__self__, "errors", errors)
        if summary is not None:
            pulumi.set(__self__, "summary", summary)
        if tests is not None:
            pulumi.set(__self__, "tests", tests)

    @property
    @pulumi.getter
    def errors(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "errors")

    @property
    @pulumi.getter
    def summary(self) -> Optional['outputs.TestStatusResultsSummary']:
        return pulumi.get(self, "summary")

    @property
    @pulumi.getter
    def tests(self) -> Optional[Sequence['outputs.TestStatusResultsTests']]:
        return pulumi.get(self, "tests")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class TestStatusResultsSummary(dict):
    def __init__(__self__, *,
                 failed: int,
                 passed: int,
                 pending: int,
                 skipped: int,
                 total: int,
                 undefined: int):
        pulumi.set(__self__, "failed", failed)
        pulumi.set(__self__, "passed", passed)
        pulumi.set(__self__, "pending", pending)
        pulumi.set(__self__, "skipped", skipped)
        pulumi.set(__self__, "total", total)
        pulumi.set(__self__, "undefined", undefined)

    @property
    @pulumi.getter
    def failed(self) -> int:
        return pulumi.get(self, "failed")

    @property
    @pulumi.getter
    def passed(self) -> int:
        return pulumi.get(self, "passed")

    @property
    @pulumi.getter
    def pending(self) -> int:
        return pulumi.get(self, "pending")

    @property
    @pulumi.getter
    def skipped(self) -> int:
        return pulumi.get(self, "skipped")

    @property
    @pulumi.getter
    def total(self) -> int:
        return pulumi.get(self, "total")

    @property
    @pulumi.getter
    def undefined(self) -> int:
        return pulumi.get(self, "undefined")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class TestStatusResultsTests(dict):
    def __init__(__self__, *,
                 classname: Optional[str] = None,
                 error_message: Optional[str] = None,
                 error_type: Optional[str] = None,
                 name: Optional[str] = None):
        if classname is not None:
            pulumi.set(__self__, "classname", classname)
        if error_message is not None:
            pulumi.set(__self__, "error_message", error_message)
        if error_type is not None:
            pulumi.set(__self__, "error_type", error_type)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def classname(self) -> Optional[str]:
        return pulumi.get(self, "classname")

    @property
    @pulumi.getter(name="errorMessage")
    def error_message(self) -> Optional[str]:
        return pulumi.get(self, "error_message")

    @property
    @pulumi.getter(name="errorType")
    def error_type(self) -> Optional[str]:
        return pulumi.get(self, "error_type")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


