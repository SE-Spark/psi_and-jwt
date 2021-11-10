using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Authentication.DAL.Entities
{
    public class Criminal
    {
        [Key]
        public Guid Id { get; set; }
        public int NationalID { get; set; }
        public int PassPortNo { get; set; }
        public String Crime { get; set; }

        public String Description { get; set; }

        public String CrimeDate { get; set; }

    }
}
