using classwork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classwork.ViewModels
{
    public class PharmacyIndexViewModel
    {
        public List<Drug> Drugs { get; set; }
        public List<DrugType> DrugTypes { get; set; }
    }
}
