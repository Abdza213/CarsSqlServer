using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DTO.Entites;

namespace Entites.Concrete
{
    public class Brands : IEntity
    {
        [Key]
        public int BrandId { get; set; }

        public string BrandName { get; set; }


    }
}
