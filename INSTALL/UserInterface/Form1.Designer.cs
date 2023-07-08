namespace UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lic = new ListBox();
            btn_continue = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            dwn = new ProgressBar();
            label2 = new Label();
            ins = new ProgressBar();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(336, 47);
            label1.TabIndex = 0;
            label1.Text = "Install MWOS Shell";
            // 
            // lic
            // 
            lic.FormattingEnabled = true;
            lic.ItemHeight = 15;
            lic.Location = new Point(12, 72);
            lic.Name = "lic";
            lic.Size = new Size(324, 334);
            lic.TabIndex = 1;
            // 
            // btn_continue
            // 
            btn_continue.Enabled = false;
            btn_continue.Location = new Point(713, 415);
            btn_continue.Name = "btn_continue";
            btn_continue.Size = new Size(75, 23);
            btn_continue.TabIndex = 2;
            btn_continue.Text = "Continue";
            btn_continue.UseVisualStyleBackColor = true;
            btn_continue.Click += btn_continue_Click;
            // 
            // button2
            // 
            button2.Location = new Point(632, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 419);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(292, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "I Read and Agree with The Software LIC agreement";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dwn
            // 
            dwn.Location = new Point(342, 72);
            dwn.Name = "dwn";
            dwn.Size = new Size(446, 23);
            dwn.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 56);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "Download";
            // 
            // ins
            // 
            ins.Location = new Point(342, 116);
            ins.Name = "ins";
            ins.Size = new Size(446, 23);
            ins.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 100);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Install";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(ins);
            Controls.Add(label2);
            Controls.Add(dwn);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(btn_continue);
            Controls.Add(lic);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Install MWOS Shell";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lic;
        private Button btn_continue;
        private Button button2;
        private CheckBox checkBox1;
        private ProgressBar dwn;
        private Label label2;
        private ProgressBar ins;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}