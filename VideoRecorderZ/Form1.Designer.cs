namespace VideoRecorderZ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VideoName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FrameRateDisplay = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveFolder = new System.Windows.Forms.TextBox();
            this.openFolderDialog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.frameCountUI = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.qualityVideoNum = new System.Windows.Forms.NumericUpDown();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.statusText = new System.Windows.Forms.Label();
            this.videoManagerBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameCountUI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityVideoNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoName
            // 
            this.VideoName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.VideoName.Location = new System.Drawing.Point(12, 49);
            this.VideoName.Name = "VideoName";
            this.VideoName.Size = new System.Drawing.Size(287, 20);
            this.VideoName.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(188, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выбрать область экрана";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кадров записано:";
            // 
            // FrameRateDisplay
            // 
            this.FrameRateDisplay.AutoSize = true;
            this.FrameRateDisplay.Location = new System.Drawing.Point(116, 9);
            this.FrameRateDisplay.Name = "FrameRateDisplay";
            this.FrameRateDisplay.Size = new System.Drawing.Size(13, 13);
            this.FrameRateDisplay.TabIndex = 6;
            this.FrameRateDisplay.Text = "0";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название видео:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Папка для сохранения:";
            // 
            // SaveFolder
            // 
            this.SaveFolder.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SaveFolder.Location = new System.Drawing.Point(12, 92);
            this.SaveFolder.Name = "SaveFolder";
            this.SaveFolder.Size = new System.Drawing.Size(263, 20);
            this.SaveFolder.TabIndex = 10;
            // 
            // openFolderDialog
            // 
            this.openFolderDialog.BackColor = System.Drawing.SystemColors.MenuBar;
            this.openFolderDialog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openFolderDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFolderDialog.Location = new System.Drawing.Point(279, 92);
            this.openFolderDialog.Name = "openFolderDialog";
            this.openFolderDialog.Size = new System.Drawing.Size(20, 20);
            this.openFolderDialog.TabIndex = 11;
            this.openFolderDialog.Text = "O";
            this.openFolderDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openFolderDialog.UseVisualStyleBackColor = false;
            this.openFolderDialog.Click += new System.EventHandler(this.openFolderDialog_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 2);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Количество кадров в секунду:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(50, 143);
            this.trackBar1.Maximum = 24;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(249, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // frameCountUI
            // 
            this.frameCountUI.Location = new System.Drawing.Point(18, 144);
            this.frameCountUI.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.frameCountUI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameCountUI.Name = "frameCountUI";
            this.frameCountUI.Size = new System.Drawing.Size(32, 20);
            this.frameCountUI.TabIndex = 16;
            this.frameCountUI.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameCountUI.ValueChanged += new System.EventHandler(this.frameCountUI_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Качество видео %:";
            // 
            // qualityVideoNum
            // 
            this.qualityVideoNum.Location = new System.Drawing.Point(18, 191);
            this.qualityVideoNum.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.qualityVideoNum.Name = "qualityVideoNum";
            this.qualityVideoNum.Size = new System.Drawing.Size(32, 20);
            this.qualityVideoNum.TabIndex = 18;
            this.qualityVideoNum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.qualityVideoNum.ValueChanged += new System.EventHandler(this.qualityVideoNum_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(50, 194);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = 30;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(249, 45);
            this.trackBar2.TabIndex = 19;
            this.trackBar2.Value = 30;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(12, 355);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(35, 13);
            this.statusText.TabIndex = 20;
            this.statusText.Text = "status";
            this.statusText.Visible = false;
            // 
            // videoManagerBtn
            // 
            this.videoManagerBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.videoManagerBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.videoManagerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoManagerBtn.Location = new System.Drawing.Point(12, 291);
            this.videoManagerBtn.Name = "videoManagerBtn";
            this.videoManagerBtn.Size = new System.Drawing.Size(111, 23);
            this.videoManagerBtn.TabIndex = 21;
            this.videoManagerBtn.Text = "Менеджер видео";
            this.videoManagerBtn.UseVisualStyleBackColor = false;
            this.videoManagerBtn.Click += new System.EventHandler(this.videoManagerBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(188, 291);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(111, 23);
            this.enterBtn.TabIndex = 22;
            this.enterBtn.Text = "Вход";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(311, 380);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.videoManagerBtn);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.qualityVideoNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.frameCountUI);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.openFolderDialog);
            this.Controls.Add(this.SaveFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FrameRateDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.VideoName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameCountUI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityVideoNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox VideoName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FrameRateDisplay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SaveFolder;
        private System.Windows.Forms.Button openFolderDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown frameCountUI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown qualityVideoNum;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Button videoManagerBtn;
        private System.Windows.Forms.Button enterBtn;
    }
}

