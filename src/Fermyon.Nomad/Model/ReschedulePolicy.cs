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
    /// ReschedulePolicy
    /// </summary>
    [DataContract(Name = "ReschedulePolicy")]
    public partial class ReschedulePolicy : IEquatable<ReschedulePolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReschedulePolicy" /> class.
        /// </summary>
        /// <param name="attempts">attempts.</param>
        /// <param name="delay">delay.</param>
        /// <param name="delayFunction">delayFunction.</param>
        /// <param name="interval">interval.</param>
        /// <param name="maxDelay">maxDelay.</param>
        /// <param name="unlimited">unlimited.</param>
        public ReschedulePolicy(int attempts = default(int), long delay = default(long), string delayFunction = default(string), long interval = default(long), long maxDelay = default(long), bool unlimited = default(bool))
        {
            this.Attempts = attempts;
            this.Delay = delay;
            this.DelayFunction = delayFunction;
            this.Interval = interval;
            this.MaxDelay = maxDelay;
            this.Unlimited = unlimited;
        }

        /// <summary>
        /// Gets or Sets Attempts
        /// </summary>
        [DataMember(Name = "Attempts", EmitDefaultValue = false)]
        public int Attempts { get; set; }

        /// <summary>
        /// Gets or Sets Delay
        /// </summary>
        [DataMember(Name = "Delay", EmitDefaultValue = false)]
        public long Delay { get; set; }

        /// <summary>
        /// Gets or Sets DelayFunction
        /// </summary>
        [DataMember(Name = "DelayFunction", EmitDefaultValue = false)]
        public string DelayFunction { get; set; }

        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "Interval", EmitDefaultValue = false)]
        public long Interval { get; set; }

        /// <summary>
        /// Gets or Sets MaxDelay
        /// </summary>
        [DataMember(Name = "MaxDelay", EmitDefaultValue = false)]
        public long MaxDelay { get; set; }

        /// <summary>
        /// Gets or Sets Unlimited
        /// </summary>
        [DataMember(Name = "Unlimited", EmitDefaultValue = true)]
        public bool Unlimited { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReschedulePolicy {\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
            sb.Append("  Delay: ").Append(Delay).Append("\n");
            sb.Append("  DelayFunction: ").Append(DelayFunction).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  MaxDelay: ").Append(MaxDelay).Append("\n");
            sb.Append("  Unlimited: ").Append(Unlimited).Append("\n");
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
            return this.Equals(input as ReschedulePolicy);
        }

        /// <summary>
        /// Returns true if ReschedulePolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of ReschedulePolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReschedulePolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attempts == input.Attempts ||
                    this.Attempts.Equals(input.Attempts)
                ) && 
                (
                    this.Delay == input.Delay ||
                    this.Delay.Equals(input.Delay)
                ) && 
                (
                    this.DelayFunction == input.DelayFunction ||
                    (this.DelayFunction != null &&
                    this.DelayFunction.Equals(input.DelayFunction))
                ) && 
                (
                    this.Interval == input.Interval ||
                    this.Interval.Equals(input.Interval)
                ) && 
                (
                    this.MaxDelay == input.MaxDelay ||
                    this.MaxDelay.Equals(input.MaxDelay)
                ) && 
                (
                    this.Unlimited == input.Unlimited ||
                    this.Unlimited.Equals(input.Unlimited)
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
                hashCode = hashCode * 59 + this.Attempts.GetHashCode();
                hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.DelayFunction != null)
                    hashCode = hashCode * 59 + this.DelayFunction.GetHashCode();
                hashCode = hashCode * 59 + this.Interval.GetHashCode();
                hashCode = hashCode * 59 + this.MaxDelay.GetHashCode();
                hashCode = hashCode * 59 + this.Unlimited.GetHashCode();
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
