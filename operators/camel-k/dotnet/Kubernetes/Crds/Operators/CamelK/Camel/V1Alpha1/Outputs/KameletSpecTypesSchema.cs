// *** WARNING: this file was generated by crd2pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Camel.V1Alpha1
{

    [OutputType]
    public sealed class KameletSpecTypesSchema
    {
        public readonly string $ref;
        /// <summary>
        /// JSONSchemaURL represents a schema url.
        /// </summary>
        public readonly string $schema;
        public readonly bool AdditionalItems;
        public readonly bool AdditionalProperties;
        public readonly ImmutableArray<object> AllOf;
        public readonly ImmutableArray<object> AnyOf;
        /// <summary>
        /// default is a default value for undefined object fields. Defaulting is a beta feature under the CustomResourceDefaulting feature gate. Defaulting requires spec.preserveUnknownFields to be false.
        /// </summary>
        public readonly object Default;
        /// <summary>
        /// JSONSchemaDefinitions contains the models explicitly defined in this spec.
        /// </summary>
        public readonly ImmutableDictionary<string, object> Definitions;
        /// <summary>
        /// JSONSchemaDependencies represent a dependencies property.
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<string>> Dependencies;
        public readonly string Description;
        public readonly ImmutableArray<object> Enum;
        public readonly object Example;
        public readonly bool ExclusiveMaximum;
        public readonly bool ExclusiveMinimum;
        /// <summary>
        /// ExternalDocumentation allows referencing an external resource for extended documentation.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Camel.V1Alpha1.KameletSpecTypesSchemaExternalDocs ExternalDocs;
        /// <summary>
        /// format is an OpenAPI v3 format string. Unknown formats are ignored. The following formats are validated: 
        ///  - bsonobjectid: a bson object ID, i.e. a 24 characters hex string - uri: an URI as parsed by Golang net/url.ParseRequestURI - email: an email address as parsed by Golang net/mail.ParseAddress - hostname: a valid representation for an Internet host name, as defined by RFC 1034, section 3.1 [RFC1034]. - ipv4: an IPv4 IP as parsed by Golang net.ParseIP - ipv6: an IPv6 IP as parsed by Golang net.ParseIP - cidr: a CIDR as parsed by Golang net.ParseCIDR - mac: a MAC address as parsed by Golang net.ParseMAC - uuid: an UUID that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?[0-9a-f]{4}-?[0-9a-f]{4}-?[0-9a-f]{12}$ - uuid3: an UUID3 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?3[0-9a-f]{3}-?[0-9a-f]{4}-?[0-9a-f]{12}$ - uuid4: an UUID4 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?4[0-9a-f]{3}-?[89ab][0-9a-f]{3}-?[0-9a-f]{12}$ - uuid5: an UUID5 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?5[0-9a-f]{3}-?[89ab][0-9a-f]{3}-?[0-9a-f]{12}$ - isbn: an ISBN10 or ISBN13 number string like "0321751043" or "978-0321751041" - isbn10: an ISBN10 number string like "0321751043" - isbn13: an ISBN13 number string like "978-0321751041" - creditcard: a credit card number defined by the regex ^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\\d{3})\\d{11})$ with any non digit characters mixed in - ssn: a U.S. social security number following the regex ^\\d{3}[- ]?\\d{2}[- ]?\\d{4}$ - hexcolor: an hexadecimal color code like "#FFFFFF: following the regex ^#?([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$ - rgbcolor: an RGB color code like rgb like "rgb(255,255,2559" - byte: base64 encoded binary data - password: any kind of string - date: a date string like "2006-01-02" as defined by full-date in RFC3339 - duration: a duration string like "22 ns" as parsed by Golang time.ParseDuration or compatible with Scala duration format - datetime: a date time string like "2014-12-15T19:30:20.000Z" as defined by date-time in RFC3339.
        /// </summary>
        public readonly string Format;
        public readonly string Id;
        public readonly object Items;
        public readonly int MaxItems;
        public readonly int MaxLength;
        public readonly int MaxProperties;
        /// <summary>
        /// A Number represents a JSON number literal.
        /// </summary>
        public readonly string Maximum;
        public readonly int MinItems;
        public readonly int MinLength;
        public readonly int MinProperties;
        /// <summary>
        /// A Number represents a JSON number literal.
        /// </summary>
        public readonly string Minimum;
        /// <summary>
        /// A Number represents a JSON number literal.
        /// </summary>
        public readonly string MultipleOf;
        public readonly object Not;
        public readonly bool Nullable;
        public readonly ImmutableArray<object> OneOf;
        public readonly string Pattern;
        public readonly ImmutableDictionary<string, object> PatternProperties;
        public readonly ImmutableDictionary<string, object> Properties;
        public readonly ImmutableArray<string> Required;
        public readonly string Title;
        public readonly string Type;
        public readonly bool UniqueItems;
        /// <summary>
        /// x-descriptors annotates an object to define additional display options.
        /// </summary>
        public readonly ImmutableArray<string> X-descriptors;
        /// <summary>
        /// x-kubernetes-embedded-resource defines that the value is an embedded Kubernetes runtime.Object, with TypeMeta and ObjectMeta. The type must be object. It is allowed to further restrict the embedded object. kind, apiVersion and metadata are validated automatically. x-kubernetes-preserve-unknown-fields is allowed to be true, but does not have to be if the object is fully specified (up to kind, apiVersion, metadata).
        /// </summary>
        public readonly bool X-kubernetes-embedded-resource;
        /// <summary>
        /// x-kubernetes-int-or-string specifies that this value is either an integer or a string. If this is true, an empty type is allowed and type as child of anyOf is permitted if following one of the following patterns: 
        ///  1) anyOf:    - type: integer    - type: string 2) allOf:    - anyOf:      - type: integer      - type: string    - ... zero or more
        /// </summary>
        public readonly bool X-kubernetes-int-or-string;
        /// <summary>
        /// x-kubernetes-list-map-keys annotates an array with the x-kubernetes-list-type `map` by specifying the keys used as the index of the map. 
        ///  This tag MUST only be used on lists that have the "x-kubernetes-list-type" extension set to "map". Also, the values specified for this attribute must be a scalar typed field of the child structure (no nesting is supported). 
        ///  The properties specified must either be required or have a default value, to ensure those properties are present for all list items.
        /// </summary>
        public readonly ImmutableArray<string> X-kubernetes-list-map-keys;
        /// <summary>
        /// x-kubernetes-list-type annotates an array to further describe its topology. This extension must only be used on lists and may have 3 possible values: 
        ///  1) `atomic`: the list is treated as a single entity, like a scalar.      Atomic lists will be entirely replaced when updated. This extension      may be used on any type of list (struct, scalar, ...). 2) `set`:      Sets are lists that must not have multiple items with the same value. Each      value must be a scalar, an object with x-kubernetes-map-type `atomic` or an      array with x-kubernetes-list-type `atomic`. 3) `map`:      These lists are like maps in that their elements have a non-index key      used to identify them. Order is preserved upon merge. The map tag      must only be used on a list with elements of type object. Defaults to atomic for arrays.
        /// </summary>
        public readonly string X-kubernetes-list-type;
        /// <summary>
        /// x-kubernetes-map-type annotates an object to further describe its topology. This extension must only be used when type is object and may have 2 possible values: 
        ///  1) `granular`:      These maps are actual maps (key-value pairs) and each fields are independent      from each other (they can each be manipulated by separate actors). This is      the default behaviour for all maps. 2) `atomic`: the list is treated as a single entity, like a scalar.      Atomic maps will be entirely replaced when updated.
        /// </summary>
        public readonly string X-kubernetes-map-type;
        /// <summary>
        /// x-kubernetes-preserve-unknown-fields stops the API server decoding step from pruning fields which are not specified in the validation schema. This affects fields recursively, but switches back to normal pruning behaviour if nested properties or additionalProperties are specified in the schema. This can either be true or undefined. False is forbidden.
        /// </summary>
        public readonly bool X-kubernetes-preserve-unknown-fields;

        [OutputConstructor]
        private KameletSpecTypesSchema(
            string @ref,

            string schema,

            bool additionalItems,

            bool additionalProperties,

            ImmutableArray<object> allOf,

            ImmutableArray<object> anyOf,

            object @default,

            ImmutableDictionary<string, object> definitions,

            ImmutableDictionary<string, ImmutableArray<string>> dependencies,

            string description,

            ImmutableArray<object> @enum,

            object example,

            bool exclusiveMaximum,

            bool exclusiveMinimum,

            Pulumi.Kubernetes.Types.Outputs.Camel.V1Alpha1.KameletSpecTypesSchemaExternalDocs externalDocs,

            string format,

            string id,

            object items,

            int maxItems,

            int maxLength,

            int maxProperties,

            string maximum,

            int minItems,

            int minLength,

            int minProperties,

            string minimum,

            string multipleOf,

            object not,

            bool nullable,

            ImmutableArray<object> oneOf,

            string pattern,

            ImmutableDictionary<string, object> patternProperties,

            ImmutableDictionary<string, object> properties,

            ImmutableArray<string> required,

            string title,

            string type,

            bool uniqueItems,

            ImmutableArray<string> x-descriptors,

            bool x-kubernetes-embedded-resource,

            bool x-kubernetes-int-or-string,

            ImmutableArray<string> x-kubernetes-list-map-keys,

            string x-kubernetes-list-type,

            string x-kubernetes-map-type,

            bool x-kubernetes-preserve-unknown-fields)
        {
            $ref = @ref;
            $schema = schema;
            AdditionalItems = additionalItems;
            AdditionalProperties = additionalProperties;
            AllOf = allOf;
            AnyOf = anyOf;
            Default = @default;
            Definitions = definitions;
            Dependencies = dependencies;
            Description = description;
            Enum = @enum;
            Example = example;
            ExclusiveMaximum = exclusiveMaximum;
            ExclusiveMinimum = exclusiveMinimum;
            ExternalDocs = externalDocs;
            Format = format;
            Id = id;
            Items = items;
            MaxItems = maxItems;
            MaxLength = maxLength;
            MaxProperties = maxProperties;
            Maximum = maximum;
            MinItems = minItems;
            MinLength = minLength;
            MinProperties = minProperties;
            Minimum = minimum;
            MultipleOf = multipleOf;
            Not = not;
            Nullable = nullable;
            OneOf = oneOf;
            Pattern = pattern;
            PatternProperties = patternProperties;
            Properties = properties;
            Required = required;
            Title = title;
            Type = type;
            UniqueItems = uniqueItems;
            X-descriptors = x-descriptors;
            X-kubernetes-embedded-resource = x-kubernetes-embedded-resource;
            X-kubernetes-int-or-string = x-kubernetes-int-or-string;
            X-kubernetes-list-map-keys = x-kubernetes-list-map-keys;
            X-kubernetes-list-type = x-kubernetes-list-type;
            X-kubernetes-map-type = x-kubernetes-map-type;
            X-kubernetes-preserve-unknown-fields = x-kubernetes-preserve-unknown-fields;
        }
    }
}
