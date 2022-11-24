using System;
using Xamarin.Forms;

namespace XFCarouselViewSample
{
    public class CarouselViewTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CurveTemplate { get; set; }
        public DataTemplate SquareTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            BannerImage banner = (BannerImage)item;
            return banner.IsSquareView ? SquareTemplate : CurveTemplate;
        }
    }
}

