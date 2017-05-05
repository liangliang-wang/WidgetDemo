using System;
using System.Runtime.InteropServices;

namespace TC.Vacations.WorkingPlatform.OutService.SpiderRuning
{
    /// <summary>WebBrowser代理</summary>
    public class IEProxy
    {
        /// <summary> OPTION</summary>
        private const int InternetOptionProxy = 38;

        /// <summary> OPEN_TYPE </summary>
        private const int InternetOpenTypeProxy = 3;

        /// <summary>INTERNET_OPEN_TYPE_DIRECT </summary>
        private const int InternetOpenTypeDirect = 1;

        /// <summary>代理地址 </summary>
        private string ProxyStr;

        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer,
            int lpdwBufferLength);

        /// <summary> 代理明细结构</summary>
        public struct Struct_INTERNET_PROXY_INFO
        {
            public int dwAccessType;
            public IntPtr proxy;
            public IntPtr proxyBypass;
        }

        /// <summary>代理设置 </summary>
        /// <param name="strProxy">代理地址</param>
        /// <returns>结果</returns>
        private bool InternetSetOption(string strProxy)
        {
            int bufferLength;
            IntPtr intptrStruct;
            Struct_INTERNET_PROXY_INFO structIpi;
            if (string.IsNullOrEmpty(strProxy) || strProxy.Trim().Length == 0)
            {
                strProxy = string.Empty;
                structIpi.dwAccessType = InternetOpenTypeDirect;
            }
            else
            {
                structIpi.dwAccessType = InternetOpenTypeProxy;
            }
            structIpi.proxy = Marshal.StringToHGlobalAnsi(strProxy);
            structIpi.proxyBypass = Marshal.StringToHGlobalAnsi("local");
            bufferLength = Marshal.SizeOf(structIpi);
            intptrStruct = Marshal.AllocCoTaskMem(bufferLength);
            Marshal.StructureToPtr(structIpi, intptrStruct, true);
            return InternetSetOption(IntPtr.Zero, InternetOptionProxy, intptrStruct, bufferLength);
        }

        /// <summary>构造方法</summary>
        /// <param name="strProxy">地址</param>
        public IEProxy(string strProxy)
        {
            this.ProxyStr = strProxy;
        }

        /// <summary>设置代理 </summary>
        /// <returns>结果</returns>
        public bool RefreshIESettings()
        {
            return InternetSetOption(this.ProxyStr);
        }

        /// <summary>取消代理 </summary>
        /// <returns>结果</returns>
        public bool DisableIEProxy()
        {
            return InternetSetOption(string.Empty);
        }
    }
}