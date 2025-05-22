using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Core.BaseEntity
{
    /// <summary>
    /// Represents the base class for all entities in the system.
    /// Provides common properties like Id, CreatedDate, and UpdatedDate.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the primary key of the entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date the entity was created.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date the entity was last updated.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }
    }

}
