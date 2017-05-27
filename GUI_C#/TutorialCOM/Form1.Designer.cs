using System;

namespace SterowanieOswietleniem
{
    partial class SterowanieOswietleniem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Awaryjne = new System.Windows.Forms.Button();
            this.TrybAuto = new System.Windows.Forms.Button();
            this.ptSwiatlo = new System.Windows.Forms.PictureBox();
            this.ltSwiatlo = new System.Windows.Forms.PictureBox();
            this.ptKierunkowskaz = new System.Windows.Forms.PictureBox();
            this.ltKierunkowskaz = new System.Windows.Forms.PictureBox();
            this.ppKierunkowskaz = new System.Windows.Forms.PictureBox();
            this.lpKierunkowskaz = new System.Windows.Forms.PictureBox();
            this.ppSwiatlo = new System.Windows.Forms.PictureBox();
            this.lpSwiatlo = new System.Windows.Forms.PictureBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Terminal = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.butClear = new System.Windows.Forms.Button();
            this.butSend = new System.Windows.Forms.Button();
            this.numericSend = new System.Windows.Forms.NumericUpDown();
            this.rtbTerminal = new System.Windows.Forms.RichTextBox();
            this.Opcje = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butRefresh = new System.Windows.Forms.Button();
            this.butDomyslne = new System.Windows.Forms.Button();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.miganieKierunkowskazu = new System.Windows.Forms.Timer(this.components);
            this.miganieKierunkowskazu2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSwiatlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltSwiatlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptKierunkowskaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltKierunkowskaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppKierunkowskaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpKierunkowskaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppSwiatlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpSwiatlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.Terminal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSend)).BeginInit();
            this.Opcje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Terminal);
            this.tabControl1.Controls.Add(this.Opcje);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::TutorialCOM.Properties.Resources.full1;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.Awaryjne);
            this.tabPage2.Controls.Add(this.TrybAuto);
            this.tabPage2.Controls.Add(this.ptSwiatlo);
            this.tabPage2.Controls.Add(this.ltSwiatlo);
            this.tabPage2.Controls.Add(this.ptKierunkowskaz);
            this.tabPage2.Controls.Add(this.ltKierunkowskaz);
            this.tabPage2.Controls.Add(this.ppKierunkowskaz);
            this.tabPage2.Controls.Add(this.lpKierunkowskaz);
            this.tabPage2.Controls.Add(this.ppSwiatlo);
            this.tabPage2.Controls.Add(this.lpSwiatlo);
            this.tabPage2.Controls.Add(this.labStatus);
            this.tabPage2.Controls.Add(this.pbStatus);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(586, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sterowanie";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Awaryjne
            // 
            this.Awaryjne.Location = new System.Drawing.Point(396, 301);
            this.Awaryjne.Name = "Awaryjne";
            this.Awaryjne.Size = new System.Drawing.Size(177, 77);
            this.Awaryjne.TabIndex = 18;
            this.Awaryjne.Text = "Awaryjne";
            this.Awaryjne.UseVisualStyleBackColor = true;
            this.Awaryjne.Click += new System.EventHandler(this.Awaryjne_Click);
            // 
            // TrybAuto
            // 
            this.TrybAuto.Location = new System.Drawing.Point(396, 66);
            this.TrybAuto.Name = "TrybAuto";
            this.TrybAuto.Size = new System.Drawing.Size(177, 77);
            this.TrybAuto.TabIndex = 17;
            this.TrybAuto.Text = "Tryb automatyczny";
            this.TrybAuto.UseVisualStyleBackColor = true;
            this.TrybAuto.Click += new System.EventHandler(this.TrybAuto_Click);
            // 
            // ptSwiatlo
            // 
            this.ptSwiatlo.BackColor = System.Drawing.Color.Gray;
            this.ptSwiatlo.Location = new System.Drawing.Point(310, 412);
            this.ptSwiatlo.Name = "ptSwiatlo";
            this.ptSwiatlo.Size = new System.Drawing.Size(39, 17);
            this.ptSwiatlo.TabIndex = 15;
            this.ptSwiatlo.TabStop = false;
            // 
            // ltSwiatlo
            // 
            this.ltSwiatlo.BackColor = System.Drawing.Color.Gray;
            this.ltSwiatlo.Location = new System.Drawing.Point(241, 412);
            this.ltSwiatlo.Name = "ltSwiatlo";
            this.ltSwiatlo.Size = new System.Drawing.Size(39, 17);
            this.ltSwiatlo.TabIndex = 14;
            this.ltSwiatlo.TabStop = false;
            this.ltSwiatlo.Click += new System.EventHandler(this.ltSwiatlo_Click);
            // 
            // ptKierunkowskaz
            // 
            this.ptKierunkowskaz.BackColor = System.Drawing.Color.Gray;
            this.ptKierunkowskaz.Location = new System.Drawing.Point(346, 412);
            this.ptKierunkowskaz.Name = "ptKierunkowskaz";
            this.ptKierunkowskaz.Size = new System.Drawing.Size(20, 17);
            this.ptKierunkowskaz.TabIndex = 13;
            this.ptKierunkowskaz.TabStop = false;
            // 
            // ltKierunkowskaz
            // 
            this.ltKierunkowskaz.BackColor = System.Drawing.Color.Gray;
            this.ltKierunkowskaz.Location = new System.Drawing.Point(224, 412);
            this.ltKierunkowskaz.Name = "ltKierunkowskaz";
            this.ltKierunkowskaz.Size = new System.Drawing.Size(20, 17);
            this.ltKierunkowskaz.TabIndex = 12;
            this.ltKierunkowskaz.TabStop = false;
            // 
            // ppKierunkowskaz
            // 
            this.ppKierunkowskaz.BackColor = System.Drawing.Color.Gray;
            this.ppKierunkowskaz.Location = new System.Drawing.Point(346, 45);
            this.ppKierunkowskaz.Name = "ppKierunkowskaz";
            this.ppKierunkowskaz.Size = new System.Drawing.Size(20, 17);
            this.ppKierunkowskaz.TabIndex = 11;
            this.ppKierunkowskaz.TabStop = false;
            // 
            // lpKierunkowskaz
            // 
            this.lpKierunkowskaz.BackColor = System.Drawing.Color.Gray;
            this.lpKierunkowskaz.Location = new System.Drawing.Point(224, 45);
            this.lpKierunkowskaz.Name = "lpKierunkowskaz";
            this.lpKierunkowskaz.Size = new System.Drawing.Size(20, 17);
            this.lpKierunkowskaz.TabIndex = 10;
            this.lpKierunkowskaz.TabStop = false;
            this.lpKierunkowskaz.Click += new System.EventHandler(this.lpKierunkowskaz_Click);
            // 
            // ppSwiatlo
            // 
            this.ppSwiatlo.BackColor = System.Drawing.Color.Gray;
            this.ppSwiatlo.Location = new System.Drawing.Point(310, 45);
            this.ppSwiatlo.Name = "ppSwiatlo";
            this.ppSwiatlo.Size = new System.Drawing.Size(39, 17);
            this.ppSwiatlo.TabIndex = 9;
            this.ppSwiatlo.TabStop = false;
            // 
            // lpSwiatlo
            // 
            this.lpSwiatlo.BackColor = System.Drawing.Color.Gray;
            this.lpSwiatlo.Location = new System.Drawing.Point(241, 45);
            this.lpSwiatlo.Name = "lpSwiatlo";
            this.lpSwiatlo.Size = new System.Drawing.Size(39, 17);
            this.lpSwiatlo.TabIndex = 8;
            this.lpSwiatlo.TabStop = false;
            this.lpSwiatlo.Click += new System.EventHandler(this.lpSwiatlo_Click);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labStatus.Location = new System.Drawing.Point(46, 446);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(85, 13);
            this.labStatus.TabIndex = 7;
            this.labStatus.Text = "Brak połączenia";
            // 
            // pbStatus
            // 
            this.pbStatus.BackColor = System.Drawing.Color.Red;
            this.pbStatus.Location = new System.Drawing.Point(22, 446);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(18, 20);
            this.pbStatus.TabIndex = 6;
            this.pbStatus.TabStop = false;
            this.pbStatus.Click += new System.EventHandler(this.pbStatus_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 75);
            this.button2.TabIndex = 5;
            this.button2.Text = "Kierunkowskaz prawy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.kierunkowskazPrawy);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 75);
            this.button5.TabIndex = 4;
            this.button5.Text = "Kierunkowskaz lewy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.kierunkowskazLewy);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 301);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 77);
            this.button6.TabIndex = 3;
            this.button6.Text = "Swiatła tył";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.swiatlaTyl);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Swiatła przód";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.swiatlaPrzod);
            // 
            // Terminal
            // 
            this.Terminal.Controls.Add(this.label6);
            this.Terminal.Controls.Add(this.butClear);
            this.Terminal.Controls.Add(this.butSend);
            this.Terminal.Controls.Add(this.numericSend);
            this.Terminal.Controls.Add(this.rtbTerminal);
            this.Terminal.Location = new System.Drawing.Point(4, 29);
            this.Terminal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Terminal.Name = "Terminal";
            this.Terminal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Terminal.Size = new System.Drawing.Size(586, 474);
            this.Terminal.TabIndex = 0;
            this.Terminal.Text = "Terminal";
            this.Terminal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Log:";
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(383, 403);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(89, 33);
            this.butClear.TabIndex = 3;
            this.butClear.Text = "Wyczyść";
            this.butClear.UseVisualStyleBackColor = true;
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(246, 403);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(89, 33);
            this.butSend.TabIndex = 2;
            this.butSend.Text = "Wyślij";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // numericSend
            // 
            this.numericSend.Hexadecimal = true;
            this.numericSend.Location = new System.Drawing.Point(85, 403);
            this.numericSend.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericSend.Name = "numericSend";
            this.numericSend.Size = new System.Drawing.Size(120, 26);
            this.numericSend.TabIndex = 1;
            this.numericSend.ValueChanged += new System.EventHandler(this.numericSend_ValueChanged);
            // 
            // rtbTerminal
            // 
            this.rtbTerminal.Location = new System.Drawing.Point(8, 36);
            this.rtbTerminal.Name = "rtbTerminal";
            this.rtbTerminal.ReadOnly = true;
            this.rtbTerminal.Size = new System.Drawing.Size(570, 317);
            this.rtbTerminal.TabIndex = 0;
            this.rtbTerminal.Text = "";
            // 
            // Opcje
            // 
            this.Opcje.Controls.Add(this.button3);
            this.Opcje.Controls.Add(this.butCancel);
            this.Opcje.Controls.Add(this.butRefresh);
            this.Opcje.Controls.Add(this.butDomyslne);
            this.Opcje.Controls.Add(this.cbStop);
            this.Opcje.Controls.Add(this.label5);
            this.Opcje.Controls.Add(this.cbParity);
            this.Opcje.Controls.Add(this.label4);
            this.Opcje.Controls.Add(this.cbData);
            this.Opcje.Controls.Add(this.label3);
            this.Opcje.Controls.Add(this.cbBaud);
            this.Opcje.Controls.Add(this.label2);
            this.Opcje.Controls.Add(this.cbName);
            this.Opcje.Controls.Add(this.label1);
            this.Opcje.Location = new System.Drawing.Point(4, 29);
            this.Opcje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Opcje.Name = "Opcje";
            this.Opcje.Size = new System.Drawing.Size(586, 474);
            this.Opcje.TabIndex = 2;
            this.Opcje.Text = "Opcje";
            this.Opcje.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(375, 47);
            this.button3.TabIndex = 13;
            this.button3.Text = "Połącz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(379, 301);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(100, 30);
            this.butCancel.TabIndex = 12;
            this.butCancel.Text = "Anuluj";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Location = new System.Drawing.Point(239, 301);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(100, 30);
            this.butRefresh.TabIndex = 11;
            this.butRefresh.Text = "Odśwież";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.Opcje_Enter);
            // 
            // butDomyslne
            // 
            this.butDomyslne.Location = new System.Drawing.Point(104, 301);
            this.butDomyslne.Name = "butDomyslne";
            this.butDomyslne.Size = new System.Drawing.Size(98, 30);
            this.butDomyslne.TabIndex = 10;
            this.butDomyslne.Text = "Domyślne";
            this.butDomyslne.UseVisualStyleBackColor = true;
            this.butDomyslne.Click += new System.EventHandler(this.butDomyslne_Click);
            // 
            // cbStop
            // 
            this.cbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Location = new System.Drawing.Point(407, 222);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(121, 28);
            this.cbStop.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bity Stopu:";
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(407, 172);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 28);
            this.cbParity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bity Parzystości:";
            // 
            // cbData
            // 
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbData.Location = new System.Drawing.Point(407, 123);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(121, 28);
            this.cbData.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bity danych:";
            // 
            // cbBaud
            // 
            this.cbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.cbBaud.Location = new System.Drawing.Point(407, 74);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 28);
            this.cbBaud.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prędkość:";
            // 
            // cbName
            // 
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(407, 26);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 28);
            this.cbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa portu:";
            // 
            // miganieKierunkowskazu
            // 
            this.miganieKierunkowskazu.Interval = 500;
            this.miganieKierunkowskazu.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // miganieKierunkowskazu2
            // 
            this.miganieKierunkowskazu2.Interval = 500;
            this.miganieKierunkowskazu2.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // SterowanieOswietleniem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 507);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SterowanieOswietleniem";
            this.Text = "Sterowanie oswietleniem";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptSwiatlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltSwiatlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptKierunkowskaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ltKierunkowskaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppKierunkowskaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpKierunkowskaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppSwiatlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpSwiatlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.Terminal.ResumeLayout(false);
            this.Terminal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSend)).EndInit();
            this.Opcje.ResumeLayout(false);
            this.Opcje.PerformLayout();
            this.ResumeLayout(false);

        }

        private void lpSwiatlo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lpKierunkowskaz_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ltSwiatlo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void numericSend_ValueChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Terminal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Opcje;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.NumericUpDown numericSend;
        private System.Windows.Forms.RichTextBox rtbTerminal;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.Button butDomyslne;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.PictureBox ptSwiatlo;
        private System.Windows.Forms.PictureBox ltSwiatlo;
        private System.Windows.Forms.PictureBox ptKierunkowskaz;
        private System.Windows.Forms.PictureBox ltKierunkowskaz;
        private System.Windows.Forms.PictureBox ppKierunkowskaz;
        private System.Windows.Forms.PictureBox lpKierunkowskaz;
        private System.Windows.Forms.PictureBox ppSwiatlo;
        private System.Windows.Forms.PictureBox lpSwiatlo;
        private System.Windows.Forms.Timer miganieKierunkowskazu;
        private System.Windows.Forms.Timer miganieKierunkowskazu2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button TrybAuto;
        private System.Windows.Forms.Button Awaryjne;
    }
}

