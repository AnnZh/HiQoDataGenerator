using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infrastructure.Models.ConstraintModels;
using Infrastructure.Models.IntermediateModels;

namespace Infrastructure.Models.CustomObjectModels
{
    public class FieldType
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public List<TypeConstraint> SupportedConstraints { get; set; }

        public FieldType()
        {
            SupportedConstraints = new List<TypeConstraint>();
        }
    }
}
