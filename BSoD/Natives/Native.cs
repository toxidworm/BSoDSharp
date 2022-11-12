//This class contains DLLImports, do not touch <3
//Coded by lib4qq (aka. ToxidWorm)

//Libraries to use
//Without system it won't work bc it cointains value types like boolean, integer, string and e.t.c.
using System;
//System.Runtime.InteropServices used to import out dll's by PInvoke method
using System.Runtime.InteropServices;

//Namespace of project
namespace BSoD.Natives
{
    //Class structure
    internal class Native
    {
        //https://www.pinvoke.net/default.aspx/ntdll/NtRaiseHandError.html
        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(
        uint ErrorStatus,
        uint NumberOfParameters,
        uint UnicodeStringParameterMask,
        IntPtr Parameters,
        uint ValidResponseOption,
        out uint Response);

        //https://www.pinvoke.net/default.aspx/ntdll/RtlAdjustPrivilege.html
        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern IntPtr RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege,
        bool IsThreadPrivilege, out bool PreviousValue);

        //idk original source
        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

    }
}
