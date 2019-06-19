using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infrastructure.Models.CustomObjectModels;
using Infrastructure.Models.IntermediateModels;

namespace Infrastructure.Models.ConstraintModels
{
    public class Constraint
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public List<TypeConstraint> SupportedTypes { get; set; }

        public Constraint()
        {
            SupportedTypes = new List<TypeConstraint>();
        }
    }
}
