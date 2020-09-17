// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1
{

    public class IoTConfigSpecArgs : Pulumi.ResourceArgs
    {
        [Input("adapters")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1.IoTConfigSpecAdaptersArgs>? Adapters { get; set; }

        [Input("enableDefaultRoutes")]
        public Input<bool>? EnableDefaultRoutes { get; set; }

        [Input("imageOverrides")]
        private InputMap<object>? _imageOverrides;
        public InputMap<object> ImageOverrides
        {
            get => _imageOverrides ?? (_imageOverrides = new InputMap<object>());
            set => _imageOverrides = value;
        }

        /// <summary>
        /// Configure the strategy to use for connecting services using certificates. If no configuration
        /// is present, and you are running on OpenShift 4, then it will automatically deploy certificates
        /// using the Service CA.
        /// </summary>
        [Input("interServiceCertificates")]
        public Input<object>? InterServiceCertificates { get; set; }

        [Input("java")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1.IoTConfigSpecJavaArgs>? Java { get; set; }

        [Input("logging")]
        private InputMap<object>? _logging;
        public InputMap<object> Logging
        {
            get => _logging ?? (_logging = new InputMap<object>());
            set => _logging = value;
        }

        [Input("mesh")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1.IoTConfigSpecMeshArgs>? Mesh { get; set; }

        [Input("monitoring")]
        private InputMap<object>? _monitoring;
        public InputMap<object> Monitoring
        {
            get => _monitoring ?? (_monitoring = new InputMap<object>());
            set => _monitoring = value;
        }

        [Input("services")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1.IoTConfigSpecServicesArgs>? Services { get; set; }

        /// <summary>
        /// Global TLS configuration
        /// </summary>
        [Input("tls")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1.IoTConfigSpecTlsArgs>? Tls { get; set; }

        [Input("tracing")]
        private InputMap<object>? _tracing;
        public InputMap<object> Tracing
        {
            get => _tracing ?? (_tracing = new InputMap<object>());
            set => _tracing = value;
        }

        public IoTConfigSpecArgs()
        {
        }
    }
}
