// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    public class APIManagerSpecZyncArgs : Pulumi.ResourceArgs
    {
        [Input("appSpec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecZyncAppSpecArgs>? AppSpec { get; set; }

        /// <summary>
        /// Affinity is a group of affinity scheduling rules.
        /// </summary>
        [Input("databaseAffinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecZyncDatabaseAffinityArgs>? DatabaseAffinity { get; set; }

        [Input("databaseTolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecZyncDatabaseTolerationsArgs>? _databaseTolerations;
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecZyncDatabaseTolerationsArgs> DatabaseTolerations
        {
            get => _databaseTolerations ?? (_databaseTolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecZyncDatabaseTolerationsArgs>());
            set => _databaseTolerations = value;
        }

        [Input("image")]
        public Input<string>? Image { get; set; }

        [Input("postgreSQLImage")]
        public Input<string>? PostgreSQLImage { get; set; }

        [Input("queSpec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1.APIManagerSpecZyncQueSpecArgs>? QueSpec { get; set; }

        public APIManagerSpecZyncArgs()
        {
        }
    }
}
