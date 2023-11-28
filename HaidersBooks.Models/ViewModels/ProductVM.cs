using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;


namespace HaidersBooks.Models.ViewModels
{
    public class ProductVM
    {
      // ProductVM updated with Ctaegory and CoveraType to retun views to back to the upsert that would the Admin Category and CoverType
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
