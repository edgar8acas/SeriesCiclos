namespace SeriesCiclos
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtRep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeno = new System.Windows.Forms.Button();
            this.btnCoseno = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(131, 31);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            // 
            // txtRep
            // 
            this.txtRep.Location = new System.Drawing.Point(131, 57);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(100, 20);
            this.txtRep.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Repeticiones";
            // 
            // btnSeno
            // 
            this.btnSeno.Location = new System.Drawing.Point(48, 105);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(75, 23);
            this.btnSeno.TabIndex = 4;
            this.btnSeno.Text = "Seno";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // btnCoseno
            // 
            this.btnCoseno.Location = new System.Drawing.Point(145, 105);
            this.btnCoseno.Name = "btnCoseno";
            this.btnCoseno.Size = new System.Drawing.Size(75, 23);
            this.btnCoseno.TabIndex = 5;
            this.btnCoseno.Text = "Coseno";
            this.btnCoseno.UseVisualStyleBackColor = true;
            this.btnCoseno.Click += new System.EventHandler(this.btnCoseno_Click);
            // 
            // btnLn
            // 
            this.btnLn.Location = new System.Drawing.Point(244, 105);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(75, 23);
            this.btnLn.TabIndex = 6;
            this.btnLn.Text = "Ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(48, 166);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(276, 212);
            this.txtRes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 390);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnCoseno);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.txtRep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.Button btnCoseno;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.TextBox txtRes;
    }
}

