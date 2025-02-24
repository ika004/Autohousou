namespace Autohousou
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            status = new Label();
            station = new Label();
            next = new Button();
            prevbutton = new Button();
            resetb = new Button();
            label1 = new Label();
            nextsta = new Label();
            label2 = new Label();
            rapidb = new CheckBox();
            for01 = new Button();
            label3 = new Label();
            fortext = new Label();
            label4 = new Label();
            debug = new Label();
            pass = new Label();
            checklcd = new CheckBox();
            label5 = new Label();
            sasendoor = new CheckBox();
            sihatubutton = new Button();
            lcdprev = new Button();
            lcdnext = new Button();
            kawanima = new Button();
            sinanima = new Button();
            sasenima = new Button();
            nimatoma = new Button();
            label6 = new Label();
            menu1 = new Button();
            menu3 = new Button();
            menu2 = new Button();
            menu4 = new Button();
            ksetting = new Button();
            ksettingok = new Button();
            keitouno = new TextBox();
            label7 = new Label();
            annocheck = new CheckBox();
            playhousou = new Button();
            button1 = new Button();
            button2 = new Button();
            b105 = new Button();
            b106 = new Button();
            label8 = new Label();
            stachange = new TextBox();
            stasetb = new Button();
            SuspendLayout();
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            status.Location = new Point(132, 40);
            status.Name = "status";
            status.Size = new Size(82, 30);
            status.TabIndex = 0;
            status.Text = "ただいま";
            // 
            // station
            // 
            station.AutoSize = true;
            station.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            station.Location = new Point(188, 70);
            station.Name = "station";
            station.Size = new Size(79, 30);
            station.TabIndex = 1;
            station.Text = "準備中";
            // 
            // next
            // 
            next.Location = new Point(742, 282);
            next.Name = "next";
            next.Size = new Size(249, 213);
            next.TabIndex = 2;
            next.Text = "放送送り";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            next.KeyDown += next_KeyDown;
            // 
            // prevbutton
            // 
            prevbutton.Location = new Point(626, 396);
            prevbutton.Name = "prevbutton";
            prevbutton.Size = new Size(110, 99);
            prevbutton.TabIndex = 3;
            prevbutton.Text = "戻";
            prevbutton.UseVisualStyleBackColor = true;
            prevbutton.Click += prevbutton_Click;
            // 
            // resetb
            // 
            resetb.BackColor = Color.Red;
            resetb.Location = new Point(626, 282);
            resetb.Name = "resetb";
            resetb.Size = new Size(110, 108);
            resetb.TabIndex = 4;
            resetb.Text = "リセット";
            resetb.UseVisualStyleBackColor = false;
            resetb.Click += resetb_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(359, 40);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 5;
            label1.Text = "次停車駅";
            // 
            // nextsta
            // 
            nextsta.AutoSize = true;
            nextsta.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nextsta.Location = new Point(427, 70);
            nextsta.Name = "nextsta";
            nextsta.Size = new Size(79, 30);
            nextsta.TabIndex = 6;
            nextsta.Text = "準備中";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "停車駅選択";
            // 
            // rapidb
            // 
            rapidb.AutoSize = true;
            rapidb.Location = new Point(98, 166);
            rapidb.Name = "rapidb";
            rapidb.Size = new Size(74, 19);
            rapidb.TabIndex = 8;
            rapidb.Text = "快速運用";
            rapidb.UseVisualStyleBackColor = true;
            rapidb.CheckedChanged += rapidb_CheckedChanged;
            // 
            // for01
            // 
            for01.Location = new Point(12, 192);
            for01.Name = "for01";
            for01.Size = new Size(118, 46);
            for01.TabIndex = 9;
            for01.Text = "苫町->二間";
            for01.UseVisualStyleBackColor = true;
            for01.Click += for01_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 192);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 10;
            label3.Text = "現在設定中の運用";
            // 
            // fortext
            // 
            fortext.AutoSize = true;
            fortext.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            fortext.Location = new Point(317, 207);
            fortext.Name = "fortext";
            fortext.Size = new Size(79, 30);
            fortext.TabIndex = 11;
            fortext.Text = "未設定";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(819, 234);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "駅番号";
            // 
            // debug
            // 
            debug.AutoSize = true;
            debug.Location = new Point(868, 234);
            debug.Name = "debug";
            debug.Size = new Size(0, 15);
            debug.TabIndex = 13;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            pass.ForeColor = Color.Red;
            pass.Location = new Point(427, 100);
            pass.Name = "pass";
            pass.Size = new Size(123, 30);
            pass.TabIndex = 14;
            pass.Text = "通過駅注意";
            pass.Visible = false;
            // 
            // checklcd
            // 
            checklcd.AutoSize = true;
            checklcd.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checklcd.Location = new Point(742, 257);
            checklcd.Name = "checklcd";
            checklcd.Size = new Size(106, 25);
            checklcd.TabIndex = 15;
            checklcd.Text = "LCD起動？";
            checklcd.UseVisualStyleBackColor = true;
            checklcd.CheckedChanged += checklcd_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(523, 282);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 16;
            label5.Text = "扉開方向選択";
            // 
            // sasendoor
            // 
            sasendoor.AutoSize = true;
            sasendoor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sasendoor.Location = new Point(505, 300);
            sasendoor.Name = "sasendoor";
            sasendoor.Size = new Size(116, 25);
            sasendoor.TabIndex = 17;
            sasendoor.Text = "埼千 選択:右";
            sasendoor.UseVisualStyleBackColor = true;
            sasendoor.CheckedChanged += sasendoor_CheckedChanged;
            // 
            // sihatubutton
            // 
            sihatubutton.Location = new Point(510, 396);
            sihatubutton.Name = "sihatubutton";
            sihatubutton.Size = new Size(110, 99);
            sihatubutton.TabIndex = 18;
            sihatubutton.Text = "始発放送再生";
            sihatubutton.UseVisualStyleBackColor = true;
            sihatubutton.Visible = false;
            sihatubutton.Click += sihatubutton_Click;
            // 
            // lcdprev
            // 
            lcdprev.Location = new Point(422, 454);
            lcdprev.Name = "lcdprev";
            lcdprev.Size = new Size(82, 41);
            lcdprev.TabIndex = 19;
            lcdprev.Text = "LCD表示戻";
            lcdprev.UseVisualStyleBackColor = true;
            lcdprev.Visible = false;
            lcdprev.Click += lcdprev_Click;
            // 
            // lcdnext
            // 
            lcdnext.Location = new Point(422, 396);
            lcdnext.Name = "lcdnext";
            lcdnext.Size = new Size(82, 52);
            lcdnext.TabIndex = 20;
            lcdnext.Text = "LCD表示送り(通過)";
            lcdnext.UseVisualStyleBackColor = true;
            lcdnext.Visible = false;
            lcdnext.Click += lcdnext_Click;
            // 
            // kawanima
            // 
            kawanima.Location = new Point(12, 241);
            kawanima.Name = "kawanima";
            kawanima.Size = new Size(118, 46);
            kawanima.TabIndex = 21;
            kawanima.Text = "苫川->二間";
            kawanima.UseVisualStyleBackColor = true;
            kawanima.Click += kawanima_Click;
            // 
            // sinanima
            // 
            sinanima.Location = new Point(12, 293);
            sinanima.Name = "sinanima";
            sinanima.Size = new Size(118, 46);
            sinanima.TabIndex = 22;
            sinanima.Text = "品川->二間";
            sinanima.UseVisualStyleBackColor = true;
            sinanima.Click += sinanima_Click;
            // 
            // sasenima
            // 
            sasenima.Location = new Point(12, 345);
            sasenima.Name = "sasenima";
            sasenima.Size = new Size(118, 46);
            sasenima.TabIndex = 23;
            sasenima.Text = "埼千->二間";
            sasenima.UseVisualStyleBackColor = true;
            sasenima.Click += sasenima_Click;
            // 
            // nimatoma
            // 
            nimatoma.Location = new Point(135, 192);
            nimatoma.Name = "nimatoma";
            nimatoma.Size = new Size(118, 46);
            nimatoma.TabIndex = 24;
            nimatoma.Text = "二間->苫町";
            nimatoma.UseVisualStyleBackColor = true;
            nimatoma.Click += nimatoma_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(829, 7);
            label6.Name = "label6";
            label6.Size = new Size(117, 30);
            label6.TabIndex = 25;
            label6.Text = "メニュー放送";
            // 
            // menu1
            // 
            menu1.Location = new Point(853, 40);
            menu1.Name = "menu1";
            menu1.Size = new Size(66, 46);
            menu1.TabIndex = 26;
            menu1.Text = "待ち合わせ";
            menu1.UseVisualStyleBackColor = true;
            menu1.Click += menu1_Click;
            // 
            // menu3
            // 
            menu3.ForeColor = Color.Red;
            menu3.Location = new Point(853, 92);
            menu3.Name = "menu3";
            menu3.Size = new Size(66, 46);
            menu3.TabIndex = 27;
            menu3.Text = "急停車";
            menu3.UseVisualStyleBackColor = true;
            menu3.Click += menu3_Click;
            // 
            // menu2
            // 
            menu2.Location = new Point(925, 40);
            menu2.Name = "menu2";
            menu2.Size = new Size(66, 46);
            menu2.TabIndex = 28;
            menu2.Text = "停止信号";
            menu2.UseVisualStyleBackColor = true;
            menu2.Click += menu2_Click;
            // 
            // menu4
            // 
            menu4.Location = new Point(925, 92);
            menu4.Name = "menu4";
            menu4.Size = new Size(66, 46);
            menu4.TabIndex = 29;
            menu4.Text = "運転見合わせ";
            menu4.UseVisualStyleBackColor = true;
            menu4.Click += menu4_Click;
            // 
            // ksetting
            // 
            ksetting.Location = new Point(253, 449);
            ksetting.Name = "ksetting";
            ksetting.Size = new Size(81, 46);
            ksetting.TabIndex = 30;
            ksetting.Text = "系統設定";
            ksetting.UseVisualStyleBackColor = true;
            ksetting.Click += ksetting_Click;
            // 
            // ksettingok
            // 
            ksettingok.Enabled = false;
            ksettingok.Location = new Point(340, 449);
            ksettingok.Name = "ksettingok";
            ksettingok.Size = new Size(76, 46);
            ksettingok.TabIndex = 41;
            ksettingok.Text = "設定";
            ksettingok.UseVisualStyleBackColor = true;
            ksettingok.Click += ksettingok_Click;
            // 
            // keitouno
            // 
            keitouno.CharacterCasing = CharacterCasing.Lower;
            keitouno.Enabled = false;
            keitouno.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            keitouno.Location = new Point(253, 416);
            keitouno.MaxLength = 3;
            keitouno.Name = "keitouno";
            keitouno.Size = new Size(163, 27);
            keitouno.TabIndex = 42;
            keitouno.TextAlign = HorizontalAlignment.Center;
            keitouno.KeyUp += keitouno_KeyUp;
            keitouno.PreviewKeyDown += keitouno_PreviewKeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 398);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 43;
            label7.Text = "系統番号";
            // 
            // annocheck
            // 
            annocheck.AutoSize = true;
            annocheck.Checked = true;
            annocheck.CheckState = CheckState.Checked;
            annocheck.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            annocheck.Location = new Point(854, 257);
            annocheck.Name = "annocheck";
            annocheck.Size = new Size(93, 25);
            annocheck.TabIndex = 44;
            annocheck.Text = "放送再生";
            annocheck.UseVisualStyleBackColor = true;
            // 
            // playhousou
            // 
            playhousou.Location = new Point(945, 234);
            playhousou.Name = "playhousou";
            playhousou.Size = new Size(46, 44);
            playhousou.TabIndex = 45;
            playhousou.Text = "放送再生";
            playhousou.UseVisualStyleBackColor = true;
            playhousou.Click += playhousou_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(781, 40);
            button1.Name = "button1";
            button1.Size = new Size(66, 46);
            button1.TabIndex = 46;
            button1.Text = "b1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(781, 92);
            button2.Name = "button2";
            button2.Size = new Size(66, 46);
            button2.TabIndex = 47;
            button2.Text = "b2";
            button2.UseVisualStyleBackColor = true;
            // 
            // b105
            // 
            b105.Location = new Point(12, 397);
            b105.Name = "b105";
            b105.Size = new Size(118, 46);
            b105.TabIndex = 48;
            b105.Text = "岩金->二間";
            b105.UseVisualStyleBackColor = true;
            b105.Click += b105_Click;
            // 
            // b106
            // 
            b106.Location = new Point(12, 449);
            b106.Name = "b106";
            b106.Size = new Size(118, 46);
            b106.TabIndex = 49;
            b106.Text = "新夢->二間";
            b106.UseVisualStyleBackColor = true;
            b106.Click += b106_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(931, 141);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 53;
            label8.Text = "位置変更";
            // 
            // stachange
            // 
            stachange.CharacterCasing = CharacterCasing.Lower;
            stachange.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            stachange.Location = new Point(925, 158);
            stachange.MaxLength = 3;
            stachange.Name = "stachange";
            stachange.Size = new Size(66, 27);
            stachange.TabIndex = 52;
            stachange.TextAlign = HorizontalAlignment.Center;
            stachange.KeyDown += stachange_KeyDown;
            // 
            // stasetb
            // 
            stasetb.Location = new Point(925, 187);
            stasetb.Name = "stasetb";
            stasetb.Size = new Size(66, 24);
            stasetb.TabIndex = 51;
            stasetb.Text = "設定";
            stasetb.UseVisualStyleBackColor = true;
            stasetb.Click += stasetb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 504);
            Controls.Add(label8);
            Controls.Add(stachange);
            Controls.Add(stasetb);
            Controls.Add(b106);
            Controls.Add(b105);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(playhousou);
            Controls.Add(annocheck);
            Controls.Add(label7);
            Controls.Add(keitouno);
            Controls.Add(ksettingok);
            Controls.Add(ksetting);
            Controls.Add(menu4);
            Controls.Add(menu2);
            Controls.Add(menu3);
            Controls.Add(menu1);
            Controls.Add(label6);
            Controls.Add(nimatoma);
            Controls.Add(sasenima);
            Controls.Add(sinanima);
            Controls.Add(kawanima);
            Controls.Add(lcdnext);
            Controls.Add(lcdprev);
            Controls.Add(sihatubutton);
            Controls.Add(sasendoor);
            Controls.Add(label5);
            Controls.Add(checklcd);
            Controls.Add(pass);
            Controls.Add(debug);
            Controls.Add(label4);
            Controls.Add(fortext);
            Controls.Add(label3);
            Controls.Add(for01);
            Controls.Add(rapidb);
            Controls.Add(label2);
            Controls.Add(nextsta);
            Controls.Add(label1);
            Controls.Add(resetb);
            Controls.Add(prevbutton);
            Controls.Add(next);
            Controls.Add(station);
            Controls.Add(status);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "制御盤 Ver.Beta0.6";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label status;
        private Label station;
        private Button next;
        private Button prevbutton;
        private Button resetb;
        private Label label1;
        private Label nextsta;
        private Label label2;
        private CheckBox rapidb;
        private Button for01;
        private Label label3;
        private Label fortext;
        private Label label4;
        private Label debug;
        private Label pass;
        private CheckBox checklcd;
        private Label label5;
        private CheckBox sasendoor;
        private Button sihatubutton;
        private Button lcdprev;
        private Button lcdnext;
        private Button kawanima;
        private Button sinanima;
        private Button sasenima;
        private Button nimatoma;
        private Label label6;
        private Button menu1;
        private Button menu3;
        private Button menu2;
        private Button menu4;
        private Button ksetting;
        private Button ksettingok;
        private TextBox keitouno;
        private Label label7;
        private CheckBox annocheck;
        private Button playhousou;
        private Button button1;
        private Button button2;
        private Button b105;
        private Button b106;
        private Label label8;
        private TextBox stachange;
        private Button stasetb;
    }
}
