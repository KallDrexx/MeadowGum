using System;
using System.Collections.ObjectModel;
using Gum;
using RenderingLibrary;
using RenderingLibrary.Graphics;

namespace MeadowGum.Shared.Components;

public class TextRuntime : MeadowGumComponent
{
    private readonly Renderable _renderable;

    public string Text
    {
        get => _renderable.Text;
        set => _renderable.Text = value;
    }

    public MeadowFont Font
    {
        get => _renderable.Font;
        set => _renderable.Font = value;
    }

    public HorizontalAlignment HorizontalAlignment
    {
        get => _renderable.HorizontalAlignment;
        set => _renderable.HorizontalAlignment = value;
    }

    public VerticalAlignment VerticalAlignment
    {
        get => _renderable.VerticalAlignment;
        set => _renderable.VerticalAlignment = value;
    }

    public byte Red
    {
        get => _renderable.Red;
        set => _renderable.Red = value;
    }

    public byte Green
    {
        get => _renderable.Green;
        set => _renderable.Green = value;
    }

    public byte Blue
    {
        get => _renderable.Blue;
        set => _renderable.Blue = value;
    }

    public TextRuntime()
    {
        _renderable = new Renderable(this);
        SetContainedObject(_renderable);
    }

    private class Renderable : IRenderableIpso
    {
        private readonly TextRuntime _parent;

        public BlendState BlendState { get; } = BlendState.Opaque;
        public bool Wrap { get; } = false;
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float Rotation { get; set; }
        public bool FlipHorizontal { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }
        public object Tag { get; set; }
        public bool Visible { get; set; } = true;
        public bool AbsoluteVisible { get; }
        public IRenderableIpso Parent { get; set; }
        public ObservableCollection<IRenderableIpso> Children { get; } = new();
        public ColorOperation ColorOperation { get; }
        public bool ClipsChildren { get; }
        IVisible IVisible.Parent { get; }

        public string Text { get; set; } = string.Empty;
        public MeadowFont Font { get; set; } = MeadowFont.Font8X12;
        public HorizontalAlignment HorizontalAlignment { get; set; } = HorizontalAlignment.Left;
        public VerticalAlignment VerticalAlignment { get; set; } = VerticalAlignment.Top;
        public byte Red { get; set; } = 255;
        public byte Green { get; set; } = 255;
        public byte Blue { get; set; } = 255;

        public Renderable(TextRuntime parent)
        {
            _parent = parent;
        }

        public void Render(ISystemManagers managers)
        {
            if (DefaultRenderer == null)
            {
                throw new InvalidOperationException("No default renderer set");
            }

            DefaultRenderer.RenderText((int)_parent.GetAbsoluteLeft(), 
                (int)_parent.GetAbsoluteTop(), 
                Font,
                HorizontalAlignment, 
                VerticalAlignment, 
                Text, 
                Red, 
                Green, 
                Blue);
        }

        public void PreRender()
        {
        }

        public void SetParentDirect(IRenderableIpso newParent)
        {
            Parent = newParent;
        }

        private int WidthPerCharacter => Font switch
        {
            MeadowFont.Font8X12 => 8,
            _ => throw new NotSupportedException(Font.ToString()),
        };

        private int HeightPerCharacter => Font switch
        {
            MeadowFont.Font8X12 => 12,
            _ => throw new NotSupportedException(Font.ToString()),
        };
    }
}