namespace IndividualTaskV7
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MoveDownMax = new System.Windows.Forms.Button();
            this.MoveTopMax = new System.Windows.Forms.Button();
            this.MoveRighMax = new System.Windows.Forms.Button();
            this.MoveLeftMax = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MoveTop = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.DownSize = new System.Windows.Forms.Button();
            this.UpSize = new System.Windows.Forms.Button();
            this.ShowObjButton = new System.Windows.Forms.Button();
            this.HideObjButton = new System.Windows.Forms.Button();
            this.CreateNewObjButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.MoveDownMax);
            this.splitContainer1.Panel1.Controls.Add(this.MoveTopMax);
            this.splitContainer1.Panel1.Controls.Add(this.MoveRighMax);
            this.splitContainer1.Panel1.Controls.Add(this.MoveLeftMax);
            this.splitContainer1.Panel1.Controls.Add(this.MoveDown);
            this.splitContainer1.Panel1.Controls.Add(this.MoveTop);
            this.splitContainer1.Panel1.Controls.Add(this.MoveRight);
            this.splitContainer1.Panel1.Controls.Add(this.MoveLeft);
            this.splitContainer1.Panel1.Controls.Add(this.DownSize);
            this.splitContainer1.Panel1.Controls.Add(this.UpSize);
            this.splitContainer1.Panel1.Controls.Add(this.ShowObjButton);
            this.splitContainer1.Panel1.Controls.Add(this.HideObjButton);
            this.splitContainer1.Panel1.Controls.Add(this.CreateNewObjButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(931, 455);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MoveDownMax
            // 
            this.MoveDownMax.Location = new System.Drawing.Point(21, 343);
            this.MoveDownMax.Name = "MoveDownMax";
            this.MoveDownMax.Size = new System.Drawing.Size(112, 20);
            this.MoveDownMax.TabIndex = 14;
            this.MoveDownMax.Text = "↓↓";
            this.MoveDownMax.UseVisualStyleBackColor = true;
            this.MoveDownMax.Click += new System.EventHandler(this.MoveDownMax_Click);
            // 
            // MoveTopMax
            // 
            this.MoveTopMax.Location = new System.Drawing.Point(21, 216);
            this.MoveTopMax.Name = "MoveTopMax";
            this.MoveTopMax.Size = new System.Drawing.Size(112, 18);
            this.MoveTopMax.TabIndex = 13;
            this.MoveTopMax.Text = "↑↑";
            this.MoveTopMax.UseVisualStyleBackColor = true;
            this.MoveTopMax.Click += new System.EventHandler(this.MoveTopMax_Click);
            // 
            // MoveRighMax
            // 
            this.MoveRighMax.Location = new System.Drawing.Point(119, 240);
            this.MoveRighMax.Name = "MoveRighMax";
            this.MoveRighMax.Size = new System.Drawing.Size(14, 97);
            this.MoveRighMax.TabIndex = 12;
            this.MoveRighMax.Text = "→→";
            this.MoveRighMax.UseVisualStyleBackColor = true;
            this.MoveRighMax.Click += new System.EventHandler(this.MoveRighMax_Click);
            // 
            // MoveLeftMax
            // 
            this.MoveLeftMax.Location = new System.Drawing.Point(21, 240);
            this.MoveLeftMax.Name = "MoveLeftMax";
            this.MoveLeftMax.Size = new System.Drawing.Size(14, 97);
            this.MoveLeftMax.TabIndex = 11;
            this.MoveLeftMax.Text = "←←";
            this.MoveLeftMax.UseVisualStyleBackColor = true;
            this.MoveLeftMax.Click += new System.EventHandler(this.MoveLeftMax_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(41, 318);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(71, 19);
            this.MoveDown.TabIndex = 10;
            this.MoveDown.Text = "↓";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // MoveTop
            // 
            this.MoveTop.Location = new System.Drawing.Point(41, 240);
            this.MoveTop.Name = "MoveTop";
            this.MoveTop.Size = new System.Drawing.Size(71, 18);
            this.MoveTop.TabIndex = 9;
            this.MoveTop.Text = "↑";
            this.MoveTop.UseVisualStyleBackColor = true;
            this.MoveTop.Click += new System.EventHandler(this.MoveTop_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Location = new System.Drawing.Point(98, 264);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(14, 48);
            this.MoveRight.TabIndex = 8;
            this.MoveRight.Text = "→";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Location = new System.Drawing.Point(41, 264);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(14, 48);
            this.MoveLeft.TabIndex = 7;
            this.MoveLeft.Text = "←";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // DownSize
            // 
            this.DownSize.Location = new System.Drawing.Point(61, 291);
            this.DownSize.Name = "DownSize";
            this.DownSize.Size = new System.Drawing.Size(31, 21);
            this.DownSize.TabIndex = 6;
            this.DownSize.Text = "-";
            this.DownSize.UseVisualStyleBackColor = true;
            this.DownSize.Click += new System.EventHandler(this.DownSize_Click);
            // 
            // UpSize
            // 
            this.UpSize.Location = new System.Drawing.Point(61, 264);
            this.UpSize.Name = "UpSize";
            this.UpSize.Size = new System.Drawing.Size(31, 21);
            this.UpSize.TabIndex = 5;
            this.UpSize.Text = "+";
            this.UpSize.UseVisualStyleBackColor = true;
            this.UpSize.Click += new System.EventHandler(this.UpSize_Click);
            // 
            // ShowObjButton
            // 
            this.ShowObjButton.Location = new System.Drawing.Point(12, 146);
            this.ShowObjButton.Name = "ShowObjButton";
            this.ShowObjButton.Size = new System.Drawing.Size(124, 24);
            this.ShowObjButton.TabIndex = 4;
            this.ShowObjButton.Text = "Show object";
            this.ShowObjButton.UseVisualStyleBackColor = true;
            this.ShowObjButton.Click += new System.EventHandler(this.ShowObjButton_Click);
            // 
            // HideObjButton
            // 
            this.HideObjButton.Location = new System.Drawing.Point(12, 116);
            this.HideObjButton.Name = "HideObjButton";
            this.HideObjButton.Size = new System.Drawing.Size(124, 24);
            this.HideObjButton.TabIndex = 3;
            this.HideObjButton.Text = "Hide object";
            this.HideObjButton.UseVisualStyleBackColor = true;
            this.HideObjButton.Click += new System.EventHandler(this.HideObjButton_Click);
            // 
            // CreateNewObjButton
            // 
            this.CreateNewObjButton.Location = new System.Drawing.Point(12, 87);
            this.CreateNewObjButton.Name = "CreateNewObjButton";
            this.CreateNewObjButton.Size = new System.Drawing.Size(124, 23);
            this.CreateNewObjButton.TabIndex = 2;
            this.CreateNewObjButton.Text = "Create new Object";
            this.CreateNewObjButton.UseVisualStyleBackColor = true;
            this.CreateNewObjButton.Click += new System.EventHandler(this.CreateNewObjButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of objects";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 455);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Individual Task Hubenko";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button MoveLeftMax;
        private System.Windows.Forms.Button MoveRighMax;
        private System.Windows.Forms.Button MoveTopMax;
        private System.Windows.Forms.Button MoveDownMax;
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveTop;
        private System.Windows.Forms.Button MoveDown;

        private System.Windows.Forms.Button MoveLeft;

        private System.Windows.Forms.Button DownSize;

        private System.Windows.Forms.Button UpSize;

        private System.Windows.Forms.Button ShowObjButton;

        private System.Windows.Forms.Button HideObjButton;

        private System.Windows.Forms.Button CreateNewObjButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.SplitContainer splitContainer1;

        #endregion
    }
}