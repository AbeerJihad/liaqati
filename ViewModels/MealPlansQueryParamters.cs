﻿namespace liaqati_master.ViewModels
{
    public class MealPlansQueryParamters : QueryParameters
    {
        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }
        public string? CategoryId { get; set; }
        public string? SearchTearm { get; set; } = string.Empty;
    }
}