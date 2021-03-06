// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An arm role receiver.
    /// </summary>
    public partial class ArmRoleReceiver
    {
        /// <summary>
        /// Initializes a new instance of the ArmRoleReceiver class.
        /// </summary>
        public ArmRoleReceiver()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArmRoleReceiver class.
        /// </summary>
        /// <param name="name">The name of the arm role receiver. Names must be
        /// unique across all receivers within an action group.</param>
        /// <param name="roleId">The arm role id.</param>
        /// <param name="useCommonAlertSchema">Indicates whether to use common
        /// alert schema.</param>
        public ArmRoleReceiver(string name, string roleId, bool useCommonAlertSchema)
        {
            Name = name;
            RoleId = roleId;
            UseCommonAlertSchema = useCommonAlertSchema;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the arm role receiver. Names must be
        /// unique across all receivers within an action group.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the arm role id.
        /// </summary>
        [JsonProperty(PropertyName = "roleId")]
        public string RoleId { get; set; }

        /// <summary>
        /// Gets or sets indicates whether to use common alert schema.
        /// </summary>
        [JsonProperty(PropertyName = "useCommonAlertSchema")]
        public bool UseCommonAlertSchema { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (RoleId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoleId");
            }
        }
    }
}
