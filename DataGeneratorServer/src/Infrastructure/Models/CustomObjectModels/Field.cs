using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models.CustomObjectModels
{
    public class Field
    {
        public int Id { get; set; }
        
        [StringLength(250)]
        public string Name { get; set; }

        public FieldType Type { get; set; }
    }
}
