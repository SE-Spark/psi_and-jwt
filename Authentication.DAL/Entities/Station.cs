using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Authentication.DAL.Entities
{
    public class Station
    {
        [Key]
        public Guid Id { get; set; }
        public int StationNo { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public String SubLocation { get; set; }
        public String Ward { get; set; }
        public String County { get; set; }

    }
}
