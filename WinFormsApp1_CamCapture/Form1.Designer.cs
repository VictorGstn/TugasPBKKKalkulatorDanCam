namespace WinFormsApp1_CamCapture
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
            comboBoxWebcamList = new ComboBox();
            buttonStart = new Button();
            buttonCamCapture = new Button();
            buttonSave = new Button();
            buttonExit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebcamList
            // 
            comboBoxWebcamList.FormattingEnabled = true;
            comboBoxWebcamList.Location = new Point(20, 47);
            comboBoxWebcamList.Name = "comboBoxWebcamList";
            comboBoxWebcamList.Size = new Size(164, 23);
            comboBoxWebcamList.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.SaddleBrown;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(20, 72);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(82, 32);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCamCapture
            // 
            buttonCamCapture.BackColor = Color.SaddleBrown;
            buttonCamCapture.FlatStyle = FlatStyle.Flat;
            buttonCamCapture.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCamCapture.ForeColor = Color.White;
            buttonCamCapture.Location = new Point(467, 73);
            buttonCamCapture.Name = "buttonCamCapture";
            buttonCamCapture.Size = new Size(77, 33);
            buttonCamCapture.TabIndex = 2;
            buttonCamCapture.Text = "Capture";
            buttonCamCapture.UseVisualStyleBackColor = false;
            buttonCamCapture.Click += button1_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.SaddleBrown;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(550, 73);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 32);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Crimson;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(550, 21);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 30);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(17, 107);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(611, 235);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(308, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 229);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(20, 13);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 6;
            label1.Text = "Camera";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(640, 354);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Controls.Add(buttonCamCapture);
            Controls.Add(buttonStart);
            Controls.Add(comboBoxWebcamList);
            Name = "Form1";
            Text = "Camera Capture";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxWebcamList;
        private Button buttonStart;
        private Button buttonCamCapture;
        private Button buttonSave;
        private Button buttonExit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}