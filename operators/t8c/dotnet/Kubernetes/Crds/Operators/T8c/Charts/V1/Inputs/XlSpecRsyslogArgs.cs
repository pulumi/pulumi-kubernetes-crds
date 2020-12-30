// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Charts.V1
{

    public class XlSpecRsyslogArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<object>? _annotations;

        /// <summary>
        /// component specific pod annotations list
        /// </summary>
        public InputMap<object> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<object>());
            set => _annotations = value;
        }

        [Input("env")]
        private InputList<ImmutableDictionary<string, object>>? _env;

        /// <summary>
        /// optional environment variables for syslog
        /// </summary>
        public InputList<ImmutableDictionary<string, object>> Env
        {
            get => _env ?? (_env = new InputList<ImmutableDictionary<string, object>>());
            set => _env = value;
        }

        /// <summary>
        /// component specific image options
        /// </summary>
        [Input("image")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecRsyslogImageArgs>? Image { get; set; }

        /// <summary>
        /// rsyslog persistence options
        /// </summary>
        [Input("persistence")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Charts.V1.XlSpecRsyslogPersistenceArgs>? Persistence { get; set; }

        public XlSpecRsyslogArgs()
        {
        }
    }
}
