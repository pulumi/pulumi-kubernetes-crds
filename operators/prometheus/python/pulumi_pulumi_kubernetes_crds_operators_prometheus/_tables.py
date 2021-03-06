# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

SNAKE_TO_CAMEL_CASE_TABLE = {
    "access_modes": "accessModes",
    "additional_alert_manager_configs": "additionalAlertManagerConfigs",
    "additional_alert_relabel_configs": "additionalAlertRelabelConfigs",
    "additional_peers": "additionalPeers",
    "additional_scrape_configs": "additionalScrapeConfigs",
    "alert_drop_labels": "alertDropLabels",
    "alertmanagers_config": "alertmanagersConfig",
    "alertmanagers_url": "alertmanagersUrl",
    "allow_privilege_escalation": "allowPrivilegeEscalation",
    "api_group": "apiGroup",
    "api_version": "apiVersion",
    "apiserver_config": "apiserverConfig",
    "arbitrary_fs_access_through_s_ms": "arbitraryFSAccessThroughSMs",
    "available_replicas": "availableReplicas",
    "aws_elastic_block_store": "awsElasticBlockStore",
    "azure_disk": "azureDisk",
    "azure_file": "azureFile",
    "base_image": "baseImage",
    "basic_auth": "basicAuth",
    "batch_send_deadline": "batchSendDeadline",
    "bearer_token": "bearerToken",
    "bearer_token_file": "bearerTokenFile",
    "bearer_token_secret": "bearerTokenSecret",
    "ca_file": "caFile",
    "caching_mode": "cachingMode",
    "cert_file": "certFile",
    "chap_auth_discovery": "chapAuthDiscovery",
    "chap_auth_session": "chapAuthSession",
    "claim_name": "claimName",
    "config_map": "configMap",
    "config_map_key_ref": "configMapKeyRef",
    "config_map_ref": "configMapRef",
    "config_maps": "configMaps",
    "config_secret": "configSecret",
    "container_name": "containerName",
    "container_port": "containerPort",
    "data_source": "dataSource",
    "dataset_name": "datasetName",
    "dataset_uuid": "datasetUUID",
    "default_mode": "defaultMode",
    "device_path": "devicePath",
    "disable_compaction": "disableCompaction",
    "disk_name": "diskName",
    "disk_uri": "diskURI",
    "downward_api": "downwardAPI",
    "empty_dir": "emptyDir",
    "enable_admin_api": "enableAdminAPI",
    "enforced_namespace_label": "enforcedNamespaceLabel",
    "env_from": "envFrom",
    "evaluation_interval": "evaluationInterval",
    "exec_": "exec",
    "expiration_seconds": "expirationSeconds",
    "external_labels": "externalLabels",
    "external_prefix": "externalPrefix",
    "external_url": "externalUrl",
    "failure_threshold": "failureThreshold",
    "field_path": "fieldPath",
    "field_ref": "fieldRef",
    "flex_volume": "flexVolume",
    "for_": "for",
    "for_grace_period": "forGracePeriod",
    "for_outage_tolerance": "forOutageTolerance",
    "fs_group": "fsGroup",
    "fs_type": "fsType",
    "gce_persistent_disk": "gcePersistentDisk",
    "git_repo": "gitRepo",
    "gmsa_credential_spec": "gmsaCredentialSpec",
    "gmsa_credential_spec_name": "gmsaCredentialSpecName",
    "honor_labels": "honorLabels",
    "honor_timestamps": "honorTimestamps",
    "host_ip": "hostIP",
    "host_path": "hostPath",
    "host_port": "hostPort",
    "http_get": "httpGet",
    "http_headers": "httpHeaders",
    "ignore_namespace_selectors": "ignoreNamespaceSelectors",
    "image_pull_policy": "imagePullPolicy",
    "image_pull_secrets": "imagePullSecrets",
    "init_containers": "initContainers",
    "initial_delay_seconds": "initialDelaySeconds",
    "initiator_name": "initiatorName",
    "insecure_skip_verify": "insecureSkipVerify",
    "iscsi_interface": "iscsiInterface",
    "job_label": "jobLabel",
    "key_file": "keyFile",
    "key_secret": "keySecret",
    "label_selector": "labelSelector",
    "last_probe_time": "lastProbeTime",
    "last_transition_time": "lastTransitionTime",
    "listen_local": "listenLocal",
    "liveness_probe": "livenessProbe",
    "log_format": "logFormat",
    "log_level": "logLevel",
    "lookback_delta": "lookbackDelta",
    "match_expressions": "matchExpressions",
    "match_fields": "matchFields",
    "match_labels": "matchLabels",
    "match_names": "matchNames",
    "max_backoff": "maxBackoff",
    "max_concurrency": "maxConcurrency",
    "max_retries": "maxRetries",
    "max_samples": "maxSamples",
    "max_samples_per_send": "maxSamplesPerSend",
    "max_shards": "maxShards",
    "metric_relabelings": "metricRelabelings",
    "min_backoff": "minBackoff",
    "min_shards": "minShards",
    "mount_path": "mountPath",
    "mount_propagation": "mountPropagation",
    "namespace_selector": "namespaceSelector",
    "node_affinity": "nodeAffinity",
    "node_publish_secret_ref": "nodePublishSecretRef",
    "node_selector": "nodeSelector",
    "node_selector_terms": "nodeSelectorTerms",
    "object_storage_config": "objectStorageConfig",
    "override_honor_labels": "overrideHonorLabels",
    "override_honor_timestamps": "overrideHonorTimestamps",
    "path_prefix": "pathPrefix",
    "pd_id": "pdID",
    "pd_name": "pdName",
    "period_seconds": "periodSeconds",
    "persistent_volume_claim": "persistentVolumeClaim",
    "photon_persistent_disk": "photonPersistentDisk",
    "pod_affinity": "podAffinity",
    "pod_affinity_term": "podAffinityTerm",
    "pod_anti_affinity": "podAntiAffinity",
    "pod_metadata": "podMetadata",
    "pod_metrics_endpoints": "podMetricsEndpoints",
    "pod_monitor_namespace_selector": "podMonitorNamespaceSelector",
    "pod_monitor_selector": "podMonitorSelector",
    "pod_target_labels": "podTargetLabels",
    "port_name": "portName",
    "portworx_volume": "portworxVolume",
    "post_start": "postStart",
    "pre_stop": "preStop",
    "preferred_during_scheduling_ignored_during_execution": "preferredDuringSchedulingIgnoredDuringExecution",
    "priority_class_name": "priorityClassName",
    "proc_mount": "procMount",
    "prometheus_external_label_name": "prometheusExternalLabelName",
    "protection_domain": "protectionDomain",
    "proxy_url": "proxyUrl",
    "query_config": "queryConfig",
    "query_endpoints": "queryEndpoints",
    "queue_config": "queueConfig",
    "read_only": "readOnly",
    "read_only_root_filesystem": "readOnlyRootFilesystem",
    "read_recent": "readRecent",
    "readiness_probe": "readinessProbe",
    "remote_read": "remoteRead",
    "remote_timeout": "remoteTimeout",
    "remote_write": "remoteWrite",
    "replica_external_label_name": "replicaExternalLabelName",
    "required_during_scheduling_ignored_during_execution": "requiredDuringSchedulingIgnoredDuringExecution",
    "required_matchers": "requiredMatchers",
    "resend_delay": "resendDelay",
    "resource_field_ref": "resourceFieldRef",
    "retention_size": "retentionSize",
    "route_prefix": "routePrefix",
    "rule_namespace_selector": "ruleNamespaceSelector",
    "rule_selector": "ruleSelector",
    "run_as_group": "runAsGroup",
    "run_as_non_root": "runAsNonRoot",
    "run_as_user": "runAsUser",
    "run_as_user_name": "runAsUserName",
    "sample_limit": "sampleLimit",
    "scale_io": "scaleIO",
    "scrape_interval": "scrapeInterval",
    "scrape_timeout": "scrapeTimeout",
    "se_linux_options": "seLinuxOptions",
    "secret_file": "secretFile",
    "secret_key_ref": "secretKeyRef",
    "secret_name": "secretName",
    "secret_ref": "secretRef",
    "security_context": "securityContext",
    "server_name": "serverName",
    "service_account_name": "serviceAccountName",
    "service_account_token": "serviceAccountToken",
    "service_monitor_namespace_selector": "serviceMonitorNamespaceSelector",
    "service_monitor_selector": "serviceMonitorSelector",
    "share_name": "shareName",
    "size_limit": "sizeLimit",
    "source_labels": "sourceLabels",
    "ssl_enabled": "sslEnabled",
    "startup_probe": "startupProbe",
    "stdin_once": "stdinOnce",
    "storage_class_name": "storageClassName",
    "storage_mode": "storageMode",
    "storage_policy_id": "storagePolicyID",
    "storage_policy_name": "storagePolicyName",
    "storage_pool": "storagePool",
    "sub_path": "subPath",
    "sub_path_expr": "subPathExpr",
    "success_threshold": "successThreshold",
    "supplemental_groups": "supplementalGroups",
    "target_label": "targetLabel",
    "target_labels": "targetLabels",
    "target_port": "targetPort",
    "target_portal": "targetPortal",
    "target_ww_ns": "targetWWNs",
    "tcp_socket": "tcpSocket",
    "termination_message_path": "terminationMessagePath",
    "termination_message_policy": "terminationMessagePolicy",
    "timeout_seconds": "timeoutSeconds",
    "tls_config": "tlsConfig",
    "toleration_seconds": "tolerationSeconds",
    "topology_key": "topologyKey",
    "tracing_config": "tracingConfig",
    "unavailable_replicas": "unavailableReplicas",
    "updated_replicas": "updatedReplicas",
    "value_from": "valueFrom",
    "volume_attributes": "volumeAttributes",
    "volume_claim_template": "volumeClaimTemplate",
    "volume_devices": "volumeDevices",
    "volume_id": "volumeID",
    "volume_mode": "volumeMode",
    "volume_mounts": "volumeMounts",
    "volume_name": "volumeName",
    "volume_namespace": "volumeNamespace",
    "volume_path": "volumePath",
    "vsphere_volume": "vsphereVolume",
    "wal_compression": "walCompression",
    "windows_options": "windowsOptions",
    "working_dir": "workingDir",
    "write_relabel_configs": "writeRelabelConfigs",
}

