using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Univer2.Models
{
    public class Person
    {
        public int Id { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Длина имени должна быть от 3 до 15")]
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Не может быть пустым")]
        public string Name { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Длина имени должна быть от 3 до 15")]
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Не может быть пустым")]

        public string SurName { get; set; }

        [Display(Name = "Курс")]
        [Range(1,5, ErrorMessage = "От 1 до 5")]
        [Required(ErrorMessage = "Не может быть пустым")]
        public int Course { get; set; }

        
        [Display(Name = "Группа")]
        [Range(1, 3,ErrorMessage ="От 1 до 3")]
        [Required(ErrorMessage = "Не может быть пустым")]
        public int Gruop { get; set; }
    }
}
