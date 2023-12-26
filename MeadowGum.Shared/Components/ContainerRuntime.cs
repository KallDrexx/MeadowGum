﻿using RenderingLibrary.Graphics;

namespace MeadowGum.Shared.Components;

public class ContainerRuntime : MeadowGumComponent
{
    public ContainerRuntime()
    {
        SetContainedObject(new InvisibleRenderable { Visible = true });
        Visible = true;
        Width = 150;
        Height = 150;
    }
}