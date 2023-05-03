namespace conversor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            timerMenu = new System.Windows.Forms.Timer(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            panelaudio = new FlowLayoutPanel();
            panel1 = new Panel();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            listBox1 = new ListBox();
            btn_past = new Button();
            txt_pastadest = new TextBox();
            paineldevideos = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panelaudio.SuspendLayout();
            panel1.SuspendLayout();
            paineldevideos.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Design_sem_nome__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MaximumSize = new Size(887, 493);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(887, 493);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(732, 187);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 2;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(141, 325);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 3;
            label2.Text = "->";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(360, 177);
            label4.Name = "label4";
            label4.Size = new Size(200, 23);
            label4.TabIndex = 5;
            label4.Text = "CONVERSÃO DE AUDIO";
            // 
            // timerMenu
            // 
            timerMenu.Interval = 50;
            timerMenu.Tick += timerMenu_Tick;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelaudio
            // 
            panelaudio.Controls.Add(panel1);
            panelaudio.Location = new Point(180, 203);
            panelaudio.MaximumSize = new Size(546, 278);
            panelaudio.MinimumSize = new Size(546, 0);
            panelaudio.Name = "panelaudio";
            panelaudio.Size = new Size(546, 0);
            panelaudio.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(btn_past);
            panel1.Controls.Add(txt_pastadest);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 275);
            panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(5, 235);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(526, 29);
            progressBar1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(351, 2);
            button1.Name = "button1";
            button1.Size = new Size(131, 29);
            button1.TabIndex = 5;
            button1.Text = "Destino";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(5, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(526, 164);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btn_past
            // 
            btn_past.Location = new Point(148, 36);
            btn_past.Name = "btn_past";
            btn_past.Size = new Size(229, 29);
            btn_past.TabIndex = 2;
            btn_past.Text = "Selecionar itens e CONVERTER";
            btn_past.UseVisualStyleBackColor = true;
            btn_past.Click += btn_past_Click;
            // 
            // txt_pastadest
            // 
            txt_pastadest.Location = new Point(53, 3);
            txt_pastadest.Name = "txt_pastadest";
            txt_pastadest.Size = new Size(292, 27);
            txt_pastadest.TabIndex = 1;
            txt_pastadest.TextChanged += txt_pastadest_TextChanged;
            // 
            // paineldevideos
            // 
            paineldevideos.BackColor = SystemColors.ActiveCaptionText;
            paineldevideos.Controls.Add(panel2);
            paineldevideos.Location = new Point(180, 200);
            paineldevideos.MaximumSize = new Size(546, 278);
            paineldevideos.MinimumSize = new Size(546, 0);
            paineldevideos.Name = "paineldevideos";
            paineldevideos.Size = new Size(546, 278);
            paineldevideos.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(546, 275);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(546, 269);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(886, 493);
            Controls.Add(paineldevideos);
            Controls.Add(panelaudio);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panelaudio.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            paineldevideos.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private System.Windows.Forms.Timer timerMenu;
        private FileSystemWatcher fileSystemWatcher1;
        private FlowLayoutPanel panelaudio;
        private FlowLayoutPanel paineldevideos;
        private Panel panel1;
        private ListBox listBox1;
        private Button btn_past;
        private TextBox txt_pastadest;
        private Button button1;
        private ProgressBar progressBar1;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}