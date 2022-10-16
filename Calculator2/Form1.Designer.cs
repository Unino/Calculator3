namespace Calculator2
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
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btKetQua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtKQ.Location = new System.Drawing.Point(421, 298);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(344, 38);
            this.txtKQ.TabIndex = 24;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtB.Location = new System.Drawing.Point(421, 228);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(344, 38);
            this.txtB.TabIndex = 25;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtA.Location = new System.Drawing.Point(421, 157);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(344, 38);
            this.txtA.TabIndex = 26;
            // 
            // btKetQua
            // 
            this.btKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btKetQua.Location = new System.Drawing.Point(307, 389);
            this.btKetQua.Name = "btKetQua";
            this.btKetQua.Size = new System.Drawing.Size(214, 41);
            this.btKetQua.TabIndex = 23;
            this.btKetQua.Text = "+";
            this.btKetQua.UseVisualStyleBackColor = true;
            this.btKetQua.Click += new System.EventHandler(this.btKetQua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(268, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kết quả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(268, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(268, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Số A:";
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btTru.Location = new System.Drawing.Point(582, 389);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(214, 41);
            this.btTru.TabIndex = 23;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 580);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTru;
    }
}

