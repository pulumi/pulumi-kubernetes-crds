// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1
{

    [OutputType]
    public sealed class PackageSpec
    {
        public readonly string Category;
        public readonly string Company;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecController Controller;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecCustomresourcedefinitions> Customresourcedefinitions;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecDependsOn> DependsOn;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecIcons> Icons;
        public readonly ImmutableArray<string> Keywords;
        public readonly string License;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecMaintainers> Maintainers;
        public readonly string Overview;
        public readonly string OverviewShort;
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecOwners> Owners;
        public readonly string PackageType;
        public readonly string PermissionScope;
        public readonly Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecPermissions Permissions;
        public readonly string Readme;
        public readonly string Source;
        public readonly string Title;
        public readonly string Version;
        public readonly string Website;

        [OutputConstructor]
        private PackageSpec(
            string category,

            string company,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecController controller,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecCustomresourcedefinitions> customresourcedefinitions,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecDependsOn> dependsOn,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecIcons> icons,

            ImmutableArray<string> keywords,

            string license,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecMaintainers> maintainers,

            string overview,

            string overviewShort,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecOwners> owners,

            string packageType,

            string permissionScope,

            Pulumi.Kubernetes.Types.Outputs.Packages.V1Alpha1.PackageSpecPermissions permissions,

            string readme,

            string source,

            string title,

            string version,

            string website)
        {
            Category = category;
            Company = company;
            Controller = controller;
            Customresourcedefinitions = customresourcedefinitions;
            DependsOn = dependsOn;
            Icons = icons;
            Keywords = keywords;
            License = license;
            Maintainers = maintainers;
            Overview = overview;
            OverviewShort = overviewShort;
            Owners = owners;
            PackageType = packageType;
            PermissionScope = permissionScope;
            Permissions = permissions;
            Readme = readme;
            Source = source;
            Title = title;
            Version = version;
            Website = website;
        }
    }
}
