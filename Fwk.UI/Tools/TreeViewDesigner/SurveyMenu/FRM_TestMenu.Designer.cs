﻿namespace Fwk.Tools.TreeView
{
    partial class FRM_TestMenu
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

        #region Windows Pelsoft Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.treeListMenuControl1 = new Fwk.Tools.TreeView.UC_TreeListMenuControl();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.Location = new System.Drawing.Point(25, 30);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(151, 28);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "View selected ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton2.Location = new System.Drawing.Point(25, 100);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(151, 28);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "change view";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // treeListMenuControl1
            // 
            this.treeListMenuControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListMenuControl1.AutoScroll = true;
            this.treeListMenuControl1.DisplayTextCaption = "";
            this.treeListMenuControl1.Location = new System.Drawing.Point(308, 15);
            this.treeListMenuControl1.Margin = new System.Windows.Forms.Padding(5);
            this.treeListMenuControl1.MenuItemSelected = null;
            this.treeListMenuControl1.Name = "treeListMenuControl1";
            this.treeListMenuControl1.Size = new System.Drawing.Size(658, 721);
            this.treeListMenuControl1.TabIndex = 2;
            this.treeListMenuControl1.TypeImageCaption = "Imagen";
            this.treeListMenuControl1.ViewImages = false;
            // 
            // FRM_TestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 734);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.treeListMenuControl1);
            this.Controls.Add(this.simpleButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRM_TestMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu preview";
            this.ResumeLayout(false);

        }

        #endregion


        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private UC_TreeListMenuControl treeListMenuControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}