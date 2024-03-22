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
            this.label3 = new System.Windows.Forms.Label();
            this.saltCheck = new System.Windows.Forms.CheckBox();
            this.saltValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saltValue);
            this.panel1.Controls.Add(this.saltCheck);
            this.panel1.Controls.Add(this.label3);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salting:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // saltCheck
            // 
            this.saltCheck.AutoSize = true;
            this.saltCheck.Location = new System.Drawing.Point(82, 66);
            this.saltCheck.Name = "saltCheck";
            this.saltCheck.Size = new System.Drawing.Size(15, 14);
            this.saltCheck.TabIndex = 9;
            this.saltCheck.UseVisualStyleBackColor = true;
            this.saltCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // saltValue
            // 
            this.saltValue.Location = new System.Drawing.Point(98, 58);
            this.saltValue.Name = "saltValue";
            this.saltValue.Size = new System.Drawing.Size(361, 27);
            this.saltValue.TabIndex = 10;
            this.saltValue.Visible = false;
            this.saltValue.TextChanged += new System.EventHandler(this.saltValue_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.BackgroundImage = global::hashing_algos.Properties.Resources.clipboard_1719736_640_ezgif_com_crop;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1192, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 49);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(122, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 145);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(874, 144);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1191, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Copy:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1280, 810);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.input);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "String Hasher Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.CheckBox saltCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox saltValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

