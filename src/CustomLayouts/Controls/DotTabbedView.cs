﻿using CustomLayouts.Controls.Dots;
using Xamarin.Forms;

namespace CustomLayouts.Controls
{
    public class DotTabbedView : CustomTabbedView
    {
        public DotTabbedView()
        {
            Indicator = new DotIndicator {DotSize = 5, DotColor = Color.Black};
            CasualLayout = new CarouselLayout.CarouselLayout();
            Generator = new DotIndicatorConfig();
        }
    }
}