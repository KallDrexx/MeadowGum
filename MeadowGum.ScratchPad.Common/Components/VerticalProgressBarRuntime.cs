using System.Linq;
using Gum.Wireframe;

namespace MeadowGum.ScratchPad.Common.Components
{
    partial class VerticalProgressBarRuntime : GraphicalUiElement
    {
        private int _percent;

        public int Percent
        {
            get => _percent;
            set
            {
                _percent = value;
                var indicatorsShown = Indicators.Children.Count * _percent / 100m;
                for (var x = 0; x < Indicators.Children.Count; x++)
                {
                    Indicators.Children[x].Visible = x < indicatorsShown;
                }
            }
        }

        partial void CustomInitialize()
        {
        }

        public void SetColor(VerticalProgressBarRuntime.Color color)
        {
            var indicatorColor = color switch
            {
                Color.Green => ProgressIndicatorRuntime.Color.Green,
                Color.Red => ProgressIndicatorRuntime.Color.Red,
                Color.Yellow => ProgressIndicatorRuntime.Color.Yellow,
            };

            foreach (var indicator in Indicators.Children.OfType<ProgressIndicatorRuntime>())
            {
                indicator.ColorState = indicatorColor;
            }
        }
    }
}