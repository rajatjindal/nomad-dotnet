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
    /// TaskArtifact
    /// </summary>
    [DataContract(Name = "TaskArtifact")]
    public partial class TaskArtifact : IEquatable<TaskArtifact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskArtifact" /> class.
        /// </summary>
        /// <param name="getterHeaders">getterHeaders.</param>
        /// <param name="getterMode">getterMode.</param>
        /// <param name="getterOptions">getterOptions.</param>
        /// <param name="getterSource">getterSource.</param>
        /// <param name="relativeDest">relativeDest.</param>
        public TaskArtifact(Dictionary<string, string> getterHeaders = default(Dictionary<string, string>), string getterMode = default(string), Dictionary<string, string> getterOptions = default(Dictionary<string, string>), string getterSource = default(string), string relativeDest = default(string))
        {
            this.GetterHeaders = getterHeaders;
            this.GetterMode = getterMode;
            this.GetterOptions = getterOptions;
            this.GetterSource = getterSource;
            this.RelativeDest = relativeDest;
        }

        /// <summary>
        /// Gets or Sets GetterHeaders
        /// </summary>
        [DataMember(Name = "GetterHeaders", EmitDefaultValue = false)]
        public Dictionary<string, string> GetterHeaders { get; set; }

        /// <summary>
        /// Gets or Sets GetterMode
        /// </summary>
        [DataMember(Name = "GetterMode", EmitDefaultValue = false)]
        public string GetterMode { get; set; }

        /// <summary>
        /// Gets or Sets GetterOptions
        /// </summary>
        [DataMember(Name = "GetterOptions", EmitDefaultValue = false)]
        public Dictionary<string, string> GetterOptions { get; set; }

        /// <summary>
        /// Gets or Sets GetterSource
        /// </summary>
        [DataMember(Name = "GetterSource", EmitDefaultValue = false)]
        public string GetterSource { get; set; }

        /// <summary>
        /// Gets or Sets RelativeDest
        /// </summary>
        [DataMember(Name = "RelativeDest", EmitDefaultValue = false)]
        public string RelativeDest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskArtifact {\n");
            sb.Append("  GetterHeaders: ").Append(GetterHeaders).Append("\n");
            sb.Append("  GetterMode: ").Append(GetterMode).Append("\n");
            sb.Append("  GetterOptions: ").Append(GetterOptions).Append("\n");
            sb.Append("  GetterSource: ").Append(GetterSource).Append("\n");
            sb.Append("  RelativeDest: ").Append(RelativeDest).Append("\n");
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
            return this.Equals(input as TaskArtifact);
        }

        /// <summary>
        /// Returns true if TaskArtifact instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskArtifact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskArtifact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GetterHeaders == input.GetterHeaders ||
                    this.GetterHeaders != null &&
                    input.GetterHeaders != null &&
                    this.GetterHeaders.SequenceEqual(input.GetterHeaders)
                ) && 
                (
                    this.GetterMode == input.GetterMode ||
                    (this.GetterMode != null &&
                    this.GetterMode.Equals(input.GetterMode))
                ) && 
                (
                    this.GetterOptions == input.GetterOptions ||
                    this.GetterOptions != null &&
                    input.GetterOptions != null &&
                    this.GetterOptions.SequenceEqual(input.GetterOptions)
                ) && 
                (
                    this.GetterSource == input.GetterSource ||
                    (this.GetterSource != null &&
                    this.GetterSource.Equals(input.GetterSource))
                ) && 
                (
                    this.RelativeDest == input.RelativeDest ||
                    (this.RelativeDest != null &&
                    this.RelativeDest.Equals(input.RelativeDest))
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
                if (this.GetterHeaders != null)
                    hashCode = hashCode * 59 + this.GetterHeaders.GetHashCode();
                if (this.GetterMode != null)
                    hashCode = hashCode * 59 + this.GetterMode.GetHashCode();
                if (this.GetterOptions != null)
                    hashCode = hashCode * 59 + this.GetterOptions.GetHashCode();
                if (this.GetterSource != null)
                    hashCode = hashCode * 59 + this.GetterSource.GetHashCode();
                if (this.RelativeDest != null)
                    hashCode = hashCode * 59 + this.RelativeDest.GetHashCode();
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
