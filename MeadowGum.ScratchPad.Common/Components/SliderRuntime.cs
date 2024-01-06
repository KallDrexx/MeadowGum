using System;
using Gum.Wireframe;

namespace MeadowGum.ScratchPad.Common.Components
{
    partial class SliderRuntime : GraphicalUiElement
    {
        private int _value;

        public Action<int>? OnValueChanged { get; set; }

        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int Increment { get; set; } = 1;

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                if (_value < Minimum)
                {
                    _value = Minimum;
                }
                else if (_value > Maximum)
                {
                    _value = Maximum;
                }

                const int minX = 3;
                var maxX = (int)GetAbsoluteWidth() - 10;
                var percent = (_value - Minimum) / ((decimal)Maximum - Minimum);
                var x = (maxX - minX) * percent;
                Indicator.X = (float)x;

                OnValueChanged?.Invoke(_value);
            }
        }

        partial void CustomInitialize()
        {
        }

        public void IncrementValue()
        {
            Value += Increment;
        }

        public void DecrementValue()
        {
            Value -= Increment;
        }
    }
}