// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Infinispan.V1
{

    public class InfinispanSpecLoggingArgs : Pulumi.ResourceArgs
    {
        [Input("categories")]
        private InputMap<string>? _categories;
        public InputMap<string> Categories
        {
            get => _categories ?? (_categories = new InputMap<string>());
            set => _categories = value;
        }

        public InfinispanSpecLoggingArgs()
        {
        }
    }
}
