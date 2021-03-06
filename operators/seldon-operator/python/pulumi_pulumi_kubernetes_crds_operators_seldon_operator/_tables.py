# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

SNAKE_TO_CAMEL_CASE_TABLE = {
    "active_deadline_seconds": "activeDeadlineSeconds",
    "allow_privilege_escalation": "allowPrivilegeEscalation",
    "api_version": "apiVersion",
    "authentication_ref": "authenticationRef",
    "automount_service_account_token": "automountServiceAccountToken",
    "available_replicas": "availableReplicas",
    "average_utilization": "averageUtilization",
    "average_value": "averageValue",
    "cert_secret_name": "certSecretName",
    "component_specs": "componentSpecs",
    "condition_type": "conditionType",
    "config_map_key_ref": "configMapKeyRef",
    "config_map_ref": "configMapRef",
    "container_name": "containerName",
    "container_port": "containerPort",
    "container_spec": "containerSpec",
    "cooldown_period": "cooldownPeriod",
    "deployment_status": "deploymentStatus",
    "device_path": "devicePath",
    "dns_config": "dnsConfig",
    "dns_policy": "dnsPolicy",
    "enable_service_links": "enableServiceLinks",
    "engine_resources": "engineResources",
    "env_from": "envFrom",
    "env_secret_ref_name": "envSecretRefName",
    "ephemeral_containers": "ephemeralContainers",
    "exec_": "exec",
    "explainer_for": "explainerFor",
    "failure_threshold": "failureThreshold",
    "field_path": "fieldPath",
    "field_ref": "fieldRef",
    "fs_group": "fsGroup",
    "fs_group_change_policy": "fsGroupChangePolicy",
    "gmsa_credential_spec": "gmsaCredentialSpec",
    "gmsa_credential_spec_name": "gmsaCredentialSpecName",
    "grpc_endpoint": "grpcEndpoint",
    "grpc_port": "grpcPort",
    "horizontal_pod_autoscaler_config": "horizontalPodAutoscalerConfig",
    "host_aliases": "hostAliases",
    "host_ip": "hostIP",
    "host_ipc": "hostIPC",
    "host_network": "hostNetwork",
    "host_pid": "hostPID",
    "host_port": "hostPort",
    "hpa_spec": "hpaSpec",
    "http_endpoint": "httpEndpoint",
    "http_get": "httpGet",
    "http_headers": "httpHeaders",
    "http_port": "httpPort",
    "image_pull_policy": "imagePullPolicy",
    "image_pull_secrets": "imagePullSecrets",
    "init_containers": "initContainers",
    "initial_delay_seconds": "initialDelaySeconds",
    "keda_spec": "kedaSpec",
    "label_selector": "labelSelector",
    "liveness_probe": "livenessProbe",
    "match_expressions": "matchExpressions",
    "match_fields": "matchFields",
    "match_labels": "matchLabels",
    "max_replica_count": "maxReplicaCount",
    "max_replicas": "maxReplicas",
    "max_skew": "maxSkew",
    "max_unavailable": "maxUnavailable",
    "metric_name": "metricName",
    "metric_selector": "metricSelector",
    "min_available": "minAvailable",
    "min_replica_count": "minReplicaCount",
    "min_replicas": "minReplicas",
    "model_uri": "modelUri",
    "mount_path": "mountPath",
    "mount_propagation": "mountPropagation",
    "node_affinity": "nodeAffinity",
    "node_name": "nodeName",
    "node_selector": "nodeSelector",
    "node_selector_terms": "nodeSelectorTerms",
    "pdb_spec": "pdbSpec",
    "period_seconds": "periodSeconds",
    "pod_affinity": "podAffinity",
    "pod_affinity_term": "podAffinityTerm",
    "pod_anti_affinity": "podAntiAffinity",
    "polling_interval": "pollingInterval",
    "post_start": "postStart",
    "pre_stop": "preStop",
    "preemption_policy": "preemptionPolicy",
    "preferred_during_scheduling_ignored_during_execution": "preferredDuringSchedulingIgnoredDuringExecution",
    "priority_class_name": "priorityClassName",
    "proc_mount": "procMount",
    "read_only": "readOnly",
    "read_only_root_filesystem": "readOnlyRootFilesystem",
    "readiness_gates": "readinessGates",
    "readiness_probe": "readinessProbe",
    "required_during_scheduling_ignored_during_execution": "requiredDuringSchedulingIgnoredDuringExecution",
    "resource_field_ref": "resourceFieldRef",
    "resource_metrics": "resourceMetrics",
    "restart_policy": "restartPolicy",
    "restore_to_original_replica_count": "restoreToOriginalReplicaCount",
    "run_as_group": "runAsGroup",
    "run_as_non_root": "runAsNonRoot",
    "run_as_user": "runAsUser",
    "run_as_user_name": "runAsUserName",
    "runtime_class_name": "runtimeClassName",
    "scale_down": "scaleDown",
    "scale_up": "scaleUp",
    "scheduler_name": "schedulerName",
    "se_linux_options": "seLinuxOptions",
    "secret_key_ref": "secretKeyRef",
    "secret_ref": "secretRef",
    "security_context": "securityContext",
    "select_policy": "selectPolicy",
    "server_type": "serverType",
    "service_account": "serviceAccount",
    "service_account_name": "serviceAccountName",
    "service_status": "serviceStatus",
    "share_process_namespace": "shareProcessNamespace",
    "stabilization_window_seconds": "stabilizationWindowSeconds",
    "startup_probe": "startupProbe",
    "stdin_once": "stdinOnce",
    "sub_path": "subPath",
    "sub_path_expr": "subPathExpr",
    "success_threshold": "successThreshold",
    "supplemental_groups": "supplementalGroups",
    "svc_name": "svcName",
    "svc_orch_spec": "svcOrchSpec",
    "target_average_utilization": "targetAverageUtilization",
    "target_average_value": "targetAverageValue",
    "target_container_name": "targetContainerName",
    "target_value": "targetValue",
    "tcp_socket": "tcpSocket",
    "termination_grace_period_seconds": "terminationGracePeriodSeconds",
    "termination_message_path": "terminationMessagePath",
    "termination_message_policy": "terminationMessagePolicy",
    "timeout_seconds": "timeoutSeconds",
    "toleration_seconds": "tolerationSeconds",
    "topology_key": "topologyKey",
    "topology_spread_constraints": "topologySpreadConstraints",
    "value_from": "valueFrom",
    "volume_devices": "volumeDevices",
    "volume_mounts": "volumeMounts",
    "when_unsatisfiable": "whenUnsatisfiable",
    "windows_options": "windowsOptions",
    "working_dir": "workingDir",
}

