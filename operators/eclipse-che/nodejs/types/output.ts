// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

import {ObjectMeta} from "../meta/v1";

export namespace org {
    export namespace v1 {
        /**
         * Desired configuration of the Che installation. Based on these settings, the operator automatically creates and maintains several config maps that will contain the appropriate environment variables the various components of the Che installation. These generated config maps should NOT be updated manually.
         */
        export interface CheClusterSpec {
            /**
             * Configuration settings related to the Authentication used by the Che installation.
             */
            auth?: outputs.org.v1.CheClusterSpecAuth;
            /**
             * Configuration settings related to the database used by the Che installation.
             */
            database?: outputs.org.v1.CheClusterSpecDatabase;
            /**
             * Kubernetes Image Puller configuration
             */
            imagePuller?: outputs.org.v1.CheClusterSpecImagePuller;
            /**
             * Configuration settings specific to Che installations made on upstream Kubernetes.
             */
            k8s?: outputs.org.v1.CheClusterSpecK8s;
            /**
             * Configuration settings related to the metrics collection used by the Che installation.
             */
            metrics?: outputs.org.v1.CheClusterSpecMetrics;
            /**
             * General configuration settings related to the Che server and the plugin and devfile registries
             */
            server?: outputs.org.v1.CheClusterSpecServer;
            /**
             * Configuration settings related to the persistent storage used by the Che installation.
             */
            storage?: outputs.org.v1.CheClusterSpecStorage;
        }

        /**
         * Configuration settings related to the Authentication used by the Che installation.
         */
        export interface CheClusterSpecAuth {
            /**
             * Instructs the operator on whether or not to deploy a dedicated Identity Provider (Keycloak or RH SSO instance). By default a dedicated Identity Provider server is deployed as part of the Che installation. But if `externalIdentityProvider` is `true`, then no dedicated identity provider will be deployed by the operator and you might need to provide details about the external identity provider you want to use. See also all the other fields starting with: `identityProvider`.
             */
            externalIdentityProvider?: boolean;
            /**
             * Overrides the name of the Identity Provider admin user. Defaults to `admin`.
             */
            identityProviderAdminUserName?: string;
            /**
             * Name of a Identity provider (Keycloak / RH SSO) `client-id` that should be used for Che. This is useful to override it ONLY if you use an external Identity Provider (see the `externalIdentityProvider` field). If omitted or left blank, it will be set to the value of the `flavour` field suffixed with `-public`.
             */
            identityProviderClientId?: string;
            /**
             * Overrides the container image used in the Identity Provider (Keycloak / RH SSO) deployment. This includes the image tag. Omit it or leave it empty to use the defaut container image provided by the operator.
             */
            identityProviderImage?: string;
            /**
             * Overrides the image pull policy used in the Identity Provider (Keycloak / RH SSO) deployment. Default value is `Always` for `nightly` or `latest` images, and `IfNotPresent` in other cases.
             */
            identityProviderImagePullPolicy?: string;
            /**
             * Ingress custom settings
             */
            identityProviderIngress?: outputs.org.v1.CheClusterSpecAuthIdentityProviderIngress;
            /**
             * Overrides the password of Keycloak admin user. This is useful to override it ONLY if you use an external Identity Provider (see the `externalIdentityProvider` field). If omitted or left blank, it will be set to an auto-generated password.
             */
            identityProviderPassword?: string;
            /**
             * Password for The Identity Provider (Keycloak / RH SSO) to connect to the database. This is useful to override it ONLY if you use an external Identity Provider (see the `externalIdentityProvider` field). If omitted or left blank, it will be set to an auto-generated password.
             */
            identityProviderPostgresPassword?: string;
            /**
             * The secret that contains `password` for The Identity Provider (Keycloak / RH SSO) to connect to the database. If the secret is defined then `identityProviderPostgresPassword` will be ignored. If the value is omitted or left blank then there are two scenarios: 1. `identityProviderPostgresPassword` is defined, then it will be used to connect to the database. 2. `identityProviderPostgresPassword` is not defined, then a new secret with the name `che-identity-postgres-secret` will be created with an auto-generated value for `password`.
             */
            identityProviderPostgresSecret?: string;
            /**
             * Name of a Identity provider (Keycloak / RH SSO) realm that should be used for Che. This is useful to override it ONLY if you use an external Identity Provider (see the `externalIdentityProvider` field). If omitted or left blank, it will be set to the value of the `flavour` field.
             */
            identityProviderRealm?: string;
            /**
             * Route custom settings
             */
            identityProviderRoute?: outputs.org.v1.CheClusterSpecAuthIdentityProviderRoute;
            /**
             * The secret that contains `user` and `password` for Identity Provider. If the secret is defined then `identityProviderAdminUserName` and `identityProviderPassword` are ignored. If the value is omitted or left blank then there are two scenarios: 1. `identityProviderAdminUserName` and `identityProviderPassword` are defined, then they will be used. 2. `identityProviderAdminUserName` or `identityProviderPassword` are not defined, then a new secret with the name `che-identity-secret` will be created with default value `admin` for `user` and with an auto-generated value for `password`.
             */
            identityProviderSecret?: string;
            /**
             * Public URL of the Identity Provider server (Keycloak / RH SSO server). You should set it ONLY if you use an external Identity Provider (see the `externalIdentityProvider` field). By default this will be automatically calculated and set by the operator.
             */
            identityProviderURL?: string;
            /**
             * Name of the OpenShift `OAuthClient` resource used to setup identity federation on the OpenShift side. Auto-generated if left blank. See also the `OpenShiftoAuth` field.
             */
            oAuthClientName?: string;
            /**
             * Name of the secret set in the OpenShift `OAuthClient` resource used to setup identity federation on the OpenShift side. Auto-generated if left blank. See also the `OAuthClientName` field.
             */
            oAuthSecret?: string;
            /**
             * Enables the integration of the identity provider (Keycloak / RHSSO) with OpenShift OAuth. Enabled by default on OpenShift. This will allow users to directly login with their Openshift user through the Openshift login, and have their workspaces created under personal OpenShift namespaces. WARNING: the `kubeadmin` user is NOT supported, and logging through it will NOT allow accessing the Che Dashboard.
             */
            openShiftoAuth?: boolean;
            /**
             * Forces the default `admin` Che user to update password on first login. Defaults to `false`.
             */
            updateAdminPassword?: boolean;
        }

