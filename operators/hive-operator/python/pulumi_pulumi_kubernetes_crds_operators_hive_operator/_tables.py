# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

SNAKE_TO_CAMEL_CASE_TABLE = {
    "active_deadline_seconds": "activeDeadlineSeconds",
    "additional_certificate_authorities_secret_ref": "additionalCertificateAuthoritiesSecretRef",
    "additional_tags": "additionalTags",
    "admin_kubeconfig_secret_ref": "adminKubeconfigSecretRef",
    "admin_password_secret_ref": "adminPasswordSecretRef",
    "aggregator_client_ca_hash": "aggregatorClientCAHash",
    "allow_privilege_escalation": "allowPrivilegeEscalation",
    "api_group": "apiGroup",
    "api_url": "apiURL",
    "api_url_override": "apiURLOverride",
    "api_version": "apiVersion",
    "apply_behavior": "applyBehavior",
    "automount_service_account_token": "automountServiceAccountToken",
    "available_updates": "availableUpdates",
    "aws_elastic_block_store": "awsElasticBlockStore",
    "azure_disk": "azureDisk",
    "azure_file": "azureFile",
    "base_domain": "baseDomain",
    "base_domain_resource_group_name": "baseDomainResourceGroupName",
    "basic_auth": "basicAuth",
    "bind_dn": "bindDN",
    "bind_password": "bindPassword",
    "caching_mode": "cachingMode",
    "certificate_bundles": "certificateBundles",
    "certificate_secret_ref": "certificateSecretRef",
    "certificates_secret_ref": "certificatesSecretRef",
    "challenge_url": "challengeURL",
    "chap_auth_discovery": "chapAuthDiscovery",
    "chap_auth_session": "chapAuthSession",
    "claim_name": "claimName",
    "cli_image": "cliImage",
    "client_common_names": "clientCommonNames",
    "client_id": "clientID",
    "client_secret": "clientSecret",
    "cluster_deployment_ref": "clusterDeploymentRef",
    "cluster_deployment_refs": "clusterDeploymentRefs",
    "cluster_deployment_selector": "clusterDeploymentSelector",
    "cluster_id": "clusterID",
    "cluster_metadata": "clusterMetadata",
    "cluster_name": "clusterName",
    "cluster_operators": "clusterOperators",
    "cluster_pool_name": "clusterPoolName",
    "cluster_pool_ref": "clusterPoolRef",
    "cluster_version_status": "clusterVersionStatus",
    "completion_time": "completionTime",
    "condition_type": "conditionType",
    "config_applied": "configApplied",
    "config_map": "configMap",
    "config_map_key_ref": "configMapKeyRef",
    "config_map_ref": "configMapRef",
    "container_name": "containerName",
    "container_port": "containerPort",
    "control_plane_config": "controlPlaneConfig",
    "cores_per_socket": "coresPerSocket",
    "credentials_secret_ref": "credentialsSecretRef",
    "dataset_name": "datasetName",
    "dataset_uuid": "datasetUUID",
    "default_datastore": "defaultDatastore",
    "default_mode": "defaultMode",
    "delete_protection": "deleteProtection",
    "deprovisions_disabled": "deprovisionsDisabled",
    "device_path": "devicePath",
    "disabled_controllers": "disabledControllers",
    "disk_name": "diskName",
    "disk_size_gb": "diskSizeGB",
    "disk_uri": "diskURI",
    "dns_config": "dnsConfig",
    "dns_policy": "dnsPolicy",
    "domain_name": "domainName",
    "downward_api": "downwardAPI",
    "email_headers": "emailHeaders",
    "empty_dir": "emptyDir",
    "enable_service_links": "enableServiceLinks",
    "env_from": "envFrom",
    "ephemeral_containers": "ephemeralContainers",
    "exec_": "exec",
    "expiration_seconds": "expirationSeconds",
    "extra_authorize_parameters": "extraAuthorizeParameters",
    "extra_scopes": "extraScopes",
    "failed_provision_config": "failedProvisionConfig",
    "failure_threshold": "failureThreshold",
    "field_path": "fieldPath",
    "field_ref": "fieldRef",
    "file_data": "fileData",
    "first_success_timestamp": "firstSuccessTimestamp",
    "flex_volume": "flexVolume",
    "fs_group": "fsGroup",
    "fs_group_change_policy": "fsGroupChangePolicy",
    "fs_type": "fsType",
    "gce_persistent_disk": "gcePersistentDisk",
    "git_repo": "gitRepo",
    "global_pull_secret_ref": "globalPullSecretRef",
    "gmsa_credential_spec": "gmsaCredentialSpec",
    "gmsa_credential_spec_name": "gmsaCredentialSpecName",
    "hive_api_enabled": "hiveAPIEnabled",
    "host_aliases": "hostAliases",
    "host_ip": "hostIP",
    "host_ipc": "hostIPC",
    "host_network": "hostNetwork",
    "host_path": "hostPath",
    "host_pid": "hostPID",
    "host_port": "hostPort",
    "hosted_domain": "hostedDomain",
    "http_get": "httpGet",
    "http_headers": "httpHeaders",
    "identity_providers": "identityProviders",
    "image_pull_policy": "imagePullPolicy",
    "image_pull_secrets": "imagePullSecrets",
    "image_set_ref": "imageSetRef",
    "infra_id": "infraID",
    "init_containers": "initContainers",
    "initial_delay_seconds": "initialDelaySeconds",
    "initiator_name": "initiatorName",
    "install_config_secret_ref": "installConfigSecretRef",
    "install_log": "installLog",
    "install_restarts": "installRestarts",
    "installed_timestamp": "installedTimestamp",
    "installer_env": "installerEnv",
    "installer_image": "installerImage",
    "iscsi_interface": "iscsiInterface",
    "job_ref": "jobRef",
    "kubeconfig_secret_ref": "kubeconfigSecretRef",
    "label_selector": "labelSelector",
    "last_backup_checksum": "lastBackupChecksum",
    "last_backup_ref": "lastBackupRef",
    "last_backup_time": "lastBackupTime",
    "last_probe_time": "lastProbeTime",
    "last_sync_generation": "lastSyncGeneration",
    "last_sync_timestamp": "lastSyncTimestamp",
    "last_transition_time": "lastTransitionTime",
    "last_updated": "lastUpdated",
    "libvirt_ssh_private_key_secret_ref": "libvirtSSHPrivateKeySecretRef",
    "link_to_parent_domain": "linkToParentDomain",
    "liveness_probe": "livenessProbe",
    "log_level": "logLevel",
    "login_url": "loginURL",
    "machine_sets": "machineSets",
    "maintenance_mode": "maintenanceMode",
    "manage_dns": "manageDNS",
    "managed_domains": "managedDomains",
    "manifests_config_map_ref": "manifestsConfigMapRef",
    "mapping_method": "mappingMethod",
    "match_expressions": "matchExpressions",
    "match_fields": "matchFields",
    "match_labels": "matchLabels",
    "max_price": "maxPrice",
    "max_replicas": "maxReplicas",
    "max_skew": "maxSkew",
    "memory_mb": "memoryMB",
    "min_backup_period_seconds": "minBackupPeriodSeconds",
    "min_replicas": "minReplicas",
    "mount_path": "mountPath",
    "mount_propagation": "mountPropagation",
    "name_headers": "nameHeaders",
    "name_servers": "nameServers",
    "namespace_selector": "namespaceSelector",
    "node_affinity": "nodeAffinity",
    "node_name": "nodeName",
    "node_publish_secret_ref": "nodePublishSecretRef",
    "node_selector": "nodeSelector",
    "node_selector_terms": "nodeSelectorTerms",
    "observed_generation": "observedGeneration",
    "open_id": "openID",
    "os_disk": "osDisk",
    "patch_type": "patchType",
    "pd_id": "pdID",
    "pd_name": "pdName",
    "period_seconds": "periodSeconds",
    "persistent_volume_claim": "persistentVolumeClaim",
    "photon_persistent_disk": "photonPersistentDisk",
    "pod_affinity": "podAffinity",
    "pod_affinity_term": "podAffinityTerm",
    "pod_anti_affinity": "podAntiAffinity",
    "pod_spec": "podSpec",
    "pool_name": "poolName",
    "portworx_volume": "portworxVolume",
    "post_start": "postStart",
    "power_state": "powerState",
    "pre_stop": "preStop",
    "preemption_policy": "preemptionPolicy",
    "preferred_during_scheduling_ignored_during_execution": "preferredDuringSchedulingIgnoredDuringExecution",
    "preferred_username": "preferredUsername",
    "preferred_username_headers": "preferredUsernameHeaders",
    "preserve_on_delete": "preserveOnDelete",
    "prev_cluster_id": "prevClusterID",
    "prev_infra_id": "prevInfraID",
    "priority_class_name": "priorityClassName",
    "proc_mount": "procMount",
    "protection_domain": "protectionDomain",
    "provision_ref": "provisionRef",
    "pull_secret_ref": "pullSecretRef",
    "read_only": "readOnly",
    "read_only_root_filesystem": "readOnlyRootFilesystem",
    "readiness_gates": "readinessGates",
    "readiness_probe": "readinessProbe",
    "release_image": "releaseImage",
    "request_header": "requestHeader",
    "required_during_scheduling_ignored_during_execution": "requiredDuringSchedulingIgnoredDuringExecution",
    "resource_apply_mode": "resourceApplyMode",
    "resource_field_ref": "resourceFieldRef",
    "resource_group_name": "resourceGroupName",
    "restart_policy": "restartPolicy",
    "root_volume": "rootVolume",
    "route_selector": "routeSelector",
    "run_as_group": "runAsGroup",
    "run_as_non_root": "runAsNonRoot",
    "run_as_user": "runAsUser",
    "run_as_user_name": "runAsUserName",
    "runtime_class_name": "runtimeClassName",
    "scale_io": "scaleIO",
    "scheduler_name": "schedulerName",
    "se_linux_options": "seLinuxOptions",
    "secret_file": "secretFile",
    "secret_key_ref": "secretKeyRef",
    "secret_mappings": "secretMappings",
    "secret_name": "secretName",
    "secret_ref": "secretRef",
    "secret_references": "secretReferences",
    "security_context": "securityContext",
    "selector_sync_set_ref": "selectorSyncSetRef",
    "service_account": "serviceAccount",
    "service_account_name": "serviceAccountName",
    "service_account_token": "serviceAccountToken",
    "serving_certificate": "servingCertificate",
    "serving_certificates": "servingCertificates",
    "share_name": "shareName",
    "share_process_namespace": "shareProcessNamespace",
    "size_gb": "sizeGB",
    "size_limit": "sizeLimit",
    "skip_gather_logs": "skipGatherLogs",
    "source_ref": "sourceRef",
    "spot_market_options": "spotMarketOptions",
    "ssh_known_hosts": "sshKnownHosts",
    "ssh_private_key_secret_ref": "sshPrivateKeySecretRef",
    "ssl_enabled": "sslEnabled",
    "started_time": "startedTime",
    "startup_probe": "startupProbe",
    "stdin_once": "stdinOnce",
    "storage_mode": "storageMode",
    "storage_policy_id": "storagePolicyID",
    "storage_policy_name": "storagePolicyName",
    "storage_pool": "storagePool",
    "sub_path": "subPath",
    "sub_path_expr": "subPathExpr",
    "success_threshold": "successThreshold",
    "supplemental_groups": "supplementalGroups",
    "sync_set_hash": "syncSetHash",
    "sync_set_reapply_interval": "syncSetReapplyInterval",
    "sync_set_ref": "syncSetRef",
    "target_container_name": "targetContainerName",
    "target_namespace": "targetNamespace",
    "target_portal": "targetPortal",
    "target_ref": "targetRef",
    "target_ww_ns": "targetWWNs",
    "tcp_socket": "tcpSocket",
    "termination_grace_period_seconds": "terminationGracePeriodSeconds",
    "termination_message_path": "terminationMessagePath",
    "termination_message_policy": "terminationMessagePolicy",
    "time_added": "timeAdded",
    "timeout_seconds": "timeoutSeconds",
    "tls_client_cert": "tlsClientCert",
    "tls_client_key": "tlsClientKey",
    "toleration_seconds": "tolerationSeconds",
    "topology_key": "topologyKey",
    "topology_spread_constraints": "topologySpreadConstraints",
    "trunk_support": "trunkSupport",
    "user_tags": "userTags",
    "v_center": "vCenter",
    "value_from": "valueFrom",
    "version_hash": "versionHash",
    "vm_type": "vmType",
    "volume_attributes": "volumeAttributes",
    "volume_devices": "volumeDevices",
    "volume_id": "volumeID",
    "volume_mounts": "volumeMounts",
    "volume_name": "volumeName",
    "volume_namespace": "volumeNamespace",
    "volume_path": "volumePath",
    "vsphere_volume": "vsphereVolume",
    "web_console_url": "webConsoleURL",
    "when_unsatisfiable": "whenUnsatisfiable",
    "windows_options": "windowsOptions",
    "working_dir": "workingDir",
    "zone_id": "zoneID",
    "zone_name": "zoneName",
}

