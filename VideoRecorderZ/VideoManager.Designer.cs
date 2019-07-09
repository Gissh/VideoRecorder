namespace VideoRecorderZ
{
    partial class VideoManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VideoNameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoPathC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoStatusC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderOpenBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VideoNameC,
            this.VideoPathC,
            this.VideoStatusC});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(493, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // VideoNameC
            // 
            this.VideoNameC.HeaderText = "Название";
            this.VideoNameC.Name = "VideoNameC";
            this.VideoNameC.ReadOnly = true;
            // 
            // VideoPathC
            // 
            this.VideoPathC.HeaderText = "Путь";
            this.VideoPathC.Name = "VideoPathC";
            this.VideoPathC.ReadOnly = true;
            this.VideoPathC.Width = 200;
            // 
            // VideoStatusC
            // 
            this.VideoStatusC.HeaderText = "Статус загрузки";
            this.VideoStatusC.Name = "VideoStatusC";
            this.VideoStatusC.ReadOnly = true;
            this.VideoStatusC.Width = 150;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(13, 310);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Загрузить";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 339);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(492, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // folderOpenBtn
            // 
            this.folderOpenBtn.Location = new System.Drawing.Point(95, 310);
            this.folderOpenBtn.Name = "folderOpenBtn";
            this.folderOpenBtn.Size = new System.Drawing.Size(96, 23);
            this.folderOpenBtn.TabIndex = 3;
            this.folderOpenBtn.Text = "Открыть папку";
            this.folderOpenBtn.UseVisualStyleBackColor = true;
            this.folderOpenBtn.Click += new System.EventHandler(this.folderOpenBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(198, 310);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(121, 23);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "Удалить из таблицы";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // VideoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 368);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.folderOpenBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VideoManager";
            this.Text = "VideoManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoManager_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoNameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoPathC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoStatusC;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button folderOpenBtn;
        private System.Windows.Forms.Button delBtn;
    }
}