        /**
         * Ingress custom settings
         */
        export interface CheClusterSpecAuthIdentityProviderIngress {
            /**
             * Comma separated list of labels that can be used to organize and categorize (scope and select) objects.
             */
            labels?: string;
        }

        /**
         * Route custom settings
         */
        export interface CheClusterSpecAuthIdentityProviderRoute {
            /**
             * Comma separated list of labels that can be used to organize and categorize (scope and select) objects.
             */
            labels?: string;
        }

        /**
         * Configuration settings related to the database used by the Che installation.
         */
        export interface CheClusterSpecDatabase {
            /**
             * Postgres database name that the Che server uses to connect to the DB. Defaults to `dbche`.
             */
            chePostgresDb?: string;
            /**
             * Postgres Database hostname that the Che server uses to connect to. Defaults to postgres. This value should be overridden ONLY when using an external database (see field `externalDb`). In the default case it will be automatically set by the operator.
             */
            chePostgresHostName?: string;
            /**
             * Postgres password that the Che server should use to connect to the DB. If omitted or left blank, it will be set to an auto-generated value.
             */
            chePostgresPassword?: string;
            /**
             * Postgres Database port that the Che server uses to connect to. Defaults to 5432. This value should be overridden ONLY when using an external database (see field `externalDb`). In the default case it will be automatically set by the operator.
             */
            chePostgresPort?: string;
            /**
             * The secret that contains Postgres `user` and `password` that the Che server should use to connect to the DB. If the secret is defined then `chePostgresUser` and `chePostgresPassword` are ignored. If the value is omitted or left blank then there are two scenarios: 1. `chePostgresUser` and `chePostgresPassword` are defined, then they will be used to connect to the DB. 2. `chePostgresUser` or `chePostgresPassword` are not defined, then a new secret with the name `che-postgres-secret` will be created with default value of `pgche` for `user` and with an auto-generated value for `password`.
             */
            chePostgresSecret?: string;
            /**
             * Postgres user that the Che server should use to connect to the DB. Defaults to `pgche`.
             */
            chePostgresUser?: string;
            /**
             * Instructs the operator on whether or not to deploy a dedicated database. By default a dedicated Postgres database is deployed as part of the Che installation. But if `externalDb` is `true`, then no dedicated database will be deployed by the operator and you might need to provide connection details to the external DB you want to use. See also all the fields starting with: `chePostgres`.
             */
            externalDb?: boolean;
            /**
             * Overrides the container image used in the Postgres database deployment. This includes the image tag. Omit it or leave it empty to use the defaut container image provided by the operator.
             */
            postgresImage?: string;
            /**
             * Overrides the image pull policy used in the Postgres database deployment. Default value is `Always` for `nightly` or `latest` images, and `IfNotPresent` in other cases.
             */
            postgresImagePullPolicy?: string;
        }

