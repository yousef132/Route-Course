﻿using Store.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Services.ProductService.Dtos
{
    public class ProductDetailsDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Pirce { get; set; }

        public string PictureUrl { get; set; }

        public string BrandName { get; set; }

        public string TypeName { get; set; }

    }
}
