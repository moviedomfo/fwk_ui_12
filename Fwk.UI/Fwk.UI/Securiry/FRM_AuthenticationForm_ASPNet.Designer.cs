using Fwk.UI.Common;
using Fwk.UI.Controls;
using Fwk.Bases;
namespace Fwk.UI.Security.Controls
{
    partial class FRM_AuthenticationForm_ASPNet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AuthenticationForm_ASPNet));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPassword = new Fwk.UI.Controls.TextBox(this.components);
            this.txtUserName = new Fwk.UI.Controls.TextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.lbllTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.aceptCancelButtonBar1 = new Fwk.UI.Controls.UC_AceptCancelButtonBar();
            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.txtUserName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.lblPassword);
            this.groupControl1.Location = new System.Drawing.Point(8, 79);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(363, 130);
            this.groupControl1.TabIndex = 444;
            this.groupControl1.Text = "Credenciales";
            // 
            // txtPassword
            // 
            this.txtPassword.CapitalOnly = false;
            this.txtPassword.Location = new System.Drawing.Point(136, 64);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NotAllowedCharacters = "";
            this.txtPassword.NullTextValue = "";
            this.txtPassword.Properties.MaxLength = 128;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Required = true;
            this.txtPassword.RequiredErrorText = "La contraseña es requerida";
            this.txtPassword.Size = new System.Drawing.Size(198, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TexMaxLength = 128;
            this.txtPassword.TextBoxType = Fwk.UI.Common.TextBoxTypeEnum.Nothing;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.CapitalOnly = false;
            this.txtUserName.Location = new System.Drawing.Point(136, 32);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NotAllowedCharacters = "";
            this.txtUserName.NullTextValue = "";
            this.txtUserName.Properties.MaxLength = 50;
            this.txtUserName.Required = true;
            this.txtUserName.RequiredErrorText = "El nombre de usuario es requerido";
            this.txtUserName.Size = new System.Drawing.Size(198, 22);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TexMaxLength = 50;
            this.txtUserName.TextBoxType = Fwk.UI.Common.TextBoxTypeEnum.Nothing;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre de usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(6, 68);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 17);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Contraseña";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // lbllTitle
            // 
            this.lbllTitle.AutoSize = true;
            this.lbllTitle.BackColor = System.Drawing.Color.White;
            this.lbllTitle.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbllTitle.Location = new System.Drawing.Point(58, 12);
            this.lbllTitle.Name = "lbllTitle";
            this.lbllTitle.Size = new System.Drawing.Size(79, 45);
            this.lbllTitle.TabIndex = 449;
            this.lbllTitle.Text = "title";
            this.lbllTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.imgTitle);
            this.panel1.Controls.Add(this.lbllTitle);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 61);
            this.panel1.TabIndex = 450;
            // 
            // imgTitle
            // 
            this.imgTitle.Image = global::Fwk.UI.Properties.Resources.ulock_32;
            this.imgTitle.Location = new System.Drawing.Point(3, 7);
            this.imgTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(58, 47);
            this.imgTitle.TabIndex = 450;
            this.imgTitle.TabStop = false;
            // 
            // aceptCancelButtonBar1
            // 
            this.aceptCancelButtonBar1.AceptButtonEnabled = true;
            this.aceptCancelButtonBar1.AceptButtonText = "&Aceptar";
            this.aceptCancelButtonBar1.AceptButtonVisible = true;
            this.aceptCancelButtonBar1.BottomsVisible = true;
            this.aceptCancelButtonBar1.CancelButtonEnabled = true;
            this.aceptCancelButtonBar1.CancelButtonText = "&Cancelar";
            this.aceptCancelButtonBar1.CancelButtonVisible = true;
            this.aceptCancelButtonBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aceptCancelButtonBar1.Location = new System.Drawing.Point(3, 224);
            this.aceptCancelButtonBar1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.aceptCancelButtonBar1.Name = "aceptCancelButtonBar1";
            this.aceptCancelButtonBar1.Size = new System.Drawing.Size(392, 30);
            this.aceptCancelButtonBar1.TabIndex = 3;
            this.aceptCancelButtonBar1.ClickOkCancelEvent += new Fwk.UI.Common.ClickOkCancelHandler(this.aceptCancelButtonBar1_ClickOkCancelEvent);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangePassword.Location = new System.Drawing.Point(13, 227);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(104, 27);
            this.btnChangePassword.TabIndex = 44;
            this.btnChangePassword.Text = "Cambiar clave";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // FRM_AuthenticationForm_ASPNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(398, 259);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.aceptCancelButtonBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 292);
            this.Name = "FRM_AuthenticationForm_ASPNet";
            this.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Iniciar sesión en ";
            this.Load += new System.EventHandler(this.AuthenticationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private System.Windows.Forms.Label lbllTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgTitle;
        private Fwk.UI.Controls.UC_AceptCancelButtonBar aceptCancelButtonBar1;
        private Fwk.UI.Controls.TextBox txtPassword;
        private Fwk.UI.Controls.TextBox txtUserName;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
    }
}