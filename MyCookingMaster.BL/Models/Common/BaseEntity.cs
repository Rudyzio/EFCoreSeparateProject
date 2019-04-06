using System.ComponentModel.DataAnnotations;

namespace MyCookingMaster.BL.Models.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
