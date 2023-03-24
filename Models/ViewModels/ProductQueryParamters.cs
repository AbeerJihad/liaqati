﻿using liaqati_master.Models.ViewModels;

namespace liaqati_master.Model
{
    public class ProductQueryParamters : QueryParameters
    {
        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }
        public string Tilte { get; set; } = string.Empty;
        public string? CategoryId { get; set; }
        public string SearchTearm { get; set; } = string.Empty;
    }
}
