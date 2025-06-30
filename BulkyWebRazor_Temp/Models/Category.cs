using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWebRazor_Temp.Models
{
    //In Entity framework Core, a model is a class that represents a table in the database.
    public class Category
    {
        // The properties of the class represent the columns in the table.
        //Data annotations are used to configure the model's properties and relationships.
        [Key] // This attribute indicates that this property is the primary key.
        public int Id { get; set; }
        [Required] // This attribute indicates that this property is required.
        [DisplayName("Category Name")] // This attribute is used to specify a display name for the property.
        [MaxLength(30, ErrorMessage = "Maximum length of characters allowed is 30")]//Maximum length of characters allowed in the property.
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Message must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
