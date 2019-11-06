using System;
using OscCore;

namespace Resolink
{
    [Serializable]
    public class FloatOscActionHandler : OscActionHandler<float>
    {
        protected override float GetMessageValue(OscMessageValues dataHandle)
        {
            return dataHandle.ReadFloatElement(0);
        }

        public FloatOscActionHandler(Action<float> action) : base(action) { }
    }
}