        /**
         * Kubernetes Image Puller configuration
         */
        export interface CheClusterSpecImagePuller {
            /**
             * Install and configure the Kubernetes Image Puller Operator. If true and no spec is provided, it will create a default KubernetesImagePuller object to be managed by the Operator. If false, the KubernetesImagePuller object will be deleted, and the operator will be uninstalled, regardless of whether or not a spec is provided.
             */
            enable?: boolean;
            /**
             * A KubernetesImagePullerSpec to configure the image puller in the CheCluster
             */
            spec?: outputs.org.v1.CheClusterSpecImagePullerSpec;
        }

        /**
         * A KubernetesImagePullerSpec to configure the image puller in the CheCluster
         */
        export interface CheClusterSpecImagePullerSpec {
            cachingCPULimit?: string;
            cachingCPURequest?: string;
            cachingIntervalHours?: string;
            cachingMemoryLimit?: string;
            cachingMemoryRequest?: string;
            configMapName?: string;
            daemonsetName?: string;
            deploymentName?: string;
            images?: string;
            nodeSelector?: string;
        }

        /**
         * Configuration settings specific to Che installations made on upstream Kubernetes.
         */
        export interface CheClusterSpecK8s {
            /**
             * Ingress class that will define the which controler will manage ingresses. Defaults to `nginx`. NB: This drives the `is kubernetes.io/ingress.class` annotation on Che-related ingresses.
             */
            ingressClass?: string;
            /**
             * Global ingress domain for a K8S cluster. This MUST be explicitly specified: there are no defaults.
             */
            ingressDomain?: string;
            /**
             * Strategy for ingress creation. This can be `multi-host` (host is explicitly provided in ingress), `single-host` (host is provided, path-based rules) and `default-host.*`(no host is provided, path-based rules). Defaults to `"multi-host` Deprecated in favor of "serverExposureStrategy" in the "server" section, which defines this regardless of the cluster type. If both are defined, `serverExposureStrategy` takes precedence.
             */
            ingressStrategy?: string;
            /**
             * FSGroup the Che pod and Workspace pods containers should run in. Defaults to `1724`.
             */
            securityContextFsGroup?: string;
            /**
             * ID of the user the Che pod and Workspace pods containers should run as. Default to `1724`.
             */
            securityContextRunAsUser?: string;
            /**
             * When the serverExposureStrategy is set to "single-host", the way the server, registries and workspaces are exposed is further configured by this property. The possible values are "native" (which means that the server and workspaces are exposed using ingresses on K8s) or "gateway" where the server and workspaces are exposed using a custom gateway based on Traefik. All the endpoints whether backed by the ingress or gateway "route" always point to the subpaths on the same domain. Defaults to "native".
             */
            singleHostExposureType?: string;
            /**
             * Name of a secret that will be used to setup ingress TLS termination if TLS is enabled. If the field is empty string, then default cluster certificate will be used. See also the `tlsSupport` field.
             */
            tlsSecretName?: string;
        }

