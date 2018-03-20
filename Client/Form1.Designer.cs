namespace Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxyourselec = new System.Windows.Forms.TextBox();
            this.buttonkeo = new System.Windows.Forms.Button();
            this.buttonbao = new System.Windows.Forms.Button();
            this.buttonbua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your selection:";
            // 
            // textBoxyourselec
            // 
            this.textBoxyourselec.Location = new System.Drawing.Point(113, 18);
            this.textBoxyourselec.Name = "textBoxyourselec";
            this.textBoxyourselec.Size = new System.Drawing.Size(261, 20);
            this.textBoxyourselec.TabIndex = 1;
            // 
            // buttonkeo
            // 
            this.buttonkeo.Location = new System.Drawing.Point(62, 103);
            this.buttonkeo.Name = "buttonkeo";
            this.buttonkeo.Size = new System.Drawing.Size(90, 102);
            this.buttonkeo.TabIndex = 2;
            this.buttonkeo.Text = "Kéo";
            this.buttonkeo.UseVisualStyleBackColor = true;
            this.buttonkeo.Click += new System.EventHandler(this.buttonkeo_Click);
            // 
            // buttonbao
            // 
            this.buttonbao.Location = new System.Drawing.Point(194, 103);
            this.buttonbao.Name = "buttonbao";
            this.buttonbao.Size = new System.Drawing.Size(90, 102);
            this.buttonbao.TabIndex = 3;
            this.buttonbao.Text = "Bao";
            this.buttonbao.UseVisualStyleBackColor = true;
            this.buttonbao.Click += new System.EventHandler(this.buttonbao_Click);
            // 
            // buttonbua
            // 
            this.buttonbua.Location = new System.Drawing.Point(327, 103);
            this.buttonbua.Name = "buttonbua";
            this.buttonbua.Size = new System.Drawing.Size(90, 102);
            this.buttonbua.TabIndex = 4;
            this.buttonbua.Text = "Búa";
            this.buttonbua.UseVisualStyleBackColor = true;
            this.buttonbua.Click += new System.EventHandler(this.buttonbua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your result:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonbua);
            this.Controls.Add(this.buttonbao);
            this.Controls.Add(this.buttonkeo);
            this.Controls.Add(this.textBoxyourselec);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxyourselec;
        private System.Windows.Forms.Button buttonkeo;
        private System.Windows.Forms.Button buttonbao;
        private System.Windows.Forms.Button buttonbua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

