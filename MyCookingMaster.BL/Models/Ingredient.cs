using MyCookingMaster.BL.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCookingMaster.BL.Models
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