        /**
         * Configuration settings related to the metrics collection used by the Che installation.
         */
        export interface CheClusterSpecMetrics {
            /**
             * Enables `metrics` Che server endpoint. Default to `true`.
             */
            enable?: boolean;
        }

        /**
         * General configuration settings related to the Che server and the plugin and devfile registries
         */
        export interface CheClusterSpecServer {
            /**
             * Optional hostname (or url) to an alternate container registry to pull images from. This value overrides the container registry hostname defined in all the default container images involved in a Che deployment. This is particularly useful to install Che in an air-gapped environment.
             */
            airGapContainerRegistryHostname?: string;
            /**
             * Optional repository name of an alternate container registry to pull images from. This value overrides the container registry organization defined in all the default container images involved in a Che deployment. This is particularly useful to install Che in an air-gapped environment.
             */
            airGapContainerRegistryOrganization?: string;
            /**
             * Defines if a user is able to specify Kubernetes namespace (or OpenShift project) different from the default. It's NOT RECOMMENDED to configured true without OAuth configured. This property is also used by the OpenShift infra.
             */
            allowUserDefinedWorkspaceNamespaces?: boolean;
            /**
             * Comma-separated list of ClusterRoles that will be assigned to che ServiceAccount. Be aware that che-operator has to already have all permissions in these ClusterRoles to be able to grant them.
             */
            cheClusterRoles?: string;
            /**
             * Enables the debug mode for Che server. Defaults to `false`.
             */
            cheDebug?: string;
            /**
             * Flavor of the installation. This is either `che` for upstream Che installations, or `codeready` for CodeReady Workspaces installation. In most cases the default value should not be overridden.
             */
            cheFlavor?: string;
            /**
             * Public hostname of the installed Che server. If value is omitted then it will be automatically set by the operator. (see the `cheHostTLSSecret` field).
             */
            cheHost?: string;
            /**
             * Name of a secret containing certificates to secure ingress/route for the custom hostname of the installed Che server. (see the `cheHost` field).
             */
            cheHostTLSSecret?: string;
            /**
             * Overrides the container image used in Che deployment. This does NOT include the container image tag. Omit it or leave it empty to use the defaut container image provided by the operator.
             */
            cheImage?: string;
            /**
             * Overrides the image pull policy used in Che deployment. Default value is `Always` for `nightly` or `latest` images, and `IfNotPresent` in other cases.
             */
            cheImagePullPolicy?: string;
            /**
             * Overrides the tag of the container image used in Che deployment. Omit it or leave it empty to use the defaut image tag provided by the operator.
             */
            cheImageTag?: string;
            /**
             * Log level for the Che server: `INFO` or `DEBUG`. Defaults to `INFO`.
             */
            cheLogLevel?: string;
            /**
             * Che server ingress custom settings
             */
            cheServerIngress?: outputs.org.v1.CheClusterSpecServerCheServerIngress;
            /**
             * Che server route custom settings
             */
            cheServerRoute?: outputs.org.v1.CheClusterSpecServerCheServerRoute;
            /**
             * Custom cluster role bound to the user for the Che workspaces. The default roles are used if this is omitted or left blank.
             */
            cheWorkspaceClusterRole?: string;
            /**
             * Map of additional environment variables that will be applied in the generated `che` config map to be used by the Che server, in addition to the values already generated from other fields of the `CheCluster` custom resource (CR). If `customCheProperties` contains a property that would be normally generated in `che` config map from other CR fields, then the value defined in the `customCheProperties` will be used instead.
             */
            customCheProperties?: {[key: string]: string};
            /**
             * Overrides the container image used in the Devfile registry deployment. This includes the image tag. Omit it or leave it empty to use the defaut container image provided by the operator.
             */
            devfileRegistryImage?: string;
            /**
             * Devfile registry ingress custom settings
             */
            devfileRegistryIngress?: outputs.org.v1.CheClusterSpecServerDevfileRegistryIngress;
            /**
             * Overrides the memory limit used in the Devfile registry deployment. Defaults to 256Mi.
             */
            devfileRegistryMemoryLimit?: string;
            /**
             * Overrides the memory request used in the Devfile registry deployment. Defaults to 16Mi.
             */
            devfileRegistryMemoryRequest?: string;
            /**
             * Overrides the image pull policy used in the Devfile registry deployment. Default value is `Always` for `nightly` or `latest` images, and `IfNotPresent` in other cases.
             */
            devfileRegistryPullPolicy?: string;
            /**
             * Devfile registry route custom settings
             */
            devfileRegistryRoute?: outputs.org.v1.CheClusterSpecServerDevfileRegistryRoute;
            /**
             * Public URL of the Devfile registry, that serves sample, ready-to-use devfiles. You should set it ONLY if you use an external devfile registry (see the `externalDevfileRegistry` field). By default this will be automatically calculated by the operator.
             */
            devfileRegistryUrl?: string;
            /**
             * Instructs the operator on whether or not to deploy a dedicated Devfile registry server. By default a dedicated devfile registry server is started. But if `externalDevfileRegistry` is `true`, then no such dedicated server will be started by the operator and you will have to manually set the `devfileRegistryUrl` field
             */
            externalDevfileRegistry?: boolean;
            /**
             * Instructs the operator on whether or not to deploy a dedicated Plugin registry server. By default a dedicated plugin registry server is started. But if `externalPluginRegistry` is `true`, then no such dedicated server will be started by the operator and you will have to manually set the `pluginRegistryUrl` field.
             */
            externalPluginRegistry?: boolean;
            /**
             * If enabled, then the certificate from `che-git-self-signed-cert` config map will be propagated to the Che components and provide particular configuration for Git.
             */
            gitSelfSignedCert?: boolean;
            /**
             * List of hosts that should not use the configured proxy. So specify wild card domain use the following form `.<DOMAIN>` and `|` as delimiter, eg: `localhost|.my.host.com|123.42.12.32` Only use when configuring a proxy is required. Operator respects OpenShift cluster wide proxy configuration and no additional configuration is required, but defining `nonProxyHosts` in a custom resource leads to merging non proxy hosts lists from the cluster proxy configuration and ones defined in the custom resources. (see the doc https://docs.openshift.com/container-platform/4.4/networking/enable-cluster-wide-proxy.html) (see also the `proxyURL` fields).
             */
            nonProxyHosts?: string;
            /**
             * Overrides the container image used in the Plugin registry deployment. This includes the image tag. Omit it or leave it empty to use the default container image provided by the operator.
             */
            pluginRegistryImage?: string;
            /**
             * Plugin registry ingress custom settings
             */
            pluginRegistryIngress?: outputs.org.v1.CheClusterSpecServerPluginRegistryIngress;
            /**
             * Overrides the memory limit used in the Plugin registry deployment. Defaults to 256Mi.
             */
            pluginRegistryMemoryLimit?: string;
            /**
             * Overrides the memory request used in the Plugin registry deployment. Defaults to 16Mi.
             */
            pluginRegistryMemoryRequest?: string;
            /**
             * Overrides the image pull policy used in the Plugin registry deployment. Default value is `Always` for `nightly` or `latest` images, and `IfNotPresent` in other cases.
             */
            pluginRegistryPullPolicy?: string;
            /**
             * Plugin registry route custom settings
             */
            pluginRegistryRoute?: outputs.org.v1.CheClusterSpecServerPluginRegistryRoute;
            /**
             * Public URL of the Plugin registry, that serves sample ready-to-use devfiles. You should set it ONLY if you use an external devfile registry (see the `externalPluginRegistry` field). By default this will be automatically calculated by the operator.
             */
            pluginRegistryUrl?: string;
            /**
             * Password of the proxy server Only use when proxy configuration is required (see also the `proxyURL`, `proxyUser` and `proxySecret` fields).
             */
            proxyPassword?: string;
            /**
             * Port of the proxy server. Only use when configuring a proxy is required. (see also the `proxyURL` and `nonProxyHosts` fields).
             */
            proxyPort?: string;
            /**
             * The secret that contains `user` and `password` for a proxy server. If the secret is defined then `proxyUser` and `proxyPassword` are ignored
             */
            proxySecret?: string;
            /**
             * URL (protocol+hostname) of the proxy server. This drives the appropriate changes in the `JAVA_OPTS` and `https(s)_proxy` variables in the Che server and workspaces containers. Only use when configuring a proxy is required. Operator respects OpenShift cluster wide proxy configuration and no additional configuration is required, but defining `proxyUrl` in a custom resource leads to overrides the cluster proxy configuration with fields `proxyUrl`, `proxyPort`, `proxyUser` and `proxyPassword` from the custom resource. (see the doc https://docs.openshift.com/container-platform/4.4/networking/enable-cluster-wide-proxy.html) (see also the `proxyPort` and `nonProxyHosts` fields).
             */
            proxyURL?: string;
            /**
             * User name of the proxy server. Only use when configuring a proxy is required (see also the `proxyURL`, `proxyPassword` and `proxySecret` fields).
             */
            proxyUser?: string;
            /**
             * Deprecated. The value of this flag is ignored. Che operator will automatically detect if router certificate is self-signed. If so it will be propagated to Che server and some other components.
             */
            selfSignedCert?: boolean;
            /**
             * Sets the server and workspaces exposure type. Possible values are "multi-host", "single-host", "default-host". Defaults to "multi-host" which creates a separate ingress (or route on OpenShift) for every required endpoint. "single-host" makes Che exposed on a single hostname with workspaces exposed on subpaths. Please read the docs to learn about the limitations of this approach. Also consult the `singleHostExposureType` property to further configure how the operator and Che server make that happen on Kubernetes. "default-host" exposes che server on the host of the cluster. Please read the docs to learn about the limitations of this approach.
             */
            serverExposureStrategy?: string;
            /**
             * Overrides the memory limit used in the Che server deployment. Defaults to 1Gi.
             */
            serverMemoryLimit?: string;
            /**
             * Overrides the memory request used in the Che server deployment. Defaults to 512Mi.
             */
            serverMemoryRequest?: string;
            /**
             * Name of the config-map with public certificates to add to Java trust store of the Che server. This is usually required when adding the OpenShift OAuth provider which has https endpoint signed with self-signed cert. So, Che server must be aware of its CA cert to be able to request it. This is disabled by default.
             */
            serverTrustStoreConfigMapName?: string;
            /**
             * The labels that need to be present (and are put) on the configmaps representing the gateway configuration.
             */
            singleHostGatewayConfigMapLabels?: {[key: string]: string};
            /**
             * The image used for the gateway sidecar that provides configuration to the gateway. Omit it or leave it empty to use the defaut container image provided by the operator.
             */
            singleHostGatewayConfigSidecarImage?: string;
            /**
             * The image used for the gateway in the single host mode. Omit it or leave it empty to use the defaut container image provided by the operator.
             */
            singleHostGatewayImage?: string;
            /**
             * Deprecated. Instructs the operator to deploy Che in TLS mode. This is enabled by default. Disabling TLS may cause malfunction of some Che components.
             */
            tlsSupport?: boolean;
            /**
             * Use internal cluster svc names to communicate between components to speed up the traffic and avoid proxy issues. The default value is `true`.
             */
            useInternalClusterSVCNames?: boolean;
            /**
             * Defines Kubernetes default namespace in which user's workspaces are created if user does not override it. It's possible to use <username>, <userid> and <workspaceid> placeholders (e.g.: che-workspace-<username>). In that case, new namespace will be created for each user (or workspace). Is used by OpenShift infra as well to specify Project
             */
            workspaceNamespaceDefault?: string;
        }

