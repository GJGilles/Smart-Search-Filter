﻿namespace WindowsFormsApplication1
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
            this.inBox = new System.Windows.Forms.TextBox();
            this.outBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin to Type Email to Search:";
            // 
            // inBox
            // 
            this.inBox.Location = new System.Drawing.Point(13, 30);
            this.inBox.Name = "inBox";
            this.inBox.Size = new System.Drawing.Size(189, 20);
            this.inBox.TabIndex = 1;
            this.inBox.TextChanged += new System.EventHandler(this.inBox_TextChanged);
            // 
            // outBox
            // 
            this.outBox.FormattingEnabled = true;
            this.outBox.Location = new System.Drawing.Point(13, 48);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(189, 199);
            this.outBox.TabIndex = 2;
            this.outBox.Visible = false;
            this.outBox.SelectedIndexChanged += new System.EventHandler(this.outBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 262);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.inBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inBox;
        private System.Windows.Forms.ListBox outBox;
    }
}

