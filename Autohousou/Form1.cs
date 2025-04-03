using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using WMPLib;

namespace Autohousou
{
    public partial class Form1 : Form
    {
        int stano = 0;
        int setno = 0;
        int settingno = 4;
        bool Issasendooropenright = true;
        bool IsReverse = false;
        int forno = 0;
        bool isfurusachi = false;

        [DllImport("user32.dll")]
        private static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern int VkKeyScan(char ch);



        WindowsMediaPlayer _wmp = new WindowsMediaPlayer();

        System.Media.SoundPlayer player = new SoundPlayer(Properties.Resources.bus);
        //•ú‘—
        //“Ï“Œ
        System.Media.SoundPlayer st21 = new SoundPlayer(Properties.Resources.s11);

        System.Media.SoundPlayer st31 = new SoundPlayer(Properties.Resources.s21);
        System.Media.SoundPlayer st32 = new SoundPlayer(Properties.Resources.s22);
        System.Media.SoundPlayer st41 = new SoundPlayer(Properties.Resources.s31);
        System.Media.SoundPlayer st42 = new SoundPlayer(Properties.Resources.s32);
        System.Media.SoundPlayer st51 = new SoundPlayer(Properties.Resources.s51);
        System.Media.SoundPlayer st52 = new SoundPlayer(Properties.Resources.s52);
        System.Media.SoundPlayer st61 = new SoundPlayer(Properties.Resources.s61);
        System.Media.SoundPlayer st62 = new SoundPlayer(Properties.Resources.s62);
        System.Media.SoundPlayer st71 = new SoundPlayer(Properties.Resources.s71);
        System.Media.SoundPlayer st72 = new SoundPlayer(Properties.Resources.s72);

        System.Media.SoundPlayer st81 = new SoundPlayer(Properties.Resources.s81);
        System.Media.SoundPlayer st82 = new SoundPlayer(Properties.Resources.s82);
        System.Media.SoundPlayer st91 = new SoundPlayer(Properties.Resources.s91);
        System.Media.SoundPlayer st92L = new SoundPlayer(Properties.Resources.s92L);
        System.Media.SoundPlayer st92R = new SoundPlayer(Properties.Resources.s92R);
        System.Media.SoundPlayer st101 = new SoundPlayer(Properties.Resources.s101);
        System.Media.SoundPlayer st102 = new SoundPlayer(Properties.Resources.s102);

        // System.Media.SoundPlayer st111 = new SoundPlayer(Properties.Resources.s111);

        //‚í‚©‚ç‚ñ
        System.Media.SoundPlayer St111l = new SoundPlayer(Properties.Resources.s111l);
        System.Media.SoundPlayer St111R = new SoundPlayer(Properties.Resources.s111R);
        System.Media.SoundPlayer St121 = new SoundPlayer(Properties.Resources.S121);
        System.Media.SoundPlayer St122 = new SoundPlayer(Properties.Resources.S122);
        System.Media.SoundPlayer St131 = new SoundPlayer(Properties.Resources.S131);
        System.Media.SoundPlayer St132l = new SoundPlayer(Properties.Resources.S132l);
        System.Media.SoundPlayer St132R = new SoundPlayer(Properties.Resources.S132R);
        System.Media.SoundPlayer St141 = new SoundPlayer(Properties.Resources.S141);
        System.Media.SoundPlayer St142 = new SoundPlayer(Properties.Resources.S142);
        System.Media.SoundPlayer St151 = new SoundPlayer(Properties.Resources.S151);
        System.Media.SoundPlayer St152 = new SoundPlayer(Properties.Resources.S152);

        /*
        System.Media.SoundPlayer st121 = new SoundPlayer(Properties.Resources.s121);
        System.Media.SoundPlayer st131 = new SoundPlayer(Properties.Resources.s131);
        System.Media.SoundPlayer st141 = new SoundPlayer(Properties.Resources.s141);
        */

        System.Media.SoundPlayer tksihatsu = new SoundPlayer(Properties.Resources.sihatsu);
        System.Media.SoundPlayer tsihatsu = new SoundPlayer(Properties.Resources.tsihatsu);
        System.Media.SoundPlayer hksihatsu = new SoundPlayer(Properties.Resources.HKshihatsu);

        System.Media.SoundPlayer smenu1 = new SoundPlayer(Properties.Resources.osirase);
        System.Media.SoundPlayer smenu2 = new SoundPlayer(Properties.Resources.teisisignal);
        System.Media.SoundPlayer smenu3 = new SoundPlayer(Properties.Resources.stop);
        System.Media.SoundPlayer smenu4 = new SoundPlayer(Properties.Resources.miawase);

