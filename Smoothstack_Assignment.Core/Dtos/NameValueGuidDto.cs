using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothstack_Assignment.Core.Dtos
{
    /// <summary>
    /// The name value data transfer object with a string name and a GUID value.
    /// </summary>
    public class NameValueGuidDto
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameValueGuidDto"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public NameValueGuidDto(string name, Guid value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public Guid Value { get; set; }
    }
}
