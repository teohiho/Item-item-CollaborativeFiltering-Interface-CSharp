namespace Recommented
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
            this.flowLayoutPanelNormalized = new System.Windows.Forms.FlowLayoutPanel();
            this.docfile = new System.Windows.Forms.Button();
            this.flowLayoutPanelMatrixX = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.flowLayoutPanelCosine = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext3 = new System.Windows.Forms.Button();
            this.flowLayoutPanelPredictionCosine = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext5 = new System.Windows.Forms.Button();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1MTY = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelNormalized
            // 
            this.flowLayoutPanelNormalized.Location = new System.Drawing.Point(53, 360);
            this.flowLayoutPanelNormalized.Name = "flowLayoutPanelNormalized";
            this.flowLayoutPanelNormalized.Size = new System.Drawing.Size(385, 255);
            this.flowLayoutPanelNormalized.TabIndex = 0;
            // 
            // docfile
            // 
            this.docfile.Location = new System.Drawing.Point(327, 6);
            this.docfile.Name = "docfile";
            this.docfile.Size = new System.Drawing.Size(111, 23);
            this.docfile.TabIndex = 1;
            this.docfile.Text = "Tạo Ma Trận";
            this.docfile.UseVisualStyleBackColor = true;
            this.docfile.Click += new System.EventHandler(this.docfile_Click);
            // 
            // flowLayoutPanelMatrixX
            // 
            this.flowLayoutPanelMatrixX.Location = new System.Drawing.Point(53, 60);
            this.flowLayoutPanelMatrixX.Name = "flowLayoutPanelMatrixX";
            this.flowLayoutPanelMatrixX.Size = new System.Drawing.Size(385, 255);
            this.flowLayoutPanelMatrixX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hàng (item)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cột (user)";
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(123, 8);
            this.txtHang.Multiline = true;
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(61, 20);
            this.txtHang.TabIndex = 5;
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(248, 7);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(65, 20);
            this.txtCot.TabIndex = 6;
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(363, 321);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(75, 23);
            this.btnNext1.TabIndex = 7;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(363, 621);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 8;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // flowLayoutPanelCosine
            // 
            this.flowLayoutPanelCosine.Location = new System.Drawing.Point(520, 60);
            this.flowLayoutPanelCosine.Name = "flowLayoutPanelCosine";
            this.flowLayoutPanelCosine.Size = new System.Drawing.Size(255, 255);
            this.flowLayoutPanelCosine.TabIndex = 2;
            // 
            // btnNext3
            // 
            this.btnNext3.Location = new System.Drawing.Point(830, 288);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.Size = new System.Drawing.Size(75, 23);
            this.btnNext3.TabIndex = 9;
            this.btnNext3.Text = "Next";
            this.btnNext3.UseVisualStyleBackColor = true;
            this.btnNext3.Click += new System.EventHandler(this.btnNext3_Click);
            // 
            // flowLayoutPanelPredictionCosine
            // 
            this.flowLayoutPanelPredictionCosine.Location = new System.Drawing.Point(520, 364);
            this.flowLayoutPanelPredictionCosine.Name = "flowLayoutPanelPredictionCosine";
            this.flowLayoutPanelPredictionCosine.Size = new System.Drawing.Size(385, 251);
            this.flowLayoutPanelPredictionCosine.TabIndex = 1;
            // 
            // btnNext5
            // 
            this.btnNext5.Location = new System.Drawing.Point(830, 621);
            this.btnNext5.Name = "btnNext5";
            this.btnNext5.Size = new System.Drawing.Size(75, 23);
            this.btnNext5.TabIndex = 11;
            this.btnNext5.Text = "Next";
            this.btnNext5.UseVisualStyleBackColor = true;
            this.btnNext5.Click += new System.EventHandler(this.btnNext5_Click);
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(327, 31);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(111, 23);
            this.btnDocFile.TabIndex = 12;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cosine Similarity Matrix";
            // 
            // flowLayoutPanel1MTY
            // 
            this.flowLayoutPanel1MTY.Location = new System.Drawing.Point(960, 364);
            this.flowLayoutPanel1MTY.Name = "flowLayoutPanel1MTY";
            this.flowLayoutPanel1MTY.Size = new System.Drawing.Size(385, 251);
            this.flowLayoutPanel1MTY.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Normalized Utility Matrix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dự đoán các (normalized) ratings còn thiếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(957, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Matrix Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1370, 653);
            this.Controls.Add(this.flowLayoutPanel1MTY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDocFile);
            this.Controls.Add(this.btnNext5);
            this.Controls.Add(this.flowLayoutPanelPredictionCosine);
            this.Controls.Add(this.btnNext3);
            this.Controls.Add(this.flowLayoutPanelCosine);
            this.Controls.Add(this.btnNext2);
            this.Controls.Add(this.flowLayoutPanelNormalized);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.txtCot);
            this.Controls.Add(this.txtHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelMatrixX);
            this.Controls.Add(this.docfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Recommented System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNormalized;
        private System.Windows.Forms.Button docfile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMatrixX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCosine;
        private System.Windows.Forms.Button btnNext3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPredictionCosine;
        private System.Windows.Forms.Button btnNext5;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1MTY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

