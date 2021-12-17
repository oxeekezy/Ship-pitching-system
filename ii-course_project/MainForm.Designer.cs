namespace ii_course_project
{
    partial class MainForm
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
            this.diagramBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxAngle = new System.Windows.Forms.TextBox();
            this.tbxTeta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPsi = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxWaveLenght = new System.Windows.Forms.TextBox();
            this.tbxShipSpeed = new System.Windows.Forms.TextBox();
            this.tbxMetaHeight = new System.Windows.Forms.TextBox();
            this.tbxShipDraught = new System.Windows.Forms.TextBox();
            this.tbxShipWidth = new System.Windows.Forms.TextBox();
            this.tbxShipLenght = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MDHE2 = new System.Windows.Forms.Label();
            this.MDHE1 = new System.Windows.Forms.Label();
            this.tbxHNOTE = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxMDHE2 = new System.Windows.Forms.TextBox();
            this.tbxMDHE1 = new System.Windows.Forms.TextBox();
            this.tbxHNOE = new System.Windows.Forms.TextBox();
            this.tbxPHE = new System.Windows.Forms.TextBox();
            this.tbxPE = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.psidePanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.keelPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.debugCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.diagramBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagramBox
            // 
            this.diagramBox.Location = new System.Drawing.Point(218, 18);
            this.diagramBox.Name = "diagramBox";
            this.diagramBox.Size = new System.Drawing.Size(397, 200);
            this.diagramBox.TabIndex = 0;
            this.diagramBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Проверка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxAngle
            // 
            this.tbxAngle.BackColor = System.Drawing.Color.Khaki;
            this.tbxAngle.Location = new System.Drawing.Point(11, 22);
            this.tbxAngle.Name = "tbxAngle";
            this.tbxAngle.Size = new System.Drawing.Size(100, 23);
            this.tbxAngle.TabIndex = 2;
            // 
            // tbxTeta
            // 
            this.tbxTeta.BackColor = System.Drawing.Color.Khaki;
            this.tbxTeta.Location = new System.Drawing.Point(11, 51);
            this.tbxTeta.Name = "tbxTeta";
            this.tbxTeta.Size = new System.Drawing.Size(100, 23);
            this.tbxTeta.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxPsi);
            this.groupBox1.Controls.Add(this.tbxAngle);
            this.groupBox1.Controls.Add(this.tbxTeta);
            this.groupBox1.Location = new System.Drawing.Point(621, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные параметры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ψ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "θ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Курс";
            // 
            // tbxPsi
            // 
            this.tbxPsi.BackColor = System.Drawing.Color.Khaki;
            this.tbxPsi.Location = new System.Drawing.Point(11, 80);
            this.tbxPsi.Name = "tbxPsi";
            this.tbxPsi.Size = new System.Drawing.Size(100, 23);
            this.tbxPsi.TabIndex = 4;
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.RosyBrown;
            this.resultBox.Location = new System.Drawing.Point(621, 132);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(188, 264);
            this.resultBox.TabIndex = 5;
            this.resultBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxWaveLenght);
            this.groupBox2.Controls.Add(this.tbxShipSpeed);
            this.groupBox2.Controls.Add(this.tbxMetaHeight);
            this.groupBox2.Controls.Add(this.tbxShipDraught);
            this.groupBox2.Controls.Add(this.tbxShipWidth);
            this.groupBox2.Controls.Add(this.tbxShipLenght);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 206);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходные данные";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Длина волны";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Скорость корабля";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Метацентр. высота";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Осадка корабля";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ширина корабля";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Длина корабля";
            // 
            // tbxWaveLenght
            // 
            this.tbxWaveLenght.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxWaveLenght.Location = new System.Drawing.Point(130, 169);
            this.tbxWaveLenght.Name = "tbxWaveLenght";
            this.tbxWaveLenght.Size = new System.Drawing.Size(64, 23);
            this.tbxWaveLenght.TabIndex = 8;
            // 
            // tbxShipSpeed
            // 
            this.tbxShipSpeed.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxShipSpeed.Location = new System.Drawing.Point(130, 140);
            this.tbxShipSpeed.Name = "tbxShipSpeed";
            this.tbxShipSpeed.Size = new System.Drawing.Size(64, 23);
            this.tbxShipSpeed.TabIndex = 7;
            // 
            // tbxMetaHeight
            // 
            this.tbxMetaHeight.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxMetaHeight.Location = new System.Drawing.Point(130, 111);
            this.tbxMetaHeight.Name = "tbxMetaHeight";
            this.tbxMetaHeight.Size = new System.Drawing.Size(64, 23);
            this.tbxMetaHeight.TabIndex = 6;
            // 
            // tbxShipDraught
            // 
            this.tbxShipDraught.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxShipDraught.Location = new System.Drawing.Point(130, 82);
            this.tbxShipDraught.Name = "tbxShipDraught";
            this.tbxShipDraught.Size = new System.Drawing.Size(64, 23);
            this.tbxShipDraught.TabIndex = 5;
            // 
            // tbxShipWidth
            // 
            this.tbxShipWidth.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxShipWidth.Location = new System.Drawing.Point(130, 54);
            this.tbxShipWidth.Name = "tbxShipWidth";
            this.tbxShipWidth.Size = new System.Drawing.Size(64, 23);
            this.tbxShipWidth.TabIndex = 4;
            // 
            // tbxShipLenght
            // 
            this.tbxShipLenght.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxShipLenght.Location = new System.Drawing.Point(130, 26);
            this.tbxShipLenght.Name = "tbxShipLenght";
            this.tbxShipLenght.Size = new System.Drawing.Size(64, 23);
            this.tbxShipLenght.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MDHE2);
            this.groupBox3.Controls.Add(this.MDHE1);
            this.groupBox3.Controls.Add(this.tbxHNOTE);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbxMDHE2);
            this.groupBox3.Controls.Add(this.tbxMDHE1);
            this.groupBox3.Controls.Add(this.tbxHNOE);
            this.groupBox3.Controls.Add(this.tbxPHE);
            this.groupBox3.Controls.Add(this.tbxPE);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 172);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Исходные оценки вероятностей";
            // 
            // MDHE2
            // 
            this.MDHE2.AutoSize = true;
            this.MDHE2.Location = new System.Drawing.Point(6, 144);
            this.MDHE2.Name = "MDHE2";
            this.MDHE2.Size = new System.Drawing.Size(60, 15);
            this.MDHE2.TabIndex = 13;
            this.MDHE2.Text = "МД(Н/Е2)";
            // 
            // MDHE1
            // 
            this.MDHE1.AutoSize = true;
            this.MDHE1.Location = new System.Drawing.Point(6, 114);
            this.MDHE1.Name = "MDHE1";
            this.MDHE1.Size = new System.Drawing.Size(60, 15);
            this.MDHE1.TabIndex = 12;
            this.MDHE1.Text = "МД(Н/Е1)";
            // 
            // tbxHNOTE
            // 
            this.tbxHNOTE.AutoSize = true;
            this.tbxHNOTE.Location = new System.Drawing.Point(6, 88);
            this.tbxHNOTE.Name = "tbxHNOTE";
            this.tbxHNOTE.Size = new System.Drawing.Size(68, 15);
            this.tbxHNOTE.TabIndex = 11;
            this.tbxHNOTE.Text = "P(H/NOT E)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "P(H/E)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "P(E)";
            // 
            // tbxMDHE2
            // 
            this.tbxMDHE2.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxMDHE2.Location = new System.Drawing.Point(130, 140);
            this.tbxMDHE2.Name = "tbxMDHE2";
            this.tbxMDHE2.Size = new System.Drawing.Size(64, 23);
            this.tbxMDHE2.TabIndex = 7;
            // 
            // tbxMDHE1
            // 
            this.tbxMDHE1.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxMDHE1.Location = new System.Drawing.Point(130, 111);
            this.tbxMDHE1.Name = "tbxMDHE1";
            this.tbxMDHE1.Size = new System.Drawing.Size(64, 23);
            this.tbxMDHE1.TabIndex = 6;
            // 
            // tbxHNOE
            // 
            this.tbxHNOE.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxHNOE.Location = new System.Drawing.Point(130, 82);
            this.tbxHNOE.Name = "tbxHNOE";
            this.tbxHNOE.Size = new System.Drawing.Size(64, 23);
            this.tbxHNOE.TabIndex = 5;
            // 
            // tbxPHE
            // 
            this.tbxPHE.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxPHE.Location = new System.Drawing.Point(130, 54);
            this.tbxPHE.Name = "tbxPHE";
            this.tbxPHE.Size = new System.Drawing.Size(64, 23);
            this.tbxPHE.TabIndex = 4;
            // 
            // tbxPE
            // 
            this.tbxPE.BackColor = System.Drawing.Color.RosyBrown;
            this.tbxPE.Location = new System.Drawing.Point(130, 26);
            this.tbxPE.Name = "tbxPE";
            this.tbxPE.Size = new System.Drawing.Size(64, 23);
            this.tbxPE.TabIndex = 3;
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logBox.Location = new System.Drawing.Point(218, 263);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(397, 133);
            this.logBox.TabIndex = 8;
            this.logBox.Text = "";
            // 
            // sidePanel
            // 
            this.sidePanel.Location = new System.Drawing.Point(218, 224);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(27, 8);
            this.sidePanel.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Бортовая качка";
            // 
            // psidePanel
            // 
            this.psidePanel.Location = new System.Drawing.Point(364, 224);
            this.psidePanel.Name = "psidePanel";
            this.psidePanel.Size = new System.Drawing.Size(27, 8);
            this.psidePanel.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(397, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Параметрическая бортовая качка";
            // 
            // keelPanel
            // 
            this.keelPanel.Location = new System.Drawing.Point(218, 243);
            this.keelPanel.Name = "keelPanel";
            this.keelPanel.Size = new System.Drawing.Size(27, 8);
            this.keelPanel.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Килевая качка";
            // 
            // debugCheck
            // 
            this.debugCheck.AutoSize = true;
            this.debugCheck.Location = new System.Drawing.Point(12, 409);
            this.debugCheck.Name = "debugCheck";
            this.debugCheck.Size = new System.Drawing.Size(111, 19);
            this.debugCheck.TabIndex = 14;
            this.debugCheck.Text = "Режим отладки";
            this.debugCheck.UseVisualStyleBackColor = true;
            this.debugCheck.CheckedChanged += new System.EventHandler(this.debugCheck_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.debugCheck);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.keelPanel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.psidePanel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diagramBox);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagramBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox diagramBox;
        private Button button1;
        private TextBox tbxAngle;
        private TextBox tbxTeta;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxPsi;
        private RichTextBox resultBox;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbxWaveLenght;
        private TextBox tbxShipSpeed;
        private TextBox tbxMetaHeight;
        private TextBox tbxShipDraught;
        private TextBox tbxShipWidth;
        private TextBox tbxShipLenght;
        private GroupBox groupBox3;
        private Label MDHE2;
        private Label MDHE1;
        private Label tbxHNOTE;
        private Label label14;
        private Label label15;
        private TextBox tbxMDHE2;
        private TextBox tbxMDHE1;
        private TextBox tbxHNOE;
        private TextBox tbxPHE;
        private TextBox tbxPE;
        private RichTextBox logBox;
        private Panel sidePanel;
        private Label label10;
        private Panel psidePanel;
        private Label label11;
        private Panel keelPanel;
        private Label label12;
        private CheckBox debugCheck;
    }
}