        /**
         * Che server ingress custom settings
         */
        export interface CheClusterSpecServerCheServerIngress {
            /**
             * Comma separated list of labels that can be used to organize and categorize (scope and select) objects.
             */
            labels?: string;
        }

        /**
         * Che server route custom settings
         */
        export interface CheClusterSpecServerCheServerRoute {
            /**
             * Comma separated list of labels that can be used to organize and categorize (scope and select) objects.
             */
            labels?: string;
        }

        /**
         * Devfile registry ingress custom settings
         */
        export interface CheClusterSpecServerDevfileRegistryIngress {
            /**
             * Comma separated list of labels that can be used to organize and categorize (scope and select) objects.
             */
            labels?: string;
        }

        /**
         * Devfile registry route custom settings
         */
        export interface CheClusterSpecServerDevfileRegistryRoute {
            /**
             * Comma separated list of labels that can be used to organize and categorize (scope and select) objects.
             */
            labels?: string;
        }

        /**
         * Plugin registry ingress custom settings
         */
        export interface CheClusterSpecServerPluginRegistryIngress {
            /**
             * Comma separated list of labels that can be used to organize and categorize (scope and select) objects.
             */
            labels?: string;
        }

        /**
         * Plugin registry route custom settings
         */
        export interface CheClusterSpecServerPluginRegistryRoute {
            /**
             * Comma separated list of labels that can be used to organize and categorize (scope and select) objects.
             */
            labels?: string;
        }

