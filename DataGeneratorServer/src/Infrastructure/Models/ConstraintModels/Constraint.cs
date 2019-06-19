using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infrastructure.Models.CustomObjectModels;
using Infrastructure.Models.IntermediateModels;

namespace Infrastructure.Models.ConstraintModels
{
    public class Constraint
    {
        public int Id { get; set; }

        [Required()]
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(50)]
        public string Description { get; set; }

        public virtual ICollection<TypeConstraint> SupportedTypes { get; set; }        
    }
}