        //settings
        System.Media.SoundPlayer pi = new SoundPlayer(Properties.Resources.pi);
        System.Media.SoundPlayer ks101 = new SoundPlayer(Properties.Resources._101);
        System.Media.SoundPlayer ks102 = new SoundPlayer(Properties.Resources._102);
        System.Media.SoundPlayer ks103 = new SoundPlayer(Properties.Resources._103);
        System.Media.SoundPlayer ks104 = new SoundPlayer(Properties.Resources._104);
        System.Media.SoundPlayer ks105 = new SoundPlayer(Properties.Resources._105);
        System.Media.SoundPlayer ks201 = new SoundPlayer(Properties.Resources._201);
        System.Media.SoundPlayer sselect = new SoundPlayer(Properties.Resources.select);

        //  ‰^—pİ’è

        //“Ï’¬ -> “ñŠÔ@Še’â
        void k101()
        {
            stano = 0;
            fortext.Text = for01.Text;
            IsReverse = false;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k102()
        {
            fortext.Text = kawanima.Text;
            IsReverse = false;
            stano = 3;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k103()
        {
            fortext.Text = sinanima.Text;
            IsReverse = false;
            stano = 7;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k104()
        {
            fortext.Text = sasenima.Text;
            IsReverse = false;
            stano = 9;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k105()
        {
            fortext.Text = "Šâ‹à -> “ñŠÔ";
            IsReverse = false;
            stano = 10;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k106()
        {
            fortext.Text = "V–² -> “ñŠÔ";
            IsReverse = false;
            stano = 15;
            kirikae();
            sihatubutton.Visible = true;
        }

        //furusacchi
        void k301()
        {
            fortext.Text = "éç -> ‹ã¯";
            IsReverse = false;
            isfurusachi = true;
            stano = 0;
            kirikae();
            sihatubutton.Visible = true;
        }

        void k401()
        {
            fortext.Text = "‹ã¯ -> éç";
            IsReverse = true;
            isfurusachi = true;
            stano = 16;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k402()
        {
            fortext.Text = "“V‹ó‹´ -> éç";
            IsReverse = true;
            isfurusachi = true;
            stano = 9;
            kirikae();
            sihatubutton.Visible = true;
        }


        // ‰õ‘¬
        void k111()
        {
            k101();
            rapidb.Checked = true;
        }
        void k112()
        {
            k102();
            rapidb.Checked = true;
        }
        void k113()
        {
            k103();
            rapidb.Checked = true;
        }
        void k114()
        {
            k104();
            rapidb.Checked = true;
        }
        void k115()
        {
            k105();
            rapidb.Checked = true;
        }
        void k116()
        {
            k106();
            rapidb.Checked = true;
        }

        void k201()
        {
            fortext.Text = nimatoma.Text;
            IsReverse = true;
            stano = 23;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k211()
        {
            k201();
            rapidb.Checked = true;
        }

        //furusachi


        void kaisou()
        {
            fortext.Text = "‰ñ‘—";
            IsReverse = false;
            stano = -2;
            kirikae();
            sihatubutton.Visible = false;
            annocheck.Checked = false;
        }

        void k011()
        {
            stano = 0;
            fortext.Text = "‰ñ‘—";
            IsReverse = false;
            kirikae();
            sihatubutton.Visible = true;
            annocheck.Checked = false;
        }
        void k012()
        {
            fortext.Text = "‰ñ‘—";
            IsReverse = false;
            stano = 3;
            kirikae();
            sihatubutton.Visible = true;
            annocheck.Checked = false;
        }
        void k013()
        {
            fortext.Text = "‰ñ‘—";
            IsReverse = false;
            stano = 7;
            kirikae();
            sihatubutton.Visible = true;
            annocheck.Checked = false;
        }
        void k014()
        {
            fortext.Text = "‰ñ‘—";
            IsReverse = false;
            stano = 9;
            kirikae();
            sihatubutton.Visible = true;
            annocheck.Checked = false;
        }
        void k015()
        {
            fortext.Text = "‰ñ‘—";
            IsReverse = false;
            stano = 10;
            kirikae();
            sihatubutton.Visible = true;
            annocheck.Checked = false;
        }
        void k016()
        {
            fortext.Text = "‰ñ‘—";
            IsReverse = false;
            stano = 15;
            kirikae();
            sihatubutton.Visible = true;
            annocheck.Checked = false;
        }
        void k021()
        {
            fortext.Text = "‰ñ‘—";
            IsReverse = true;
            stano = 23;
            kirikae();
            sihatubutton.Visible = true;
            annocheck.Checked = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            boo boo = new boo();
            boo.ShowDialog();
            this.Show();

            reset();
            ActiveControl = ksetting;
        }

        private async void kirikae()
        {
            if (IsReverse == false)
            {
                stano += 1;
            }
            else
            {
                stano -= 1;
            }


            //_wmp.URL = Properties.Resources.bus;
            player.Play();
            await Task.Delay(400);
            if (isfurusachi == false)
            {
                if (IsReverse == false)
                {
                    switch (stano)
                    {
                        case 1://“Ï’¬

                            station.Text = "“Ï’¬E”É‰ØŠX";
                            nextsta.Text = "‚Æ‚Ü‚Æ‚İ‚ç‚¢";
                            debug.Text = stano.ToString();
                            break;
                        case 2://‚Æ‚Ü‚İ‚ç
                            station.Text = "‚Æ‚Ü‚Æ‚İ‚ç‚¢";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "“Ïì";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "VR“c";
                            }
                            debug.Text = stano.ToString();
                            break;
                        case 3://VR
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "VR“c";
                                nextsta.Text = "“Ïì";
                                debug.Text = stano.ToString();
                            }
                            break;
                        case 4://“Ïì
                            station.Text = "“Ïì";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "“Ï–¼";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "“Ï“V›";

                            }
                            debug.Text = stano.ToString();
                            break;
                        case 5://“Ï“V
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "“Ï“V›";
                                nextsta.Text = "“Ï–¼";
                                debug.Text = stano.ToString();
                            }
                            break;
                        case 6://“Ï–¼
                            pass.Visible = false;
                            station.Text = "“Ï–¼";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "ˆî‰×ì";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "V“Ïq";
                                debug.Text = stano.ToString();
                            }
                            break;
                        case 7:
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "V“Ïq";
                                nextsta.Text = "ˆî‰×ì";
                                debug.Text = stano.ToString();
                            }
                            break;


                        case 8://ˆî‰×ì
                            pass.Visible = false;
                            station.Text = "ˆî‰×ì";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "éç";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "”~—Ñ’¬";
                                debug.Text = stano.ToString();
                            }
                            sihatubutton.Visible = true;
                            break;
                        case 9://”~—Ñ’¬
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "”~—Ñ’¬";
                                nextsta.Text = "éç";
                                debug.Text = stano.ToString();
                            }
                            break;
                        case 10://éç
                            pass.Visible = false;
                            station.Text = "éç";
                            nextsta.Text = "Šâ‹à";
                            debug.Text = stano.ToString();
                            break;
                        case 11:
                            pass.Visible = false;
                            station.Text = "Šâ‹à";
                            nextsta.Text = "¼_’J";
                            debug.Text = stano.ToString();

                            break;
                        case 12:
                            pass.Visible = false;
                            station.Text = "¼_’J";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "–kg—t";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "‹Õ•½";
                            }
                            debug.Text = stano.ToString();

                            break;
                        case 13:
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "‹Õ•½";
                                nextsta.Text = "–kg—t";
                                debug.Text = stano.ToString();
                            }
                            debug.Text = stano.ToString();

                            break;
                        case 14:
                            pass.Visible = false;
                            station.Text = "–kg—t";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "V–²‰_";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "«‘å";
                            }

