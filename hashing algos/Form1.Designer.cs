namespace hashing_algos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelboxalg = new System.Windows.Forms.ListBox();
            this.function = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.actionbutton = new System.Windows.Forms.Button();
            this.labelboxfun = new System.Windows.Forms.ListBox();
            this.input = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelboxalg);
            this.panel1.Controls.Add(this.function);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.actionbutton);
            this.panel1.Controls.Add(this.labelboxfun);
            this.panel1.Location = new System.Drawing.Point(122, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 184);
            this.panel1.TabIndex = 1;
            // 
            // labelboxalg
            // 
            this.labelboxalg.FormattingEnabled = true;
            this.labelboxalg.ItemHeight = 19;
            this.labelboxalg.Items.AddRange(new object[] {
            "MD4",
            "MD5",
            "SHA-1",
            "SHA-256"});
            this.labelboxalg.Location = new System.Drawing.Point(98, 29);
            this.labelboxalg.Name = "labelboxalg";
            this.labelboxalg.Size = new System.Drawing.Size(361, 23);
            this.labelboxalg.TabIndex = 7;
            this.labelboxalg.SelectedIndexChanged += new System.EventHandler(this.labelboxalg_SelectedIndexChanged);
            // 
            // function
            // 
            this.function.AutoSize = true;
            this.function.Location = new System.Drawing.Point(3, 4);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(83, 19);
            this.function.TabIndex = 6;
            this.function.Text = "Function:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Algorithm:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // actionbutton
            // 
            this.actionbutton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.actionbutton.Location = new System.Drawing.Point(128, 97);
            this.actionbutton.Name = "actionbutton";
            this.actionbutton.Size = new System.Drawing.Size(173, 56);
            this.actionbutton.TabIndex = 0;
            this.actionbutton.Text = "GO";
            this.actionbutton.UseVisualStyleBackColor = true;
            this.actionbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelboxfun
            // 
            this.labelboxfun.FormattingEnabled = true;
            this.labelboxfun.ItemHeight = 19;
            this.labelboxfun.Items.AddRange(new object[] {
            "Hash",
            "Decrypt"});
            this.labelboxfun.Location = new System.Drawing.Point(98, 0);
            this.labelboxfun.Name = "labelboxfun";
            this.labelboxfun.Size = new System.Drawing.Size(361, 23);
            this.labelboxfun.TabIndex = 0;
            this.labelboxfun.SelectedIndexChanged += new System.EventHandler(this.labelboxfun_SelectedIndexChanged);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(122, 306);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(459, 49);
            this.input.TabIndex = 3;
            this.input.Text = "Enter characters here";
            this.input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(727, 306);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(459, 49);
            this.result.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1280, 810);
            this.Controls.Add(this.result);
            this.Controls.Add(this.input);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button actionbutton;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.ListBox labelboxfun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label function;
        private System.Windows.Forms.ListBox labelboxalg;
    }
}

