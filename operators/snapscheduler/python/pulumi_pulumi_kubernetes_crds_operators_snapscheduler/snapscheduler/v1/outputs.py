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
    'SnapshotScheduleSpec',
    'SnapshotScheduleSpecClaimSelector',
    'SnapshotScheduleSpecClaimSelectorMatchExpressions',
    'SnapshotScheduleSpecRetention',
    'SnapshotScheduleSpecSnapshotTemplate',
    'SnapshotScheduleStatus',
    'SnapshotScheduleStatusConditions',
]

@pulumi.output_type
class SnapshotScheduleSpec(dict):
    """
    SnapshotScheduleSpec defines the desired state of SnapshotSchedule
    """
    def __init__(__self__, *,
                 claim_selector: Optional['outputs.SnapshotScheduleSpecClaimSelector'] = None,
                 disabled: Optional[bool] = None,
                 retention: Optional['outputs.SnapshotScheduleSpecRetention'] = None,
                 schedule: Optional[str] = None,
                 snapshot_template: Optional['outputs.SnapshotScheduleSpecSnapshotTemplate'] = None):
        """
        SnapshotScheduleSpec defines the desired state of SnapshotSchedule
        :param 'SnapshotScheduleSpecClaimSelectorArgs' claim_selector: ClaimSelector selects which PVCs will be snapshotted according to this schedule.
        :param bool disabled: Disabled determines whether this schedule is currently disabled.
        :param 'SnapshotScheduleSpecRetentionArgs' retention: Retention determines how long this schedule's snapshots will be kept.
        :param str schedule: Schedule is a Cronspec specifying when snapshots should be taken. See https://en.wikipedia.org/wiki/Cron for a description of the format.
        :param 'SnapshotScheduleSpecSnapshotTemplateArgs' snapshot_template: SnapshotTemplate is a template description of the Snapshots to be created.
        """
        if claim_selector is not None:
            pulumi.set(__self__, "claim_selector", claim_selector)
        if disabled is not None:
            pulumi.set(__self__, "disabled", disabled)
        if retention is not None:
            pulumi.set(__self__, "retention", retention)
        if schedule is not None:
            pulumi.set(__self__, "schedule", schedule)
        if snapshot_template is not None:
            pulumi.set(__self__, "snapshot_template", snapshot_template)

    @property
    @pulumi.getter(name="claimSelector")
    def claim_selector(self) -> Optional['outputs.SnapshotScheduleSpecClaimSelector']:
        """
        ClaimSelector selects which PVCs will be snapshotted according to this schedule.
        """
        return pulumi.get(self, "claim_selector")

    @property
    @pulumi.getter
    def disabled(self) -> Optional[bool]:
        """
        Disabled determines whether this schedule is currently disabled.
        """
        return pulumi.get(self, "disabled")

    @property
    @pulumi.getter
    def retention(self) -> Optional['outputs.SnapshotScheduleSpecRetention']:
        """
        Retention determines how long this schedule's snapshots will be kept.
        """
        return pulumi.get(self, "retention")

    @property
    @pulumi.getter
    def schedule(self) -> Optional[str]:
        """
        Schedule is a Cronspec specifying when snapshots should be taken. See https://en.wikipedia.org/wiki/Cron for a description of the format.
        """
        return pulumi.get(self, "schedule")

    @property
    @pulumi.getter(name="snapshotTemplate")
    def snapshot_template(self) -> Optional['outputs.SnapshotScheduleSpecSnapshotTemplate']:
        """
        SnapshotTemplate is a template description of the Snapshots to be created.
        """
        return pulumi.get(self, "snapshot_template")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SnapshotScheduleSpecClaimSelector(dict):
    """
    ClaimSelector selects which PVCs will be snapshotted according to this schedule.
    """
    def __init__(__self__, *,
                 match_expressions: Optional[Sequence['outputs.SnapshotScheduleSpecClaimSelectorMatchExpressions']] = None,
                 match_labels: Optional[Mapping[str, str]] = None):
        """
        ClaimSelector selects which PVCs will be snapshotted according to this schedule.
        :param Sequence['SnapshotScheduleSpecClaimSelectorMatchExpressionsArgs'] match_expressions: matchExpressions is a list of label selector requirements. The requirements are ANDed.
        :param Mapping[str, str] match_labels: matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
        """
        if match_expressions is not None:
            pulumi.set(__self__, "match_expressions", match_expressions)
        if match_labels is not None:
            pulumi.set(__self__, "match_labels", match_labels)

    @property
    @pulumi.getter(name="matchExpressions")
    def match_expressions(self) -> Optional[Sequence['outputs.SnapshotScheduleSpecClaimSelectorMatchExpressions']]:
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
class SnapshotScheduleSpecClaimSelectorMatchExpressions(dict):
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
class SnapshotScheduleSpecRetention(dict):
    """
    Retention determines how long this schedule's snapshots will be kept.
    """
    def __init__(__self__, *,
                 expires: Optional[str] = None,
                 max_count: Optional[int] = None):
        """
        Retention determines how long this schedule's snapshots will be kept.
        :param str expires: Expires is the length of time (time.Duration) after which a given Snapshot will be deleted.
        """
        if expires is not None:
            pulumi.set(__self__, "expires", expires)
        if max_count is not None:
            pulumi.set(__self__, "max_count", max_count)

    @property
    @pulumi.getter
    def expires(self) -> Optional[str]:
        """
        Expires is the length of time (time.Duration) after which a given Snapshot will be deleted.
        """
        return pulumi.get(self, "expires")

    @property
    @pulumi.getter(name="maxCount")
    def max_count(self) -> Optional[int]:
        return pulumi.get(self, "max_count")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SnapshotScheduleSpecSnapshotTemplate(dict):
    """
    SnapshotTemplate is a template description of the Snapshots to be created.
    """
    def __init__(__self__, *,
                 labels: Optional[Mapping[str, str]] = None,
                 snapshot_class_name: Optional[str] = None):
        """
        SnapshotTemplate is a template description of the Snapshots to be created.
        :param Mapping[str, str] labels: Labels is a list of labels that should be added to each Snapshot created by this schedule.
        :param str snapshot_class_name: SnapshotClassName is the name of the VSC to be used when creating Snapshots.
        """
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if snapshot_class_name is not None:
            pulumi.set(__self__, "snapshot_class_name", snapshot_class_name)

    @property
    @pulumi.getter
    def labels(self) -> Optional[Mapping[str, str]]:
        """
        Labels is a list of labels that should be added to each Snapshot created by this schedule.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="snapshotClassName")
    def snapshot_class_name(self) -> Optional[str]:
        """
        SnapshotClassName is the name of the VSC to be used when creating Snapshots.
        """
        return pulumi.get(self, "snapshot_class_name")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SnapshotScheduleStatus(dict):
    """
    SnapshotScheduleStatus defines the observed state of SnapshotSchedule
    """
    def __init__(__self__, *,
                 conditions: Optional[Sequence['outputs.SnapshotScheduleStatusConditions']] = None,
                 last_snapshot_time: Optional[str] = None,
                 next_snapshot_time: Optional[str] = None):
        """
        SnapshotScheduleStatus defines the observed state of SnapshotSchedule
        :param Sequence['SnapshotScheduleStatusConditionsArgs'] conditions: Conditions is a list of conditions related to operator reconciliation.
        :param str last_snapshot_time: LastSnapshotTime is the time of the most recent set of snapshots generated by this schedule.
        :param str next_snapshot_time: NextSnapshotTime is the time when this schedule should create the next set of snapshots.
        """
        if conditions is not None:
            pulumi.set(__self__, "conditions", conditions)
        if last_snapshot_time is not None:
            pulumi.set(__self__, "last_snapshot_time", last_snapshot_time)
        if next_snapshot_time is not None:
            pulumi.set(__self__, "next_snapshot_time", next_snapshot_time)

    @property
    @pulumi.getter
    def conditions(self) -> Optional[Sequence['outputs.SnapshotScheduleStatusConditions']]:
        """
        Conditions is a list of conditions related to operator reconciliation.
        """
        return pulumi.get(self, "conditions")

    @property
    @pulumi.getter(name="lastSnapshotTime")
    def last_snapshot_time(self) -> Optional[str]:
        """
        LastSnapshotTime is the time of the most recent set of snapshots generated by this schedule.
        """
        return pulumi.get(self, "last_snapshot_time")

    @property
    @pulumi.getter(name="nextSnapshotTime")
    def next_snapshot_time(self) -> Optional[str]:
        """
        NextSnapshotTime is the time when this schedule should create the next set of snapshots.
        """
        return pulumi.get(self, "next_snapshot_time")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SnapshotScheduleStatusConditions(dict):
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


