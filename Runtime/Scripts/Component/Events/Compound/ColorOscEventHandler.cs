using UnityEngine;

namespace Resolink
{
    public class ColorOscEventHandler : CompoundOscEventHandler<FloatOscActionHandler, 
        ColorUnityEvent, Color, float>
    {
        public override void Setup()
        {
            if (Handlers == null)
            {
                Handlers = new[]
                {
                    new FloatOscActionHandler(SetRed),
                    new FloatOscActionHandler(SetGreen),
                    new FloatOscActionHandler(SetBlue),
                    new FloatOscActionHandler(SetAlpha),
                };
            }
        }

        public void SetHandlers(ColorShortcutGroup group)
        {
            Handlers[0].Shortcut = group.Red; 
            Handlers[1].Shortcut = group.Green;
            Handlers[2].Shortcut = group.Blue;
            Handlers[3].Shortcut = group.Alpha;
        }

        public void SetRed(float r)
        {
            Value.r = r;
        }
        
        public void SetGreen(float g)
        {
            Value.g = g;
        }
        
        public void SetBlue(float b)
        {
            Value.b = b;
        }
        
        public void SetAlpha(float a)
        {
            Value.a = a;
        }
    }
}