using DTO.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entites.Concrete
{
    public class Colors : IEntity
    {
        [Key]
        public int ColorId { get; set; }

        public string ColorName { get; set; }

    }
}
