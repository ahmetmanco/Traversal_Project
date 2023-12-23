using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace EntityLayer.Concrete
{
    public class SubAbout
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
