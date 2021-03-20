using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Squirrel;

namespace Infoware.Updates
{
    public static unsafe class FUnsafeUtility
    {
        public static List<Tuple<string, int>> EnumerateProcesses()
        {
            int bytesReturned = 0;
            var pids = new int[2048];

            fixed (int* p = pids)
            {
                if (!FNativeMethods.EnumProcesses((IntPtr)p, sizeof(int) * pids.Length, out bytesReturned))
                {
                    throw new Win32Exception("Failed to enumerate processes");
                }

                if (bytesReturned < 1) throw new Exception("Failed to enumerate processes");
            }

            return Enumerable.Range(0, bytesReturned / sizeof(int))
                .Where(i => pids[i] > 0)
                .Select(i =>
                {
                    try
                    {
                        var hProcess = FNativeMethods.OpenProcess(ProcessAccess.QueryLimitedInformation, false, pids[i]);
                        if (hProcess == IntPtr.Zero) throw new Win32Exception();

                        var sb = new StringBuilder(256);
                        var capacity = sb.Capacity;
                        if (!FNativeMethods.QueryFullProcessImageName(hProcess, 0, sb, ref capacity))
                        {
                            throw new Win32Exception();
                        }

                        FNativeMethods.CloseHandle(hProcess);
                        return Tuple.Create(sb.ToString(), pids[i]);
                    }
                    catch (Exception)
                    {
                        return Tuple.Create(default(string), pids[i]);
                    }
                })
                .ToList();
        }
    }

}