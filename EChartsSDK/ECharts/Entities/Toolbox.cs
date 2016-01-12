﻿using ECharts.Entities.feature;
using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities
{
    public class ToolBox:Basic<ToolBox>
    {
        public OrientType? horizontal { get; set; }

        public int? itemGap { get; set; }

        public int? itemSize { get; set; }

        public IList<string> color { get; set; }

        public string disableColor { get; set; }

        public string effectiveColor { get; set; }

        public bool? showTitle { get; set; }

        public TextStyle textStyle { get; set; }

        public Feature feature { get; set; }

        public Feature Feature()
        {
            if (feature == null)
                feature = new Entities.feature.Feature();
            return feature;
        }

        public TextStyle TextStyle()
        {
            if (textStyle == null)
                this.textStyle = new style.TextStyle();
            return this.textStyle;
        }
    }
}
