using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infrastructure.Models.CustomObjectModels;

namespace Infrastructure.Models.ConstraintModels
{
    public class ConstraintValue
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Value { get; set; }
       
        public int ConstraintId { get; set; }//FK
        public Constraint Constraint { get; set; }//Navigation property        
    }
}
