using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Form
    {
        //[Column("NAME")]
        public string Name { get; set; }

        //[Column("DEPARTMENT")]

        public string Department { get; set; }

        //[Column("GENDER")]

        public string Gender { get; set; }   
    }
}