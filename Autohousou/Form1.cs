using System.Media;
using System.Runtime.InteropServices;
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
        //����
        //�ϓ�
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

        System.Media.SoundPlayer st111 = new SoundPlayer(Properties.Resources.s111);
        /*
        System.Media.SoundPlayer st121 = new SoundPlayer(Properties.Resources.s121);
        System.Media.SoundPlayer st131 = new SoundPlayer(Properties.Resources.s131);
        System.Media.SoundPlayer st141 = new SoundPlayer(Properties.Resources.s141);
        */

        System.Media.SoundPlayer tksihatsu = new SoundPlayer(Properties.Resources.sihatsu);
        System.Media.SoundPlayer tsihatsu = new SoundPlayer(Properties.Resources.tsihatsu);

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
            stano = 6;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k104()
        {
            fortext.Text = sasenima.Text;
            IsReverse = false;
            stano = 8;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k105()
        {
            fortext.Text = "��� -> ���";
            IsReverse = false;
            stano = 9;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k111()
        {
            stano = 0;
            fortext.Text = for01.Text;
            IsReverse = false;
            kirikae();
            sihatubutton.Visible = true;
            rapidb.Checked = true;
        }

        void k201()
        {
            fortext.Text = nimatoma.Text;
            IsReverse = true;
            stano = 19;
            kirikae();
            sihatubutton.Visible = true;
        }
        void kaisou()
        {
            fortext.Text = "��";
            IsReverse = false;
            stano = -2;
            kirikae();
            sihatubutton.Visible = false;
        }

        void k011()
        {
            stano = 0;
            fortext.Text = "��";
            IsReverse = false;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k012()
        {
            fortext.Text = "��";
            IsReverse = false;
            stano = 3;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k013()
        {
            fortext.Text = "��";
            IsReverse = false;
            stano = 6;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k014()
        {
            fortext.Text = "��";
            IsReverse = false;
            stano = 8;
            kirikae();
            sihatubutton.Visible = true;
        }
        void k015()
        {
            fortext.Text = "��";
            IsReverse = false;
            stano = 9;
            kirikae();
            sihatubutton.Visible = true;
        }

        void k021()
        {
            fortext.Text = "��";
            IsReverse = true;
            stano = 19;
            kirikae();
            sihatubutton.Visible = true;
        }

        public Form1()
        {
            InitializeComponent();


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
            if (IsReverse == false)
            {
                switch (stano)
                {
                    case 1://�ϒ�

                        station.Text = "�ϒ��E�ɉ؊X";
                        nextsta.Text = "�Ƃ܂Ƃ݂炢";
                        debug.Text = stano.ToString();
                        break;
                    case 2://�Ƃ܂݂�
                        station.Text = "�Ƃ܂Ƃ݂炢";
                        if (rapidb.Checked == true)
                        {
                            nextsta.Text = "�ϐ�";
                            pass.Visible = true;
                        }
                        else
                        {
                            nextsta.Text = "�V�R�c";
                        }
                        debug.Text = stano.ToString();
                        break;
                    case 3://�V�R
                        pass.Visible = false;
                        if (rapidb.Checked == true)
                        {
                            kirikae();
                        }
                        else
                        {
                            station.Text = "�V�R�c";
                            nextsta.Text = "�ϐ�";
                            debug.Text = stano.ToString();
                        }
                        break;
                    case 4://�ϐ�
                        station.Text = "�ϐ�";
                        if (rapidb.Checked == true)
                        {
                            nextsta.Text = "�ϖ�";
                            pass.Visible = true;
                        }
                        else
                        {
                            nextsta.Text = "�ϓV��";

                        }
                        debug.Text = stano.ToString();
                        break;
                    case 5://�ϓV
                        pass.Visible = false;
                        if (rapidb.Checked == true)
                        {
                            kirikae();
                        }
                        else
                        {
                            station.Text = "�ϓV��";
                            nextsta.Text = "�ϖ�";
                            debug.Text = stano.ToString();
                        }
                        break;
                    case 6://�ϖ�
                        pass.Visible = false;

                        station.Text = "�ϖ�";
                        nextsta.Text = "�i��";
                        debug.Text = stano.ToString();
                        break;
                    case 7://�i��
                        pass.Visible = false;
                        station.Text = "�i��";
                        if (rapidb.Checked == true)
                        {
                            nextsta.Text = "���";
                            pass.Visible = true;
                        }
                        else
                        {
                            nextsta.Text = "���";
                            debug.Text = stano.ToString();
                        }
                        sihatubutton.Visible = true;
                        break;
                    case 8://���
                        pass.Visible = false;
                        if (rapidb.Checked == true)
                        {
                            kirikae();
                        }
                        else
                        {
                            station.Text = "���";
                            nextsta.Text = "���";
                            debug.Text = stano.ToString();
                        }
                        break;
                    case 9://���
                        pass.Visible = false;
                        station.Text = "���";
                        nextsta.Text = "���";
                        debug.Text = stano.ToString();
                        break;
                    case 10:
                        pass.Visible = false;
                        station.Text = "���";
                        nextsta.Text = "���_�J";
                        debug.Text = stano.ToString();

                        break;
                    case 11:
                        pass.Visible = false;
                        station.Text = "���_�J";
                        if (rapidb.Checked == true)
                        {
                            nextsta.Text = "�k�g�t";
                            pass.Visible = true;
                        }
                        else
                        {
                            nextsta.Text = "�Օ�";
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
                            station.Text = "�Օ�";
                            nextsta.Text = "�k�g�t";
                            debug.Text = stano.ToString();
                        }
                        debug.Text = stano.ToString();

                        break;
                    case 13:
                        pass.Visible = false;
                        station.Text = "�k�g�t";
                        if (rapidb.Checked == true)
                        {
                            nextsta.Text = "�V���_";
                            pass.Visible = true;
                        }
                        else
                        {
                            nextsta.Text = "����";
                        }

                        debug.Text = stano.ToString();

                        break;
                    case 14:
                        pass.Visible = false;
                        if (rapidb.Checked == true)
                        {
                            kirikae();
                        }
                        else
                        {
                            station.Text = "����";
                            nextsta.Text = "�V���_";
                        }

                        debug.Text = stano.ToString();

                        break;
                    case 15:

                        station.Text = "�V���_";
                        nextsta.Text = "���_";
                        pass.Visible = true;
                        debug.Text = stano.ToString();

                        break;
                    case 16:

                        station.Text = "���_";
                        nextsta.Text = "�H��";
                        pass.Visible = false;
                        debug.Text = stano.ToString();

                        break;
                    case 17:

                        station.Text = "�H��";
                        nextsta.Text = "��^";
                        pass.Visible = true;
                        debug.Text = stano.ToString();

                        break;
                    case 18:
                        station.Text = "���";
                        nextsta.Text = "�I�_";
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
                    case 1://�ϒ�

                        station.Text = "�ϒ��E�ɉ؊X";
                        nextsta.Text = "";
                        debug.Text = stano.ToString();
                        break;
                    case 2://�Ƃ܂݂�
                        station.Text = "�Ƃ܂Ƃ݂炢";
                        nextsta.Text = "�ϒ��E�ɉ؊X";
                        debug.Text = stano.ToString();
                        break;
                    case 3://�V�R
                        pass.Visible = false;
                        if (rapidb.Checked == true)
                        {
                            kirikae();
                        }
                        else
                        {
                            station.Text = "�V�R�c";
                            nextsta.Text = "�Ƃ܂Ƃ݂炢";
                            debug.Text = stano.ToString();
                        }
                        break;
                    case 4://�ϐ�
                        station.Text = "�ϐ�";
                        if (rapidb.Checked == true)
                        {
                            nextsta.Text = "�ϐ�";
                            pass.Visible = true;
                        }
                        else
                        {
                            nextsta.Text = "�V�R�c";
                        }

                        debug.Text = stano.ToString();
                        break;
                    case 5://�ϓV
                        pass.Visible = false;
                        if (rapidb.Checked == true)
                        {
                            kirikae();
                        }
                        else
                        {
                            station.Text = "�ϓV��";
                            nextsta.Text = "�ϐ�";
                            debug.Text = stano.ToString();
                        }
                        break;
                    case 6://�ϖ�
                        pass.Visible = false;

                        station.Text = "�ϖ�";
                        nextsta.Text = "�ϓV��";
                        debug.Text = stano.ToString();
                        break;
                    case 7://�i��
                        pass.Visible = false;
                        station.Text = "�i��";
                        nextsta.Text = "�ϖ�";
                        sihatubutton.Visible = true;
                        break;
                    case 8://���
                        pass.Visible = false;
                        if (rapidb.Checked == true)
                        {
                            kirikae();
                        }
                        else
                        {
                            station.Text = "���";
                            nextsta.Text = "�i��";
                            debug.Text = stano.ToString();
                        }
                        break;
                    case 9://���
                        pass.Visible = false;
                        station.Text = "���";
                        nextsta.Text = "���";
                        debug.Text = stano.ToString();
                        break;
                    case 10:
                        pass.Visible = false;
                        station.Text = "���";
                        nextsta.Text = "���";
                        debug.Text = stano.ToString();

                        break;
                    case 11:
                        pass.Visible = false;
                        station.Text = "���_�J";
                        nextsta.Text = "���";
                        debug.Text = stano.ToString();

                        break;
                    case 12:
                        pass.Visible = false;
                        station.Text = "�Օ�";
                        nextsta.Text = "���_�J";
                        debug.Text = stano.ToString();

                        break;
                    case 13:
                        pass.Visible = false;
                        station.Text = "�k�g�t";
                        nextsta.Text = "�Օ�";
                        debug.Text = stano.ToString();

                        break;
                    case 14:
                        pass.Visible = false;
                        station.Text = "����";
                        nextsta.Text = "�k�g�t";
                        debug.Text = stano.ToString();

                        break;
                    case 15:

                        station.Text = "�V���_";
                        nextsta.Text = "����";
                        pass.Visible = true;
                        debug.Text = stano.ToString();

                        break;
                    case 16:

                        station.Text = "���_";
                        nextsta.Text = "�V���_";
                        pass.Visible = false;
                        debug.Text = stano.ToString();

                        break;
                    case 17:

                        station.Text = "�H��";
                        nextsta.Text = "���_";
                        pass.Visible = true;
                        debug.Text = stano.ToString();

                        break;
                    case 18:
                        station.Text = "���";
                        nextsta.Text = "�H��";
                        pass.Visible = false;
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
        void reset()
        {
            stano = 0;
            station.Text = "������";
            nextsta.Text = "������";
            debug.Text = stano.ToString();
            fortext.Text = "���ݒ�";
            settingno = 3;
            setting();
            rapidb.Checked = false;

        }
        async void setting()
        {
            if (settingno == 1)
            {
                status.Text = "����";
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
                            case 7:
                                st71.Play();
                                break;
                            case 8:
                                sihatubutton.Visible = false;
                                st81.Play();
                                break;
                            case 9:
                                st91.Play();
                                break;
                            case 10:
                                st101.Play();
                                break;
                            case 11:
                                st111.Play();
                                break;
                        }
                    }
                }


            }
            else if (settingno == 2)
            {

                status.Text = "�܂��Ȃ�";
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
                            case 7:
                                st72.Play();
                                break;

                            case 8:
                                st82.Play();
                                break;
                            case 9:
                                if (sasendoor.Checked == true)
                                {
                                    st92L.Play();
                                }
                                else
                                {
                                    st92R.Play();
                                }

                                break;
                            case 10:
                                st102.Play();
                                break;
                        }
                    }

                }

            }

            else if (settingno == 3)
            {
                status.Text = "��������";
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
            await Task.Delay(400);
            setting();
            if (checklcd.Checked == true)
            {
                await Task.Delay(400);
                Microsoft.VisualBasic.Interaction.AppActivate("lcdMaker");
                SendKeys.SendWait("{RIGHT}");
                Microsoft.VisualBasic.Interaction.AppActivate(this.Text);
            }



        }

        private void resetb_Click(object sender, EventArgs e)
        {
            pass.Visible = false;
            reset();
        }

        private void rapidb_CheckedChanged(object sender, EventArgs e)
        {

            // MessageBox.Show("���̋@�\�́A���݂͊e�w��Ԃł̓����O��Ƃ��Ă��邽�߁A���삵�Ȃ����A�������@�\���Ȃ��ꍇ������܂��B", "�m�F", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            pass.Visible = false;
            stano -= 1;
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
                sasendoor.Text = "��� �I��:��";
            }
            else
            {
                sasendoor.Text = "��� �I��:�E";
            }
        }

        private void sihatubutton_Click(object sender, EventArgs e)
        {
            if (stano >= 7)
            {
                tksihatsu.Play();
            }
            else if (stano <= 6)
            {
                tsihatsu.Play();
            }

        }

        private void checklcd_CheckedChanged(object sender, EventArgs e)
        {
            if (checklcd.Checked == true)
            {
                lcdnext.Visible = true;
                lcdprev.Visible = true;
            }
            else
            {
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
            if(checklcd.Checked == true)
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
        }
        //�s��ԍ��ݒ�
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
                case "111":
                    k111();
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
                case "201":
                    k201();
                    ks201.Play();
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
                        case 7:
                            st71.Play();
                            break;
                        case 8:
                            sihatubutton.Visible = false;
                            st81.Play();
                            break;
                        case 9:
                            st91.Play();
                            break;
                        case 10:
                            st101.Play();
                            break;
                        case 11:
                            st111.Play();
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
                        case 7:
                            st72.Play();
                            break;

                        case 8:
                            st82.Play();
                            break;
                        case 9:
                            if (sasendoor.Checked == true)
                            {
                                st92L.Play();
                            }
                            else
                            {
                                st92R.Play();
                            }
                            break;
                        case 10:
                            st102.Play();
                            break;
                    }
                }
            }
        }

        
    }
}