CAMEL_TO_SNAKE_CASE_TABLE = {
    "activeDeadlineSeconds": "active_deadline_seconds",
    "allowPrivilegeEscalation": "allow_privilege_escalation",
    "apiVersion": "api_version",
    "authenticationRef": "authentication_ref",
    "automountServiceAccountToken": "automount_service_account_token",
    "availableReplicas": "available_replicas",
    "averageUtilization": "average_utilization",
    "averageValue": "average_value",
    "certSecretName": "cert_secret_name",
    "componentSpecs": "component_specs",
    "conditionType": "condition_type",
    "configMapKeyRef": "config_map_key_ref",
    "configMapRef": "config_map_ref",
    "containerName": "container_name",
    "containerPort": "container_port",
    "containerSpec": "container_spec",
    "cooldownPeriod": "cooldown_period",
    "deploymentStatus": "deployment_status",
    "devicePath": "device_path",
    "dnsConfig": "dns_config",
    "dnsPolicy": "dns_policy",
    "enableServiceLinks": "enable_service_links",
    "engineResources": "engine_resources",
    "envFrom": "env_from",
    "envSecretRefName": "env_secret_ref_name",
    "ephemeralContainers": "ephemeral_containers",
    "exec": "exec_",
    "explainerFor": "explainer_for",
    "failureThreshold": "failure_threshold",
    "fieldPath": "field_path",
    "fieldRef": "field_ref",
    "fsGroup": "fs_group",
    "fsGroupChangePolicy": "fs_group_change_policy",
    "gmsaCredentialSpec": "gmsa_credential_spec",
    "gmsaCredentialSpecName": "gmsa_credential_spec_name",
    "grpcEndpoint": "grpc_endpoint",
    "grpcPort": "grpc_port",
    "horizontalPodAutoscalerConfig": "horizontal_pod_autoscaler_config",
    "hostAliases": "host_aliases",
    "hostIP": "host_ip",
    "hostIPC": "host_ipc",
    "hostNetwork": "host_network",
    "hostPID": "host_pid",
    "hostPort": "host_port",
    "hpaSpec": "hpa_spec",
    "httpEndpoint": "http_endpoint",
    "httpGet": "http_get",
    "httpHeaders": "http_headers",
    "httpPort": "http_port",
    "imagePullPolicy": "image_pull_policy",
    "imagePullSecrets": "image_pull_secrets",
    "initContainers": "init_containers",
    "initialDelaySeconds": "initial_delay_seconds",
    "kedaSpec": "keda_spec",
    "labelSelector": "label_selector",
    "livenessProbe": "liveness_probe",
    "matchExpressions": "match_expressions",
    "matchFields": "match_fields",
    "matchLabels": "match_labels",
    "maxReplicaCount": "max_replica_count",
    "maxReplicas": "max_replicas",
    "maxSkew": "max_skew",
    "maxUnavailable": "max_unavailable",
    "metricName": "metric_name",
    "metricSelector": "metric_selector",
    "minAvailable": "min_available",
    "minReplicaCount": "min_replica_count",
    "minReplicas": "min_replicas",
    "modelUri": "model_uri",
    "mountPath": "mount_path",
    "mountPropagation": "mount_propagation",
    "nodeAffinity": "node_affinity",
    "nodeName": "node_name",
    "nodeSelector": "node_selector",
    "nodeSelectorTerms": "node_selector_terms",
    "pdbSpec": "pdb_spec",
    "periodSeconds": "period_seconds",
    "podAffinity": "pod_affinity",
    "podAffinityTerm": "pod_affinity_term",
    "podAntiAffinity": "pod_anti_affinity",
    "pollingInterval": "polling_interval",
    "postStart": "post_start",
    "preStop": "pre_stop",
    "preemptionPolicy": "preemption_policy",
    "preferredDuringSchedulingIgnoredDuringExecution": "preferred_during_scheduling_ignored_during_execution",
    "priorityClassName": "priority_class_name",
    "procMount": "proc_mount",
    "readOnly": "read_only",
    "readOnlyRootFilesystem": "read_only_root_filesystem",
    "readinessGates": "readiness_gates",
    "readinessProbe": "readiness_probe",
    "requiredDuringSchedulingIgnoredDuringExecution": "required_during_scheduling_ignored_during_execution",
    "resourceFieldRef": "resource_field_ref",
    "resourceMetrics": "resource_metrics",
    "restartPolicy": "restart_policy",
    "restoreToOriginalReplicaCount": "restore_to_original_replica_count",
    "runAsGroup": "run_as_group",
    "runAsNonRoot": "run_as_non_root",
    "runAsUser": "run_as_user",
    "runAsUserName": "run_as_user_name",
    "runtimeClassName": "runtime_class_name",
    "scaleDown": "scale_down",
    "scaleUp": "scale_up",
    "schedulerName": "scheduler_name",
    "seLinuxOptions": "se_linux_options",
    "secretKeyRef": "secret_key_ref",
    "secretRef": "secret_ref",
    "securityContext": "security_context",
    "selectPolicy": "select_policy",
    "serverType": "server_type",
    "serviceAccount": "service_account",
    "serviceAccountName": "service_account_name",
    "serviceStatus": "service_status",
    "shareProcessNamespace": "share_process_namespace",
    "stabilizationWindowSeconds": "stabilization_window_seconds",
    "startupProbe": "startup_probe",
    "stdinOnce": "stdin_once",
    "subPath": "sub_path",
    "subPathExpr": "sub_path_expr",
    "successThreshold": "success_threshold",
    "supplementalGroups": "supplemental_groups",
    "svcName": "svc_name",
    "svcOrchSpec": "svc_orch_spec",
    "targetAverageUtilization": "target_average_utilization",
    "targetAverageValue": "target_average_value",
    "targetContainerName": "target_container_name",
    "targetValue": "target_value",
    "tcpSocket": "tcp_socket",
    "terminationGracePeriodSeconds": "termination_grace_period_seconds",
    "terminationMessagePath": "termination_message_path",
    "terminationMessagePolicy": "termination_message_policy",
    "timeoutSeconds": "timeout_seconds",
    "tolerationSeconds": "toleration_seconds",
    "topologyKey": "topology_key",
    "topologySpreadConstraints": "topology_spread_constraints",
    "valueFrom": "value_from",
    "volumeDevices": "volume_devices",
    "volumeMounts": "volume_mounts",
    "whenUnsatisfiable": "when_unsatisfiable",
    "windowsOptions": "windows_options",
    "workingDir": "working_dir",
}
