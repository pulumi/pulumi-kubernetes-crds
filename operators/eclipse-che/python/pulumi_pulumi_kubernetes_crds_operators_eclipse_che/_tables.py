# coding=utf-8
# *** WARNING: this file was generated by crd2pulumi. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

SNAKE_TO_CAMEL_CASE_TABLE = {
    "air_gap_container_registry_hostname": "airGapContainerRegistryHostname",
    "air_gap_container_registry_organization": "airGapContainerRegistryOrganization",
    "allow_user_defined_workspace_namespaces": "allowUserDefinedWorkspaceNamespaces",
    "api_version": "apiVersion",
    "caching_cpu_limit": "cachingCPULimit",
    "caching_cpu_request": "cachingCPURequest",
    "caching_interval_hours": "cachingIntervalHours",
    "caching_memory_limit": "cachingMemoryLimit",
    "caching_memory_request": "cachingMemoryRequest",
    "che_cluster_roles": "cheClusterRoles",
    "che_cluster_running": "cheClusterRunning",
    "che_debug": "cheDebug",
    "che_flavor": "cheFlavor",
    "che_host": "cheHost",
    "che_host_tls_secret": "cheHostTLSSecret",
    "che_image": "cheImage",
    "che_image_pull_policy": "cheImagePullPolicy",
    "che_image_tag": "cheImageTag",
    "che_log_level": "cheLogLevel",
    "che_postgres_db": "chePostgresDb",
    "che_postgres_host_name": "chePostgresHostName",
    "che_postgres_password": "chePostgresPassword",
    "che_postgres_port": "chePostgresPort",
    "che_postgres_secret": "chePostgresSecret",
    "che_postgres_user": "chePostgresUser",
    "che_server_ingress": "cheServerIngress",
    "che_server_route": "cheServerRoute",
    "che_url": "cheURL",
    "che_version": "cheVersion",
    "che_workspace_cluster_role": "cheWorkspaceClusterRole",
    "config_map_name": "configMapName",
    "custom_che_properties": "customCheProperties",
    "daemonset_name": "daemonsetName",
    "db_provisioned": "dbProvisioned",
    "deployment_name": "deploymentName",
    "devfile_registry_image": "devfileRegistryImage",
    "devfile_registry_ingress": "devfileRegistryIngress",
    "devfile_registry_memory_limit": "devfileRegistryMemoryLimit",
    "devfile_registry_memory_request": "devfileRegistryMemoryRequest",
    "devfile_registry_pull_policy": "devfileRegistryPullPolicy",
    "devfile_registry_route": "devfileRegistryRoute",
    "devfile_registry_url": "devfileRegistryUrl",
    "external_db": "externalDb",
    "external_devfile_registry": "externalDevfileRegistry",
    "external_identity_provider": "externalIdentityProvider",
    "external_plugin_registry": "externalPluginRegistry",
    "git_self_signed_cert": "gitSelfSignedCert",
    "help_link": "helpLink",
    "identity_provider_admin_user_name": "identityProviderAdminUserName",
    "identity_provider_client_id": "identityProviderClientId",
    "identity_provider_image": "identityProviderImage",
    "identity_provider_image_pull_policy": "identityProviderImagePullPolicy",
    "identity_provider_ingress": "identityProviderIngress",
    "identity_provider_password": "identityProviderPassword",
    "identity_provider_postgres_password": "identityProviderPostgresPassword",
    "identity_provider_postgres_secret": "identityProviderPostgresSecret",
    "identity_provider_realm": "identityProviderRealm",
    "identity_provider_route": "identityProviderRoute",
    "identity_provider_secret": "identityProviderSecret",
    "identity_provider_url": "identityProviderURL",
    "image_puller": "imagePuller",
    "ingress_class": "ingressClass",
    "ingress_domain": "ingressDomain",
    "ingress_strategy": "ingressStrategy",
    "keycloak_provisioned": "keycloakProvisioned",
    "keycloak_url": "keycloakURL",
    "node_selector": "nodeSelector",
    "non_proxy_hosts": "nonProxyHosts",
    "o_auth_client_name": "oAuthClientName",
    "o_auth_secret": "oAuthSecret",
    "open_shifto_auth": "openShiftoAuth",
    "open_shifto_auth_provisioned": "openShiftoAuthProvisioned",
    "plugin_registry_image": "pluginRegistryImage",
    "plugin_registry_ingress": "pluginRegistryIngress",
    "plugin_registry_memory_limit": "pluginRegistryMemoryLimit",
    "plugin_registry_memory_request": "pluginRegistryMemoryRequest",
    "plugin_registry_pull_policy": "pluginRegistryPullPolicy",
    "plugin_registry_route": "pluginRegistryRoute",
    "plugin_registry_url": "pluginRegistryUrl",
    "postgres_image": "postgresImage",
    "postgres_image_pull_policy": "postgresImagePullPolicy",
    "postgres_pvc_storage_class_name": "postgresPVCStorageClassName",
    "pre_create_sub_paths": "preCreateSubPaths",
    "proxy_password": "proxyPassword",
    "proxy_port": "proxyPort",
    "proxy_secret": "proxySecret",
    "proxy_url": "proxyURL",
    "proxy_user": "proxyUser",
    "pvc_claim_size": "pvcClaimSize",
    "pvc_jobs_image": "pvcJobsImage",
    "pvc_strategy": "pvcStrategy",
    "security_context_fs_group": "securityContextFsGroup",
    "security_context_run_as_user": "securityContextRunAsUser",
    "self_signed_cert": "selfSignedCert",
    "server_exposure_strategy": "serverExposureStrategy",
    "server_memory_limit": "serverMemoryLimit",
    "server_memory_request": "serverMemoryRequest",
    "server_trust_store_config_map_name": "serverTrustStoreConfigMapName",
    "single_host_exposure_type": "singleHostExposureType",
    "single_host_gateway_config_map_labels": "singleHostGatewayConfigMapLabels",
    "single_host_gateway_config_sidecar_image": "singleHostGatewayConfigSidecarImage",
    "single_host_gateway_image": "singleHostGatewayImage",
    "tls_secret_name": "tlsSecretName",
    "tls_support": "tlsSupport",
    "update_admin_password": "updateAdminPassword",
    "use_internal_cluster_svc_names": "useInternalClusterSVCNames",
    "workspace_namespace_default": "workspaceNamespaceDefault",
    "workspace_pvc_storage_class_name": "workspacePVCStorageClassName",
}

