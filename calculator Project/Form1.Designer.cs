namespace calculator_Project
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnPers = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnExi = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblEqua = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.txtFirstNumbe = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.pixLog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pixLog)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(16, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 54);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(99, 232);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(78, 54);
            this.btnMul.TabIndex = 2;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnPers
            // 
            this.btnPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPers.Location = new System.Drawing.Point(181, 232);
            this.btnPers.Name = "btnPers";
            this.btnPers.Size = new System.Drawing.Size(78, 54);
            this.btnPers.TabIndex = 2;
            this.btnPers.Text = "%";
            this.btnPers.UseVisualStyleBackColor = true;
            this.btnPers.Click += new System.EventHandler(this.btnPers_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(421, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 54);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(16, 302);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(78, 54);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(100, 302);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(78, 54);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPow
            // 
            this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow.Location = new System.Drawing.Point(181, 302);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(78, 54);
            this.btnPow.TabIndex = 6;
            this.btnPow.Text = "^";
            this.btnPow.UseVisualStyleBackColor = true;
            // 
            // btnExi
            // 
            this.btnExi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExi.Location = new System.Drawing.Point(421, 302);
            this.btnExi.Name = "btnExi";
            this.btnExi.Size = new System.Drawing.Size(99, 54);
            this.btnExi.TabIndex = 7;
            this.btnExi.Text = "Exit ";
            this.btnExi.UseVisualStyleBackColor = true;
            this.btnExi.Click += new System.EventHandler(this.btnExi_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Castellar", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 102);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "ASA Super Calculator ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 155);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 23);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "First Number ";
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOperator
            // 
            this.lblOperator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(118, 130);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(57, 22);
            this.lblOperator.TabIndex = 10;
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName2
            // 
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Location = new System.Drawing.Point(172, 153);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(107, 23);
            this.lblName2.TabIndex = 11;
            this.lblName2.Text = "Second Number ";
            // 
            // lblEqua
            // 
            this.lblEqua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqua.Location = new System.Drawing.Point(285, 132);
            this.lblEqua.Name = "lblEqua";
            this.lblEqua.Size = new System.Drawing.Size(67, 23);
            this.lblEqua.TabIndex = 12;
            this.lblEqua.Text = "=";
            this.lblEqua.Click += new System.EventHandler(this.lblEqua_Click);
            // 
            // lblSolution
            // 
            this.lblSolution.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolution.Location = new System.Drawing.Point(358, 132);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(150, 23);
            this.lblSolution.TabIndex = 13;
            // 
            // txtFirstNumbe
            // 
            this.txtFirstNumbe.Location = new System.Drawing.Point(12, 132);
            this.txtFirstNumbe.Name = "txtFirstNumbe";
            this.txtFirstNumbe.Size = new System.Drawing.Size(102, 20);
            this.txtFirstNumbe.TabIndex = 0;
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(181, 132);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNum.TabIndex = 1;
            // 
            // pixLog
            // 
            this.pixLog.Image = global::calculator_Project.Properties.Resources.brand_logox350;
            this.pixLog.Location = new System.Drawing.Point(358, 12);
            this.pixLog.Name = "pixLog";
            this.pixLog.Size = new System.Drawing.Size(150, 102);
            this.pixLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pixLog.TabIndex = 14;
            this.pixLog.TabStop = false;
            this.pixLog.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 373);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNumbe);
            this.Controls.Add(this.pixLog);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.lblEqua);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExi);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPers);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pixLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnPers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnExi;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblEqua;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.PictureBox pixLog;
        private System.Windows.Forms.TextBox txtFirstNumbe;
        private System.Windows.Forms.TextBox txtSecondNum;
    }
}

