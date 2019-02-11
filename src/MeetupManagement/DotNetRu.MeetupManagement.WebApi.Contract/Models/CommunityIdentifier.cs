#pragma warning disable SA1028 // Code must not contain trailing whitespace
/*
 * Meetup Management Service API
 *
 * Meetup Management Service API
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
#pragma warning restore SA1028 // Code must not contain trailing whitespace

// ReSharper disable RedundantUsingDirective
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DotNetRu.MeetupManagement.WebApi.Contract.Models
#pragma warning disable SA1028 // Code must not contain trailing whitespace
{ 
    /// <inheritdoc />
    /// <summary>
    /// 
    /// </summary>
#pragma warning restore SA1028 // Code must not contain trailing whitespace
    [DataContract]
    public class CommunityIdentifier : IEquatable<CommunityIdentifier>
#pragma warning disable SA1028 // Code must not contain trailing whitespace
    {
#pragma warning restore SA1028 // Code must not contain trailing whitespace
        /// <summary>
        /// Gets or sets CommunityId
        /// </summary>
        [Required]
        [DataMember(Name="CommunityId")]
        public string CommunityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommunityIdentifier {\n");
            sb.Append("  CommunityId: ").Append(CommunityId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        // ReSharper disable once UnusedMember.Global
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
#pragma warning disable IDE0041 // Use 'is null' check
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            return obj.GetType() == GetType() && Equals((CommunityIdentifier)obj);
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns true if CommunityIdentifier instances are equal
        /// </summary>
        /// <param name="other">Instance of CommunityIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommunityIdentifier other)
        {
#pragma warning disable IDE0041 // Use 'is null' check
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;

#pragma warning disable CA1309 // Use ordinal stringcomparison
#pragma warning disable CA1307 // Specify StringComparison
#pragma warning disable SA1515 // Single-line comment must be preceded by blank line
#pragma warning disable SA1009 // Closing parenthesis must be spaced correctly
            return
#pragma warning disable SA1119 // Statement must not use unnecessary parenthesis
                (
                    // ReSharper disable once RedundantNameQualifier
                    string.Equals(CommunityId, other.CommunityId) ||
                    (CommunityId != null && CommunityId.Equals(other.CommunityId))
                );
#pragma warning restore SA1119 // Statement must not use unnecessary parenthesis
#pragma warning restore SA1009 // Closing parenthesis must be spaced correctly
#pragma warning restore SA1515 // Single-line comment must be preceded by blank line
#pragma warning restore CA1307 // Specify StringComparison
#pragma warning restore CA1309 // Use ordinal stringcomparison
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // Overflow is fine, just wrap
            unchecked
            {
                var hashCode = 41;

                // Suitable nullity checks etc, of course :)
#pragma warning disable CA1307 // Specify StringComparison

                // ReSharper disable once NonReadonlyMemberInGetHashCode
                    if (CommunityId != null)
                    {
                    // ReSharper disable once NonReadonlyMemberInGetHashCode
                    hashCode = (hashCode * 59) + CommunityId.GetHashCode();
                    }
#pragma warning restore CA1307 // Specify StringComparison
                return hashCode;
            }
        }

#pragma warning disable SA1124 // Do not use regions
        #region Operators
        #pragma warning disable 1591
        #pragma warning disable SA1201 // Elements must appear in the correct order
        public static bool operator ==(CommunityIdentifier left, CommunityIdentifier right)
        {
            return Equals(left, right);
        }
        #pragma warning restore SA1201 // Elements must appear in the correct order

        public static bool operator !=(CommunityIdentifier left, CommunityIdentifier right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
#pragma warning restore SA1124 // Do not use regions
    }
}