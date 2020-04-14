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
    /// Task
    /// </summary>
    [DataContract]
    public partial class Task :  IEquatable<Task>, IValidatableObject
    {
        /// <summary>
        /// Defines WorkflowType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WorkflowTypeEnum
        {
            /// <summary>
            /// Enum Activearchive for value: active_archive
            /// </summary>
            [EnumMember(Value = "active_archive")]
            Activearchive = 1,

            /// <summary>
            /// Enum Offlinearchive for value: offline_archive
            /// </summary>
            [EnumMember(Value = "offline_archive")]
            Offlinearchive = 2,

            /// <summary>
            /// Enum Dataexchange for value: data_exchange
            /// </summary>
            [EnumMember(Value = "data_exchange")]
            Dataexchange = 3,

            /// <summary>
            /// Enum Datamigration for value: data_migration
            /// </summary>
            [EnumMember(Value = "data_migration")]
            Datamigration = 4,

            /// <summary>
            /// Enum Maintenance for value: maintenance
            /// </summary>
            [EnumMember(Value = "maintenance")]
            Maintenance = 5,

            /// <summary>
            /// Enum Dataenrichment for value: data_enrichment
            /// </summary>
            [EnumMember(Value = "data_enrichment")]
            Dataenrichment = 6

        }

        /// <summary>
        /// Gets or Sets WorkflowType
        /// </summary>
        [DataMember(Name="workflow_type", EmitDefaultValue=false)]
        public WorkflowTypeEnum? WorkflowType { get; set; }
        /// <summary>
        /// Defines WorkflowAction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WorkflowActionEnum
        {
            /// <summary>
            /// Enum Copy for value: copy
            /// </summary>
            [EnumMember(Value = "copy")]
            Copy = 1,

            /// <summary>
            /// Enum Move for value: move
            /// </summary>
            [EnumMember(Value = "move")]
            Move = 2,

            /// <summary>
            /// Enum Scan for value: scan
            /// </summary>
            [EnumMember(Value = "scan")]
            Scan = 3,

            /// <summary>
            /// Enum Rehydratation for value: rehydratation
            /// </summary>
            [EnumMember(Value = "rehydratation")]
            Rehydratation = 4,

            /// <summary>
            /// Enum Format for value: format
            /// </summary>
            [EnumMember(Value = "format")]
            Format = 5,

            /// <summary>
            /// Enum Checkconsistency for value: check_consistency
            /// </summary>
            [EnumMember(Value = "check_consistency")]
            Checkconsistency = 6,

            /// <summary>
            /// Enum Duplication for value: duplication
            /// </summary>
            [EnumMember(Value = "duplication")]
            Duplication = 7,

            /// <summary>
            /// Enum Cachecleaning for value: cache_cleaning
            /// </summary>
            [EnumMember(Value = "cache_cleaning")]
            Cachecleaning = 8,

            /// <summary>
            /// Enum Ejection for value: ejection
            /// </summary>
            [EnumMember(Value = "ejection")]
            Ejection = 9,

            /// <summary>
            /// Enum Getindex for value: get_index
            /// </summary>
            [EnumMember(Value = "get_index")]
            Getindex = 10,

            /// <summary>
            /// Enum Fullbackup for value: full_backup
            /// </summary>
            [EnumMember(Value = "full_backup")]
            Fullbackup = 11,

            /// <summary>
            /// Enum Incrementalbackup for value: incremental_backup
            /// </summary>
            [EnumMember(Value = "incremental_backup")]
            Incrementalbackup = 12

        }

        /// <summary>
        /// Gets or Sets WorkflowAction
        /// </summary>
        [DataMember(Name="workflow_action", EmitDefaultValue=false)]
        public WorkflowActionEnum? WorkflowAction { get; set; }
        /// <summary>
        /// Defines SourceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceTypeEnum
        {
            /// <summary>
            /// Enum Container for value: container
            /// </summary>
            [EnumMember(Value = "container")]
            Container = 1,

            /// <summary>
            /// Enum Primarynas for value: primary_nas
            /// </summary>
            [EnumMember(Value = "primary_nas")]
            Primarynas = 2,

            /// <summary>
            /// Enum Secondarynas for value: secondary_nas
            /// </summary>
            [EnumMember(Value = "secondary_nas")]
            Secondarynas = 3,

            /// <summary>
            /// Enum Primarycloud for value: primary_cloud
            /// </summary>
            [EnumMember(Value = "primary_cloud")]
            Primarycloud = 4,

            /// <summary>
            /// Enum Secondarycloud for value: secondary_cloud
            /// </summary>
            [EnumMember(Value = "secondary_cloud")]
            Secondarycloud = 5,

            /// <summary>
            /// Enum Secondarytape for value: secondary_tape
            /// </summary>
            [EnumMember(Value = "secondary_tape")]
            Secondarytape = 6

        }

        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name="source_type", EmitDefaultValue=false)]
        public SourceTypeEnum? SourceType { get; set; }
        /// <summary>
        /// Defines DestinationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DestinationTypeEnum
        {
            /// <summary>
            /// Enum Container for value: container
            /// </summary>
            [EnumMember(Value = "container")]
            Container = 1,

            /// <summary>
            /// Enum Primarynas for value: primary_nas
            /// </summary>
            [EnumMember(Value = "primary_nas")]
            Primarynas = 2,

            /// <summary>
            /// Enum Secondarynas for value: secondary_nas
            /// </summary>
            [EnumMember(Value = "secondary_nas")]
            Secondarynas = 3,

            /// <summary>
            /// Enum Primarycloud for value: primary_cloud
            /// </summary>
            [EnumMember(Value = "primary_cloud")]
            Primarycloud = 4,

            /// <summary>
            /// Enum Secondarycloud for value: secondary_cloud
            /// </summary>
            [EnumMember(Value = "secondary_cloud")]
            Secondarycloud = 5,

            /// <summary>
            /// Enum Secondarytape for value: secondary_tape
            /// </summary>
            [EnumMember(Value = "secondary_tape")]
            Secondarytape = 6

        }

        /// <summary>
        /// Gets or Sets DestinationType
        /// </summary>
        [DataMember(Name="destination_type", EmitDefaultValue=false)]
        public DestinationTypeEnum? DestinationType { get; set; }
        /// <summary>
        /// Defines ConflictResolution
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConflictResolutionEnum
        {
            /// <summary>
            /// Enum Rename for value: rename
            /// </summary>
            [EnumMember(Value = "rename")]
            Rename = 1,

            /// <summary>
            /// Enum Overwrite for value: overwrite
            /// </summary>
            [EnumMember(Value = "overwrite")]
            Overwrite = 2,

            /// <summary>
            /// Enum Ignore for value: ignore
            /// </summary>
            [EnumMember(Value = "ignore")]
            Ignore = 3

        }

        /// <summary>
        /// Gets or Sets ConflictResolution
        /// </summary>
        [DataMember(Name="conflict_resolution", EmitDefaultValue=false)]
        public ConflictResolutionEnum? ConflictResolution { get; set; }
        /// <summary>
        /// Defines Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Noop for value: noop
            /// </summary>
            [EnumMember(Value = "noop")]
            Noop = 1,

            /// <summary>
            /// Enum Run for value: run
            /// </summary>
            [EnumMember(Value = "run")]
            Run = 2,

            /// <summary>
            /// Enum Pause for value: pause
            /// </summary>
            [EnumMember(Value = "pause")]
            Pause = 3,

            /// <summary>
            /// Enum Stop for value: stop
            /// </summary>
            [EnumMember(Value = "stop")]
            Stop = 4,

            /// <summary>
            /// Enum Resume for value: resume
            /// </summary>
            [EnumMember(Value = "resume")]
            Resume = 5

        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Notactivated for value: not_activated
            /// </summary>
            [EnumMember(Value = "not_activated")]
            Notactivated = 1,

            /// <summary>
            /// Enum Done for value: done
            /// </summary>
            [EnumMember(Value = "done")]
            Done = 2,

            /// <summary>
            /// Enum Inprogress for value: in_progress
            /// </summary>
            [EnumMember(Value = "in_progress")]
            Inprogress = 3,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 4,

            /// <summary>
            /// Enum Paused for value: paused
            /// </summary>
            [EnumMember(Value = "paused")]
            Paused = 5,

            /// <summary>
            /// Enum Stoppedbysystem for value: stopped_by_system
            /// </summary>
            [EnumMember(Value = "stopped_by_system")]
            Stoppedbysystem = 6,

            /// <summary>
            /// Enum Inqueue for value: in_queue
            /// </summary>
            [EnumMember(Value = "in_queue")]
            Inqueue = 7,

            /// <summary>
            /// Enum Finishedwithwarnings for value: finished_with_warnings
            /// </summary>
            [EnumMember(Value = "finished_with_warnings")]
            Finishedwithwarnings = 8,

            /// <summary>
            /// Enum Calculating for value: calculating
            /// </summary>
            [EnumMember(Value = "calculating")]
            Calculating = 9,

            /// <summary>
            /// Enum Stoppedbyuser for value: stopped_by_user
            /// </summary>
            [EnumMember(Value = "stopped_by_user")]
            Stoppedbyuser = 10

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="comment">comment.</param>
        /// <param name="workflowType">workflowType.</param>
        /// <param name="workflowAction">workflowAction.</param>
        /// <param name="sourceType">sourceType.</param>
        /// <param name="destinationType">destinationType.</param>
        /// <param name="priority">priority.</param>
        /// <param name="conflictResolution">conflictResolution.</param>
        /// <param name="activate">activate.</param>
        public Task(string name = default(string), string comment = default(string), WorkflowTypeEnum? workflowType = default(WorkflowTypeEnum?), WorkflowActionEnum? workflowAction = default(WorkflowActionEnum?), SourceTypeEnum? sourceType = default(SourceTypeEnum?), DestinationTypeEnum? destinationType = default(DestinationTypeEnum?), int priority = default(int), ConflictResolutionEnum? conflictResolution = default(ConflictResolutionEnum?), bool activate = default(bool))
        {
            this.Name = name;
            this.Comment = comment;
            this.WorkflowType = workflowType;
            this.WorkflowAction = workflowAction;
            this.SourceType = sourceType;
            this.DestinationType = destinationType;
            this.Priority = priority;
            this.ConflictResolution = conflictResolution;
            this.Activate = activate;
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
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or Sets Activate
        /// </summary>
        [DataMember(Name="activate", EmitDefaultValue=false)]
        public bool Activate { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creation_date", EmitDefaultValue=false)]
        public string CreationDate { get; private set; }

        /// <summary>
        /// Gets or Sets ModificationDate
        /// </summary>
        [DataMember(Name="modification_date", EmitDefaultValue=false)]
        public string ModificationDate { get; private set; }

        /// <summary>
        /// Gets or Sets CreationUsername
        /// </summary>
        [DataMember(Name="creation_username", EmitDefaultValue=false)]
        public string CreationUsername { get; private set; }

        /// <summary>
        /// Gets or Sets ModificationUsername
        /// </summary>
        [DataMember(Name="modification_username", EmitDefaultValue=false)]
        public string ModificationUsername { get; private set; }

        /// <summary>
        /// Gets or Sets JobStarted
        /// </summary>
        [DataMember(Name="job_started", EmitDefaultValue=false)]
        public string JobStarted { get; private set; }

        /// <summary>
        /// Gets or Sets JobFinished
        /// </summary>
        [DataMember(Name="job_finished", EmitDefaultValue=false)]
        public string JobFinished { get; private set; }

        /// <summary>
        /// Gets or Sets ProcessedSize
        /// </summary>
        [DataMember(Name="processed_size", EmitDefaultValue=false)]
        public int ProcessedSize { get; private set; }

        /// <summary>
        /// Gets or Sets ToProcessSize
        /// </summary>
        [DataMember(Name="to_process_size", EmitDefaultValue=false)]
        public int ToProcessSize { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  WorkflowType: ").Append(WorkflowType).Append("\n");
            sb.Append("  WorkflowAction: ").Append(WorkflowAction).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  DestinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ConflictResolution: ").Append(ConflictResolution).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Activate: ").Append(Activate).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  ModificationDate: ").Append(ModificationDate).Append("\n");
            sb.Append("  CreationUsername: ").Append(CreationUsername).Append("\n");
            sb.Append("  ModificationUsername: ").Append(ModificationUsername).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  JobStarted: ").Append(JobStarted).Append("\n");
            sb.Append("  JobFinished: ").Append(JobFinished).Append("\n");
            sb.Append("  ProcessedSize: ").Append(ProcessedSize).Append("\n");
            sb.Append("  ToProcessSize: ").Append(ToProcessSize).Append("\n");
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
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="input">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task input)
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
                    this.WorkflowType == input.WorkflowType ||
                    this.WorkflowType.Equals(input.WorkflowType)
                ) && 
                (
                    this.WorkflowAction == input.WorkflowAction ||
                    this.WorkflowAction.Equals(input.WorkflowAction)
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    this.SourceType.Equals(input.SourceType)
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    this.DestinationType.Equals(input.DestinationType)
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.ConflictResolution == input.ConflictResolution ||
                    this.ConflictResolution.Equals(input.ConflictResolution)
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Activate == input.Activate ||
                    this.Activate.Equals(input.Activate)
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.ModificationDate == input.ModificationDate ||
                    (this.ModificationDate != null &&
                    this.ModificationDate.Equals(input.ModificationDate))
                ) && 
                (
                    this.CreationUsername == input.CreationUsername ||
                    (this.CreationUsername != null &&
                    this.CreationUsername.Equals(input.CreationUsername))
                ) && 
                (
                    this.ModificationUsername == input.ModificationUsername ||
                    (this.ModificationUsername != null &&
                    this.ModificationUsername.Equals(input.ModificationUsername))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.JobStarted == input.JobStarted ||
                    (this.JobStarted != null &&
                    this.JobStarted.Equals(input.JobStarted))
                ) && 
                (
                    this.JobFinished == input.JobFinished ||
                    (this.JobFinished != null &&
                    this.JobFinished.Equals(input.JobFinished))
                ) && 
                (
                    this.ProcessedSize == input.ProcessedSize ||
                    this.ProcessedSize.Equals(input.ProcessedSize)
                ) && 
                (
                    this.ToProcessSize == input.ToProcessSize ||
                    this.ToProcessSize.Equals(input.ToProcessSize)
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
                hashCode = hashCode * 59 + this.WorkflowType.GetHashCode();
                hashCode = hashCode * 59 + this.WorkflowAction.GetHashCode();
                hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                hashCode = hashCode * 59 + this.ConflictResolution.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.Activate.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.ModificationDate != null)
                    hashCode = hashCode * 59 + this.ModificationDate.GetHashCode();
                if (this.CreationUsername != null)
                    hashCode = hashCode * 59 + this.CreationUsername.GetHashCode();
                if (this.ModificationUsername != null)
                    hashCode = hashCode * 59 + this.ModificationUsername.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.JobStarted != null)
                    hashCode = hashCode * 59 + this.JobStarted.GetHashCode();
                if (this.JobFinished != null)
                    hashCode = hashCode * 59 + this.JobFinished.GetHashCode();
                hashCode = hashCode * 59 + this.ProcessedSize.GetHashCode();
                hashCode = hashCode * 59 + this.ToProcessSize.GetHashCode();
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