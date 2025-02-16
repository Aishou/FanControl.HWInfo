using FanControl.Plugins;

namespace FanControl.HWInfo
{
    public class HWInfoPluginSensor : IPluginSensor
    {
        internal HWInfoPluginSensor(int index, string id, string name)
        {
            Index = index;
            Id = id;
            Name = name;
        }

        internal int Index { get; set; }

        #region IPluginSensor Implementation

        public string Name { get; }

        public float? Value { get; internal set; }

        public string Id { get; }

        public void Update() { }

        internal void Invalidate()
        {
            Index = -1;
        }

        public bool IsValid => Index > -1;

        #endregion
    }
}
