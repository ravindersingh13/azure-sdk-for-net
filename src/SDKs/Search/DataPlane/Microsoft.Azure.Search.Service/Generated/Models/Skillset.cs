// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A list of Cognitive Search skills.
    /// <see
    /// href="https://docs.microsoft.com/azure/search/cognitive-search-tutorial-blob"
    /// />
    /// </summary>
    public partial class Skillset
    {
        /// <summary>
        /// Initializes a new instance of the Skillset class.
        /// </summary>
        public Skillset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Skillset class.
        /// </summary>
        /// <param name="name">The name of the skillset.</param>
        /// <param name="description">The description of the skillset.</param>
        /// <param name="skills">A list of skills in the skillset.</param>
        /// <param name="eTag">The ETag of the skillset.</param>
        public Skillset(string name, string description, IList<Skill> skills, string eTag = default(string))
        {
            Name = name;
            Description = description;
            Skills = skills;
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the skillset.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the skillset.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a list of skills in the skillset.
        /// </summary>
        [JsonProperty(PropertyName = "skills")]
        public IList<Skill> Skills { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the skillset.
        /// </summary>
        [JsonProperty(PropertyName = "@odata.etag")]
        public string ETag { get; set; }

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
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
            if (Skills == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Skills");
            }
            if (Skills != null)
            {
                foreach (var element in Skills)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
