using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class VenuesViewModel
    {
        public string SelectedItem { get; set; }
        public int SelectedValue { get; set; }

        //public List<SelectListItem> listItems { get; set; }
        public IEnumerable<SelectListItem> listItems { get; set; }

    }
}
