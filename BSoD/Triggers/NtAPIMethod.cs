using System;
using BSoD.Natives;

namespace BSoD.Triggers
{
   
    internal class LogCorruptionDetected
    {
        public static void Trigger()
        {
            Native.RtlAdjustPrivilege(19, true, false, out bool previousValue);
            Native.NtRaiseHardError(0xc0190030, 0, 0, IntPtr.Zero, 6, out uint Response);
        }
    }
}
