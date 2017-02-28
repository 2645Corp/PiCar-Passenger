using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WangHeng.Org.PiCar
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            InitControl();
            KeyHookUtils.Hook_Start();
            getUrl();
        }

        private void InitControl()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "PiCar Control  v" + this.ProductVersion;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.btnDown.Tag = "t_down";
            this.btnLeft.Tag = "t_left";
            this.btnRight.Tag = "t_right";
            this.btnUp.Tag = "t_up";
            this.btnStop.Tag = "t_stop";
            this.btnPyLeft.Tag = "py_left";
            this.btnPyRight.Tag = "py_right";
            this.btnCamUp.Tag = this.btnCamDown.Tag = "ctlcamx";
            this.btnCamLeft.Tag = this.btnCamRight.Tag = "ctlcamy";
            this.btnCamRst.Tag = "ctlcamrst";
            this.statusStrip1.SizingGrip = false;
            this.lblPostResultInfo.Text = "启动成功！";
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                lblPostResultInfo.Text = "left";
            }
            return base.ProcessDialogKey(keyData);
        }

        private void ctlButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var result = CarCtl.TurnFunc(btn.Tag.ToString());
            this.lblPostResultInfo.Text = "请求成功 - " + result;
        }
        private void camctlButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            const int anglegain = 10;
            switch (btn.Name.ToString())
            {
                case "btnCamUp":
                    if (CamCtl.AngleX - anglegain >= 50)
                        CamCtl.AngleX -= anglegain;
                    break;
                case "btnCamDown":
                    if (CamCtl.AngleX + anglegain <= 180)
                        CamCtl.AngleX += anglegain;
                    break;
                case "btnCamLeft":
                    if (CamCtl.AngleY + anglegain <= 180)
                        CamCtl.AngleY += anglegain;
                    break;
                case "btnCamRight":
                    if (CamCtl.AngleY - anglegain >= 0)
                        CamCtl.AngleY -= anglegain;
                    break;
                case "btnCamRst":
                    CamCtl.AngleX = 130;
                    CamCtl.AngleY = 90;
                    break;
            }
            var result = CamCtl.TurnFunc();
            this.lblPostResultInfo.Text = "请求成功 - " + result;
        }
        private void lightCtlButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var result = LightCtl.LightFunc(btn.Tag.ToString());
            this.lblPostResultInfo.Text = "请求成功 - " + result;
        }
        private void setSpeedButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var result = CarCtl.SetSpeed(btn.Tag.ToString(), btn.Tag.ToString());
            this.lblPostResultInfo.Text = "请求成功 - " + result;
        }
        public void getUrl()
        {
            tempUrl = "http://" + ipBox.Text + ":" + portBox.Text;
        }
        static public string tempUrl;

        private void ipBox_TextChanged(object sender, EventArgs e)
        {
            getUrl();
        }

        private void portBox_TextChanged(object sender, EventArgs e)
        {
            getUrl();
        }

        private void btnPyLeft_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var result = CarCtl.TurnFunc(btn.Tag.ToString());
            this.lblPostResultInfo.Text = "请求成功 - " + result;
        }

        private void btnPyRight_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var result = CarCtl.TurnFunc(btn.Tag.ToString());
            this.lblPostResultInfo.Text = "请求成功 - " + result;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var result = CarCtl.SetSpeed((255 - this.trackBar1.Value).ToString(),
                (100 + this.trackBar1.Value).ToString());
            this.lblPostResultInfo.Text = "请求成功 - " + result;
        }
    }

    public static class CarCtl
    {
        public enum CarStatus
        {
            Left,
            Right,
            Up,
            Down,
            Stop,
            Unknown
        }

        public static CarStatus CurrentStatus = CarStatus.Unknown;
        public static string TurnFunc(string direcID)
        {
            //var requestUrl = "http://192.168.1.114:2000/ctl";
            var requestUrl = MainFrm.tempUrl + "/ctl";
            var requestData = new Dictionary<string, string>() { { "id", direcID } };
            var requestUserAgent = "WangHeng PiCar/v1.0";
            var requestEncoding = Encoding.Default;
            var result = HttpUtility.CreatePostHttpResponse(
                    requestUrl,
                    requestData,
                    5000,
                    requestUserAgent,
                    requestEncoding,
                    null);

            using (var sr = new StreamReader(result.GetResponseStream(), requestEncoding))
            {
                return sr.ReadToEnd();
            }
        }
        public static string SetSpeed(string speedA, string speedB)
        {
            //var requestUrl = "http://192.168.1.114:2000/ctl";
            var requestUrl = MainFrm.tempUrl + "/ctlspeed";
            var requestData = new Dictionary<string, string>() {
                { "speedA", speedA },
                { "speedB", speedB }
            };
            var requestUserAgent = "WangHeng PiCar/v1.0";
            var requestEncoding = Encoding.Default;
            var result = HttpUtility.CreatePostHttpResponse(
                    requestUrl,
                    requestData,
                    5000,
                    requestUserAgent,
                    requestEncoding,
                    null);

            using (var sr = new StreamReader(result.GetResponseStream(), requestEncoding))
            {
                return sr.ReadToEnd();
            }
        }
    }

    public static class CamCtl
    {
        public static int AngleX = 130;
        public static int AngleY = 90;
        public static string TurnFunc()
        {
            var requestUrl = MainFrm.tempUrl + "/ctlcam";
            var requestData = new Dictionary<string, string>()
            { { "anglex", CamCtl.AngleX.ToString() }, { "angley", CamCtl.AngleY.ToString() } };
            var requestUserAgent = "WangHeng PiCar/v1.0";
            var requestEncoding = Encoding.Default;
            var result = HttpUtility.CreatePostHttpResponse(
                    requestUrl,
                    requestData,
                    5000,
                    requestUserAgent,
                    requestEncoding,
                    null);

            using (var sr = new StreamReader(result.GetResponseStream(), requestEncoding))
            {
                return sr.ReadToEnd();
            }
        }
    }
    public static class LightCtl
    {
        public static string LightFunc(string frontLightStatus)
        {
            var requestUrl = MainFrm.tempUrl + "/ctllight";
            var requestData = new Dictionary<string, string>()
            {{ "frontLight", frontLightStatus }};
            var requestUserAgent = "WangHeng PiCar/v1.0";
            var requestEncoding = Encoding.Default;
            var result = HttpUtility.CreatePostHttpResponse(
                    requestUrl,
                    requestData,
                    5000,
                    requestUserAgent,
                    requestEncoding,
                    null);

            using (var sr = new StreamReader(result.GetResponseStream(), requestEncoding))
            {
                return sr.ReadToEnd();
            }
        }
    }

    public class KeyHookUtils
    {
        [StructLayout(LayoutKind.Sequential)]
        public class KeyBoardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }
        //委托 
        public delegate int HookProc(int nCode, int wParam, IntPtr lParam);
        static int hHook = 0;
        public const int WH_KEYBOARD_LL = 13;
        //LowLevel键盘截获，如果是WH_KEYBOARD＝2，并不能对系统键盘截取，Acrobat Reader会在你截取之前获得键盘。 
        static HookProc KeyBoardHookProcedure;

        //设置钩子 
        [DllImport("user32.dll")]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        //抽掉钩子 
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        //调用下一个钩子 
        [DllImport("user32.dll")]
        public static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        public static extern int GetCurrentThreadId();

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string name);

        public static void Hook_Start()
        {
            if (hHook == 0)
            {
                KeyBoardHookProcedure = new HookProc(KeyBoardHookProc);
                hHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyBoardHookProcedure,
                        GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
                //如果设置钩子失败. 
                if (hHook == 0)
                {
                    Hook_Clear();
                }
            }
        }

        /// <summary>
        /// 取消钩子事件
        /// </summary>
        public static void Hook_Clear()
        {
            bool retKeyboard = true;
            if (hHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hHook);
                hHook = 0;
            }
        }

        public static int KeyBoardHookProc(int nCode, int wParam, IntPtr lParam)
        {
            const int anglegain = 10;
            if (nCode >= 0)
            {
                KeyBoardHookStruct kbh = (KeyBoardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyBoardHookStruct));
                Keys k = (Keys)Enum.Parse(typeof(Keys), kbh.vkCode.ToString());
                switch (k)
                {
                    case Keys.Left:
                        if (kbh.flags == 1)
                        {
                            // 这里写按下后做什么事
                            if (CarCtl.CurrentStatus != CarCtl.CarStatus.Up)
                            {
                                CarCtl.TurnFunc("t_left");
                                CarCtl.CurrentStatus = CarCtl.CarStatus.Up;
                            }
                        }
                        else if (kbh.flags == 129)
                        {
                            //放开后做什么事
                            CarCtl.TurnFunc("t_stop");
                            CarCtl.CurrentStatus = CarCtl.CarStatus.Stop;
                        }
                        return 1;
                    case Keys.Up:
                        if (kbh.flags == 1)
                        {
                            // 这里写按下后做什么事
                            if (CarCtl.CurrentStatus != CarCtl.CarStatus.Up)
                            {
                                CarCtl.TurnFunc("t_up");
                                CarCtl.CurrentStatus = CarCtl.CarStatus.Up;
                            }
                        }
                        else if (kbh.flags == 129)
                        {
                            //放开后做什么事
                            CarCtl.TurnFunc("t_stop");
                            CarCtl.CurrentStatus = CarCtl.CarStatus.Stop;
                        }
                        return 1;
                    case Keys.Right:
                        if (kbh.flags == 1)
                        {
                            if (CarCtl.CurrentStatus != CarCtl.CarStatus.Up)
                            {
                                CarCtl.TurnFunc("t_right");
                                CarCtl.CurrentStatus = CarCtl.CarStatus.Up;
                            }
                        }
                        else if (kbh.flags == 129)
                        {
                            //放开后做什么事
                            CarCtl.TurnFunc("t_stop");
                            CarCtl.CurrentStatus = CarCtl.CarStatus.Stop;
                        }
                        return 1;
                    case Keys.Down:
                        if (kbh.flags == 1)
                        {
                            if (CarCtl.CurrentStatus != CarCtl.CarStatus.Up)
                            {
                                CarCtl.TurnFunc("t_down");
                                CarCtl.CurrentStatus = CarCtl.CarStatus.Up;
                            }
                        }
                        else if (kbh.flags == 129)
                        {
                            //放开后做什么事
                            CarCtl.TurnFunc("t_stop");
                            CarCtl.CurrentStatus = CarCtl.CarStatus.Stop;
                        }
                        return 1;
                    case Keys.NumPad8:
                        if (kbh.flags == 1)
                        {
                            // 这里写按下后做什么事
                            if (CamCtl.AngleX + anglegain <= 180)
                                CamCtl.AngleX += anglegain;
                            CamCtl.TurnFunc();
                        }
                        else if (kbh.flags == 129)
                        {
                            //放开后做什么事
                        }
                        return 1;
                    case Keys.NumPad2:
                        if (kbh.flags == 1)
                        {
                            // 这里写按下后做什么事
                            if (CamCtl.AngleX + anglegain >= 0)
                                CamCtl.AngleX -= anglegain;
                            CamCtl.TurnFunc();
                        }
                        else if (kbh.flags == 129)
                        {
                            //放开后做什么事
                        }
                        return 1;
                    case Keys.NumPad4:
                        if (kbh.flags == 1)
                        {
                            // 这里写按下后做什么事
                            if (CamCtl.AngleY + anglegain <= 180)
                                CamCtl.AngleY += anglegain;
                            CamCtl.TurnFunc();
                        }
                        else if (kbh.flags == 129)
                        {
                            //放开后做什么事
                        }
                        return 1;
                    case Keys.NumPad6:
                        if (kbh.flags == 1)
                        {
                            // 这里写按下后做什么事
                            if (CamCtl.AngleY + anglegain >= 0)
                                CamCtl.AngleY -= anglegain;
                            CamCtl.TurnFunc();
                        }
                        else if (kbh.flags == 129)
                        {
                            //放开后做什么事
                        }
                        return 1;
                    default:
                        break;
                }
            }
            return CallNextHookEx(hHook, nCode, wParam, lParam);
        }
    }
}
