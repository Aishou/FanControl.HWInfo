using System;
using System.Globalization;
using Microsoft.Win32;

namespace FanControl.HWInfo
{
    internal class HWInfoRegistry : IDisposable
    {
        public HWInfoRegistry()
        {
        }

        public bool IsActive()
        {
            return false;
        }

        public void Dispose()
        {
        }
    }
}
