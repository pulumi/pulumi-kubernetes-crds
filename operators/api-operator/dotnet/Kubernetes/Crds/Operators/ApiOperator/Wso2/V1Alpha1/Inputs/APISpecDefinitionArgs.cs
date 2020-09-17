// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1
{

    public class APISpecDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("interceptors")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Wso2.V1Alpha1.APISpecDefinitionInterceptorsArgs>? Interceptors { get; set; }

        [Input("swaggerConfigmapNames", required: true)]
        private InputList<string>? _swaggerConfigmapNames;
        public InputList<string> SwaggerConfigmapNames
        {
            get => _swaggerConfigmapNames ?? (_swaggerConfigmapNames = new InputList<string>());
            set => _swaggerConfigmapNames = value;
        }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public APISpecDefinitionArgs()
        {
        }
    }
}
