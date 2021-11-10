using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Authentication.DAL.Entities
{
    public class Foreigner
    {
        [Key]
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int PassPortNo { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public String DateIn { get; set; }
        public String DateOut { get; set; }
    }
}
