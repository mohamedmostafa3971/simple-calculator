namespace simpleCalcu
{
    partial class simpcalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(simpcalc));
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btntimes = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmodules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(85, 25);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(149, 35);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY.Location = new System.Drawing.Point(85, 71);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(149, 35);
            this.txtY.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblX.Location = new System.Drawing.Point(27, 25);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(29, 29);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblY.Location = new System.Drawing.Point(27, 77);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(29, 29);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 5;
            this.label2.Tag = "10";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(80, 131);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 29);
            this.lblresult.TabIndex = 6;
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(12, 228);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(110, 44);
            this.btnplus.TabIndex = 7;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.Location = new System.Drawing.Point(148, 228);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(116, 44);
            this.btnminus.TabIndex = 8;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btntimes
            // 
            this.btntimes.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimes.Location = new System.Drawing.Point(14, 299);
            this.btntimes.Name = "btntimes";
            this.btntimes.Size = new System.Drawing.Size(108, 41);
            this.btntimes.TabIndex = 9;
            this.btntimes.Text = "*";
            this.btntimes.UseVisualStyleBackColor = true;
            this.btntimes.Click += new System.EventHandler(this.btntimes_Click);
            // 
            // btndivide
            // 
            this.btndivide.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(148, 299);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(116, 41);
            this.btndivide.TabIndex = 10;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnmodules
            // 
            this.btnmodules.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodules.Location = new System.Drawing.Point(63, 359);
            this.btnmodules.Name = "btnmodules";
            this.btnmodules.Size = new System.Drawing.Size(133, 50);
            this.btnmodules.TabIndex = 11;
            this.btnmodules.Text = "%";
            this.btnmodules.UseVisualStyleBackColor = true;
            this.btnmodules.Click += new System.EventHandler(this.btnmodules_Click);
            // 
            // simpcalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(276, 431);
            this.Controls.Add(this.btnmodules);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btntimes);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "simpcalc";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btntimes;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnmodules;
    }
}

