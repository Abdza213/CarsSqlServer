using DTO;
using DTO.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class CarDetailDto : IDTO
    {

        public int CarId { get; set; }

        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public decimal DailyPrice { get; set; }

        public string Description { get; set; }

    }
}
