//Code for NameEntry
using Gum.Converters;
using Gum.DataTypes;
using Gum.Managers;
using Gum.Wireframe;

using RenderingLibrary.Graphics;

using MeadowGum.Core;
using MeadowGum.Core.Components;
using MeadowGum.ScratchPad.Common.Components;


namespace MeadowGum.ScratchPad.Common.Screens
{
    public partial class NameEntryRuntime
    {
        public BackgroundRuntime BackgroundInstance { get; protected set; }
        public ScreenLabelRuntime ScreenLabelInstance { get; protected set; }

        public NameEntryRuntime(bool fullInstantiation = true)
        {
            if(fullInstantiation)
            {

                 

                InitializeInstances();

                if(fullInstantiation)
                {
                    ApplyDefaultVariables();
                }
                AssignParents();
                CustomInitialize();
            }
        }
        protected virtual void InitializeInstances()
        {
            BackgroundInstance = new BackgroundRuntime();
            BackgroundInstance.Name = "BackgroundInstance";
            ScreenLabelInstance = new ScreenLabelRuntime();
            ScreenLabelInstance.Name = "ScreenLabelInstance";
        }
        protected virtual void AssignParents()
        {
            this.WhatThisContains.Add(BackgroundInstance);
            this.WhatThisContains.Add(ScreenLabelInstance);
        }
        private void ApplyDefaultVariables()
        {

            this.ScreenLabelInstance.Text = "Name Entry";

        }
        partial void CustomInitialize();
    }
}
