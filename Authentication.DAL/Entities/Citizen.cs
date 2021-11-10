using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Authentication.DAL.Entities
{
    public class Citizen
    {
        [Key]
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int NationalID { get; set; }
        public String Location { get; set; }
        public String SubLocation { get; set; }
        public String Ward { get; set; }
        public String County { get; set; }
    }
}
