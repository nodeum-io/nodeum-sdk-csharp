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
    /// Container
    /// </summary>
    [DataContract]
    public partial class Container :  IEquatable<Container>, IValidatableObject
    {
        /// <summary>
        /// Defines GuestRight
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GuestRightEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Read for value: read
            /// </summary>
            [EnumMember(Value = "read")]
            Read = 2,

            /// <summary>
            /// Enum Readwrite for value: read_write
            /// </summary>
            [EnumMember(Value = "read_write")]
            Readwrite = 3

        }

        /// <summary>
        /// Gets or Sets GuestRight
        /// </summary>
        [DataMember(Name="guest_right", EmitDefaultValue=false)]
        public GuestRightEnum? GuestRight { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Container" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="comment">comment.</param>
        /// <param name="quotaTotalSize">quotaTotalSize.</param>
        /// <param name="quotaOnCache">quotaOnCache.</param>
        /// <param name="guestRight">guestRight.</param>
        public Container(string name = default(string), string comment = default(string), int quotaTotalSize = default(int), int quotaOnCache = default(int), GuestRightEnum? guestRight = default(GuestRightEnum?))
        {
            this.Name = name;
            this.Comment = comment;
            this.QuotaTotalSize = quotaTotalSize;
            this.QuotaOnCache = quotaOnCache;
            this.GuestRight = guestRight;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets QuotaTotalSize
        /// </summary>
        [DataMember(Name="quota_total_size", EmitDefaultValue=false)]
        public int QuotaTotalSize { get; set; }

        /// <summary>
        /// Gets or Sets QuotaOnCache
        /// </summary>
        [DataMember(Name="quota_on_cache", EmitDefaultValue=false)]
        public int QuotaOnCache { get; set; }

        /// <summary>
        /// Gets or Sets StatTotalFiles
        /// </summary>
        [DataMember(Name="stat_total_files", EmitDefaultValue=false)]
        public int StatTotalFiles { get; private set; }

        /// <summary>
        /// Gets or Sets OnlyOnCacheFileCount
        /// </summary>
        [DataMember(Name="only_on_cache_file_count", EmitDefaultValue=false)]
        public int OnlyOnCacheFileCount { get; private set; }

        /// <summary>
        /// Gets or Sets StatTotalSize
        /// </summary>
        [DataMember(Name="stat_total_size", EmitDefaultValue=false)]
        public int StatTotalSize { get; private set; }

        /// <summary>
        /// Gets or Sets StatSizeOnCache
        /// </summary>
        [DataMember(Name="stat_size_on_cache", EmitDefaultValue=false)]
        public int StatSizeOnCache { get; private set; }

        /// <summary>
        /// Gets or Sets OnlyOnCacheFileSizeSum
        /// </summary>
        [DataMember(Name="only_on_cache_file_size_sum", EmitDefaultValue=false)]
        public int OnlyOnCacheFileSizeSum { get; private set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name="last_update", EmitDefaultValue=false)]
        public string LastUpdate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Container {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  QuotaTotalSize: ").Append(QuotaTotalSize).Append("\n");
            sb.Append("  QuotaOnCache: ").Append(QuotaOnCache).Append("\n");
            sb.Append("  StatTotalFiles: ").Append(StatTotalFiles).Append("\n");
            sb.Append("  OnlyOnCacheFileCount: ").Append(OnlyOnCacheFileCount).Append("\n");
            sb.Append("  StatTotalSize: ").Append(StatTotalSize).Append("\n");
            sb.Append("  StatSizeOnCache: ").Append(StatSizeOnCache).Append("\n");
            sb.Append("  OnlyOnCacheFileSizeSum: ").Append(OnlyOnCacheFileSizeSum).Append("\n");
            sb.Append("  GuestRight: ").Append(GuestRight).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
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
            return this.Equals(input as Container);
        }

        /// <summary>
        /// Returns true if Container instances are equal
        /// </summary>
        /// <param name="input">Instance of Container to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Container input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.QuotaTotalSize == input.QuotaTotalSize ||
                    this.QuotaTotalSize.Equals(input.QuotaTotalSize)
                ) && 
                (
                    this.QuotaOnCache == input.QuotaOnCache ||
                    this.QuotaOnCache.Equals(input.QuotaOnCache)
                ) && 
                (
                    this.StatTotalFiles == input.StatTotalFiles ||
                    this.StatTotalFiles.Equals(input.StatTotalFiles)
                ) && 
                (
                    this.OnlyOnCacheFileCount == input.OnlyOnCacheFileCount ||
                    this.OnlyOnCacheFileCount.Equals(input.OnlyOnCacheFileCount)
                ) && 
                (
                    this.StatTotalSize == input.StatTotalSize ||
                    this.StatTotalSize.Equals(input.StatTotalSize)
                ) && 
                (
                    this.StatSizeOnCache == input.StatSizeOnCache ||
                    this.StatSizeOnCache.Equals(input.StatSizeOnCache)
                ) && 
                (
                    this.OnlyOnCacheFileSizeSum == input.OnlyOnCacheFileSizeSum ||
                    this.OnlyOnCacheFileSizeSum.Equals(input.OnlyOnCacheFileSizeSum)
                ) && 
                (
                    this.GuestRight == input.GuestRight ||
                    this.GuestRight.Equals(input.GuestRight)
                ) && 
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                hashCode = hashCode * 59 + this.QuotaTotalSize.GetHashCode();
                hashCode = hashCode * 59 + this.QuotaOnCache.GetHashCode();
                hashCode = hashCode * 59 + this.StatTotalFiles.GetHashCode();
                hashCode = hashCode * 59 + this.OnlyOnCacheFileCount.GetHashCode();
                hashCode = hashCode * 59 + this.StatTotalSize.GetHashCode();
                hashCode = hashCode * 59 + this.StatSizeOnCache.GetHashCode();
                hashCode = hashCode * 59 + this.OnlyOnCacheFileSizeSum.GetHashCode();
                hashCode = hashCode * 59 + this.GuestRight.GetHashCode();
                if (this.LastUpdate != null)
                    hashCode = hashCode * 59 + this.LastUpdate.GetHashCode();
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