                            debug.Text = stano.ToString();

                            break;
                        case 15:
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "«‘å";
                                nextsta.Text = "V–²‰_";
                            }

                            debug.Text = stano.ToString();

                            break;
                        case 16:

                            station.Text = "V–²‰_";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "–²‰_";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "ŠLR";
                            }

                            debug.Text = stano.ToString();

                            break;
                        case 17:
                            pass.Visible = false;
                            if (rapidb.Checked)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "ŠLR";
                                nextsta.Text = "–²‰_";
                            }
                            debug.Text = stano.ToString();
                            break;
                        case 18:

                            station.Text = "–²‰_";
                            nextsta.Text = "‰H‹à";
                            pass.Visible = false;
                            debug.Text = stano.ToString();

                            break;
                        case 19:

                            station.Text = "‰H‹à";
                            if (rapidb.Checked)
                            {
                                nextsta.Text = "“ñŠÔ";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "Œ´";
                            }

                            debug.Text = stano.ToString();
                            break;
                        case 20:
                            if (rapidb.Checked)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "Œ´";
                                nextsta.Text = "“ì“ñŠÔ";
                            }
                            debug.Text = stano.ToString();
                            break;
                        case 21:
                            if (rapidb.Checked)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "“ì“ñŠÔ";
                                nextsta.Text = "“ñŠÔ";
                            }
                            debug.Text = stano.ToString();
                            break;

                        case 22:
                            station.Text = "“ñŠÔ";
                            nextsta.Text = "I“_";
                            pass.Visible = false;
                            debug.Text = stano.ToString();
                            break;
                        default:
                            reset();
                            break;
                    }
                }
                else
                {
                    switch (stano)
                    {
                        case 1://“Ï’¬

                            station.Text = "“Ï’¬E”É‰ØŠX";
                            nextsta.Text = "";
                            debug.Text = stano.ToString();
                            break;
                        case 2://‚Æ‚Ü‚İ‚ç
                            station.Text = "‚Æ‚Ü‚Æ‚İ‚ç‚¢";
                            nextsta.Text = "“Ï’¬E”É‰ØŠX";
                            debug.Text = stano.ToString();
                            break;
                        case 3://VR
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "VR“c";
                                nextsta.Text = "‚Æ‚Ü‚Æ‚İ‚ç‚¢";
                                debug.Text = stano.ToString();
                            }
                            break;
                        case 4://“Ïì
                            station.Text = "“Ïì";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "‚Æ‚Ü‚Æ‚İ‚ç‚¢";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "VR“c";
                            }

                            debug.Text = stano.ToString();
                            break;
                        case 5://“Ï“V
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "“Ï“V›";
                                nextsta.Text = "“Ïì";
                                debug.Text = stano.ToString();
                            }
                            break;
                        case 6://“Ï–¼
                            pass.Visible = false;

                            station.Text = "“Ï–¼";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "“Ïì";
                            }
                            else
                            {
                                nextsta.Text = "“Ï“V›";
                            }

                            debug.Text = stano.ToString();
                            break;

                        case 7: // V“Ïq
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "V“Ïq";
                                nextsta.Text = "“Ï–¼";
                                debug.Text = stano.ToString();
                            }
                            break;


                        case 8://ˆî‰×ì

                            pass.Visible = false;
                            station.Text = "ˆî‰×ì";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "“Ï–¼";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "V“Ïq";
                            }

                            /*
                            pass.Visible = false;
                            station.Text = "ˆî‰×ì";
                            nextsta.Text = "V“Ïq";
                            sihatubutton.Visible = true;

                            */
                            break;
                        case 9://”~—Ñ’¬
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "”~—Ñ’¬";
                                nextsta.Text = "ˆî‰×ì";
                                debug.Text = stano.ToString();
                            }
                            break;
                        case 10://éç
                            pass.Visible = false;
                            station.Text = "éç";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "ˆî‰×ì";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "”~—Ñ’¬";
                            }


                            debug.Text = stano.ToString();
                            break;
                        case 11:
                            pass.Visible = false;
                            station.Text = "Šâ‹à";
                            nextsta.Text = "éç";
                            debug.Text = stano.ToString();

                            break;
                        case 12:
                            pass.Visible = false;
                            station.Text = "¼_’J";
                            nextsta.Text = "Šâ‹à";
                            debug.Text = stano.ToString();

                            break;
                        case 13:
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                pass.Visible = false;
                                station.Text = "‹Õ•½";
                                nextsta.Text = "¼_’J";
                            }

                            debug.Text = stano.ToString();

                            break;
                        case 14:
                            pass.Visible = false;
                            station.Text = "–kg—t";
                            if (rapidb.Checked == true)
                            {
                                pass.Visible = true;
                                nextsta.Text = "¼_’J";
                            }
                            else
                            {
                                nextsta.Text = "‹Õ•½";
                            }

                            debug.Text = stano.ToString();

                            break;
                        case 15:
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                pass.Visible = false;
                                station.Text = "«‘å";
                                nextsta.Text = "–kg—t";
                            }

                            debug.Text = stano.ToString();

                            break;
                        case 16:

                            station.Text = "V–²‰_";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "–kg—t";
                                pass.Visible = true;
                            }
                            else
                            {
                                pass.Visible = false;
                                nextsta.Text = "«‘å";
                            }


                            debug.Text = stano.ToString();

                            break;
                        case 17:
                            if (rapidb.Checked)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "ŠLR";
                                nextsta.Text = "V–²‰_";
                            }
                            debug.Text = stano.ToString();
                            break;

                        case 18:

                            station.Text = "–²‰_";
                            if (rapidb.Checked)
                            {
                                nextsta.Text = "V–²‰_";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "ŠLR";
                            }


                            debug.Text = stano.ToString();

                            break;
                        case 19:

                            station.Text = "‰H‹à";
                            nextsta.Text = "–²‰_";
                            debug.Text = stano.ToString();

                            break;
                        case 20:
                            if (rapidb.Checked)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "Œ´";
                                nextsta.Text = "‰H‹à";

                            }
                            debug.Text = stano.ToString();
                            break;
                        case 21:
                            if (rapidb.Checked)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "“ì“ñŠÔ";
                                nextsta.Text = "Œ´";
                            }
                            debug.Text = stano.ToString();
                            break;
                        case 22:
                            station.Text = "“ñŠÔ";
                            if (rapidb.Checked)
                            {
                                nextsta.Text = "‰H‹à";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "“ì“ñŠÔ";
                            }
                            debug.Text = stano.ToString();
                            break;
                        case -1:
                            break;
                        default:
                            reset();
                            break;
                    }
                }
            }

            if (isfurusachi == true)
            {
                if (IsReverse == false)
                {
                    switch (stano)
                    {
                        case 1://éç

                            station.Text = "éç";
                            nextsta.Text = "—§’¬O’š–Ú";
                            debug.Text = stano.ToString();
                            break;
                        case 2://—§’¬
                            station.Text = "—§’¬O’š–Ú";

                            nextsta.Text = "“ìŒÃË";

                            debug.Text = stano.ToString();
                            break;
                        case 3:
                            station.Text = "“ìŒÃË";
                            nextsta.Text = "ŒÃË";
                            debug.Text = stano.ToString();
                            break;
                        case 4:
                            station.Text = "ŒÃË";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "–kg—t";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "“Œ‰ÃR";

                            }
                            debug.Text = stano.ToString();
                            break;
                        case 5://“Ï“V
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "“Œ‰ÃR";
                                nextsta.Text = "–kg—t";
                                debug.Text = stano.ToString();
                            }
                            break;
                        case 6://“Ï–¼
                            pass.Visible = false;
                            station.Text = "–kg—t";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "“V‹ó‹´";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "–é˜O";
                                debug.Text = stano.ToString();
                            }
                            break;
                        case 7:
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "–é˜O";
                                nextsta.Text = "“V‹ó‹´";
                                debug.Text = stano.ToString();
                            }
                            break;


                        case 8:
                            pass.Visible = false;
                            station.Text = "“V‹ó‹´";
                            nextsta.Text = "…‘ä";
                            debug.Text = stano.ToString();
                            sihatubutton.Visible = true;
                            break;
                        case 9:
                            pass.Visible = false;
                            station.Text = "…‘ä";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "’ƒ’J";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "“‰Ô";
                            }
                            debug.Text = stano.ToString();
                            break;
                        case 10:
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "“‰Ô";
                                nextsta.Text = "ŒjŒ´";
                            }
                            debug.Text = stano.ToString();
                            break;
                        case 11:
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "ŒjŒ´";
                                nextsta.Text = "‹_‰€›";
                            }
                            debug.Text = stano.ToString();

                            break;
                        case 12:
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "‹_‰€›";
                                nextsta.Text = "‰Ô]";
                            }
                            pass.Visible = false;
                            debug.Text = stano.ToString();

                            break;
                        case 13:
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "‰Ô]";
                                nextsta.Text = "’ƒ’J";
                                debug.Text = stano.ToString();
                            }
                            debug.Text = stano.ToString();

                            break;
                        case 14:
                            pass.Visible = false;
                            station.Text = "’ƒ’J";
                            nextsta.Text = "‹ã¯";
                            debug.Text = stano.ToString();

                            break;

                        case 15:
                            station.Text = "‹ã¯";
                            nextsta.Text = "I“_";
                            pass.Visible = false;
                            debug.Text = stano.ToString();
                            break;
                        default:
                            reset();
                            break;
                    }

                }
                else //ŒÃË
                {
                    switch (stano)
                    {
                        case 1:

                            station.Text = "éç";
                            nextsta.Text = "";
                            debug.Text = stano.ToString();
                            break;
                        case 2:
                            station.Text = "—§’¬O’š–Ú";
                            nextsta.Text = "éç";
                            debug.Text = stano.ToString();
                            break;
                        case 3:
                            station.Text = "“ìŒÃË";
                            nextsta.Text = "—§’¬O’š–Ú";
                            debug.Text = stano.ToString();

                            break;
                        case 4:
                            station.Text = "ŒÃË";
                            nextsta.Text = "“ìŒÃË";


                            debug.Text = stano.ToString();
                            break;
                        case 5://“Ï“V
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "“Œ‰ÃR";
                                nextsta.Text = "ŒÃË";
                                debug.Text = stano.ToString();
                            }
                            break;
                        case 6://“Ï–¼
                            pass.Visible = false;

                            station.Text = "–kg—t";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "ŒÃË";
                            }
                            else
                            {
                                nextsta.Text = "“Œ‰ÃR";
                            }

                            debug.Text = stano.ToString();
                            break;

                        case 7: // V“Ïq
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                station.Text = "–é˜O";
                                nextsta.Text = "–kg—t";
                                debug.Text = stano.ToString();
                            }
                            break;


                        case 8://ˆî‰×ì

                            pass.Visible = false;
                            station.Text = "“V‹ó‹´";
                            if (rapidb.Checked == true)
                            {
                                nextsta.Text = "–kg—t";
                                pass.Visible = true;
                            }
                            else
                            {
                                nextsta.Text = "–é˜O";
                            }

                            break;
                        case 9://”~—Ñ’¬
                            pass.Visible = false;
                            station.Text = "…‘ä";
                            nextsta.Text = "“V‹ó‹´";
                            debug.Text = stano.ToString();
                            break;
                        case 10://éç
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                pass.Visible = false;
                                station.Text = "“‰Ô";
                                nextsta.Text = "…‘ä";
                            }


                            debug.Text = stano.ToString();
                            break;
                        case 11:
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                pass.Visible = false;
                                station.Text = "ŒjŒ´";
                                nextsta.Text = "…‘ä";
                            }
                            debug.Text = stano.ToString();

                            break;
                        case 12:
                            pass.Visible = false;
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                pass.Visible = false;
                                station.Text = "‹_‰€›";
                                nextsta.Text = "ŒjŒ´";
                            }
                            debug.Text = stano.ToString();

                            break;
                        case 13:
                            if (rapidb.Checked == true)
                            {
                                kirikae();
                            }
                            else
                            {
                                pass.Visible = false;
                                station.Text = "‰Ô]";
                                nextsta.Text = "‹_‰€›";
                            }

                            debug.Text = stano.ToString();

                            break;
                        case 14:
                            pass.Visible = false;
                            station.Text = "’ƒ’J";
                            if (rapidb.Checked == true)
                            {
                                pass.Visible = true;
                                nextsta.Text = "…‘ä";
                            }
                            else
                            {
                                nextsta.Text = "‹_‰€›";
                            }

                            debug.Text = stano.ToString();

                            break;

                        case 15:
                            station.Text = "‹ã¯";
                            nextsta.Text = "’ƒ’J";
                            debug.Text = stano.ToString();
                            break;
                        case -1:
                            break;
                        default:
                            reset();
                            break;
                    }
                }
            }


            debug.Text = stano.ToString();

        }
        void reset()
        {
            stano = 0;
            station.Text = "€”õ’†";
            nextsta.Text = "€”õ’†";
            debug.Text = stano.ToString();
            fortext.Text = "–¢İ’è";
            settingno = 3;
            setting();
            rapidb.Checked = false;
            ksetting.Focus();

        }
        async void setting()
        {
            if (settingno == 1)
            {
                status.Text = "Ÿ‚Í";
                settingno = 2;
                await Task.Delay(1000);
                if (annocheck.Checked == true)
                {
                    if (IsReverse == false)
                    {
                        switch (stano)
                        {
                            case 2:
                                st21.Play();
                                sihatubutton.Visible = false;
                                break;
                            case 3:
                                st31.Play();
                                break;
                            case 4:
                                st41.Play();
                                break;
                            case 5:
                                st51.Play();
                                break;
                            case 6:
                                st61.Play();
                                break;



                            case 8:
                                st71.Play();
                                break;
                            case 9:
                                sihatubutton.Visible = false;
                                st81.Play();
                                break;
                            case 10:
                                st91.Play();
                                break;
                            case 11:
                                st101.Play();
                                break;
                            case 12:
                                if (rapidb.Checked == true)
                                {
                                    St111R.Play();
                                }
                                else
                                {
                                    St111l.Play();
                                }
                                // st111.Play();
                                break;

                            case 13:
                                St121.Play();
                                break;
                            case 14:
                                St131.Play();
                                break;
                            case 15:
                                St141.Play();
                                break;
                            case 16:
                                St151.Play();
                                break;
                        }
                    }
                }


            }
            else if (settingno == 2)
            {

                status.Text = "‚Ü‚à‚È‚­";
                settingno = 3;
                if (annocheck.Checked == true)
                {
                    if (IsReverse == false)
                    {
                        switch (stano)
                        {
                            case 1:
                                sihatubutton.Visible = true;
                                break;
                            case 2:
                                break;
                            case 3:
                                st32.Play();
                                break;
                            case 4:
                                st42.Play();
                                break;
                            case 5:
                                st52.Play();
                                break;
                            case 6:
                                st62.Play();
                                break;

                            case 8:
                                st72.Play();
                                break;

                            case 9:
                                st82.Play();
                                break;
                            case 10:
                                if (sasendoor.Checked == true)
                                {
                                    st92L.Play();
                                }
                                else
                                {
                                    st92R.Play();
                                }

                                break;
                            case 11:
                                sihatubutton.Visible = true;
                                st102.Play();
                                break;
                            case 13:
                                St122.Play();
                                break;
                            case 14:
                                if (rapidb.Checked == true)
                                {
                                    St132R.Play();
                                }
                                else
                                {
                                    St132l.Play();
                                }
                                break;
                            case 15:
                                St142.Play();
                                break;
                            case 16:
                                St152.Play();
                                break;
                        }
                    }

                }

            }

            else if (settingno == 3)
            {
                status.Text = "‚½‚¾‚¢‚Ü";
                settingno = 4;
            }
            else
            {
                kirikae();
                settingno = 1;
                setting();
            }
        }
        private async void next_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            setting();
            if (checklcd.Checked == true)
            {
                // await Task.Delay(300);
                Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
                await Task.Delay(100);
                SendKeys.SendWait("{RIGHT}");
                Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
            }



        }

        private void resetb_Click(object sender, EventArgs e)
        {
            isfurusachi = false;
            pass.Visible = false;
            reset();
        }

        private void rapidb_CheckedChanged(object sender, EventArgs e)
        {

            // MessageBox.Show("‚±‚Ì‹@”\‚ÍAŒ»İ‚ÍŠe‰w’âÔ‚Å‚Ì“®ì‚ğ‘O’ñ‚Æ‚µ‚Ä‚¢‚é‚½‚ßA“®ì‚µ‚È‚¢‚©A³‚µ‚­‹@”\‚µ‚È‚¢ê‡‚ª‚ ‚è‚Ü‚·B", "Šm”F", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            pass.Visible = false;
            if (IsReverse == false)
            {
                stano -= 1;
            }
            else if (IsReverse == true)
            {
                stano += 1;
            }



            kirikae();
        }



        private void prevbutton_Click(object sender, EventArgs e)
        {
            if (IsReverse == false)
            {
                stano -= 2;
            }
            else
            {
                stano += 2;
            }
            kirikae();
        }

        private void sasendoor_CheckedChanged(object sender, EventArgs e)
        {
            if (sasendoor.Checked == true)
            {
                sasendoor.Text = "éç ‘I‘ğ:¶";
            }
            else
            {
                sasendoor.Text = "éç ‘I‘ğ:‰E";
            }
        }

        private void sihatubutton_Click(object sender, EventArgs e)
        {
            if (stano >= 11)
            {
                hksihatsu.Play();
            }
            else if (stano >= 8 && stano <= 10)
            {
                tksihatsu.Play();
            }
            else if (stano <= 7)
            {
                tsihatsu.Play();
            }

        }

        private void checklcd_CheckedChanged(object sender, EventArgs e)
        {
            if (checklcd.Checked == true)
            {
                LCDba.Enabled = true;
                LCDbs.Enabled = true;
                LCDbd.Enabled = true;
                LCDbf.Enabled = true;
                LCDbg.Enabled = true;
                LCDbh.Enabled = true;
                LCDbj.Enabled = true;


                lcdnext.Visible = true;
                lcdprev.Visible = true;
            }
            else
            {
                LCDba.Enabled = false;
                LCDbs.Enabled = false;
                LCDbd.Enabled = false;
                LCDbf.Enabled = false;
                LCDbg.Enabled = false;
                LCDbh.Enabled = false;
                LCDbj.Enabled = false;


                lcdnext.Visible = false;
                lcdprev.Visible = false;
            }
        }

        private void lcdnext_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
            SendKeys.SendWait("{RIGHT}");
        }

        private void lcdprev_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
            SendKeys.SendWait("{LEFT}");
        }

        private void for01_Click(object sender, EventArgs e)
        {
            k101();
        }

        private void kawanima_Click(object sender, EventArgs e)
        {
            k102();
        }

        private void sinanima_Click(object sender, EventArgs e)
        {
            k103();
        }

        private void sasenima_Click(object sender, EventArgs e)
        {
            k104();
        }

        private void nimatoma_Click(object sender, EventArgs e)
        {
            k201();
        }
        private void b105_Click(object sender, EventArgs e)
        {
            k105();
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            smenu1.Play();
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            smenu2.Play();
        }

        private async void menu3_Click(object sender, EventArgs e)
        {
            emergency emergency = new emergency();
            smenu3.Play();
            emergency.Show();
            await Task.Delay(10000);
            emergency.Close();
            if (checklcd.Checked == true)
            {
                Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
                SendKeys.SendWait("{RIGHT}");
                Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
                SendKeys.SendWait("{LEFT}");
            }


        }

        private void menu4_Click(object sender, EventArgs e)
        {
            smenu4.Play();
        }

        private void ksetting_Click(object sender, EventArgs e)
        {
            reset();
            sselect.Play();
            keitouno.Enabled = true;
            ksettingok.Enabled = true;
            keitouno.Text = null;
            keitouno.Focus();
        }
        //sæ”Ô†İ’è
        private void ksettingok_Click(object sender, EventArgs e)
        {
            keitouno.Enabled = false;
            ksettingok.Enabled = false;
            switch (keitouno.Text)
            {
                case "101":
                    k101();
                    ks101.Play();
                    break;
                case "102":
                    k102();
                    ks102.Play();
                    break;
                case "103":
                    k103();
                    ks103.Play();
                    break;
                case "104":
                    k104();
                    ks104.Play();
                    break;
                case "105":
                    k105();
                    ks105.Play();
                    break;
                case "106":
                    k106();
                    break;

                case "301":
                    k301();
                    break;

                case "401":
                    k401();
                    break;
                case "402":
                    k402();
                    break;

                case "111":
                    k111();
                    break;
                case "112":
                    k112();
                    break;
                case "113":
                    k113();
                    break;
                case "114":
                    k114();
                    break;
                case "115":
                    k115();
                    break;
                case "116":
                    k116();
                    break;

                case "201":
                    k201();
                    ks201.Play();
                    break;
                case "211":
                    k211();
                    break;

                case "011":
                    k011();
                    break;
                case "012":
                    k012();
                    break;
                case "013":
                    k013();
                    break;
                case "014":
                    k014();
                    break;
                case "015":
                    k015();
                    break;
                case "016":
                    k016();
                    break;
                case "021":
                    k021();
                    break;
                default:
                    reset();
                    break;
            }
        }

        private void keitouno_KeyUp(object sender, KeyEventArgs e)
        {
            pi.Play();
        }
        private async void keitouno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ksettingok.Focus();
                await Task.Delay(500);
                next.Focus();
            }
        }

        private void playhousou_Click(object sender, EventArgs e)
        {
            if (settingno == 2)
            {
                if (IsReverse == false)
                {
                    switch (stano)
                    {
                        case 2:
                            st21.Play();
                            sihatubutton.Visible = false;
                            break;
                        case 3:
                            st31.Play();
                            break;
                        case 4:
                            st41.Play();
                            break;
                        case 5:
                            st51.Play();
                            break;
                        case 6:
                            st61.Play();
                            break;


                        case 8:
                            st71.Play();
                            break;
                        case 9:
                            sihatubutton.Visible = false;
                            st81.Play();
                            break;
                        case 10:
                            st91.Play();
                            break;
                        case 11:
                            st101.Play();
                            break;
                        case 12:
                            if (rapidb.Checked == true)
                            {
                                St111R.Play();
                            }
                            else
                            {
                                St111l.Play();
                            }
                            break;

                        case 13:
                            St121.Play();
                            break;
                        case 14:
                            St131.Play();
                            break;
                        case 15:
                            St141.Play();
                            break;
                        case 16:
                            St151.Play();
                            break;


                    }
                }
            }
            else if (settingno == 3)
            {
                if (IsReverse == false)
                {
                    switch (stano)
                    {
                        case 1:
                            sihatubutton.Visible = true;
                            break;
                        case 2:
                            break;
                        case 3:
                            st32.Play();
                            break;
                        case 4:
                            st42.Play();
                            break;
                        case 5:
                            st52.Play();
                            break;
                        case 6:
                            st62.Play();
                            break;
                        case 8:
                            st72.Play();
                            break;

                        case 9:
                            st82.Play();
                            break;
                        case 10:
                            if (sasendoor.Checked == true)
                            {
                                st92L.Play();
                            }
                            else
                            {
                                st92R.Play();
                            }
                            break;
                        case 11:
                            st102.Play();
                            break;
                        case 13:
                            St122.Play();
                            break;
                        case 14:
                            if (rapidb.Checked == true)
                            {
                                St132R.Play();
                            }
                            else
                            {
                                St132l.Play();
                            }
                            break;
                        case 15:
                            St142.Play();
                            break;
                        case 16:
                            St152.Play();
                            break;
                    }
                }
            }
        }

        private void stasetb_Click(object sender, EventArgs e)
        {
            if (stachange.Text != null)
            {
                if (IsReverse == true)
                {
                    stano = Int32.Parse(stachange.Text) + 1;

                }
                else
                {
                    stano = Int32.Parse(stachange.Text) - 1;
                }
                settingno = 3;
                kirikae();
                stachange.Text = null;

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private async void next_KeyDown(object sender, KeyEventArgs e)
        //ƒeƒ“ƒL[‚Å‚Ì‘€ì‘O’ñBƒVƒ‡[ƒgƒJƒbƒgƒL[“I‚È‹@”\
        {
            if (e.KeyCode == Keys.Multiply)
            {
                stachange.Focus();
                stachange.Text = null;
            }
            if (e.KeyCode == Keys.Divide)
            {
                reset();
            }

            if (e.KeyCode == Keys.Add)
            {
                if (checklcd.Checked == true)
                {
                    Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
                    await Task.Delay(300);
                    SendKeys.SendWait("{RIGHT}");
                    await Task.Delay(300);
                    Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
                }
            }
            if (e.KeyCode == Keys.Subtract)
            {
                if (checklcd.Checked == true)
                {
                    Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
                    await Task.Delay(300);
                    SendKeys.SendWait("{LEFT}");
                    await Task.Delay(300);
                    Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
                }
            }

        }


        private async void stachange_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //ƒ}ƒ‹ƒQƒŠ[ƒ^ƒR[ƒhB‚±‚±‰½‚Æ‚©‚µ‚½‚¢
                if (stachange.Text != null)
                {
                    if (IsReverse)
                    {
                        stano = Int32.Parse(stachange.Text) + 1;

                    }
                    else
                    {
                        stano = Int32.Parse(stachange.Text) - 1;
                    }
                    settingno = 3;
                    kirikae();

                }

                await Task.Delay(200);
                next.Focus();
            }
        }

        private void b106_Click(object sender, EventArgs e)
        {
            k106();
        }

        private async void LCDba_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
            await Task.Delay(300);
            SendKeys.SendWait("a");
            await Task.Delay(300);
            Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
        }

        private async void LCDbs_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
            await Task.Delay(300);
            SendKeys.SendWait("{s}");
            await Task.Delay(300);
            Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
        }

        private async void LCDbg_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
            await Task.Delay(300);
            SendKeys.SendWait("{g}");
            await Task.Delay(300);
            Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
        }

        private async void LCDbd_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
            await Task.Delay(300);
            SendKeys.SendWait("{d}");
            await Task.Delay(300);
            Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
        }

        private async void LCDbf_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
            await Task.Delay(300);
            SendKeys.SendWait("{f}");
            await Task.Delay(300);
            Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
        }

        private async void LCDbh_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
            await Task.Delay(300);
            SendKeys.SendWait("{h}");
            await Task.Delay(300);
            Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
        }

        private async void LCDbj_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
            await Task.Delay(300);
            SendKeys.SendWait("{j}");
            await Task.Delay(300);
            Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
        }
    }
}
