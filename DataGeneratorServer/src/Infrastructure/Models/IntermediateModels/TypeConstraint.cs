using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Infrastructure.Models.CustomObjectModels;
using Infrastructure.Models.ConstraintModels;

namespace Infrastructure.Models.IntermediateModels
{
    [Table("Types_Support_Constraints")]
    public class TypeConstraint
    {
        public int Id { get; set; }

        public int TypeId { get; set; }
        
        [ForeignKey("TypeId")]
        public FieldType FieldType { get; set; }

        public int ConstraintId { get; set; }
        public Constraint Constraint;
    }
}