CAMEL_TO_SNAKE_CASE_TABLE = {
    "airGapContainerRegistryHostname": "air_gap_container_registry_hostname",
    "airGapContainerRegistryOrganization": "air_gap_container_registry_organization",
    "allowUserDefinedWorkspaceNamespaces": "allow_user_defined_workspace_namespaces",
    "apiVersion": "api_version",
    "cachingCPULimit": "caching_cpu_limit",
    "cachingCPURequest": "caching_cpu_request",
    "cachingIntervalHours": "caching_interval_hours",
    "cachingMemoryLimit": "caching_memory_limit",
    "cachingMemoryRequest": "caching_memory_request",
    "cheClusterRoles": "che_cluster_roles",
    "cheClusterRunning": "che_cluster_running",
    "cheDebug": "che_debug",
    "cheFlavor": "che_flavor",
    "cheHost": "che_host",
    "cheHostTLSSecret": "che_host_tls_secret",
    "cheImage": "che_image",
    "cheImagePullPolicy": "che_image_pull_policy",
    "cheImageTag": "che_image_tag",
    "cheLogLevel": "che_log_level",
    "chePostgresDb": "che_postgres_db",
    "chePostgresHostName": "che_postgres_host_name",
    "chePostgresPassword": "che_postgres_password",
    "chePostgresPort": "che_postgres_port",
    "chePostgresSecret": "che_postgres_secret",
    "chePostgresUser": "che_postgres_user",
    "cheServerIngress": "che_server_ingress",
    "cheServerRoute": "che_server_route",
    "cheURL": "che_url",
    "cheVersion": "che_version",
    "cheWorkspaceClusterRole": "che_workspace_cluster_role",
    "configMapName": "config_map_name",
    "customCheProperties": "custom_che_properties",
    "daemonsetName": "daemonset_name",
    "dbProvisioned": "db_provisioned",
    "deploymentName": "deployment_name",
    "devfileRegistryImage": "devfile_registry_image",
    "devfileRegistryIngress": "devfile_registry_ingress",
    "devfileRegistryMemoryLimit": "devfile_registry_memory_limit",
    "devfileRegistryMemoryRequest": "devfile_registry_memory_request",
    "devfileRegistryPullPolicy": "devfile_registry_pull_policy",
    "devfileRegistryRoute": "devfile_registry_route",
    "devfileRegistryUrl": "devfile_registry_url",
    "externalDb": "external_db",
    "externalDevfileRegistry": "external_devfile_registry",
    "externalIdentityProvider": "external_identity_provider",
    "externalPluginRegistry": "external_plugin_registry",
    "gitSelfSignedCert": "git_self_signed_cert",
    "helpLink": "help_link",
    "identityProviderAdminUserName": "identity_provider_admin_user_name",
    "identityProviderClientId": "identity_provider_client_id",
    "identityProviderImage": "identity_provider_image",
    "identityProviderImagePullPolicy": "identity_provider_image_pull_policy",
    "identityProviderIngress": "identity_provider_ingress",
    "identityProviderPassword": "identity_provider_password",
    "identityProviderPostgresPassword": "identity_provider_postgres_password",
    "identityProviderPostgresSecret": "identity_provider_postgres_secret",
    "identityProviderRealm": "identity_provider_realm",
    "identityProviderRoute": "identity_provider_route",
    "identityProviderSecret": "identity_provider_secret",
    "identityProviderURL": "identity_provider_url",
    "imagePuller": "image_puller",
    "ingressClass": "ingress_class",
    "ingressDomain": "ingress_domain",
    "ingressStrategy": "ingress_strategy",
    "keycloakProvisioned": "keycloak_provisioned",
    "keycloakURL": "keycloak_url",
    "nodeSelector": "node_selector",
    "nonProxyHosts": "non_proxy_hosts",
    "oAuthClientName": "o_auth_client_name",
    "oAuthSecret": "o_auth_secret",
    "openShiftoAuth": "open_shifto_auth",
    "openShiftoAuthProvisioned": "open_shifto_auth_provisioned",
    "pluginRegistryImage": "plugin_registry_image",
    "pluginRegistryIngress": "plugin_registry_ingress",
    "pluginRegistryMemoryLimit": "plugin_registry_memory_limit",
    "pluginRegistryMemoryRequest": "plugin_registry_memory_request",
    "pluginRegistryPullPolicy": "plugin_registry_pull_policy",
    "pluginRegistryRoute": "plugin_registry_route",
    "pluginRegistryUrl": "plugin_registry_url",
    "postgresImage": "postgres_image",
    "postgresImagePullPolicy": "postgres_image_pull_policy",
    "postgresPVCStorageClassName": "postgres_pvc_storage_class_name",
    "preCreateSubPaths": "pre_create_sub_paths",
    "proxyPassword": "proxy_password",
    "proxyPort": "proxy_port",
    "proxySecret": "proxy_secret",
    "proxyURL": "proxy_url",
    "proxyUser": "proxy_user",
    "pvcClaimSize": "pvc_claim_size",
    "pvcJobsImage": "pvc_jobs_image",
    "pvcStrategy": "pvc_strategy",
    "securityContextFsGroup": "security_context_fs_group",
    "securityContextRunAsUser": "security_context_run_as_user",
    "selfSignedCert": "self_signed_cert",
    "serverExposureStrategy": "server_exposure_strategy",
    "serverMemoryLimit": "server_memory_limit",
    "serverMemoryRequest": "server_memory_request",
    "serverTrustStoreConfigMapName": "server_trust_store_config_map_name",
    "singleHostExposureType": "single_host_exposure_type",
    "singleHostGatewayConfigMapLabels": "single_host_gateway_config_map_labels",
    "singleHostGatewayConfigSidecarImage": "single_host_gateway_config_sidecar_image",
    "singleHostGatewayImage": "single_host_gateway_image",
    "tlsSecretName": "tls_secret_name",
    "tlsSupport": "tls_support",
    "updateAdminPassword": "update_admin_password",
    "useInternalClusterSVCNames": "use_internal_cluster_svc_names",
    "workspaceNamespaceDefault": "workspace_namespace_default",
    "workspacePVCStorageClassName": "workspace_pvc_storage_class_name",
}
