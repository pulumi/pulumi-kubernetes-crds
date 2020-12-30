// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1Alpha1
{

    /// <summary>
    /// APIManager Deployment Configs
    /// </summary>
    public class APIManagerStatusDeploymentsArgs : Pulumi.ResourceArgs
    {
        [Input("ready")]
        private InputList<string>? _ready;

        /// <summary>
        /// Deployments are ready to serve requests
        /// </summary>
        public InputList<string> Ready
        {
            get => _ready ?? (_ready = new InputList<string>());
            set => _ready = value;
        }

        [Input("starting")]
        private InputList<string>? _starting;

        /// <summary>
        /// Deployments are starting, may or may not succeed
        /// </summary>
        public InputList<string> Starting
        {
            get => _starting ?? (_starting = new InputList<string>());
            set => _starting = value;
        }

        [Input("stopped")]
        private InputList<string>? _stopped;

        /// <summary>
        /// Deployments are not starting, unclear what next step will be
        /// </summary>
        public InputList<string> Stopped
        {
            get => _stopped ?? (_stopped = new InputList<string>());
            set => _stopped = value;
        }

        public APIManagerStatusDeploymentsArgs()
        {
        }
    }
}
