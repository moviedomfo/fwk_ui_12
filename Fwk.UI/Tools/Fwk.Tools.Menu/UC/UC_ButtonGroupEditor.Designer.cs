namespace Fwk.Tools.Menu
{
    partial class UC_ButtonGroupEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtToolTip = new DevExpress.XtraEditors.TextEdit();
            this.buttonGroupsBindingSource = new System.Windows.Forms.BindingSource();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCaption = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.cmdGroupStyle = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToolTip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(3, 286);
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelControl1.Size = new System.Drawing.Size(620, 41);
            this.panelControl1.Visible = true;
            // 
            // txtToolTip
            // 
            this.txtToolTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolTip.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.buttonGroupsBindingSource, "ToolTipText", true));
            this.txtToolTip.Location = new System.Drawing.Point(105, 90);
            this.txtToolTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToolTip.Name = "txtToolTip";
            this.txtToolTip.Size = new System.Drawing.Size(509, 22);
            this.txtToolTip.TabIndex = 24;
            // 
            // buttonGroupsBindingSource
            // 
            this.buttonGroupsBindingSource.DataSource = typeof(Fwk.UI.Controls.Menu.BarGroup);
            this.buttonGroupsBindingSource.CurrentItemChanged += new System.EventHandler(this.buttonGroupsBindingSource_CurrentItemChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 94);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 16);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "ToolTip Text:";
            // 
            // txtCaption
            // 
            this.txtCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaption.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.buttonGroupsBindingSource, "Caption", true));
            this.txtCaption.Location = new System.Drawing.Point(105, 58);
            this.txtCaption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(509, 22);
            this.txtCaption.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 62);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 16);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Caption:";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.buttonGroupsBindingSource, "Id", true));
            this.txtId.EditValue = "<Null>";
            this.txtId.Location = new System.Drawing.Point(105, 26);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.MinimumSize = new System.Drawing.Size(94, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(195, 22);
            this.txtId.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 30);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 16);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Group ID:";
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = true;
            this.radioGroup1.Location = new System.Drawing.Point(105, 151);
            this.radioGroup1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Is tree"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Nav bar")});
            this.radioGroup1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radioGroup1.Size = new System.Drawing.Size(197, 75);
            this.radioGroup1.TabIndex = 27;
            // 
            // cmdGroupStyle
            // 
            this.cmdGroupStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGroupStyle.FormattingEnabled = true;
            this.cmdGroupStyle.Items.AddRange(new object[] {
            "SmallIconsText",
            "LargeIconsText",
            "SmallIconsList",
            "LargeIconsList"});
            this.cmdGroupStyle.Location = new System.Drawing.Point(336, 170);
            this.cmdGroupStyle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdGroupStyle.Name = "cmdGroupStyle";
            this.cmdGroupStyle.Size = new System.Drawing.Size(277, 24);
            this.cmdGroupStyle.TabIndex = 29;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(336, 146);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 16);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Group style";
            // 
            // UC_ButtonGroupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cmdGroupStyle);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.txtToolTip);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelControl1);
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_ButtonGroupEditor";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Size = new System.Drawing.Size(626, 332);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.labelControl1, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.labelControl2, 0);
            this.Controls.SetChildIndex(this.txtCaption, 0);
            this.Controls.SetChildIndex(this.labelControl3, 0);
            this.Controls.SetChildIndex(this.txtToolTip, 0);
            this.Controls.SetChildIndex(this.radioGroup1, 0);
            this.Controls.SetChildIndex(this.cmdGroupStyle, 0);
            this.Controls.SetChildIndex(this.labelControl4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToolTip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtToolTip;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCaption;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource buttonGroupsBindingSource;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.ComboBox cmdGroupStyle;
        private DevExpress.XtraEditors.LabelControl labelControl4;

    }
}
