// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Iot.V1Alpha1
{

    /// <summary>
    /// The input accepted from the `.spec.configuration` section, split up into the different areas.
    /// </summary>
    public class IoTProjectStatusAcceptedArgs : Pulumi.ResourceArgs
    {
        [Input("configuration")]
        private InputMap<object>? _configuration;

        /// <summary>
        /// The accepted configuration section, ready to be used as a reply to a "Get Tenant" request.
        /// </summary>
        public InputMap<object> Configuration
        {
            get => _configuration ?? (_configuration = new InputMap<object>());
            set => _configuration = value;
        }

        public IoTProjectStatusAcceptedArgs()
        {
        }
    }
}