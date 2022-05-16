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
    /// Service
    /// </summary>
    [DataContract(Name = "Service")]
    public partial class Service : IEquatable<Service>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Service" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="addressMode">addressMode.</param>
        /// <param name="canaryMeta">canaryMeta.</param>
        /// <param name="canaryTags">canaryTags.</param>
        /// <param name="checkRestart">checkRestart.</param>
        /// <param name="checks">checks.</param>
        /// <param name="connect">connect.</param>
        /// <param name="enableTagOverride">enableTagOverride.</param>
        /// <param name="meta">meta.</param>
        /// <param name="name">name.</param>
        /// <param name="onUpdate">onUpdate.</param>
        /// <param name="portLabel">portLabel.</param>
        /// <param name="provider">provider.</param>
        /// <param name="tags">tags.</param>
        /// <param name="taskName">taskName.</param>
        public Service(string address = default(string), string addressMode = default(string), Dictionary<string, string> canaryMeta = default(Dictionary<string, string>), List<string> canaryTags = default(List<string>), CheckRestart checkRestart = default(CheckRestart), List<ServiceCheck> checks = default(List<ServiceCheck>), ConsulConnect connect = default(ConsulConnect), bool enableTagOverride = default(bool), Dictionary<string, string> meta = default(Dictionary<string, string>), string name = default(string), string onUpdate = default(string), string portLabel = default(string), string provider = default(string), List<string> tags = default(List<string>), string taskName = default(string))
        {
            this.Address = address;
            this.AddressMode = addressMode;
            this.CanaryMeta = canaryMeta;
            this.CanaryTags = canaryTags;
            this.CheckRestart = checkRestart;
            this.Checks = checks;
            this.Connect = connect;
            this.EnableTagOverride = enableTagOverride;
            this.Meta = meta;
            this.Name = name;
            this.OnUpdate = onUpdate;
            this.PortLabel = portLabel;
            this.Provider = provider;
            this.Tags = tags;
            this.TaskName = taskName;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "Address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets AddressMode
        /// </summary>
        [DataMember(Name = "AddressMode", EmitDefaultValue = false)]
        public string AddressMode { get; set; }

        /// <summary>
        /// Gets or Sets CanaryMeta
        /// </summary>
        [DataMember(Name = "CanaryMeta", EmitDefaultValue = false)]
        public Dictionary<string, string> CanaryMeta { get; set; }

        /// <summary>
        /// Gets or Sets CanaryTags
        /// </summary>
        [DataMember(Name = "CanaryTags", EmitDefaultValue = false)]
        public List<string> CanaryTags { get; set; }

        /// <summary>
        /// Gets or Sets CheckRestart
        /// </summary>
        [DataMember(Name = "CheckRestart", EmitDefaultValue = false)]
        public CheckRestart CheckRestart { get; set; }

        /// <summary>
        /// Gets or Sets Checks
        /// </summary>
        [DataMember(Name = "Checks", EmitDefaultValue = false)]
        public List<ServiceCheck> Checks { get; set; }

        /// <summary>
        /// Gets or Sets Connect
        /// </summary>
        [DataMember(Name = "Connect", EmitDefaultValue = false)]
        public ConsulConnect Connect { get; set; }

        /// <summary>
        /// Gets or Sets EnableTagOverride
        /// </summary>
        [DataMember(Name = "EnableTagOverride", EmitDefaultValue = true)]
        public bool EnableTagOverride { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "Meta", EmitDefaultValue = false)]
        public Dictionary<string, string> Meta { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OnUpdate
        /// </summary>
        [DataMember(Name = "OnUpdate", EmitDefaultValue = false)]
        public string OnUpdate { get; set; }

        /// <summary>
        /// Gets or Sets PortLabel
        /// </summary>
        [DataMember(Name = "PortLabel", EmitDefaultValue = false)]
        public string PortLabel { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "Provider", EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "Tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets TaskName
        /// </summary>
        [DataMember(Name = "TaskName", EmitDefaultValue = false)]
        public string TaskName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Service {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressMode: ").Append(AddressMode).Append("\n");
            sb.Append("  CanaryMeta: ").Append(CanaryMeta).Append("\n");
            sb.Append("  CanaryTags: ").Append(CanaryTags).Append("\n");
            sb.Append("  CheckRestart: ").Append(CheckRestart).Append("\n");
            sb.Append("  Checks: ").Append(Checks).Append("\n");
            sb.Append("  Connect: ").Append(Connect).Append("\n");
            sb.Append("  EnableTagOverride: ").Append(EnableTagOverride).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OnUpdate: ").Append(OnUpdate).Append("\n");
            sb.Append("  PortLabel: ").Append(PortLabel).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
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
            return this.Equals(input as Service);
        }

        /// <summary>
        /// Returns true if Service instances are equal
        /// </summary>
        /// <param name="input">Instance of Service to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Service input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AddressMode == input.AddressMode ||
                    (this.AddressMode != null &&
                    this.AddressMode.Equals(input.AddressMode))
                ) && 
                (
                    this.CanaryMeta == input.CanaryMeta ||
                    this.CanaryMeta != null &&
                    input.CanaryMeta != null &&
                    this.CanaryMeta.SequenceEqual(input.CanaryMeta)
                ) && 
                (
                    this.CanaryTags == input.CanaryTags ||
                    this.CanaryTags != null &&
                    input.CanaryTags != null &&
                    this.CanaryTags.SequenceEqual(input.CanaryTags)
                ) && 
                (
                    this.CheckRestart == input.CheckRestart ||
                    (this.CheckRestart != null &&
                    this.CheckRestart.Equals(input.CheckRestart))
                ) && 
                (
                    this.Checks == input.Checks ||
                    this.Checks != null &&
                    input.Checks != null &&
                    this.Checks.SequenceEqual(input.Checks)
                ) && 
                (
                    this.Connect == input.Connect ||
                    (this.Connect != null &&
                    this.Connect.Equals(input.Connect))
                ) && 
                (
                    this.EnableTagOverride == input.EnableTagOverride ||
                    this.EnableTagOverride.Equals(input.EnableTagOverride)
                ) && 
                (
                    this.Meta == input.Meta ||
                    this.Meta != null &&
                    input.Meta != null &&
                    this.Meta.SequenceEqual(input.Meta)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OnUpdate == input.OnUpdate ||
                    (this.OnUpdate != null &&
                    this.OnUpdate.Equals(input.OnUpdate))
                ) && 
                (
                    this.PortLabel == input.PortLabel ||
                    (this.PortLabel != null &&
                    this.PortLabel.Equals(input.PortLabel))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TaskName == input.TaskName ||
                    (this.TaskName != null &&
                    this.TaskName.Equals(input.TaskName))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressMode != null)
                    hashCode = hashCode * 59 + this.AddressMode.GetHashCode();
                if (this.CanaryMeta != null)
                    hashCode = hashCode * 59 + this.CanaryMeta.GetHashCode();
                if (this.CanaryTags != null)
                    hashCode = hashCode * 59 + this.CanaryTags.GetHashCode();
                if (this.CheckRestart != null)
                    hashCode = hashCode * 59 + this.CheckRestart.GetHashCode();
                if (this.Checks != null)
                    hashCode = hashCode * 59 + this.Checks.GetHashCode();
                if (this.Connect != null)
                    hashCode = hashCode * 59 + this.Connect.GetHashCode();
                hashCode = hashCode * 59 + this.EnableTagOverride.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OnUpdate != null)
                    hashCode = hashCode * 59 + this.OnUpdate.GetHashCode();
                if (this.PortLabel != null)
                    hashCode = hashCode * 59 + this.PortLabel.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TaskName != null)
                    hashCode = hashCode * 59 + this.TaskName.GetHashCode();
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