        /**
         * Configuration settings related to the persistent storage used by the Che installation.
         */
        export interface CheClusterSpecStorage {
            /**
             * Storage class for the Persistent Volume Claim dedicated to the Postgres database. If omitted or left blank, default storage class is used.
             */
            postgresPVCStorageClassName?: string;
            /**
             * Instructs the Che server to launch a special pod to pre-create a subpath in the Persistent Volumes. Defaults to `false`, however it might need to enable it according to the configuration of your K8S cluster.
             */
            preCreateSubPaths?: boolean;
            /**
             * Size of the persistent volume claim for workspaces. Defaults to `1Gi`
             */
            pvcClaimSize?: string;
            /**
             * Overrides the container image used to create sub-paths in the Persistent Volumes. This includes the image tag. Omit it or leave it empty to use the defaut container image provided by the operator. See also the `preCreateSubPaths` field.
             */
            pvcJobsImage?: string;
            /**
             * Persistent volume claim strategy for the Che server. This Can be:`common` (all workspaces PVCs in one volume), `per-workspace` (one PVC per workspace for all declared volumes) and `unique` (one PVC per declared volume). Defaults to `common`.
             */
            pvcStrategy?: string;
            /**
             * Storage class for the Persistent Volume Claims dedicated to the Che workspaces. If omitted or left blank, default storage class is used.
             */
            workspacePVCStorageClassName?: string;
        }

