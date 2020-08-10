/* 
 * Nodeum API
 *
 * The Nodeum API makes it easy to tap into the digital data mesh that runs across your organisation. Make requests to our API endpoints and we’ll give you everything you need to interconnect your business workflows with your storage.  All production API requests are made to:  http://nodeumhostname/api/  The current production version of the API is v1.   **REST** The Nodeum API is a RESTful API. This means that the API is designed to allow you to get, create, update, & delete objects with the HTTP verbs GET, POST, PUT, PATCH, & DELETE.  **JSON** The Nodeum API speaks exclusively in JSON. This means that you should always set the Content-Type header to application/json to ensure that your requests are properly accepted and processed by the API.  **Authentication** All API calls require user-password authentication.   **Cross-Origin Resource Sharing** The Nodeum API supports CORS for communicating from Javascript for these endpoints. You will need to specify an Origin URI when creating your application to allow for CORS to be whitelisted for your domain.   **Pagination** Some endpoints such as File Listing return a potentially lengthy array of objects. In order to keep the response sizes manageable the API will take advantage of pagination. Pagination is a mechanism for returning a subset of the results for a request and allowing for subsequent requests to “page” through the rest of the results until the end is reached. Paginated endpoints follow a standard interface that accepts two query parameters, limit and offset, and return a payload that follows a standard form. These parameters names and their behavior are borrowed from SQL LIMIT and OFFSET keywords.  **Versioning** The Nodeum API is constantly being worked on to add features, make improvements, and fix bugs. This means that you should expect changes to be introduced and documented.   However, there are some changes or additions that are considered backwards-compatible and your applications should be flexible enough to handle them. These include:  - Adding new endpoints to the API - Adding new attributes to the response of an existing endpoint - Changing the order of attributes of responses (JSON by definition is an object of unordered key/value pairs)  **Filter parameters** When browsing a list of items, multiple filter parameters may be applied. Some operators can be added to the value as a prefix:  - `=` value is equal. Default operator, may be omitted  - `!=` value is different  - `>` greater than  - `>=` greater than or equal  - `<` lower than  - `>=` lower than or equal  - `><` included in list, items should be separated by `|`  - `!><` not included in list, items should be separated by `|`  - `~` pattern matching, may include `%` (any characters) and `_` (one character)  - `!~` pattern not matching, may include `%` (any characters) and `_` (one character)  
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: info@nodeum.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Io.Nodeum.Sdk.Client.OpenAPIDateConverter;

namespace Io.Nodeum.Sdk.Model
{
    /// <summary>
    /// StorageFacet
    /// </summary>
    [DataContract]
    public partial class StorageFacet :  IEquatable<StorageFacet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFacet" /> class.
        /// </summary>
        /// <param name="container">container.</param>
        /// <param name="nasShare">nasShare.</param>
        /// <param name="cloudBucket">cloudBucket.</param>
        /// <param name="tape">tape.</param>
        /// <param name="pool">pool.</param>
        public StorageFacet(DefaultFacet container = default(DefaultFacet), StorageNasShareFacets nasShare = default(StorageNasShareFacets), StorageCloudBucketFacets cloudBucket = default(StorageCloudBucketFacets), StorageTapeFacets tape = default(StorageTapeFacets), StoragePoolFacets pool = default(StoragePoolFacets))
        {
            this.Container = container;
            this.NasShare = nasShare;
            this.CloudBucket = cloudBucket;
            this.Tape = tape;
            this.Pool = pool;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int Count { get; private set; }

        /// <summary>
        /// Gets or Sets Container
        /// </summary>
        [DataMember(Name="container", EmitDefaultValue=false)]
        public DefaultFacet Container { get; set; }

        /// <summary>
        /// Gets or Sets NasShare
        /// </summary>
        [DataMember(Name="nas_share", EmitDefaultValue=false)]
        public StorageNasShareFacets NasShare { get; set; }

        /// <summary>
        /// Gets or Sets CloudBucket
        /// </summary>
        [DataMember(Name="cloud_bucket", EmitDefaultValue=false)]
        public StorageCloudBucketFacets CloudBucket { get; set; }

        /// <summary>
        /// Gets or Sets Tape
        /// </summary>
        [DataMember(Name="tape", EmitDefaultValue=false)]
        public StorageTapeFacets Tape { get; set; }

        /// <summary>
        /// Gets or Sets Pool
        /// </summary>
        [DataMember(Name="pool", EmitDefaultValue=false)]
        public StoragePoolFacets Pool { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageFacet {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Container: ").Append(Container).Append("\n");
            sb.Append("  NasShare: ").Append(NasShare).Append("\n");
            sb.Append("  CloudBucket: ").Append(CloudBucket).Append("\n");
            sb.Append("  Tape: ").Append(Tape).Append("\n");
            sb.Append("  Pool: ").Append(Pool).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StorageFacet);
        }

        /// <summary>
        /// Returns true if StorageFacet instances are equal
        /// </summary>
        /// <param name="input">Instance of StorageFacet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageFacet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Container == input.Container ||
                    (this.Container != null &&
                    this.Container.Equals(input.Container))
                ) && 
                (
                    this.NasShare == input.NasShare ||
                    (this.NasShare != null &&
                    this.NasShare.Equals(input.NasShare))
                ) && 
                (
                    this.CloudBucket == input.CloudBucket ||
                    (this.CloudBucket != null &&
                    this.CloudBucket.Equals(input.CloudBucket))
                ) && 
                (
                    this.Tape == input.Tape ||
                    (this.Tape != null &&
                    this.Tape.Equals(input.Tape))
                ) && 
                (
                    this.Pool == input.Pool ||
                    (this.Pool != null &&
                    this.Pool.Equals(input.Pool))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Container != null)
                    hashCode = hashCode * 59 + this.Container.GetHashCode();
                if (this.NasShare != null)
                    hashCode = hashCode * 59 + this.NasShare.GetHashCode();
                if (this.CloudBucket != null)
                    hashCode = hashCode * 59 + this.CloudBucket.GetHashCode();
                if (this.Tape != null)
                    hashCode = hashCode * 59 + this.Tape.GetHashCode();
                if (this.Pool != null)
                    hashCode = hashCode * 59 + this.Pool.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
