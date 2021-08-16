using System;
using System.ComponentModel.DataAnnotations;

namespace MyCRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}

        [Required]
        [Display(Name="Chef's Name:")]
        public string ChefName {get; set;}

        [Required]
        [Display(Name="Name of Dish:")]
        public string DishName {get; set;}

        [Required]
        [Range(0,10000000)]
        [Display(Name="# of Calories:")]
        public string Calories {get; set;}

        [Required]
        [Range(0,5)]
        [Display(Name="Tastiness:")]
        public string Tastiness {get; set;}

        [Required]
        [Display(Name="Description:")]
        public string Description {get; set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}