        /**
         * CheClusterStatus defines the observed state of Che installation
         */
        export interface CheClusterStatus {
            /**
             * Status of a Che installation. Can be `Available`, `Unavailable`, or `Available, Rolling Update in Progress`
             */
            cheClusterRunning?: string;
            /**
             * Public URL to the Che server
             */
            cheURL?: string;
            /**
             * Current installed Che version
             */
            cheVersion?: string;
            /**
             * Indicates if or not a Postgres instance has been correctly provisioned
             */
            dbProvisioned?: boolean;
            /**
             * Public URL to the Devfile registry
             */
            devfileRegistryURL?: string;
            /**
             * A URL that can point to some URL where to find help related to the current Operator status.
             */
            helpLink?: string;
            /**
             * Indicates whether an Identity Provider instance (Keycloak / RH SSO) has been provisioned with realm, client and user
             */
            keycloakProvisioned?: boolean;
            /**
             * Public URL to the Identity Provider server (Keycloak / RH SSO).
             */
            keycloakURL?: string;
            /**
             * A human readable message indicating details about why the pod is in this condition.
             */
            message?: string;
            /**
             * Indicates whether an Identity Provider instance (Keycloak / RH SSO) has been configured to integrate with the OpenShift OAuth.
             */
            openShiftoAuthProvisioned?: boolean;
            /**
             * Public URL to the Plugin registry
             */
            pluginRegistryURL?: string;
            /**
             * A brief CamelCase message indicating details about why the pod is in this state.
             */
            reason?: string;
        }
    }
}
