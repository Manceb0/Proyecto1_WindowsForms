namespace Proyecto1_WindowsForms
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSB = new System.Windows.Forms.TextBox();
            this.lblSB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAFP = new System.Windows.Forms.Label();
            this.txtSFSTotal = new System.Windows.Forms.TextBox();
            this.txtISRTotal = new System.Windows.Forms.TextBox();
            this.txtAPFTotal = new System.Windows.Forms.TextBox();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.txtSFS = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblSFS = new System.Windows.Forms.Label();
            this.lblISR = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "CÁLCULO DE IMPUESTOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSB
            // 
            this.txtSB.Location = new System.Drawing.Point(322, 155);
            this.txtSB.Name = "txtSB";
            this.txtSB.Size = new System.Drawing.Size(164, 22);
            this.txtSB.TabIndex = 15;
            this.txtSB.TextChanged += new System.EventHandler(this.txtSB_TextChanged);
            // 
            // lblSB
            // 
            this.lblSB.AutoSize = true;
            this.lblSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSB.Location = new System.Drawing.Point(341, 114);
            this.lblSB.Name = "lblSB";
            this.lblSB.Size = new System.Drawing.Size(138, 26);
            this.lblSB.TabIndex = 14;
            this.lblSB.Text = "Sueldo Bruto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAFP);
            this.groupBox1.Controls.Add(this.txtSFSTotal);
            this.groupBox1.Controls.Add(this.txtISRTotal);
            this.groupBox1.Controls.Add(this.txtAPFTotal);
            this.groupBox1.Controls.Add(this.txtISR);
            this.groupBox1.Controls.Add(this.txtSFS);
            this.groupBox1.Controls.Add(this.txtAFP);
            this.groupBox1.Location = new System.Drawing.Point(154, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 156);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deducciones";
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFP.Location = new System.Drawing.Point(47, 27);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(75, 26);
            this.lblAFP.TabIndex = 19;
            this.lblAFP.Text = "%AFP";
            // 
            // txtSFSTotal
            // 
            this.txtSFSTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSFSTotal.Location = new System.Drawing.Point(370, 104);
            this.txtSFSTotal.Name = "txtSFSTotal";
            this.txtSFSTotal.ReadOnly = true;
            this.txtSFSTotal.Size = new System.Drawing.Size(122, 27);
            this.txtSFSTotal.TabIndex = 14;
            this.txtSFSTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtISRTotal
            // 
            this.txtISRTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISRTotal.Location = new System.Drawing.Point(192, 104);
            this.txtISRTotal.Name = "txtISRTotal";
            this.txtISRTotal.ReadOnly = true;
            this.txtISRTotal.Size = new System.Drawing.Size(119, 27);
            this.txtISRTotal.TabIndex = 13;
            this.txtISRTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAPFTotal
            // 
            this.txtAPFTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPFTotal.Location = new System.Drawing.Point(26, 104);
            this.txtAPFTotal.Name = "txtAPFTotal";
            this.txtAPFTotal.ReadOnly = true;
            this.txtAPFTotal.Size = new System.Drawing.Size(123, 27);
            this.txtAPFTotal.TabIndex = 12;
            this.txtAPFTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtISR
            // 
            this.txtISR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISR.Location = new System.Drawing.Point(192, 63);
            this.txtISR.Name = "txtISR";
            this.txtISR.Size = new System.Drawing.Size(119, 27);
            this.txtISR.TabIndex = 4;
            this.txtISR.Text = "9";
            this.txtISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSFS
            // 
            this.txtSFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSFS.Location = new System.Drawing.Point(370, 63);
            this.txtSFS.Name = "txtSFS";
            this.txtSFS.Size = new System.Drawing.Size(122, 27);
            this.txtSFS.TabIndex = 6;
            this.txtSFS.Text = "10";
            this.txtSFS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAFP
            // 
            this.txtAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFP.Location = new System.Drawing.Point(26, 63);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(123, 27);
            this.txtAFP.TabIndex = 2;
            this.txtAFP.Text = "7";
            this.txtAFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(275, 380);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(256, 59);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.8F, System.Drawing.FontStyle.Bold);
            this.lblSN.Location = new System.Drawing.Point(346, 460);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(87, 61);
            this.lblSN.TabIndex = 16;
            this.lblSN.Text = "00";
            this.lblSN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSFS
            // 
            this.lblSFS.AutoSize = true;
            this.lblSFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFS.Location = new System.Drawing.Point(546, 225);
            this.lblSFS.Name = "lblSFS";
            this.lblSFS.Size = new System.Drawing.Size(75, 26);
            this.lblSFS.TabIndex = 13;
            this.lblSFS.Text = "%SFS";
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISR.Location = new System.Drawing.Point(368, 225);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(69, 26);
            this.lblISR.TabIndex = 12;
            this.lblISR.Text = "%ISR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.txtSB);
            this.Controls.Add(this.lblSB);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.lblSFS);
            this.Controls.Add(this.lblISR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSB;
        private System.Windows.Forms.Label lblSB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.TextBox txtSFSTotal;
        private System.Windows.Forms.TextBox txtISRTotal;
        private System.Windows.Forms.TextBox txtAPFTotal;
        private System.Windows.Forms.TextBox txtISR;
        private System.Windows.Forms.TextBox txtSFS;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblSFS;
        private System.Windows.Forms.Label lblISR;
    }
}

