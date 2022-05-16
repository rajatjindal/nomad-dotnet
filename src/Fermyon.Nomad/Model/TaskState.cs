/*
 * Nomad
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.1.4
 * Contact: support@hashicorp.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Fermyon.Nomad.Client.OpenAPIDateConverter;

namespace Fermyon.Nomad.Model
{
    /// <summary>
    /// TaskState
    /// </summary>
    [DataContract(Name = "TaskState")]
    public partial class TaskState : IEquatable<TaskState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskState" /> class.
        /// </summary>
        /// <param name="events">events.</param>
        /// <param name="failed">failed.</param>
        /// <param name="finishedAt">finishedAt.</param>
        /// <param name="lastRestart">lastRestart.</param>
        /// <param name="restarts">restarts.</param>
        /// <param name="startedAt">startedAt.</param>
        /// <param name="state">state.</param>
        /// <param name="taskHandle">taskHandle.</param>
        public TaskState(List<TaskEvent> events = default(List<TaskEvent>), bool failed = default(bool), DateTime? finishedAt = default(DateTime?), DateTime? lastRestart = default(DateTime?), int restarts = default(int), DateTime? startedAt = default(DateTime?), string state = default(string), TaskHandle taskHandle = default(TaskHandle))
        {
            this.Events = events;
            this.Failed = failed;
            this.FinishedAt = finishedAt;
            this.LastRestart = lastRestart;
            this.Restarts = restarts;
            this.StartedAt = startedAt;
            this.State = state;
            this.TaskHandle = taskHandle;
        }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "Events", EmitDefaultValue = false)]
        public List<TaskEvent> Events { get; set; }

        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name = "Failed", EmitDefaultValue = true)]
        public bool Failed { get; set; }

        /// <summary>
        /// Gets or Sets FinishedAt
        /// </summary>
        [DataMember(Name = "FinishedAt", EmitDefaultValue = false)]
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastRestart
        /// </summary>
        [DataMember(Name = "LastRestart", EmitDefaultValue = false)]
        public DateTime? LastRestart { get; set; }

        /// <summary>
        /// Gets or Sets Restarts
        /// </summary>
        [DataMember(Name = "Restarts", EmitDefaultValue = false)]
        public int Restarts { get; set; }

        /// <summary>
        /// Gets or Sets StartedAt
        /// </summary>
        [DataMember(Name = "StartedAt", EmitDefaultValue = false)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "State", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets TaskHandle
        /// </summary>
        [DataMember(Name = "TaskHandle", EmitDefaultValue = false)]
        public TaskHandle TaskHandle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskState {\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  LastRestart: ").Append(LastRestart).Append("\n");
            sb.Append("  Restarts: ").Append(Restarts).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TaskHandle: ").Append(TaskHandle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskState);
        }

        /// <summary>
        /// Returns true if TaskState instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Failed == input.Failed ||
                    this.Failed.Equals(input.Failed)
                ) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
                ) && 
                (
                    this.LastRestart == input.LastRestart ||
                    (this.LastRestart != null &&
                    this.LastRestart.Equals(input.LastRestart))
                ) && 
                (
                    this.Restarts == input.Restarts ||
                    this.Restarts.Equals(input.Restarts)
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TaskHandle == input.TaskHandle ||
                    (this.TaskHandle != null &&
                    this.TaskHandle.Equals(input.TaskHandle))
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
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.FinishedAt != null)
                    hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.LastRestart != null)
                    hashCode = hashCode * 59 + this.LastRestart.GetHashCode();
                hashCode = hashCode * 59 + this.Restarts.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TaskHandle != null)
                    hashCode = hashCode * 59 + this.TaskHandle.GetHashCode();
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
            // Restarts (int) maximum
            if(this.Restarts > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Restarts, must be a value less than or equal to 384.", new [] { "Restarts" });
            }

            // Restarts (int) minimum
            if(this.Restarts < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Restarts, must be a value greater than or equal to 0.", new [] { "Restarts" });
            }

            yield break;
        }
    }

}
