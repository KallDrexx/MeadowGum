using System;
using RenderingLibrary;

namespace MeadowGum.Shared.Components;

public class SpriteRuntime
{
    private readonly GumComponent _innerComponent;
    private string? _sourceFile;
    private float _width, _height;
    private bool _hasTextureChanged;

    public bool FlipHorizontal { get; set; } // Not supported
    public float X { get; set; }
    public float Y { get; set; }
    
    public string? SourceFile
    {
        get => _sourceFile;
        set
        {
            if (_sourceFile != value)
            {
                _sourceFile = value;
                _hasTextureChanged = true;
            }
        }
    }
    
    public float Width
    {
        get => _width;
        set
        {
            if (Math.Abs(_width - value) > 0.001f)
            {
                _width = value;
                _hasTextureChanged = true;
            }
        }
    }
    
    public float Height
    {
        get => _height;
        set
        {
            if (Math.Abs(_height - value) > 0.001f)
            {
                _height = value;
                _hasTextureChanged = true;
            }
        }
    }

    public SpriteRuntime()
    {
        _innerComponent = new GumComponent(this);
    }
    
    public 

    private class GumComponent : MeadowGumComponent
    {
        private readonly SpriteRuntime _owner;

        public GumComponent(SpriteRuntime owner)
        {
            _owner = owner;
        }

        public override void Render(ISystemManagers managers)
        {
            if (DefaultRenderer == null)
            {
                const string message = "No default renderer set yet";
                throw new InvalidOperationException(message);
            }

            throw new NotImplementedException();
        }
    }
}