// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Reflection;
using Pulumi.Kubernetes;

namespace Pulumi.Pulumi.Kubernetes.Crds.Operators.IotSimulator
{
    static class Utilities
    {
        public static string Version { get; } = GetVersion();

        private static string GetVersion()
        {
            const string UtilitiesType = "Pulumi.Kubernetes.Utilities";
            const string VersionProperty = "Version";

            Type? type = Assembly.GetAssembly(typeof(Provider))?.GetType(UtilitiesType);
            if (type is null)
            {
                throw new InvalidOperationException($"{UtilitiesType} type could not be obtained.");
            }

            PropertyInfo? prop = type.GetProperty(VersionProperty, BindingFlags.Static | BindingFlags.Public);
            if (prop is null)
            {
                throw new InvalidOperationException($"{UtilitiesType}.{VersionProperty} property could not be obtained.");
            }

            var result = prop.GetValue(type, null) as string;
            if (result is null)
            {
                throw new InvalidOperationException($"Expected {UtilitiesType}.{VersionProperty} to return a non-null string.");
            }
            return result;
        }
    }
}
