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
    /// Tape
    /// </summary>
    [DataContract]
    public partial class Tape :  IEquatable<Tape>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Data for value: data
            /// </summary>
            [EnumMember(Value = "data")]
            Data = 2,

            /// <summary>
            /// Enum Cleaning for value: cleaning
            /// </summary>
            [EnumMember(Value = "cleaning")]
            Cleaning = 3,

            /// <summary>
            /// Enum Diagnostic for value: diagnostic
            /// </summary>
            [EnumMember(Value = "diagnostic")]
            Diagnostic = 4,

            /// <summary>
            /// Enum Datalto1 for value: data_lto1
            /// </summary>
            [EnumMember(Value = "data_lto1")]
            Datalto1 = 5,

            /// <summary>
            /// Enum Datalto2 for value: data_lto2
            /// </summary>
            [EnumMember(Value = "data_lto2")]
            Datalto2 = 6,

            /// <summary>
            /// Enum Datalto3 for value: data_lto3
            /// </summary>
            [EnumMember(Value = "data_lto3")]
            Datalto3 = 7,

            /// <summary>
            /// Enum Datalto4 for value: data_lto4
            /// </summary>
            [EnumMember(Value = "data_lto4")]
            Datalto4 = 8,

            /// <summary>
            /// Enum Datalto5 for value: data_lto5
            /// </summary>
            [EnumMember(Value = "data_lto5")]
            Datalto5 = 9,

            /// <summary>
            /// Enum Datalto6 for value: data_lto6
            /// </summary>
            [EnumMember(Value = "data_lto6")]
            Datalto6 = 10,

            /// <summary>
            /// Enum Datalto7 for value: data_lto7
            /// </summary>
            [EnumMember(Value = "data_lto7")]
            Datalto7 = 11,

            /// <summary>
            /// Enum Datalto8 for value: data_lto8
            /// </summary>
            [EnumMember(Value = "data_lto8")]
            Datalto8 = 12,

            /// <summary>
            /// Enum Datalto9 for value: data_lto9
            /// </summary>
            [EnumMember(Value = "data_lto9")]
            Datalto9 = 13,

            /// <summary>
            /// Enum Datalto10 for value: data_lto10
            /// </summary>
            [EnumMember(Value = "data_lto10")]
            Datalto10 = 14,

            /// <summary>
            /// Enum Datalto11 for value: data_lto11
            /// </summary>
            [EnumMember(Value = "data_lto11")]
            Datalto11 = 15,

            /// <summary>
            /// Enum Datalto12 for value: data_lto12
            /// </summary>
            [EnumMember(Value = "data_lto12")]
            Datalto12 = 16

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tape" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Tape()
        {
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; private set; }

        /// <summary>
        /// Gets or Sets TapeLibraryId
        /// </summary>
        [DataMember(Name="tape_library_id", EmitDefaultValue=false)]
        public int TapeLibraryId { get; private set; }

        /// <summary>
        /// Gets or Sets PoolId
        /// </summary>
        [DataMember(Name="pool_id", EmitDefaultValue=false)]
        public int PoolId { get; private set; }

        /// <summary>
        /// Gets or Sets Barcode
        /// </summary>
        [DataMember(Name="barcode", EmitDefaultValue=false)]
        public string Barcode { get; private set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool Locked { get; private set; }

        /// <summary>
        /// Gets or Sets Scratch
        /// </summary>
        [DataMember(Name="scratch", EmitDefaultValue=false)]
        public bool Scratch { get; private set; }

        /// <summary>
        /// Gets or Sets Cleaning
        /// </summary>
        [DataMember(Name="cleaning", EmitDefaultValue=false)]
        public bool Cleaning { get; private set; }

        /// <summary>
        /// Gets or Sets WriteProtect
        /// </summary>
        [DataMember(Name="write_protect", EmitDefaultValue=false)]
        public bool WriteProtect { get; private set; }

        /// <summary>
        /// Gets or Sets Mounted
        /// </summary>
        [DataMember(Name="mounted", EmitDefaultValue=false)]
        public bool Mounted { get; private set; }

        /// <summary>
        /// Gets or Sets Ejected
        /// </summary>
        [DataMember(Name="ejected", EmitDefaultValue=false)]
        public bool Ejected { get; private set; }

        /// <summary>
        /// Gets or Sets Known
        /// </summary>
        [DataMember(Name="known", EmitDefaultValue=false)]
        public bool Known { get; private set; }

        /// <summary>
        /// Gets or Sets MountCount
        /// </summary>
        [DataMember(Name="mount_count", EmitDefaultValue=false)]
        public int MountCount { get; private set; }

        /// <summary>
        /// Gets or Sets DateIn
        /// </summary>
        [DataMember(Name="date_in", EmitDefaultValue=false)]
        public string DateIn { get; private set; }

        /// <summary>
        /// Gets or Sets DateMove
        /// </summary>
        [DataMember(Name="date_move", EmitDefaultValue=false)]
        public string DateMove { get; private set; }

        /// <summary>
        /// Gets or Sets Free
        /// </summary>
        [DataMember(Name="free", EmitDefaultValue=false)]
        public int Free { get; private set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public int Max { get; private set; }

        /// <summary>
        /// Gets or Sets LastSizeUpdate
        /// </summary>
        [DataMember(Name="last_size_update", EmitDefaultValue=false)]
        public string LastSizeUpdate { get; private set; }

        /// <summary>
        /// Gets or Sets LastMaintenance
        /// </summary>
        [DataMember(Name="last_maintenance", EmitDefaultValue=false)]
        public string LastMaintenance { get; private set; }

        /// <summary>
        /// Gets or Sets LastRepack
        /// </summary>
        [DataMember(Name="last_repack", EmitDefaultValue=false)]
        public string LastRepack { get; private set; }

        /// <summary>
        /// Gets or Sets RepackStatus
        /// </summary>
        [DataMember(Name="repack_status", EmitDefaultValue=false)]
        public bool RepackStatus { get; private set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; private set; }

        /// <summary>
        /// Gets or Sets ForceImportType
        /// </summary>
        [DataMember(Name="force_import_type", EmitDefaultValue=false)]
        public bool ForceImportType { get; private set; }

        /// <summary>
        /// Gets or Sets NeedToCheck
        /// </summary>
        [DataMember(Name="need_to_check", EmitDefaultValue=false)]
        public bool NeedToCheck { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tape {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TapeLibraryId: ").Append(TapeLibraryId).Append("\n");
            sb.Append("  PoolId: ").Append(PoolId).Append("\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Scratch: ").Append(Scratch).Append("\n");
            sb.Append("  Cleaning: ").Append(Cleaning).Append("\n");
            sb.Append("  WriteProtect: ").Append(WriteProtect).Append("\n");
            sb.Append("  Mounted: ").Append(Mounted).Append("\n");
            sb.Append("  Ejected: ").Append(Ejected).Append("\n");
            sb.Append("  Known: ").Append(Known).Append("\n");
            sb.Append("  MountCount: ").Append(MountCount).Append("\n");
            sb.Append("  DateIn: ").Append(DateIn).Append("\n");
            sb.Append("  DateMove: ").Append(DateMove).Append("\n");
            sb.Append("  Free: ").Append(Free).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  LastSizeUpdate: ").Append(LastSizeUpdate).Append("\n");
            sb.Append("  LastMaintenance: ").Append(LastMaintenance).Append("\n");
            sb.Append("  LastRepack: ").Append(LastRepack).Append("\n");
            sb.Append("  RepackStatus: ").Append(RepackStatus).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  ForceImportType: ").Append(ForceImportType).Append("\n");
            sb.Append("  NeedToCheck: ").Append(NeedToCheck).Append("\n");
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
            return this.Equals(input as Tape);
        }

        /// <summary>
        /// Returns true if Tape instances are equal
        /// </summary>
        /// <param name="input">Instance of Tape to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tape input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.TapeLibraryId == input.TapeLibraryId ||
                    this.TapeLibraryId.Equals(input.TapeLibraryId)
                ) && 
                (
                    this.PoolId == input.PoolId ||
                    this.PoolId.Equals(input.PoolId)
                ) && 
                (
                    this.Barcode == input.Barcode ||
                    (this.Barcode != null &&
                    this.Barcode.Equals(input.Barcode))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Locked == input.Locked ||
                    this.Locked.Equals(input.Locked)
                ) && 
                (
                    this.Scratch == input.Scratch ||
                    this.Scratch.Equals(input.Scratch)
                ) && 
                (
                    this.Cleaning == input.Cleaning ||
                    this.Cleaning.Equals(input.Cleaning)
                ) && 
                (
                    this.WriteProtect == input.WriteProtect ||
                    this.WriteProtect.Equals(input.WriteProtect)
                ) && 
                (
                    this.Mounted == input.Mounted ||
                    this.Mounted.Equals(input.Mounted)
                ) && 
                (
                    this.Ejected == input.Ejected ||
                    this.Ejected.Equals(input.Ejected)
                ) && 
                (
                    this.Known == input.Known ||
                    this.Known.Equals(input.Known)
                ) && 
                (
                    this.MountCount == input.MountCount ||
                    this.MountCount.Equals(input.MountCount)
                ) && 
                (
                    this.DateIn == input.DateIn ||
                    (this.DateIn != null &&
                    this.DateIn.Equals(input.DateIn))
                ) && 
                (
                    this.DateMove == input.DateMove ||
                    (this.DateMove != null &&
                    this.DateMove.Equals(input.DateMove))
                ) && 
                (
                    this.Free == input.Free ||
                    this.Free.Equals(input.Free)
                ) && 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
                ) && 
                (
                    this.LastSizeUpdate == input.LastSizeUpdate ||
                    (this.LastSizeUpdate != null &&
                    this.LastSizeUpdate.Equals(input.LastSizeUpdate))
                ) && 
                (
                    this.LastMaintenance == input.LastMaintenance ||
                    (this.LastMaintenance != null &&
                    this.LastMaintenance.Equals(input.LastMaintenance))
                ) && 
                (
                    this.LastRepack == input.LastRepack ||
                    (this.LastRepack != null &&
                    this.LastRepack.Equals(input.LastRepack))
                ) && 
                (
                    this.RepackStatus == input.RepackStatus ||
                    this.RepackStatus.Equals(input.RepackStatus)
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.ForceImportType == input.ForceImportType ||
                    this.ForceImportType.Equals(input.ForceImportType)
                ) && 
                (
                    this.NeedToCheck == input.NeedToCheck ||
                    this.NeedToCheck.Equals(input.NeedToCheck)
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
                hashCode = hashCode * 59 + this.TapeLibraryId.GetHashCode();
                hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Barcode != null)
                    hashCode = hashCode * 59 + this.Barcode.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Locked.GetHashCode();
                hashCode = hashCode * 59 + this.Scratch.GetHashCode();
                hashCode = hashCode * 59 + this.Cleaning.GetHashCode();
                hashCode = hashCode * 59 + this.WriteProtect.GetHashCode();
                hashCode = hashCode * 59 + this.Mounted.GetHashCode();
                hashCode = hashCode * 59 + this.Ejected.GetHashCode();
                hashCode = hashCode * 59 + this.Known.GetHashCode();
                hashCode = hashCode * 59 + this.MountCount.GetHashCode();
                if (this.DateIn != null)
                    hashCode = hashCode * 59 + this.DateIn.GetHashCode();
                if (this.DateMove != null)
                    hashCode = hashCode * 59 + this.DateMove.GetHashCode();
                hashCode = hashCode * 59 + this.Free.GetHashCode();
                hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.LastSizeUpdate != null)
                    hashCode = hashCode * 59 + this.LastSizeUpdate.GetHashCode();
                if (this.LastMaintenance != null)
                    hashCode = hashCode * 59 + this.LastMaintenance.GetHashCode();
                if (this.LastRepack != null)
                    hashCode = hashCode * 59 + this.LastRepack.GetHashCode();
                hashCode = hashCode * 59 + this.RepackStatus.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                hashCode = hashCode * 59 + this.ForceImportType.GetHashCode();
                hashCode = hashCode * 59 + this.NeedToCheck.GetHashCode();
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