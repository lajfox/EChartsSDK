﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Line : Rectangular<Line>
    {
        public bool? smooth { get; set; }

        public object dataFilter { get; set; }

        public Line() {
            this.type = ChartType.line;
        }

        public Line(string name):this() {
            this.name = name;
        }

        public Line Smooth(bool smooth) {
            this.smooth = smooth;
            return this;
        }

    }
}
