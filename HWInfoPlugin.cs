using System;
using FanControl.Plugins;

namespace FanControl.HWInfo
{
    public class HWInfoPlugin : IPlugin2
    {
        private readonly IPluginLogger _logger;
        private readonly IPluginDialog _dialog;

        public HWInfoPlugin(IPluginLogger logger, IPluginDialog dialog)
        {
            _logger = logger;
            _dialog = dialog;
        }

        public string Name => "HWInfo";

        public void Initialize()
        {
            // Initialization logic
        }

        public void Close()
        {
            // Cleanup logic
        }

        public void Load(IPluginSensorsContainer container)
        {
            // Load logic
        }

        public void Update()
        {
            // Update logic
        }
    }
}
