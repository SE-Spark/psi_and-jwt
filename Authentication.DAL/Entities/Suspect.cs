using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Authentication.DAL.Entities
{
    public class Suspect
    {
        [Key]
        public Guid Id { get; set; }
        public int NationalID { get; set; }
        public int PassPortNo { get; set; }
        public String Allegation { get; set; }

        public String Description { get; set; }

        public String AllegationDate { get; set; }

    }
}
