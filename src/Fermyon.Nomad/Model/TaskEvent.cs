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
    /// TaskEvent
    /// </summary>
    [DataContract(Name = "TaskEvent")]
    public partial class TaskEvent : IEquatable<TaskEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskEvent" /> class.
        /// </summary>
        /// <param name="details">details.</param>
        /// <param name="diskLimit">diskLimit.</param>
        /// <param name="diskSize">diskSize.</param>
        /// <param name="displayMessage">displayMessage.</param>
        /// <param name="downloadError">downloadError.</param>
        /// <param name="driverError">driverError.</param>
        /// <param name="driverMessage">driverMessage.</param>
        /// <param name="exitCode">exitCode.</param>
        /// <param name="failedSibling">failedSibling.</param>
        /// <param name="failsTask">failsTask.</param>
        /// <param name="genericSource">genericSource.</param>
        /// <param name="killError">killError.</param>
        /// <param name="killReason">killReason.</param>
        /// <param name="killTimeout">killTimeout.</param>
        /// <param name="message">message.</param>
        /// <param name="restartReason">restartReason.</param>
        /// <param name="setupError">setupError.</param>
        /// <param name="signal">signal.</param>
        /// <param name="startDelay">startDelay.</param>
        /// <param name="taskSignal">taskSignal.</param>
        /// <param name="taskSignalReason">taskSignalReason.</param>
        /// <param name="time">time.</param>
        /// <param name="type">type.</param>
        /// <param name="validationError">validationError.</param>
        /// <param name="vaultError">vaultError.</param>
        public TaskEvent(Dictionary<string, string> details = default(Dictionary<string, string>), long diskLimit = default(long), long diskSize = default(long), string displayMessage = default(string), string downloadError = default(string), string driverError = default(string), string driverMessage = default(string), int exitCode = default(int), string failedSibling = default(string), bool failsTask = default(bool), string genericSource = default(string), string killError = default(string), string killReason = default(string), long killTimeout = default(long), string message = default(string), string restartReason = default(string), string setupError = default(string), int signal = default(int), long startDelay = default(long), string taskSignal = default(string), string taskSignalReason = default(string), long time = default(long), string type = default(string), string validationError = default(string), string vaultError = default(string))
        {
            this.Details = details;
            this.DiskLimit = diskLimit;
            this.DiskSize = diskSize;
            this.DisplayMessage = displayMessage;
            this.DownloadError = downloadError;
            this.DriverError = driverError;
            this.DriverMessage = driverMessage;
            this.ExitCode = exitCode;
            this.FailedSibling = failedSibling;
            this.FailsTask = failsTask;
            this.GenericSource = genericSource;
            this.KillError = killError;
            this.KillReason = killReason;
            this.KillTimeout = killTimeout;
            this.Message = message;
            this.RestartReason = restartReason;
            this.SetupError = setupError;
            this.Signal = signal;
            this.StartDelay = startDelay;
            this.TaskSignal = taskSignal;
            this.TaskSignalReason = taskSignalReason;
            this.Time = time;
            this.Type = type;
            this.ValidationError = validationError;
            this.VaultError = vaultError;
        }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "Details", EmitDefaultValue = false)]
        public Dictionary<string, string> Details { get; set; }

        /// <summary>
        /// Gets or Sets DiskLimit
        /// </summary>
        [DataMember(Name = "DiskLimit", EmitDefaultValue = false)]
        public long DiskLimit { get; set; }

        /// <summary>
        /// Gets or Sets DiskSize
        /// </summary>
        [DataMember(Name = "DiskSize", EmitDefaultValue = false)]
        public long DiskSize { get; set; }

        /// <summary>
        /// Gets or Sets DisplayMessage
        /// </summary>
        [DataMember(Name = "DisplayMessage", EmitDefaultValue = false)]
        public string DisplayMessage { get; set; }

        /// <summary>
        /// Gets or Sets DownloadError
        /// </summary>
        [DataMember(Name = "DownloadError", EmitDefaultValue = false)]
        public string DownloadError { get; set; }

        /// <summary>
        /// Gets or Sets DriverError
        /// </summary>
        [DataMember(Name = "DriverError", EmitDefaultValue = false)]
        public string DriverError { get; set; }

        /// <summary>
        /// Gets or Sets DriverMessage
        /// </summary>
        [DataMember(Name = "DriverMessage", EmitDefaultValue = false)]
        public string DriverMessage { get; set; }

        /// <summary>
        /// Gets or Sets ExitCode
        /// </summary>
        [DataMember(Name = "ExitCode", EmitDefaultValue = false)]
        public int ExitCode { get; set; }

        /// <summary>
        /// Gets or Sets FailedSibling
        /// </summary>
        [DataMember(Name = "FailedSibling", EmitDefaultValue = false)]
        public string FailedSibling { get; set; }

        /// <summary>
        /// Gets or Sets FailsTask
        /// </summary>
        [DataMember(Name = "FailsTask", EmitDefaultValue = true)]
        public bool FailsTask { get; set; }

        /// <summary>
        /// Gets or Sets GenericSource
        /// </summary>
        [DataMember(Name = "GenericSource", EmitDefaultValue = false)]
        public string GenericSource { get; set; }

        /// <summary>
        /// Gets or Sets KillError
        /// </summary>
        [DataMember(Name = "KillError", EmitDefaultValue = false)]
        public string KillError { get; set; }

        /// <summary>
        /// Gets or Sets KillReason
        /// </summary>
        [DataMember(Name = "KillReason", EmitDefaultValue = false)]
        public string KillReason { get; set; }

        /// <summary>
        /// Gets or Sets KillTimeout
        /// </summary>
        [DataMember(Name = "KillTimeout", EmitDefaultValue = false)]
        public long KillTimeout { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "Message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets RestartReason
        /// </summary>
        [DataMember(Name = "RestartReason", EmitDefaultValue = false)]
        public string RestartReason { get; set; }

        /// <summary>
        /// Gets or Sets SetupError
        /// </summary>
        [DataMember(Name = "SetupError", EmitDefaultValue = false)]
        public string SetupError { get; set; }

        /// <summary>
        /// Gets or Sets Signal
        /// </summary>
        [DataMember(Name = "Signal", EmitDefaultValue = false)]
        public int Signal { get; set; }

        /// <summary>
        /// Gets or Sets StartDelay
        /// </summary>
        [DataMember(Name = "StartDelay", EmitDefaultValue = false)]
        public long StartDelay { get; set; }

        /// <summary>
        /// Gets or Sets TaskSignal
        /// </summary>
        [DataMember(Name = "TaskSignal", EmitDefaultValue = false)]
        public string TaskSignal { get; set; }

        /// <summary>
        /// Gets or Sets TaskSignalReason
        /// </summary>
        [DataMember(Name = "TaskSignalReason", EmitDefaultValue = false)]
        public string TaskSignalReason { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "Time", EmitDefaultValue = false)]
        public long Time { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ValidationError
        /// </summary>
        [DataMember(Name = "ValidationError", EmitDefaultValue = false)]
        public string ValidationError { get; set; }

        /// <summary>
        /// Gets or Sets VaultError
        /// </summary>
        [DataMember(Name = "VaultError", EmitDefaultValue = false)]
        public string VaultError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskEvent {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  DiskLimit: ").Append(DiskLimit).Append("\n");
            sb.Append("  DiskSize: ").Append(DiskSize).Append("\n");
            sb.Append("  DisplayMessage: ").Append(DisplayMessage).Append("\n");
            sb.Append("  DownloadError: ").Append(DownloadError).Append("\n");
            sb.Append("  DriverError: ").Append(DriverError).Append("\n");
            sb.Append("  DriverMessage: ").Append(DriverMessage).Append("\n");
            sb.Append("  ExitCode: ").Append(ExitCode).Append("\n");
            sb.Append("  FailedSibling: ").Append(FailedSibling).Append("\n");
            sb.Append("  FailsTask: ").Append(FailsTask).Append("\n");
            sb.Append("  GenericSource: ").Append(GenericSource).Append("\n");
            sb.Append("  KillError: ").Append(KillError).Append("\n");
            sb.Append("  KillReason: ").Append(KillReason).Append("\n");
            sb.Append("  KillTimeout: ").Append(KillTimeout).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  RestartReason: ").Append(RestartReason).Append("\n");
            sb.Append("  SetupError: ").Append(SetupError).Append("\n");
            sb.Append("  Signal: ").Append(Signal).Append("\n");
            sb.Append("  StartDelay: ").Append(StartDelay).Append("\n");
            sb.Append("  TaskSignal: ").Append(TaskSignal).Append("\n");
            sb.Append("  TaskSignalReason: ").Append(TaskSignalReason).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValidationError: ").Append(ValidationError).Append("\n");
            sb.Append("  VaultError: ").Append(VaultError).Append("\n");
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
            return this.Equals(input as TaskEvent);
        }

        /// <summary>
        /// Returns true if TaskEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.DiskLimit == input.DiskLimit ||
                    this.DiskLimit.Equals(input.DiskLimit)
                ) && 
                (
                    this.DiskSize == input.DiskSize ||
                    this.DiskSize.Equals(input.DiskSize)
                ) && 
                (
                    this.DisplayMessage == input.DisplayMessage ||
                    (this.DisplayMessage != null &&
                    this.DisplayMessage.Equals(input.DisplayMessage))
                ) && 
                (
                    this.DownloadError == input.DownloadError ||
                    (this.DownloadError != null &&
                    this.DownloadError.Equals(input.DownloadError))
                ) && 
                (
                    this.DriverError == input.DriverError ||
                    (this.DriverError != null &&
                    this.DriverError.Equals(input.DriverError))
                ) && 
                (
                    this.DriverMessage == input.DriverMessage ||
                    (this.DriverMessage != null &&
                    this.DriverMessage.Equals(input.DriverMessage))
                ) && 
                (
                    this.ExitCode == input.ExitCode ||
                    this.ExitCode.Equals(input.ExitCode)
                ) && 
                (
                    this.FailedSibling == input.FailedSibling ||
                    (this.FailedSibling != null &&
                    this.FailedSibling.Equals(input.FailedSibling))
                ) && 
                (
                    this.FailsTask == input.FailsTask ||
                    this.FailsTask.Equals(input.FailsTask)
                ) && 
                (
                    this.GenericSource == input.GenericSource ||
                    (this.GenericSource != null &&
                    this.GenericSource.Equals(input.GenericSource))
                ) && 
                (
                    this.KillError == input.KillError ||
                    (this.KillError != null &&
                    this.KillError.Equals(input.KillError))
                ) && 
                (
                    this.KillReason == input.KillReason ||
                    (this.KillReason != null &&
                    this.KillReason.Equals(input.KillReason))
                ) && 
                (
                    this.KillTimeout == input.KillTimeout ||
                    this.KillTimeout.Equals(input.KillTimeout)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.RestartReason == input.RestartReason ||
                    (this.RestartReason != null &&
                    this.RestartReason.Equals(input.RestartReason))
                ) && 
                (
                    this.SetupError == input.SetupError ||
                    (this.SetupError != null &&
                    this.SetupError.Equals(input.SetupError))
                ) && 
                (
                    this.Signal == input.Signal ||
                    this.Signal.Equals(input.Signal)
                ) && 
                (
                    this.StartDelay == input.StartDelay ||
                    this.StartDelay.Equals(input.StartDelay)
                ) && 
                (
                    this.TaskSignal == input.TaskSignal ||
                    (this.TaskSignal != null &&
                    this.TaskSignal.Equals(input.TaskSignal))
                ) && 
                (
                    this.TaskSignalReason == input.TaskSignalReason ||
                    (this.TaskSignalReason != null &&
                    this.TaskSignalReason.Equals(input.TaskSignalReason))
                ) && 
                (
                    this.Time == input.Time ||
                    this.Time.Equals(input.Time)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ValidationError == input.ValidationError ||
                    (this.ValidationError != null &&
                    this.ValidationError.Equals(input.ValidationError))
                ) && 
                (
                    this.VaultError == input.VaultError ||
                    (this.VaultError != null &&
                    this.VaultError.Equals(input.VaultError))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                hashCode = hashCode * 59 + this.DiskLimit.GetHashCode();
                hashCode = hashCode * 59 + this.DiskSize.GetHashCode();
                if (this.DisplayMessage != null)
                    hashCode = hashCode * 59 + this.DisplayMessage.GetHashCode();
                if (this.DownloadError != null)
                    hashCode = hashCode * 59 + this.DownloadError.GetHashCode();
                if (this.DriverError != null)
                    hashCode = hashCode * 59 + this.DriverError.GetHashCode();
                if (this.DriverMessage != null)
                    hashCode = hashCode * 59 + this.DriverMessage.GetHashCode();
                hashCode = hashCode * 59 + this.ExitCode.GetHashCode();
                if (this.FailedSibling != null)
                    hashCode = hashCode * 59 + this.FailedSibling.GetHashCode();
                hashCode = hashCode * 59 + this.FailsTask.GetHashCode();
                if (this.GenericSource != null)
                    hashCode = hashCode * 59 + this.GenericSource.GetHashCode();
                if (this.KillError != null)
                    hashCode = hashCode * 59 + this.KillError.GetHashCode();
                if (this.KillReason != null)
                    hashCode = hashCode * 59 + this.KillReason.GetHashCode();
                hashCode = hashCode * 59 + this.KillTimeout.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.RestartReason != null)
                    hashCode = hashCode * 59 + this.RestartReason.GetHashCode();
                if (this.SetupError != null)
                    hashCode = hashCode * 59 + this.SetupError.GetHashCode();
                hashCode = hashCode * 59 + this.Signal.GetHashCode();
                hashCode = hashCode * 59 + this.StartDelay.GetHashCode();
                if (this.TaskSignal != null)
                    hashCode = hashCode * 59 + this.TaskSignal.GetHashCode();
                if (this.TaskSignalReason != null)
                    hashCode = hashCode * 59 + this.TaskSignalReason.GetHashCode();
                hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValidationError != null)
                    hashCode = hashCode * 59 + this.ValidationError.GetHashCode();
                if (this.VaultError != null)
                    hashCode = hashCode * 59 + this.VaultError.GetHashCode();
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
