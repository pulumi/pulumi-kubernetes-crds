// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1
{

    [OutputType]
    public sealed class APIMgmtAPISpecProperties
    {
        /// <summary>
        /// APIRevision - Describes the Revision of the Api. If no value is provided, default revision 1 is created
        /// </summary>
        public readonly string ApiRevision;
        /// <summary>
        /// APIRevisionDescription - Description of the Api Revision.
        /// </summary>
        public readonly string ApiRevisionDescription;
        /// <summary>
        /// APIVersion - Indicates the Version identifier of the API if the API is versioned
        /// </summary>
        public readonly string ApiVersion;
        /// <summary>
        /// APIVersionDescription - Description of the Api Version.
        /// </summary>
        public readonly string ApiVersionDescription;
        /// <summary>
        /// APIVersionSetID - A resource identifier for the related ApiVersionSet.
        /// </summary>
        public readonly string ApiVersionSetId;
        /// <summary>
        /// APIVersionSet - APIVersionSetContractDetails an API Version Set contains the common configuration for a set of API versions.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1.APIMgmtAPISpecPropertiesApiVersionSets ApiVersionSets;
        /// <summary>
        /// Description - Description of the API. May include HTML formatting tags.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// DisplayName - API name. Must be 1 to 300 characters long.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        ///  Format - Format of the Content in which the API is getting imported. Possible values include: 	'WadlXML', 'WadlLinkJSON', 'SwaggerJSON', 'SwaggerLinkJSON', 'Wsdl', 'WsdlLink', 'Openapi', 'Openapijson', 'OpenapiLink'
        /// </summary>
        public readonly string Format;
        /// <summary>
        /// IsCurrent - Indicates if API revision is current api revision.
        /// </summary>
        public readonly bool IsCurrent;
        /// <summary>
        /// IsOnline - READ-ONLY; Indicates if API revision is accessible via the gateway.
        /// </summary>
        public readonly bool IsOnline;
        /// <summary>
        ///  Path - Relative URL uniquely identifying this API and all of its resource paths within the API Management service instance. 	It is appended to the API endpoint base URL specified during the service instance creation to form a public URL for this API.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Protocols - Describes on which protocols the operations in this API can be invoked.
        /// </summary>
        public readonly ImmutableArray<string> Protocols;
        /// <summary>
        /// ServiceURL - Absolute URL of the backend service implementing this API. Cannot be more than 2000 characters long.
        /// </summary>
        public readonly string ServiceUrl;
        /// <summary>
        /// SourceAPIID - API identifier of the source API.
        /// </summary>
        public readonly string SourceApiId;
        /// <summary>
        /// SubscriptionRequired - Specifies whether an API or Product subscription is required for accessing the API.
        /// </summary>
        public readonly bool SubscriptionRequired;

        [OutputConstructor]
        private APIMgmtAPISpecProperties(
            string apiRevision,

            string apiRevisionDescription,

            string apiVersion,

            string apiVersionDescription,

            string apiVersionSetId,

            Pulumi.Kubernetes.Types.Outputs.Azure.V1Alpha1.APIMgmtAPISpecPropertiesApiVersionSets apiVersionSets,

            string description,

            string displayName,

            string format,

            bool isCurrent,

            bool isOnline,

            string path,

            ImmutableArray<string> protocols,

            string serviceUrl,

            string sourceApiId,

            bool subscriptionRequired)
        {
            ApiRevision = apiRevision;
            ApiRevisionDescription = apiRevisionDescription;
            ApiVersion = apiVersion;
            ApiVersionDescription = apiVersionDescription;
            ApiVersionSetId = apiVersionSetId;
            ApiVersionSets = apiVersionSets;
            Description = description;
            DisplayName = displayName;
            Format = format;
            IsCurrent = isCurrent;
            IsOnline = isOnline;
            Path = path;
            Protocols = protocols;
            ServiceUrl = serviceUrl;
            SourceApiId = sourceApiId;
            SubscriptionRequired = subscriptionRequired;
        }
    }
}