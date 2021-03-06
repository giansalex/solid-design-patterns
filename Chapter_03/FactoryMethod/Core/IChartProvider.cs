﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace FactoryMethod.Core
{
    public interface IChartProvider
    {
        IChart GetChart();
    }



    public class ChartProviderFree:IChartProvider
    {
        public IChart GetChart()
        {
            IChart chart = new BarChart();
            return chart;
        }
    }



    public class ChartProviderPaid : IChartProvider
    {
        public IChart GetChart()
        {
            IChart chart = new PieChart();
            return chart;
        }
    }
}
