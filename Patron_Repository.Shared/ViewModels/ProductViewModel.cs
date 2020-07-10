using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Patron_Repository.Shared.ViewModels
{
    public class ProductViewModel
    {

        public int ProductId { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Nombre es requerido")]
        public string Name { get; set; }

        [Display(Name = "Codigo")]
        [Required(ErrorMessage = "Codigo es requerido")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Tiene menos de 3 digitos")]
        public string Code { get; set; }

        [Display(Name = "Descripcion")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Tiene menos de 3 digitos")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        [DataType(DataType.Currency)]
        [Range(1.0, 99999.99)]
        [Required(ErrorMessage = "Precio es requerido")]
        public decimal Price { get; set; }

        [Display(Name = "Cantidad")]
        [Range(1, 99999)]
        [Required(ErrorMessage = "Cantidad es requerido")]
        public int Quantity { get; set; }

    }
}
