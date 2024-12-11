namespace WindowsFormsMT02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCircleArea = new System.Windows.Forms.Button();
            this.btncircumference = new System.Windows.Forms.Button();
            this.lblRusult = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.btnTriangle01 = new System.Windows.Forms.Button();
            this.txtletter = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnRefparameter = new System.Windows.Forms.Button();
            this.btnoutputParameter = new System.Windows.Forms.Button();
            this.btnArrayparameter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRadius);
            this.groupBox1.Controls.Add(this.lblRusult);
            this.groupBox1.Controls.Add(this.btncircumference);
            this.groupBox1.Controls.Add(this.btnCircleArea);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รูปวงกลม";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "รัศมีวงกลม";
            // 
            // btnCircleArea
            // 
            this.btnCircleArea.Location = new System.Drawing.Point(228, 44);
            this.btnCircleArea.Name = "btnCircleArea";
            this.btnCircleArea.Size = new System.Drawing.Size(75, 23);
            this.btnCircleArea.TabIndex = 1;
            this.btnCircleArea.Text = "พื้นที่";
            this.btnCircleArea.UseVisualStyleBackColor = true;
            this.btnCircleArea.Click += new System.EventHandler(this.btnCircleArea_Click);
            // 
            // btncircumference
            // 
            this.btncircumference.Location = new System.Drawing.Point(309, 44);
            this.btncircumference.Name = "btncircumference";
            this.btncircumference.Size = new System.Drawing.Size(75, 23);
            this.btncircumference.TabIndex = 2;
            this.btncircumference.Text = "เส้นรอบวง";
            this.btncircumference.UseVisualStyleBackColor = true;
            this.btncircumference.Click += new System.EventHandler(this.btncircumference_Click);
            // 
            // lblRusult
            // 
            this.lblRusult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRusult.Location = new System.Drawing.Point(92, 103);
            this.lblRusult.Name = "lblRusult";
            this.lblRusult.Size = new System.Drawing.Size(250, 56);
            this.lblRusult.TabIndex = 3;
            this.lblRusult.Text = ".....";
            this.lblRusult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(95, 41);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnoutputParameter);
            this.groupBox2.Controls.Add(this.btnRefparameter);
            this.groupBox2.Controls.Add(this.txtinput);
            this.groupBox2.Controls.Add(this.txtSize);
            this.groupBox2.Controls.Add(this.txtletter);
            this.groupBox2.Controls.Add(this.btnTriangle01);
            this.groupBox2.Controls.Add(this.txtoutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ทดสอบfunction";
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(20, 22);
            this.txtoutput.Multiline = true;
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.Size = new System.Drawing.Size(100, 162);
            this.txtoutput.TabIndex = 0;
            // 
            // btnTriangle01
            // 
            this.btnTriangle01.Location = new System.Drawing.Point(254, 33);
            this.btnTriangle01.Name = "btnTriangle01";
            this.btnTriangle01.Size = new System.Drawing.Size(93, 38);
            this.btnTriangle01.TabIndex = 1;
            this.btnTriangle01.Text = "Triangle";
            this.btnTriangle01.UseVisualStyleBackColor = true;
            this.btnTriangle01.Click += new System.EventHandler(this.btnTriangle01_Click);
            // 
            // txtletter
            // 
            this.txtletter.Location = new System.Drawing.Point(148, 22);
            this.txtletter.Name = "txtletter";
            this.txtletter.Size = new System.Drawing.Size(100, 22);
            this.txtletter.TabIndex = 2;
            this.txtletter.Text = "A";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(148, 68);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 22);
            this.txtSize.TabIndex = 3;
            this.txtSize.Text = "5";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(157, 107);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(196, 22);
            this.txtinput.TabIndex = 4;
            // 
            // btnRefparameter
            // 
            this.btnRefparameter.Location = new System.Drawing.Point(157, 136);
            this.btnRefparameter.Name = "btnRefparameter";
            this.btnRefparameter.Size = new System.Drawing.Size(196, 23);
            this.btnRefparameter.TabIndex = 5;
            this.btnRefparameter.Text = "ทดสอบ Refparameter\r\n\r\n";
            this.btnRefparameter.UseVisualStyleBackColor = true;
            this.btnRefparameter.Click += new System.EventHandler(this.btnRefparameter_Click);
            // 
            // btnoutputParameter
            // 
            this.btnoutputParameter.Location = new System.Drawing.Point(157, 187);
            this.btnoutputParameter.Name = "btnoutputParameter";
            this.btnoutputParameter.Size = new System.Drawing.Size(196, 23);
            this.btnoutputParameter.TabIndex = 6;
            this.btnoutputParameter.Text = "ทดสอบ output parameter";
            this.btnoutputParameter.UseVisualStyleBackColor = true;
            this.btnoutputParameter.Click += new System.EventHandler(this.btnoutputParameter_Click);
            // 
            // btnArrayparameter
            // 
            this.btnArrayparameter.Location = new System.Drawing.Point(627, 41);
            this.btnArrayparameter.Name = "btnArrayparameter";
            this.btnArrayparameter.Size = new System.Drawing.Size(138, 68);
            this.btnArrayparameter.TabIndex = 2;
            this.btnArrayparameter.Text = "Parameter แบบ Array";
            this.btnArrayparameter.UseVisualStyleBackColor = true;
            this.btnArrayparameter.Click += new System.EventHandler(this.btnArrayparameter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 704);
            this.Controls.Add(this.btnArrayparameter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRusult;
        private System.Windows.Forms.Button btncircumference;
        private System.Windows.Forms.Button btnCircleArea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.TextBox txtletter;
        private System.Windows.Forms.Button btnTriangle01;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnRefparameter;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnoutputParameter;
        private System.Windows.Forms.Button btnArrayparameter;
    }
}

