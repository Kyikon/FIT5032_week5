using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032_MyViewModel.Models
{
    public class SampleFormViewModels
    {
    }

    //新建一个类
    public class FormOneViewModel
    {
        [Required]
        [Display(Name = "First Name")]

        public string FirstName { get; set;}

        public string LastName { get; set;}

    }
}