# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

SNAKE_TO_CAMEL_CASE_TABLE = {
    "api_version": "apiVersion",
    "auth_secret": "authSecret",
    "auto_update_components": "autoUpdateComponents",
    "capacity_specs": "capacitySpecs",
    "cloud_storage": "cloudStorage",
    "cluster_name": "clusterName",
    "cluster_uid": "clusterUid",
    "collision_count": "collisionCount",
    "config_map_key_ref": "configMapKeyRef",
    "container_name": "containerName",
    "custom_image_registry": "customImageRegistry",
    "data_interface": "dataInterface",
    "data_ip": "dataIP",
    "delete_strategy": "deleteStrategy",
    "device_specs": "deviceSpecs",
    "drive_configs": "driveConfigs",
    "enable_metrics": "enableMetrics",
    "export_metrics": "exportMetrics",
    "feature_gates": "featureGates",
    "field_path": "fieldPath",
    "field_ref": "fieldRef",
    "force_use_disks": "forceUseDisks",
    "guest_access": "guestAccess",
    "host_network": "hostNetwork",
    "image_pull_policy": "imagePullPolicy",
    "image_pull_secret": "imagePullSecret",
    "journal_device": "journalDevice",
    "journal_device_spec": "journalDeviceSpec",
    "kvdb_device": "kvdbDevice",
    "kvdb_device_spec": "kvdbDeviceSpec",
    "label_selector": "labelSelector",
    "lock_image": "lockImage",
    "match_expressions": "matchExpressions",
    "match_fields": "matchFields",
    "match_labels": "matchLabels",
    "max_capacity_in_gi_b": "maxCapacityInGiB",
    "max_storage_nodes": "maxStorageNodes",
    "max_storage_nodes_per_zone": "maxStorageNodesPerZone",
    "max_unavailable": "maxUnavailable",
    "mgmt_interface": "mgmtInterface",
    "mgmt_ip": "mgmtIP",
    "min_capacity_in_gi_b": "minCapacityInGiB",
    "min_iops": "minIOPS",
    "node_affinity": "nodeAffinity",
    "node_name": "nodeName",
    "node_selector_terms": "nodeSelectorTerms",
    "node_uid": "nodeUid",
    "preferred_during_scheduling_ignored_during_execution": "preferredDuringSchedulingIgnoredDuringExecution",
    "remote_write_endpoint": "remoteWriteEndpoint",
    "required_during_scheduling_ignored_during_execution": "requiredDuringSchedulingIgnoredDuringExecution",
    "resource_field_ref": "resourceFieldRef",
    "revision_history_limit": "revisionHistoryLimit",
    "rolling_update": "rollingUpdate",
    "runtime_options": "runtimeOptions",
    "secret_key_ref": "secretKeyRef",
    "secrets_provider": "secretsProvider",
    "self_signed": "selfSigned",
    "shared_secret": "sharedSecret",
    "size_in_gi_b": "sizeInGiB",
    "start_port": "startPort",
    "storage_nodes_per_zone": "storageNodesPerZone",
    "system_metadata_device": "systemMetadataDevice",
    "system_metadata_device_spec": "systemMetadataDeviceSpec",
    "token_lifetime": "tokenLifetime",
    "toleration_seconds": "tolerationSeconds",
    "total_size": "totalSize",
    "update_strategy": "updateStrategy",
    "use_all": "useAll",
    "use_all_with_partitions": "useAllWithPartitions",
    "used_size": "usedSize",
    "user_interface": "userInterface",
    "value_from": "valueFrom",
}

CAMEL_TO_SNAKE_CASE_TABLE = {
    "apiVersion": "api_version",
    "authSecret": "auth_secret",
    "autoUpdateComponents": "auto_update_components",
    "capacitySpecs": "capacity_specs",
    "cloudStorage": "cloud_storage",
    "clusterName": "cluster_name",
    "clusterUid": "cluster_uid",
    "collisionCount": "collision_count",
    "configMapKeyRef": "config_map_key_ref",
    "containerName": "container_name",
    "customImageRegistry": "custom_image_registry",
    "dataInterface": "data_interface",
    "dataIP": "data_ip",
    "deleteStrategy": "delete_strategy",
    "deviceSpecs": "device_specs",
    "driveConfigs": "drive_configs",
    "enableMetrics": "enable_metrics",
    "exportMetrics": "export_metrics",
    "featureGates": "feature_gates",
    "fieldPath": "field_path",
    "fieldRef": "field_ref",
    "forceUseDisks": "force_use_disks",
    "guestAccess": "guest_access",
    "hostNetwork": "host_network",
    "imagePullPolicy": "image_pull_policy",
    "imagePullSecret": "image_pull_secret",
    "journalDevice": "journal_device",
    "journalDeviceSpec": "journal_device_spec",
    "kvdbDevice": "kvdb_device",
    "kvdbDeviceSpec": "kvdb_device_spec",
    "labelSelector": "label_selector",
    "lockImage": "lock_image",
    "matchExpressions": "match_expressions",
    "matchFields": "match_fields",
    "matchLabels": "match_labels",
    "maxCapacityInGiB": "max_capacity_in_gi_b",
    "maxStorageNodes": "max_storage_nodes",
    "maxStorageNodesPerZone": "max_storage_nodes_per_zone",
    "maxUnavailable": "max_unavailable",
    "mgmtInterface": "mgmt_interface",
    "mgmtIP": "mgmt_ip",
    "minCapacityInGiB": "min_capacity_in_gi_b",
    "minIOPS": "min_iops",
    "nodeAffinity": "node_affinity",
    "nodeName": "node_name",
    "nodeSelectorTerms": "node_selector_terms",
    "nodeUid": "node_uid",
    "preferredDuringSchedulingIgnoredDuringExecution": "preferred_during_scheduling_ignored_during_execution",
    "remoteWriteEndpoint": "remote_write_endpoint",
    "requiredDuringSchedulingIgnoredDuringExecution": "required_during_scheduling_ignored_during_execution",
    "resourceFieldRef": "resource_field_ref",
    "revisionHistoryLimit": "revision_history_limit",
    "rollingUpdate": "rolling_update",
    "runtimeOptions": "runtime_options",
    "secretKeyRef": "secret_key_ref",
    "secretsProvider": "secrets_provider",
    "selfSigned": "self_signed",
    "sharedSecret": "shared_secret",
    "sizeInGiB": "size_in_gi_b",
    "startPort": "start_port",
    "storageNodesPerZone": "storage_nodes_per_zone",
    "systemMetadataDevice": "system_metadata_device",
    "systemMetadataDeviceSpec": "system_metadata_device_spec",
    "tokenLifetime": "token_lifetime",
    "tolerationSeconds": "toleration_seconds",
    "totalSize": "total_size",
    "updateStrategy": "update_strategy",
    "useAll": "use_all",
    "useAllWithPartitions": "use_all_with_partitions",
    "usedSize": "used_size",
    "userInterface": "user_interface",
    "valueFrom": "value_from",
}
