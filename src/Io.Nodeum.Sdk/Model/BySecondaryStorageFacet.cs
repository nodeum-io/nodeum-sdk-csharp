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
    /// BySecondaryStorageFacet
    /// </summary>
    [DataContract]
    public partial class BySecondaryStorageFacet :  IEquatable<BySecondaryStorageFacet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BySecondaryStorageFacet" /> class.
        /// </summary>
        /// <param name="onSecondaryNas">onSecondaryNas.</param>
        /// <param name="onSecondaryPublicCloud">onSecondaryPublicCloud.</param>
        /// <param name="onSecondaryObjectCloud">onSecondaryObjectCloud.</param>
        /// <param name="onSecondaryTape">onSecondaryTape.</param>
        /// <param name="onAnySecondary">onAnySecondary.</param>
        /// <param name="onNoSecondary">onNoSecondary.</param>
        public BySecondaryStorageFacet(BySecondaryTypeFacet onSecondaryNas = default(BySecondaryTypeFacet), BySecondaryTypeFacet onSecondaryPublicCloud = default(BySecondaryTypeFacet), BySecondaryTypeFacet onSecondaryObjectCloud = default(BySecondaryTypeFacet), BySecondaryTypeFacet onSecondaryTape = default(BySecondaryTypeFacet), BySecondaryTypeFacet onAnySecondary = default(BySecondaryTypeFacet), BySecondaryTypeFacet onNoSecondary = default(BySecondaryTypeFacet))
        {
            this.OnSecondaryNas = onSecondaryNas;
            this.OnSecondaryPublicCloud = onSecondaryPublicCloud;
            this.OnSecondaryObjectCloud = onSecondaryObjectCloud;
            this.OnSecondaryTape = onSecondaryTape;
            this.OnAnySecondary = onAnySecondary;
            this.OnNoSecondary = onNoSecondary;
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
        /// Gets or Sets OnSecondaryNas
        /// </summary>
        [DataMember(Name="on_secondary_nas", EmitDefaultValue=false)]
        public BySecondaryTypeFacet OnSecondaryNas { get; set; }

        /// <summary>
        /// Gets or Sets OnSecondaryPublicCloud
        /// </summary>
        [DataMember(Name="on_secondary_public_cloud", EmitDefaultValue=false)]
        public BySecondaryTypeFacet OnSecondaryPublicCloud { get; set; }

        /// <summary>
        /// Gets or Sets OnSecondaryObjectCloud
        /// </summary>
        [DataMember(Name="on_secondary_object_cloud", EmitDefaultValue=false)]
        public BySecondaryTypeFacet OnSecondaryObjectCloud { get; set; }

        /// <summary>
        /// Gets or Sets OnSecondaryTape
        /// </summary>
        [DataMember(Name="on_secondary_tape", EmitDefaultValue=false)]
        public BySecondaryTypeFacet OnSecondaryTape { get; set; }

        /// <summary>
        /// Gets or Sets OnAnySecondary
        /// </summary>
        [DataMember(Name="on_any_secondary", EmitDefaultValue=false)]
        public BySecondaryTypeFacet OnAnySecondary { get; set; }

        /// <summary>
        /// Gets or Sets OnNoSecondary
        /// </summary>
        [DataMember(Name="on_no_secondary", EmitDefaultValue=false)]
        public BySecondaryTypeFacet OnNoSecondary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BySecondaryStorageFacet {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  FilesCount: ").Append(FilesCount).Append("\n");
            sb.Append("  FileSizeSum: ").Append(FileSizeSum).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  OnSecondaryNas: ").Append(OnSecondaryNas).Append("\n");
            sb.Append("  OnSecondaryPublicCloud: ").Append(OnSecondaryPublicCloud).Append("\n");
            sb.Append("  OnSecondaryObjectCloud: ").Append(OnSecondaryObjectCloud).Append("\n");
            sb.Append("  OnSecondaryTape: ").Append(OnSecondaryTape).Append("\n");
            sb.Append("  OnAnySecondary: ").Append(OnAnySecondary).Append("\n");
            sb.Append("  OnNoSecondary: ").Append(OnNoSecondary).Append("\n");
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
            return this.Equals(input as BySecondaryStorageFacet);
        }

        /// <summary>
        /// Returns true if BySecondaryStorageFacet instances are equal
        /// </summary>
        /// <param name="input">Instance of BySecondaryStorageFacet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BySecondaryStorageFacet input)
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
                    this.OnSecondaryNas == input.OnSecondaryNas ||
                    (this.OnSecondaryNas != null &&
                    this.OnSecondaryNas.Equals(input.OnSecondaryNas))
                ) && 
                (
                    this.OnSecondaryPublicCloud == input.OnSecondaryPublicCloud ||
                    (this.OnSecondaryPublicCloud != null &&
                    this.OnSecondaryPublicCloud.Equals(input.OnSecondaryPublicCloud))
                ) && 
                (
                    this.OnSecondaryObjectCloud == input.OnSecondaryObjectCloud ||
                    (this.OnSecondaryObjectCloud != null &&
                    this.OnSecondaryObjectCloud.Equals(input.OnSecondaryObjectCloud))
                ) && 
                (
                    this.OnSecondaryTape == input.OnSecondaryTape ||
                    (this.OnSecondaryTape != null &&
                    this.OnSecondaryTape.Equals(input.OnSecondaryTape))
                ) && 
                (
                    this.OnAnySecondary == input.OnAnySecondary ||
                    (this.OnAnySecondary != null &&
                    this.OnAnySecondary.Equals(input.OnAnySecondary))
                ) && 
                (
                    this.OnNoSecondary == input.OnNoSecondary ||
                    (this.OnNoSecondary != null &&
                    this.OnNoSecondary.Equals(input.OnNoSecondary))
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
                if (this.OnSecondaryNas != null)
                    hashCode = hashCode * 59 + this.OnSecondaryNas.GetHashCode();
                if (this.OnSecondaryPublicCloud != null)
                    hashCode = hashCode * 59 + this.OnSecondaryPublicCloud.GetHashCode();
                if (this.OnSecondaryObjectCloud != null)
                    hashCode = hashCode * 59 + this.OnSecondaryObjectCloud.GetHashCode();
                if (this.OnSecondaryTape != null)
                    hashCode = hashCode * 59 + this.OnSecondaryTape.GetHashCode();
                if (this.OnAnySecondary != null)
                    hashCode = hashCode * 59 + this.OnAnySecondary.GetHashCode();
                if (this.OnNoSecondary != null)
                    hashCode = hashCode * 59 + this.OnNoSecondary.GetHashCode();
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
