namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIMPORT = new System.Windows.Forms.Button();
            this.buttonEXPORT = new System.Windows.Forms.Button();
            this.buttonCALCULATE = new System.Windows.Forms.Button();
            this.dgvIMPORT = new System.Windows.Forms.DataGridView();
            this.dgvRESULT = new System.Windows.Forms.DataGridView();
            this.txtKsi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVbi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIMPORT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRESULT)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIMPORT
            // 
            this.buttonIMPORT.Location = new System.Drawing.Point(12, 12);
            this.buttonIMPORT.Name = "buttonIMPORT";
            this.buttonIMPORT.Size = new System.Drawing.Size(80, 30);
            this.buttonIMPORT.TabIndex = 0;
            this.buttonIMPORT.Text = "Import";
            this.buttonIMPORT.UseVisualStyleBackColor = true;
            this.buttonIMPORT.Click += new System.EventHandler(this.buttonIMPORT_Click);
            // 
            // buttonEXPORT
            // 
            this.buttonEXPORT.Location = new System.Drawing.Point(12, 589);
            this.buttonEXPORT.Name = "buttonEXPORT";
            this.buttonEXPORT.Size = new System.Drawing.Size(80, 30);
            this.buttonEXPORT.TabIndex = 1;
            this.buttonEXPORT.Text = "Export";
            this.buttonEXPORT.UseVisualStyleBackColor = true;
            this.buttonEXPORT.Click += new System.EventHandler(this.buttonEXPORT_Click);
            // 
            // buttonCALCULATE
            // 
            this.buttonCALCULATE.Location = new System.Drawing.Point(12, 553);
            this.buttonCALCULATE.Name = "buttonCALCULATE";
            this.buttonCALCULATE.Size = new System.Drawing.Size(80, 30);
            this.buttonCALCULATE.TabIndex = 2;
            this.buttonCALCULATE.Text = "Calculate";
            this.buttonCALCULATE.UseVisualStyleBackColor = true;
            this.buttonCALCULATE.Click += new System.EventHandler(this.buttonCALCULATE_Click);
            // 
            // dgvIMPORT
            // 
            this.dgvIMPORT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIMPORT.Location = new System.Drawing.Point(98, 12);
            this.dgvIMPORT.Name = "dgvIMPORT";
            this.dgvIMPORT.Size = new System.Drawing.Size(865, 300);
            this.dgvIMPORT.TabIndex = 3;
            // 
            // dgvRESULT
            // 
            this.dgvRESULT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRESULT.Location = new System.Drawing.Point(98, 328);
            this.dgvRESULT.Name = "dgvRESULT";
            this.dgvRESULT.Size = new System.Drawing.Size(865, 300);
            this.dgvRESULT.TabIndex = 4;
            // 
            // txtKsi
            // 
            this.txtKsi.Location = new System.Drawing.Point(12, 344);
            this.txtKsi.Name = "txtKsi";
            this.txtKsi.Size = new System.Drawing.Size(80, 20);
            this.txtKsi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ξ(s   k   )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vbi(V)";
            // 
            // txtVbi
            // 
            this.txtVbi.Location = new System.Drawing.Point(12, 392);
            this.txtVbi.Name = "txtVbi";
            this.txtVbi.Size = new System.Drawing.Size(80, 20);
            this.txtVbi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "w(cm)";
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(12, 439);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(80, 20);
            this.txtW.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Eg(eV)";
            // 
            // txtEg
            // 
            this.txtEg.Location = new System.Drawing.Point(12, 485);
            this.txtEg.Name = "txtEg";
            this.txtEg.Size = new System.Drawing.Size(80, 20);
            this.txtEg.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 7);
            this.label5.TabIndex = 13;
            this.label5.Text = "-1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 7);
            this.label6.TabIndex = 14;
            this.label6.Text = "-2";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.25F);
            this.info.Location = new System.Drawing.Point(5, 620);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(12, 7);
            this.info.TabIndex = 15;
            this.info.Text = "1.0";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 631);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVbi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKsi);
            this.Controls.Add(this.dgvRESULT);
            this.Controls.Add(this.dgvIMPORT);
            this.Controls.Add(this.buttonCALCULATE);
            this.Controls.Add(this.buttonEXPORT);
            this.Controls.Add(this.buttonIMPORT);
            this.Name = "Form1";
            this.Text = "DOS-EA Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIMPORT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRESULT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIMPORT;
        private System.Windows.Forms.Button buttonEXPORT;
        private System.Windows.Forms.Button buttonCALCULATE;
        private System.Windows.Forms.DataGridView dgvIMPORT;
        private System.Windows.Forms.DataGridView dgvRESULT;
        private System.Windows.Forms.TextBox txtKsi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVbi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label info;
    }
}

