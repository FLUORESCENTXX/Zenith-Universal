using System;
using System.Windows.Forms;
using AutoItX3Lib;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing;
using System.IO;

namespace Zenith_Aimbot
{
    public partial class Universal : Form
    {

        AutoItX3 au3 = new AutoItX3();

        [DllImport("user32.dll")]

        static extern short GetAsyncKeyState(Keys vKey);
        public Universal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
        }

        void AIMBOT()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.XButton2) < 0)
                {
                    try
                    {
                        object pix = au3.PixelSearch(2, 165, 1586, 651, 0xfbfbfb);
                        if (pix.ToString() != "1")
                        {
                            object[] pixCoord = (object[])pix;
                            au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                        }
                    }

                    catch { }

                }
                Thread.Sleep(1);
            }
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arsenal Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xfedcaf);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da Hood Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xD79750);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EnergyAssault Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xD79750);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red EnergyAssault Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xBD2D48);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blue EnergyAssault Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0x1C25A4);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aimblox Enabled");
        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dark Da Hood Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0x644844);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Normal Da Hood Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xD09668);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Strucid Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xFFD090);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }


            }
        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red Arsenal Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xB60205);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Purple Arsenal Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xC140E2);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blue Arsenal Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0x0179C7);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green Arsenal Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0x109613);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orange Arsenal Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xFDD60F);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FFA Arsenal Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xE6C3A3);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blue Aimblox Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0x09245B);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red Aimblox Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0x950002);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phantom Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0x818287);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ghosts Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0x7D7E83);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }

        private void bunifuButton16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FFA EnergyAssault Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0xEAC696);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void bunifuButton8_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Phantom Forces Enabled");
            Thread AB = new Thread(AIMBOT) { IsBackground = true };
            AB.Start();
            void AIMBOT()
            {
                while (true)
                {
                    if (GetAsyncKeyState(Keys.XButton2) < 0)
                    {
                        try
                        {
                            object pix = au3.PixelSearch(2, 165, 1586, 651, 0x978496);
                            if (pix.ToString() != "1")
                            {
                                object[] pixCoord = (object[])pix;
                                au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                            }
                        }

                        catch { }

                    }
                    Thread.Sleep(1);
                }
            }
        }
    }
}