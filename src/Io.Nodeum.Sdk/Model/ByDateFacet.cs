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
    /// ByDateFacet
    /// </summary>
    [DataContract]
    public partial class ByDateFacet :  IEquatable<ByDateFacet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ByDateFacet" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="filesCount">filesCount.</param>
        /// <param name="fileSizeSum">fileSizeSum.</param>
        /// <param name="cost">cost.</param>
        /// <param name="inCache">inCache.</param>
        /// <param name="less1Week">less1Week.</param>
        /// <param name="less1Month">less1Month.</param>
        /// <param name="less3Months">less3Months.</param>
        /// <param name="less6Months">less6Months.</param>
        /// <param name="less1Year">less1Year.</param>
        /// <param name="less2Years">less2Years.</param>
        /// <param name="more2Years">more2Years.</param>
        public ByDateFacet(int count = default(int), int filesCount = default(int), int fileSizeSum = default(int), decimal cost = default(decimal), FileFacet inCache = default(FileFacet), FileFacet less1Week = default(FileFacet), FileFacet less1Month = default(FileFacet), FileFacet less3Months = default(FileFacet), FileFacet less6Months = default(FileFacet), FileFacet less1Year = default(FileFacet), FileFacet less2Years = default(FileFacet), FileFacet more2Years = default(FileFacet))
        {
            this.Count = count;
            this.FilesCount = filesCount;
            this.FileSizeSum = fileSizeSum;
            this.Cost = cost;
            this.InCache = inCache;
            this.Less1Week = less1Week;
            this.Less1Month = less1Month;
            this.Less3Months = less3Months;
            this.Less6Months = less6Months;
            this.Less1Year = less1Year;
            this.Less2Years = less2Years;
            this.More2Years = more2Years;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets FilesCount
        /// </summary>
        [DataMember(Name="files_count", EmitDefaultValue=false)]
        public int FilesCount { get; set; }

        /// <summary>
        /// Gets or Sets FileSizeSum
        /// </summary>
        [DataMember(Name="file_size_sum", EmitDefaultValue=false)]
        public int FileSizeSum { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or Sets InCache
        /// </summary>
        [DataMember(Name="in_cache", EmitDefaultValue=false)]
        public FileFacet InCache { get; set; }

        /// <summary>
        /// Gets or Sets Less1Week
        /// </summary>
        [DataMember(Name="less_1_week", EmitDefaultValue=false)]
        public FileFacet Less1Week { get; set; }

        /// <summary>
        /// Gets or Sets Less1Month
        /// </summary>
        [DataMember(Name="less_1_month", EmitDefaultValue=false)]
        public FileFacet Less1Month { get; set; }

        /// <summary>
        /// Gets or Sets Less3Months
        /// </summary>
        [DataMember(Name="less_3_months", EmitDefaultValue=false)]
        public FileFacet Less3Months { get; set; }

        /// <summary>
        /// Gets or Sets Less6Months
        /// </summary>
        [DataMember(Name="less_6_months", EmitDefaultValue=false)]
        public FileFacet Less6Months { get; set; }

        /// <summary>
        /// Gets or Sets Less1Year
        /// </summary>
        [DataMember(Name="less_1_year", EmitDefaultValue=false)]
        public FileFacet Less1Year { get; set; }

        /// <summary>
        /// Gets or Sets Less2Years
        /// </summary>
        [DataMember(Name="less_2_years", EmitDefaultValue=false)]
        public FileFacet Less2Years { get; set; }

        /// <summary>
        /// Gets or Sets More2Years
        /// </summary>
        [DataMember(Name="more_2_years", EmitDefaultValue=false)]
        public FileFacet More2Years { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ByDateFacet {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  FilesCount: ").Append(FilesCount).Append("\n");
            sb.Append("  FileSizeSum: ").Append(FileSizeSum).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  InCache: ").Append(InCache).Append("\n");
            sb.Append("  Less1Week: ").Append(Less1Week).Append("\n");
            sb.Append("  Less1Month: ").Append(Less1Month).Append("\n");
            sb.Append("  Less3Months: ").Append(Less3Months).Append("\n");
            sb.Append("  Less6Months: ").Append(Less6Months).Append("\n");
            sb.Append("  Less1Year: ").Append(Less1Year).Append("\n");
            sb.Append("  Less2Years: ").Append(Less2Years).Append("\n");
            sb.Append("  More2Years: ").Append(More2Years).Append("\n");
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
            return this.Equals(input as ByDateFacet);
        }

        /// <summary>
        /// Returns true if ByDateFacet instances are equal
        /// </summary>
        /// <param name="input">Instance of ByDateFacet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ByDateFacet input)
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
                    this.InCache == input.InCache ||
                    (this.InCache != null &&
                    this.InCache.Equals(input.InCache))
                ) && 
                (
                    this.Less1Week == input.Less1Week ||
                    (this.Less1Week != null &&
                    this.Less1Week.Equals(input.Less1Week))
                ) && 
                (
                    this.Less1Month == input.Less1Month ||
                    (this.Less1Month != null &&
                    this.Less1Month.Equals(input.Less1Month))
                ) && 
                (
                    this.Less3Months == input.Less3Months ||
                    (this.Less3Months != null &&
                    this.Less3Months.Equals(input.Less3Months))
                ) && 
                (
                    this.Less6Months == input.Less6Months ||
                    (this.Less6Months != null &&
                    this.Less6Months.Equals(input.Less6Months))
                ) && 
                (
                    this.Less1Year == input.Less1Year ||
                    (this.Less1Year != null &&
                    this.Less1Year.Equals(input.Less1Year))
                ) && 
                (
                    this.Less2Years == input.Less2Years ||
                    (this.Less2Years != null &&
                    this.Less2Years.Equals(input.Less2Years))
                ) && 
                (
                    this.More2Years == input.More2Years ||
                    (this.More2Years != null &&
                    this.More2Years.Equals(input.More2Years))
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
                if (this.InCache != null)
                    hashCode = hashCode * 59 + this.InCache.GetHashCode();
                if (this.Less1Week != null)
                    hashCode = hashCode * 59 + this.Less1Week.GetHashCode();
                if (this.Less1Month != null)
                    hashCode = hashCode * 59 + this.Less1Month.GetHashCode();
                if (this.Less3Months != null)
                    hashCode = hashCode * 59 + this.Less3Months.GetHashCode();
                if (this.Less6Months != null)
                    hashCode = hashCode * 59 + this.Less6Months.GetHashCode();
                if (this.Less1Year != null)
                    hashCode = hashCode * 59 + this.Less1Year.GetHashCode();
                if (this.Less2Years != null)
                    hashCode = hashCode * 59 + this.Less2Years.GetHashCode();
                if (this.More2Years != null)
                    hashCode = hashCode * 59 + this.More2Years.GetHashCode();
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
