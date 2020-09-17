// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apiextensions.V1Alpha1
{

    /// <summary>
    /// validation describes the schema used for validation and pruning of the custom resource. If present, this validation schema is used to validate all versions. Top-level and per-version schemas are mutually exclusive.
    /// </summary>
    public class InfrastructureDefinitionSpecCrdSpecTemplateValidationArgs : Pulumi.ResourceArgs
    {
        [Input("openAPIV3Schema")]
        private InputMap<object>? _openAPIV3Schema;

        /// <summary>
        /// openAPIV3Schema is the OpenAPI v3 schema to use for validation and pruning.
        /// </summary>
        public InputMap<object> OpenAPIV3Schema
        {
            get => _openAPIV3Schema ?? (_openAPIV3Schema = new InputMap<object>());
            set => _openAPIV3Schema = value;
        }

        public InfrastructureDefinitionSpecCrdSpecTemplateValidationArgs()
        {
        }
    }
}
