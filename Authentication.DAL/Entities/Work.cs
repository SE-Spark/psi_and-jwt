using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Authentication.DAL.Entities
{
    public class Work
    {
        [Key]
        public Guid Id { get; set; }
        public String Name { get; set; }

    }
}
