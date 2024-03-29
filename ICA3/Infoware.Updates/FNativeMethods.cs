﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Squirrel;

namespace Infoware.Updates
{
    public static class FNativeMethods
    {
        public static int GetParentProcessId()
        {
            var pbi = new PROCESS_BASIC_INFORMATION();

            //Get a handle to our own process
            IntPtr hProc = OpenProcess((ProcessAccess)0x001F0FFF, false, Process.GetCurrentProcess().Id);

            try
            {
                int sizeInfoReturned;
                int queryStatus = NtQueryInformationProcess(hProc, (PROCESSINFOCLASS)0, ref pbi, pbi.Size, out sizeInfoReturned);
            }
            finally
            {
                if (!hProc.Equals(IntPtr.Zero))
                {
                    //Close handle and free allocated memory
                    CloseHandle(hProc);
                    hProc = IntPtr.Zero;
                }
            }

            return (int)pbi.InheritedFromUniqueProcessId;
        }


        [DllImport("version.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetFileVersionInfo(
            string lpszFileName,
            int dwHandleIgnored,
            int dwLen,
            [MarshalAs(UnmanagedType.LPArray)] byte[] lpData);

        [DllImport("version.dll", SetLastError = true)]
        internal static extern int GetFileVersionInfoSize(
            string lpszFileName,
            IntPtr dwHandleIgnored);

        [DllImport("version.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool VerQueryValue(
            byte[] pBlock,
            string pSubBlock,
            out IntPtr pValue,
            out int len);

        [DllImport("psapi.dll", SetLastError = true)]
        internal static extern bool EnumProcesses(
            IntPtr pProcessIds, // pointer to allocated DWORD array
            int cb,
            out int pBytesReturned);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool QueryFullProcessImageName(
            IntPtr hProcess,
            [In] int justPassZeroHere,
            [Out] StringBuilder lpImageFileName,
            [In][MarshalAs(UnmanagedType.U4)] ref int nSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr OpenProcess(
            ProcessAccess processAccess,
            bool bInheritHandle,
            int processId);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool CloseHandle(IntPtr hHandle);

        [DllImport("NTDLL.DLL", SetLastError = true)]
        internal static extern int NtQueryInformationProcess(IntPtr hProcess, PROCESSINFOCLASS pic, ref PROCESS_BASIC_INFORMATION pbi, int cb, out int pSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        [DllImport("kernel32.dll", EntryPoint = "GetStdHandle")]
        internal static extern IntPtr GetStdHandle(StandardHandles nStdHandle);

        [DllImport("kernel32.dll", EntryPoint = "AllocConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        internal static extern bool AttachConsole(int pid);

        [DllImport("Kernel32.dll", SetLastError = true)]
        internal static extern IntPtr BeginUpdateResource(string pFileName, bool bDeleteExistingResources);

        [DllImport("Kernel32.dll", SetLastError = true)]
        internal static extern bool UpdateResource(IntPtr handle, string pType, IntPtr pName, short language, [MarshalAs(UnmanagedType.LPArray)] byte[] pData, int dwSize);

        [DllImport("Kernel32.dll", SetLastError = true)]
        internal static extern bool EndUpdateResource(IntPtr handle, bool discard);
    }
}
