﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstTrade_.Models.Services
{
    public class RegistersCriteriaVM
    {
        public int Go { get; set; }
        public int Total { get; set; }
        public int StartDate { get; set; }
    }
    public class StockVM
    {
        public int count { get; set; }
        public int id { get; set; }
        public string stockname { get; set; }
        public List<double?> price { get; set; }
        public double? UpL { get; set; }
        public double? DownL { get; set; }
        public void UDLimit(StockVM combine,int count)
        {
            combine.UpL = combine.price.Max();
            combine.DownL = combine.price.Min();
            combine.count = count;
        }
    }
}