CAMEL_TO_SNAKE_CASE_TABLE = {
    "accessModes": "access_modes",
    "additionalAlertManagerConfigs": "additional_alert_manager_configs",
    "additionalAlertRelabelConfigs": "additional_alert_relabel_configs",
    "additionalPeers": "additional_peers",
    "additionalScrapeConfigs": "additional_scrape_configs",
    "alertDropLabels": "alert_drop_labels",
    "alertmanagersConfig": "alertmanagers_config",
    "alertmanagersUrl": "alertmanagers_url",
    "allowPrivilegeEscalation": "allow_privilege_escalation",
    "apiGroup": "api_group",
    "apiVersion": "api_version",
    "apiserverConfig": "apiserver_config",
    "arbitraryFSAccessThroughSMs": "arbitrary_fs_access_through_s_ms",
    "availableReplicas": "available_replicas",
    "awsElasticBlockStore": "aws_elastic_block_store",
    "azureDisk": "azure_disk",
    "azureFile": "azure_file",
    "baseImage": "base_image",
    "basicAuth": "basic_auth",
    "batchSendDeadline": "batch_send_deadline",
    "bearerToken": "bearer_token",
    "bearerTokenFile": "bearer_token_file",
    "bearerTokenSecret": "bearer_token_secret",
    "caFile": "ca_file",
    "cachingMode": "caching_mode",
    "certFile": "cert_file",
    "chapAuthDiscovery": "chap_auth_discovery",
    "chapAuthSession": "chap_auth_session",
    "claimName": "claim_name",
    "configMap": "config_map",
    "configMapKeyRef": "config_map_key_ref",
    "configMapRef": "config_map_ref",
    "configMaps": "config_maps",
    "configSecret": "config_secret",
    "containerName": "container_name",
    "containerPort": "container_port",
    "dataSource": "data_source",
    "datasetName": "dataset_name",
    "datasetUUID": "dataset_uuid",
    "defaultMode": "default_mode",
    "devicePath": "device_path",
    "disableCompaction": "disable_compaction",
    "diskName": "disk_name",
    "diskURI": "disk_uri",
    "downwardAPI": "downward_api",
    "emptyDir": "empty_dir",
    "enableAdminAPI": "enable_admin_api",
    "enforcedNamespaceLabel": "enforced_namespace_label",
    "envFrom": "env_from",
    "evaluationInterval": "evaluation_interval",
    "exec": "exec_",
    "expirationSeconds": "expiration_seconds",
    "externalLabels": "external_labels",
    "externalPrefix": "external_prefix",
    "externalUrl": "external_url",
    "failureThreshold": "failure_threshold",
    "fieldPath": "field_path",
    "fieldRef": "field_ref",
    "flexVolume": "flex_volume",
    "for": "for_",
    "forGracePeriod": "for_grace_period",
    "forOutageTolerance": "for_outage_tolerance",
    "fsGroup": "fs_group",
    "fsType": "fs_type",
    "gcePersistentDisk": "gce_persistent_disk",
    "gitRepo": "git_repo",
    "gmsaCredentialSpec": "gmsa_credential_spec",
    "gmsaCredentialSpecName": "gmsa_credential_spec_name",
    "honorLabels": "honor_labels",
    "honorTimestamps": "honor_timestamps",
    "hostIP": "host_ip",
    "hostPath": "host_path",
    "hostPort": "host_port",
    "httpGet": "http_get",
    "httpHeaders": "http_headers",
    "ignoreNamespaceSelectors": "ignore_namespace_selectors",
    "imagePullPolicy": "image_pull_policy",
    "imagePullSecrets": "image_pull_secrets",
    "initContainers": "init_containers",
    "initialDelaySeconds": "initial_delay_seconds",
    "initiatorName": "initiator_name",
    "insecureSkipVerify": "insecure_skip_verify",
    "iscsiInterface": "iscsi_interface",
    "jobLabel": "job_label",
    "keyFile": "key_file",
    "keySecret": "key_secret",
    "labelSelector": "label_selector",
    "lastProbeTime": "last_probe_time",
    "lastTransitionTime": "last_transition_time",
    "listenLocal": "listen_local",
    "livenessProbe": "liveness_probe",
    "logFormat": "log_format",
    "logLevel": "log_level",
    "lookbackDelta": "lookback_delta",
    "matchExpressions": "match_expressions",
    "matchFields": "match_fields",
    "matchLabels": "match_labels",
    "matchNames": "match_names",
    "maxBackoff": "max_backoff",
    "maxConcurrency": "max_concurrency",
    "maxRetries": "max_retries",
    "maxSamples": "max_samples",
    "maxSamplesPerSend": "max_samples_per_send",
    "maxShards": "max_shards",
    "metricRelabelings": "metric_relabelings",
    "minBackoff": "min_backoff",
    "minShards": "min_shards",
    "mountPath": "mount_path",
    "mountPropagation": "mount_propagation",
    "namespaceSelector": "namespace_selector",
    "nodeAffinity": "node_affinity",
    "nodePublishSecretRef": "node_publish_secret_ref",
    "nodeSelector": "node_selector",
    "nodeSelectorTerms": "node_selector_terms",
    "objectStorageConfig": "object_storage_config",
    "overrideHonorLabels": "override_honor_labels",
    "overrideHonorTimestamps": "override_honor_timestamps",
    "pathPrefix": "path_prefix",
    "pdID": "pd_id",
    "pdName": "pd_name",
    "periodSeconds": "period_seconds",
    "persistentVolumeClaim": "persistent_volume_claim",
    "photonPersistentDisk": "photon_persistent_disk",
    "podAffinity": "pod_affinity",
    "podAffinityTerm": "pod_affinity_term",
    "podAntiAffinity": "pod_anti_affinity",
    "podMetadata": "pod_metadata",
    "podMetricsEndpoints": "pod_metrics_endpoints",
    "podMonitorNamespaceSelector": "pod_monitor_namespace_selector",
    "podMonitorSelector": "pod_monitor_selector",
    "podTargetLabels": "pod_target_labels",
    "portName": "port_name",
    "portworxVolume": "portworx_volume",
    "postStart": "post_start",
    "preStop": "pre_stop",
    "preferredDuringSchedulingIgnoredDuringExecution": "preferred_during_scheduling_ignored_during_execution",
    "priorityClassName": "priority_class_name",
    "procMount": "proc_mount",
    "prometheusExternalLabelName": "prometheus_external_label_name",
    "protectionDomain": "protection_domain",
    "proxyUrl": "proxy_url",
    "queryConfig": "query_config",
    "queryEndpoints": "query_endpoints",
    "queueConfig": "queue_config",
    "readOnly": "read_only",
    "readOnlyRootFilesystem": "read_only_root_filesystem",
    "readRecent": "read_recent",
    "readinessProbe": "readiness_probe",
    "remoteRead": "remote_read",
    "remoteTimeout": "remote_timeout",
    "remoteWrite": "remote_write",
    "replicaExternalLabelName": "replica_external_label_name",
    "requiredDuringSchedulingIgnoredDuringExecution": "required_during_scheduling_ignored_during_execution",
    "requiredMatchers": "required_matchers",
    "resendDelay": "resend_delay",
    "resourceFieldRef": "resource_field_ref",
    "retentionSize": "retention_size",
    "routePrefix": "route_prefix",
    "ruleNamespaceSelector": "rule_namespace_selector",
    "ruleSelector": "rule_selector",
    "runAsGroup": "run_as_group",
    "runAsNonRoot": "run_as_non_root",
    "runAsUser": "run_as_user",
    "runAsUserName": "run_as_user_name",
    "sampleLimit": "sample_limit",
    "scaleIO": "scale_io",
    "scrapeInterval": "scrape_interval",
    "scrapeTimeout": "scrape_timeout",
    "seLinuxOptions": "se_linux_options",
    "secretFile": "secret_file",
    "secretKeyRef": "secret_key_ref",
    "secretName": "secret_name",
    "secretRef": "secret_ref",
    "securityContext": "security_context",
    "serverName": "server_name",
    "serviceAccountName": "service_account_name",
    "serviceAccountToken": "service_account_token",
    "serviceMonitorNamespaceSelector": "service_monitor_namespace_selector",
    "serviceMonitorSelector": "service_monitor_selector",
    "shareName": "share_name",
    "sizeLimit": "size_limit",
    "sourceLabels": "source_labels",
    "sslEnabled": "ssl_enabled",
    "startupProbe": "startup_probe",
    "stdinOnce": "stdin_once",
    "storageClassName": "storage_class_name",
    "storageMode": "storage_mode",
    "storagePolicyID": "storage_policy_id",
    "storagePolicyName": "storage_policy_name",
    "storagePool": "storage_pool",
    "subPath": "sub_path",
    "subPathExpr": "sub_path_expr",
    "successThreshold": "success_threshold",
    "supplementalGroups": "supplemental_groups",
    "targetLabel": "target_label",
    "targetLabels": "target_labels",
    "targetPort": "target_port",
    "targetPortal": "target_portal",
    "targetWWNs": "target_ww_ns",
    "tcpSocket": "tcp_socket",
    "terminationMessagePath": "termination_message_path",
    "terminationMessagePolicy": "termination_message_policy",
    "timeoutSeconds": "timeout_seconds",
    "tlsConfig": "tls_config",
    "tolerationSeconds": "toleration_seconds",
    "topologyKey": "topology_key",
    "tracingConfig": "tracing_config",
    "unavailableReplicas": "unavailable_replicas",
    "updatedReplicas": "updated_replicas",
    "valueFrom": "value_from",
    "volumeAttributes": "volume_attributes",
    "volumeClaimTemplate": "volume_claim_template",
    "volumeDevices": "volume_devices",
    "volumeID": "volume_id",
    "volumeMode": "volume_mode",
    "volumeMounts": "volume_mounts",
    "volumeName": "volume_name",
    "volumeNamespace": "volume_namespace",
    "volumePath": "volume_path",
    "vsphereVolume": "vsphere_volume",
    "walCompression": "wal_compression",
    "windowsOptions": "windows_options",
    "workingDir": "working_dir",
    "writeRelabelConfigs": "write_relabel_configs",
}
