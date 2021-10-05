
namespace SortingAlgorithmsApp
{
    partial class frmViewAllResults
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
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDataset = new System.Windows.Forms.ComboBox();
            this.cmbRunNumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisplayResult = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "View All Results";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Location = new System.Drawing.Point(159, 102);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(252, 21);
            this.cmbAlgorithm.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select algorithm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select dataset:";
            // 
            // cmbDataset
            // 
            this.cmbDataset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDataset.FormattingEnabled = true;
            this.cmbDataset.Location = new System.Drawing.Point(159, 129);
            this.cmbDataset.Name = "cmbDataset";
            this.cmbDataset.Size = new System.Drawing.Size(252, 21);
            this.cmbDataset.TabIndex = 1;
            // 
            // cmbRunNumber
            // 
            this.cmbRunNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRunNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRunNumber.FormattingEnabled = true;
            this.cmbRunNumber.Location = new System.Drawing.Point(159, 156);
            this.cmbRunNumber.Name = "cmbRunNumber";
            this.cmbRunNumber.Size = new System.Drawing.Size(252, 21);
            this.cmbRunNumber.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Run Number:";
            // 
            // btnDisplayResult
            // 
            this.btnDisplayResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplayResult.Location = new System.Drawing.Point(276, 183);
            this.btnDisplayResult.Name = "btnDisplayResult";
            this.btnDisplayResult.Size = new System.Drawing.Size(135, 36);
            this.btnDisplayResult.TabIndex = 3;
            this.btnDisplayResult.Text = "Display Result";
            this.btnDisplayResult.UseVisualStyleBackColor = true;
            this.btnDisplayResult.Click += new System.EventHandler(this.btnDisplayResult_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblDiff);
            this.groupBox2.Controls.Add(this.lblEndTime);
            this.groupBox2.Controls.Add(this.lblStartTime);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Difference:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "End Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Start Time:";
            // 
            // lblDiff
            // 
            this.lblDiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiff.Location = new System.Drawing.Point(147, 90);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(252, 25);
            this.lblDiff.TabIndex = 2;
            this.lblDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndTime
            // 
            this.lblEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEndTime.Location = new System.Drawing.Point(147, 56);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(252, 25);
            this.lblEndTime.TabIndex = 2;
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartTime
            // 
            this.lblStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStartTime.Location = new System.Drawing.Point(147, 22);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(252, 25);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmViewAllResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDisplayResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRunNumber);
            this.Controls.Add(this.cmbDataset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAlgorithm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewAllResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Results";
            this.Load += new System.EventHandler(this.frmViewAllResults_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDataset;
        private System.Windows.Forms.ComboBox cmbRunNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisplayResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
    }
}