using Gma.System.MouseKeyHook;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EasierMocking
{
    public partial class Form1 : Form
    {
        private static bool panelOpen = false;
        private static bool toggled = false;
        private IKeyboardMouseEvents globalHook;

        public Form1()
        {
            InitializeComponent();
            RegEvent();
            this.Width = 184;
            openConverterButton.Text = "Open Converter";
        }

        public void Convert(object sender, EventArgs e)
        {
            int l = cTextbox.TextLength;
            if (l == 0)
            {
                cTextbox.Text = "u should type something";
            }
            else
            {
                Random rand = new Random();
                int num = rand.Next(0, 2);
                char c;
                string preconversion = cTextbox.Text;
                cTextbox.Clear();
                foreach (char i in preconversion)
                {
                    if (num == 0)
                    {
                        num = 1;
                        c = char.ToUpper(i);
                        cTextbox.AppendText(c.ToString());
                        continue;
                    }
                    if (num == 1)
                    {
                        num = 0;
                        c = char.ToLower(i);
                        cTextbox.AppendText(c.ToString());
                        continue;
                    }
                }
            }
        }

        public void ConverterPanelTrigger(object sender, EventArgs e)
        {
            if (!panelOpen)
            {
                Width = Width + 416;
                panelOpen = true;
                openConverterButton.Text = "Close Converter";
            }
            else
            {
                Width = Width - 416;
                panelOpen = false;
                openConverterButton.Text = "Open Converter";
            }
        }

        public void OnKP(object sender, KeyEventArgs e)
        {
            if (toggled)
            {
                const int KEYEVENTF_EXTENDEDKEY = 0x1;
                const int KEYEVENTF_KEYUP = 0x2;
                keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(0x14, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP,
                (UIntPtr)0);
            }
        }

        public void OnToggle(object sender, EventArgs e)
        {
            if (toggleCb.CheckState == CheckState.Checked)
            {
                toggled = true;
            }
            if (toggleCb.CheckState == CheckState.Unchecked)
            {
                toggled = false;
            }
        }

        public void RegEvent()
        {
            openConverterButton.Click += new EventHandler(ConverterPanelTrigger);
            cButton.Click += new EventHandler(Convert);
            toggleCb.CheckedChanged += new EventHandler(OnToggle);
            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += new KeyEventHandler(OnKP);
        }
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
UIntPtr dwExtraInfo);
    }
}