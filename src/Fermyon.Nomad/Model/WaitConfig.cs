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
    /// WaitConfig
    /// </summary>
    [DataContract(Name = "WaitConfig")]
    public partial class WaitConfig : IEquatable<WaitConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitConfig" /> class.
        /// </summary>
        /// <param name="max">max.</param>
        /// <param name="min">min.</param>
        public WaitConfig(long max = default(long), long min = default(long))
        {
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name = "Max", EmitDefaultValue = false)]
        public long Max { get; set; }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name = "Min", EmitDefaultValue = false)]
        public long Min { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitConfig {\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
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
            return this.Equals(input as WaitConfig);
        }

        /// <summary>
        /// Returns true if WaitConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of WaitConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
                ) && 
                (
                    this.Min == input.Min ||
                    this.Min.Equals(input.Min)
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
                hashCode = hashCode * 59 + this.Max.GetHashCode();
                hashCode = hashCode * 59 + this.Min.GetHashCode();
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