CAMEL_TO_SNAKE_CASE_TABLE = {
    "activeDeadlineSeconds": "active_deadline_seconds",
    "additionalCertificateAuthoritiesSecretRef": "additional_certificate_authorities_secret_ref",
    "additionalTags": "additional_tags",
    "adminKubeconfigSecretRef": "admin_kubeconfig_secret_ref",
    "adminPasswordSecretRef": "admin_password_secret_ref",
    "aggregatorClientCAHash": "aggregator_client_ca_hash",
    "allowPrivilegeEscalation": "allow_privilege_escalation",
    "apiGroup": "api_group",
    "apiURL": "api_url",
    "apiURLOverride": "api_url_override",
    "apiVersion": "api_version",
    "applyBehavior": "apply_behavior",
    "automountServiceAccountToken": "automount_service_account_token",
    "availableUpdates": "available_updates",
    "awsElasticBlockStore": "aws_elastic_block_store",
    "azureDisk": "azure_disk",
    "azureFile": "azure_file",
    "baseDomain": "base_domain",
    "baseDomainResourceGroupName": "base_domain_resource_group_name",
    "basicAuth": "basic_auth",
    "bindDN": "bind_dn",
    "bindPassword": "bind_password",
    "cachingMode": "caching_mode",
    "certificateBundles": "certificate_bundles",
    "certificateSecretRef": "certificate_secret_ref",
    "certificatesSecretRef": "certificates_secret_ref",
    "challengeURL": "challenge_url",
    "chapAuthDiscovery": "chap_auth_discovery",
    "chapAuthSession": "chap_auth_session",
    "claimName": "claim_name",
    "cliImage": "cli_image",
    "clientCommonNames": "client_common_names",
    "clientID": "client_id",
    "clientSecret": "client_secret",
    "clusterDeploymentRef": "cluster_deployment_ref",
    "clusterDeploymentRefs": "cluster_deployment_refs",
    "clusterDeploymentSelector": "cluster_deployment_selector",
    "clusterID": "cluster_id",
    "clusterMetadata": "cluster_metadata",
    "clusterName": "cluster_name",
    "clusterOperators": "cluster_operators",
    "clusterPoolName": "cluster_pool_name",
    "clusterPoolRef": "cluster_pool_ref",
    "clusterVersionStatus": "cluster_version_status",
    "completionTime": "completion_time",
    "conditionType": "condition_type",
    "configApplied": "config_applied",
    "configMap": "config_map",
    "configMapKeyRef": "config_map_key_ref",
    "configMapRef": "config_map_ref",
    "containerName": "container_name",
    "containerPort": "container_port",
    "controlPlaneConfig": "control_plane_config",
    "coresPerSocket": "cores_per_socket",
    "credentialsSecretRef": "credentials_secret_ref",
    "datasetName": "dataset_name",
    "datasetUUID": "dataset_uuid",
    "defaultDatastore": "default_datastore",
    "defaultMode": "default_mode",
    "deleteProtection": "delete_protection",
    "deprovisionsDisabled": "deprovisions_disabled",
    "devicePath": "device_path",
    "disabledControllers": "disabled_controllers",
    "diskName": "disk_name",
    "diskSizeGB": "disk_size_gb",
    "diskURI": "disk_uri",
    "dnsConfig": "dns_config",
    "dnsPolicy": "dns_policy",
    "domainName": "domain_name",
    "downwardAPI": "downward_api",
    "emailHeaders": "email_headers",
    "emptyDir": "empty_dir",
    "enableServiceLinks": "enable_service_links",
    "envFrom": "env_from",
    "ephemeralContainers": "ephemeral_containers",
    "exec": "exec_",
    "expirationSeconds": "expiration_seconds",
    "extraAuthorizeParameters": "extra_authorize_parameters",
    "extraScopes": "extra_scopes",
    "failedProvisionConfig": "failed_provision_config",
    "failureThreshold": "failure_threshold",
    "fieldPath": "field_path",
    "fieldRef": "field_ref",
    "fileData": "file_data",
    "firstSuccessTimestamp": "first_success_timestamp",
    "flexVolume": "flex_volume",
    "fsGroup": "fs_group",
    "fsGroupChangePolicy": "fs_group_change_policy",
    "fsType": "fs_type",
    "gcePersistentDisk": "gce_persistent_disk",
    "gitRepo": "git_repo",
    "globalPullSecretRef": "global_pull_secret_ref",
    "gmsaCredentialSpec": "gmsa_credential_spec",
    "gmsaCredentialSpecName": "gmsa_credential_spec_name",
    "hiveAPIEnabled": "hive_api_enabled",
    "hostAliases": "host_aliases",
    "hostIP": "host_ip",
    "hostIPC": "host_ipc",
    "hostNetwork": "host_network",
    "hostPath": "host_path",
    "hostPID": "host_pid",
    "hostPort": "host_port",
    "hostedDomain": "hosted_domain",
    "httpGet": "http_get",
    "httpHeaders": "http_headers",
    "identityProviders": "identity_providers",
    "imagePullPolicy": "image_pull_policy",
    "imagePullSecrets": "image_pull_secrets",
    "imageSetRef": "image_set_ref",
    "infraID": "infra_id",
    "initContainers": "init_containers",
    "initialDelaySeconds": "initial_delay_seconds",
    "initiatorName": "initiator_name",
    "installConfigSecretRef": "install_config_secret_ref",
    "installLog": "install_log",
    "installRestarts": "install_restarts",
    "installedTimestamp": "installed_timestamp",
    "installerEnv": "installer_env",
    "installerImage": "installer_image",
    "iscsiInterface": "iscsi_interface",
    "jobRef": "job_ref",
    "kubeconfigSecretRef": "kubeconfig_secret_ref",
    "labelSelector": "label_selector",
    "lastBackupChecksum": "last_backup_checksum",
    "lastBackupRef": "last_backup_ref",
    "lastBackupTime": "last_backup_time",
    "lastProbeTime": "last_probe_time",
    "lastSyncGeneration": "last_sync_generation",
    "lastSyncTimestamp": "last_sync_timestamp",
    "lastTransitionTime": "last_transition_time",
    "lastUpdated": "last_updated",
    "libvirtSSHPrivateKeySecretRef": "libvirt_ssh_private_key_secret_ref",
    "linkToParentDomain": "link_to_parent_domain",
    "livenessProbe": "liveness_probe",
    "logLevel": "log_level",
    "loginURL": "login_url",
    "machineSets": "machine_sets",
    "maintenanceMode": "maintenance_mode",
    "manageDNS": "manage_dns",
    "managedDomains": "managed_domains",
    "manifestsConfigMapRef": "manifests_config_map_ref",
    "mappingMethod": "mapping_method",
    "matchExpressions": "match_expressions",
    "matchFields": "match_fields",
    "matchLabels": "match_labels",
    "maxPrice": "max_price",
    "maxReplicas": "max_replicas",
    "maxSkew": "max_skew",
    "memoryMB": "memory_mb",
    "minBackupPeriodSeconds": "min_backup_period_seconds",
    "minReplicas": "min_replicas",
    "mountPath": "mount_path",
    "mountPropagation": "mount_propagation",
    "nameHeaders": "name_headers",
    "nameServers": "name_servers",
    "namespaceSelector": "namespace_selector",
    "nodeAffinity": "node_affinity",
    "nodeName": "node_name",
    "nodePublishSecretRef": "node_publish_secret_ref",
    "nodeSelector": "node_selector",
    "nodeSelectorTerms": "node_selector_terms",
    "observedGeneration": "observed_generation",
    "openID": "open_id",
    "osDisk": "os_disk",
    "patchType": "patch_type",
    "pdID": "pd_id",
    "pdName": "pd_name",
    "periodSeconds": "period_seconds",
    "persistentVolumeClaim": "persistent_volume_claim",
    "photonPersistentDisk": "photon_persistent_disk",
    "podAffinity": "pod_affinity",
    "podAffinityTerm": "pod_affinity_term",
    "podAntiAffinity": "pod_anti_affinity",
    "podSpec": "pod_spec",
    "poolName": "pool_name",
    "portworxVolume": "portworx_volume",
    "postStart": "post_start",
    "powerState": "power_state",
    "preStop": "pre_stop",
    "preemptionPolicy": "preemption_policy",
    "preferredDuringSchedulingIgnoredDuringExecution": "preferred_during_scheduling_ignored_during_execution",
    "preferredUsername": "preferred_username",
    "preferredUsernameHeaders": "preferred_username_headers",
    "preserveOnDelete": "preserve_on_delete",
    "prevClusterID": "prev_cluster_id",
    "prevInfraID": "prev_infra_id",
    "priorityClassName": "priority_class_name",
    "procMount": "proc_mount",
    "protectionDomain": "protection_domain",
    "provisionRef": "provision_ref",
    "pullSecretRef": "pull_secret_ref",
    "readOnly": "read_only",
    "readOnlyRootFilesystem": "read_only_root_filesystem",
    "readinessGates": "readiness_gates",
    "readinessProbe": "readiness_probe",
    "releaseImage": "release_image",
    "requestHeader": "request_header",
    "requiredDuringSchedulingIgnoredDuringExecution": "required_during_scheduling_ignored_during_execution",
    "resourceApplyMode": "resource_apply_mode",
    "resourceFieldRef": "resource_field_ref",
    "resourceGroupName": "resource_group_name",
    "restartPolicy": "restart_policy",
    "rootVolume": "root_volume",
    "routeSelector": "route_selector",
    "runAsGroup": "run_as_group",
    "runAsNonRoot": "run_as_non_root",
    "runAsUser": "run_as_user",
    "runAsUserName": "run_as_user_name",
    "runtimeClassName": "runtime_class_name",
    "scaleIO": "scale_io",
    "schedulerName": "scheduler_name",
    "seLinuxOptions": "se_linux_options",
    "secretFile": "secret_file",
    "secretKeyRef": "secret_key_ref",
    "secretMappings": "secret_mappings",
    "secretName": "secret_name",
    "secretRef": "secret_ref",
    "secretReferences": "secret_references",
    "securityContext": "security_context",
    "selectorSyncSetRef": "selector_sync_set_ref",
    "serviceAccount": "service_account",
    "serviceAccountName": "service_account_name",
    "serviceAccountToken": "service_account_token",
    "servingCertificate": "serving_certificate",
    "servingCertificates": "serving_certificates",
    "shareName": "share_name",
    "shareProcessNamespace": "share_process_namespace",
    "sizeGB": "size_gb",
    "sizeLimit": "size_limit",
    "skipGatherLogs": "skip_gather_logs",
    "sourceRef": "source_ref",
    "spotMarketOptions": "spot_market_options",
    "sshKnownHosts": "ssh_known_hosts",
    "sshPrivateKeySecretRef": "ssh_private_key_secret_ref",
    "sslEnabled": "ssl_enabled",
    "startedTime": "started_time",
    "startupProbe": "startup_probe",
    "stdinOnce": "stdin_once",
    "storageMode": "storage_mode",
    "storagePolicyID": "storage_policy_id",
    "storagePolicyName": "storage_policy_name",
    "storagePool": "storage_pool",
    "subPath": "sub_path",
    "subPathExpr": "sub_path_expr",
    "successThreshold": "success_threshold",
    "supplementalGroups": "supplemental_groups",
    "syncSetHash": "sync_set_hash",
    "syncSetReapplyInterval": "sync_set_reapply_interval",
    "syncSetRef": "sync_set_ref",
    "targetContainerName": "target_container_name",
    "targetNamespace": "target_namespace",
    "targetPortal": "target_portal",
    "targetRef": "target_ref",
    "targetWWNs": "target_ww_ns",
    "tcpSocket": "tcp_socket",
    "terminationGracePeriodSeconds": "termination_grace_period_seconds",
    "terminationMessagePath": "termination_message_path",
    "terminationMessagePolicy": "termination_message_policy",
    "timeAdded": "time_added",
    "timeoutSeconds": "timeout_seconds",
    "tlsClientCert": "tls_client_cert",
    "tlsClientKey": "tls_client_key",
    "tolerationSeconds": "toleration_seconds",
    "topologyKey": "topology_key",
    "topologySpreadConstraints": "topology_spread_constraints",
    "trunkSupport": "trunk_support",
    "userTags": "user_tags",
    "vCenter": "v_center",
    "valueFrom": "value_from",
    "versionHash": "version_hash",
    "vmType": "vm_type",
    "volumeAttributes": "volume_attributes",
    "volumeDevices": "volume_devices",
    "volumeID": "volume_id",
    "volumeMounts": "volume_mounts",
    "volumeName": "volume_name",
    "volumeNamespace": "volume_namespace",
    "volumePath": "volume_path",
    "vsphereVolume": "vsphere_volume",
    "webConsoleURL": "web_console_url",
    "whenUnsatisfiable": "when_unsatisfiable",
    "windowsOptions": "windows_options",
    "workingDir": "working_dir",
    "zoneID": "zone_id",
    "zoneName": "zone_name",
}
