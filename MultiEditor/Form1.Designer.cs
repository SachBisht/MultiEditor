namespace MultiEditor
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.filePicker = new System.Windows.Forms.TextBox();
            this.txtStringA = new System.Windows.Forms.TextBox();
            this.txtStringB = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.procSubmit = new System.Diagnostics.Process();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.procReplace = new System.Diagnostics.Process();
            this.btnReplace = new System.Windows.Forms.Button();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Footlight MT Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(13, 85);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(71, 15);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Select file:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Footlight MT Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(13, 127);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(141, 15);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Enter string to search:";
            // 
            // filePicker
            // 
            this.filePicker.Location = new System.Drawing.Point(359, 85);
            this.filePicker.Name = "filePicker";
            this.filePicker.ReadOnly = true;
            this.filePicker.Size = new System.Drawing.Size(219, 20);
            this.filePicker.TabIndex = 2;
            // 
            // txtStringA
            // 
            this.txtStringA.Location = new System.Drawing.Point(359, 127);
            this.txtStringA.Multiline = true;
            this.txtStringA.Name = "txtStringA";
            this.txtStringA.Size = new System.Drawing.Size(293, 85);
            this.txtStringA.TabIndex = 3;
            // 
            // txtStringB
            // 
            this.txtStringB.Location = new System.Drawing.Point(359, 240);
            this.txtStringB.Multiline = true;
            this.txtStringB.Name = "txtStringB";
            this.txtStringB.Size = new System.Drawing.Size(293, 85);
            this.txtStringB.TabIndex = 5;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Footlight MT Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(13, 240);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(249, 15);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Enter string to replace the above string:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(577, 354);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // procSubmit
            // 
            this.procSubmit.StartInfo.Domain = "";
            this.procSubmit.StartInfo.LoadUserProfile = false;
            this.procSubmit.StartInfo.Password = null;
            this.procSubmit.StartInfo.StandardErrorEncoding = null;
            this.procSubmit.StartInfo.StandardOutputEncoding = null;
            this.procSubmit.StartInfo.UserName = "";
            this.procSubmit.SynchronizingObject = this;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Footlight MT Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(13, 386);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(195, 15);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Count of string A found in file:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Turquoise;
            this.lblCount.Font = new System.Drawing.Font("Footlight MT Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(356, 386);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(15, 15);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Positions of string A found in file:";
            // 
            // procReplace
            // 
            this.procReplace.StartInfo.Domain = "";
            this.procReplace.StartInfo.LoadUserProfile = false;
            this.procReplace.StartInfo.Password = null;
            this.procReplace.StartInfo.StandardErrorEncoding = null;
            this.procReplace.StartInfo.StandardOutputEncoding = null;
            this.procReplace.StartInfo.UserName = "";
            this.procReplace.SynchronizingObject = this;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(577, 438);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 11;
            this.btnReplace.Text = "Replace all";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Firebrick;
            this.lblSuccess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSuccess.Font = new System.Drawing.Font("Footlight MT Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.Location = new System.Drawing.Point(356, 463);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(56, 22);
            this.lblSuccess.TabIndex = 12;
            this.lblSuccess.Text = "Failed";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(577, 84);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 21);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtStringB);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtStringA);
            this.Controls.Add(this.filePicker);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Footlight MT Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox filePicker;
        private System.Windows.Forms.TextBox txtStringA;
        private System.Windows.Forms.TextBox txtStringB;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Diagnostics.Process procSubmit;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lbl4;
        private System.Diagnostics.Process procReplace;
        private System.Windows.Forms.Button btnBrowse;
    }
}

