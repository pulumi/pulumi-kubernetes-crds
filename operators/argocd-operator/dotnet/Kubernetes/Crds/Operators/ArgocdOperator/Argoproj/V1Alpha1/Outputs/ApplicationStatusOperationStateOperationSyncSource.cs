// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1
{

    [OutputType]
    public sealed class ApplicationStatusOperationStateOperationSyncSource
    {
        /// <summary>
        /// Chart is a Helm chart name
        /// </summary>
        public readonly string Chart;
        /// <summary>
        /// Directory holds path/directory specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceDirectory Directory;
        /// <summary>
        /// Helm holds helm specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceHelm Helm;
        /// <summary>
        /// Ksonnet holds ksonnet specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceKsonnet Ksonnet;
        /// <summary>
        /// Kustomize holds kustomize specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceKustomize Kustomize;
        /// <summary>
        /// Path is a directory path within the Git repository
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// ConfigManagementPlugin holds config management plugin specific options
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourcePlugin Plugin;
        /// <summary>
        /// RepoURL is the repository URL of the application manifests
        /// </summary>
        public readonly string RepoURL;
        /// <summary>
        /// TargetRevision defines the commit, tag, or branch in which to sync the application to. If omitted, will sync to HEAD
        /// </summary>
        public readonly string TargetRevision;

        [OutputConstructor]
        private ApplicationStatusOperationStateOperationSyncSource(
            string chart,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceDirectory directory,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceHelm helm,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceKsonnet ksonnet,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourceKustomize kustomize,

            string path,

            Pulumi.Kubernetes.Types.Outputs.Argoproj.V1Alpha1.ApplicationStatusOperationStateOperationSyncSourcePlugin plugin,

            string repoURL,

            string targetRevision)
        {
            Chart = chart;
            Directory = directory;
            Helm = helm;
            Ksonnet = ksonnet;
            Kustomize = kustomize;
            Path = path;
            Plugin = plugin;
            RepoURL = repoURL;
            TargetRevision = targetRevision;
        }
    }
}