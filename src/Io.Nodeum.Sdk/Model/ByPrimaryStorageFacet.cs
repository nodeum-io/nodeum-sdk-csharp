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
    /// ByPrimaryStorageFacet
    /// </summary>
    [DataContract]
    public partial class ByPrimaryStorageFacet :  IEquatable<ByPrimaryStorageFacet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ByPrimaryStorageFacet" /> class.
        /// </summary>
        /// <param name="onPrimaryContainer">onPrimaryContainer.</param>
        /// <param name="onPrimaryNas">onPrimaryNas.</param>
        /// <param name="onPrimaryPublicCloud">onPrimaryPublicCloud.</param>
        /// <param name="onPrimaryObjectCloud">onPrimaryObjectCloud.</param>
        public ByPrimaryStorageFacet(ByPrimaryTypeFacet onPrimaryContainer = default(ByPrimaryTypeFacet), ByPrimaryTypeFacet onPrimaryNas = default(ByPrimaryTypeFacet), ByPrimaryTypeFacet onPrimaryPublicCloud = default(ByPrimaryTypeFacet), ByPrimaryTypeFacet onPrimaryObjectCloud = default(ByPrimaryTypeFacet))
        {
            this.OnPrimaryContainer = onPrimaryContainer;
            this.OnPrimaryNas = onPrimaryNas;
            this.OnPrimaryPublicCloud = onPrimaryPublicCloud;
            this.OnPrimaryObjectCloud = onPrimaryObjectCloud;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int Count { get; private set; }

        /// <summary>
        /// Gets or Sets FilesCount
        /// </summary>
        [DataMember(Name="files_count", EmitDefaultValue=false)]
        public int FilesCount { get; private set; }

        /// <summary>
        /// Gets or Sets FileSizeSum
        /// </summary>
        [DataMember(Name="file_size_sum", EmitDefaultValue=false)]
        public int FileSizeSum { get; private set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public decimal Cost { get; private set; }

        /// <summary>
        /// Gets or Sets OnPrimaryContainer
        /// </summary>
        [DataMember(Name="on_primary_container", EmitDefaultValue=false)]
        public ByPrimaryTypeFacet OnPrimaryContainer { get; set; }

        /// <summary>
        /// Gets or Sets OnPrimaryNas
        /// </summary>
        [DataMember(Name="on_primary_nas", EmitDefaultValue=false)]
        public ByPrimaryTypeFacet OnPrimaryNas { get; set; }

        /// <summary>
        /// Gets or Sets OnPrimaryPublicCloud
        /// </summary>
        [DataMember(Name="on_primary_public_cloud", EmitDefaultValue=false)]
        public ByPrimaryTypeFacet OnPrimaryPublicCloud { get; set; }

        /// <summary>
        /// Gets or Sets OnPrimaryObjectCloud
        /// </summary>
        [DataMember(Name="on_primary_object_cloud", EmitDefaultValue=false)]
        public ByPrimaryTypeFacet OnPrimaryObjectCloud { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ByPrimaryStorageFacet {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  FilesCount: ").Append(FilesCount).Append("\n");
            sb.Append("  FileSizeSum: ").Append(FileSizeSum).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  OnPrimaryContainer: ").Append(OnPrimaryContainer).Append("\n");
            sb.Append("  OnPrimaryNas: ").Append(OnPrimaryNas).Append("\n");
            sb.Append("  OnPrimaryPublicCloud: ").Append(OnPrimaryPublicCloud).Append("\n");
            sb.Append("  OnPrimaryObjectCloud: ").Append(OnPrimaryObjectCloud).Append("\n");
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
            return this.Equals(input as ByPrimaryStorageFacet);
        }

        /// <summary>
        /// Returns true if ByPrimaryStorageFacet instances are equal
        /// </summary>
        /// <param name="input">Instance of ByPrimaryStorageFacet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ByPrimaryStorageFacet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.FilesCount == input.FilesCount ||
                    this.FilesCount.Equals(input.FilesCount)
                ) && 
                (
                    this.FileSizeSum == input.FileSizeSum ||
                    this.FileSizeSum.Equals(input.FileSizeSum)
                ) && 
                (
                    this.Cost == input.Cost ||
                    this.Cost.Equals(input.Cost)
                ) && 
                (
                    this.OnPrimaryContainer == input.OnPrimaryContainer ||
                    (this.OnPrimaryContainer != null &&
                    this.OnPrimaryContainer.Equals(input.OnPrimaryContainer))
                ) && 
                (
                    this.OnPrimaryNas == input.OnPrimaryNas ||
                    (this.OnPrimaryNas != null &&
                    this.OnPrimaryNas.Equals(input.OnPrimaryNas))
                ) && 
                (
                    this.OnPrimaryPublicCloud == input.OnPrimaryPublicCloud ||
                    (this.OnPrimaryPublicCloud != null &&
                    this.OnPrimaryPublicCloud.Equals(input.OnPrimaryPublicCloud))
                ) && 
                (
                    this.OnPrimaryObjectCloud == input.OnPrimaryObjectCloud ||
                    (this.OnPrimaryObjectCloud != null &&
                    this.OnPrimaryObjectCloud.Equals(input.OnPrimaryObjectCloud))
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
                hashCode = hashCode * 59 + this.FilesCount.GetHashCode();
                hashCode = hashCode * 59 + this.FileSizeSum.GetHashCode();
                hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.OnPrimaryContainer != null)
                    hashCode = hashCode * 59 + this.OnPrimaryContainer.GetHashCode();
                if (this.OnPrimaryNas != null)
                    hashCode = hashCode * 59 + this.OnPrimaryNas.GetHashCode();
                if (this.OnPrimaryPublicCloud != null)
                    hashCode = hashCode * 59 + this.OnPrimaryPublicCloud.GetHashCode();
                if (this.OnPrimaryObjectCloud != null)
                    hashCode = hashCode * 59 + this.OnPrimaryObjectCloud.GetHashCode();
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
