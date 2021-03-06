﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Fwk.HelperFunctions;
using DevExpress.XtraEditors.Controls;
using Fwk.UI.Controls.Menu.Tree;


namespace Fwk.Tools.TreeView
{

    public partial class UC_MenuItemEditor : UserControl
    {
        #region Declarations
        public ImageList imgList;

        bool _CategoryChange = false;
        [Browsable(false)]
        public bool CategoryChange
        {
            get { return _CategoryChange; }
            set { _CategoryChange = value; }
        }
        int? m_Image_Sel_index;
        int? m_Image_index;
        int? m_ImageType_index;

        /// <summary>
        /// Almacena la acción a realizar por el Pelsoftulario
        /// </summary>
        Action _ShowAction = Action.Query;

        /// <summary>
        /// Almacena la acción a realizar por el Pelsoftulario
        /// </summary>
        public Action ShowAction
        {
            get { return _ShowAction; }
            set
            {
                _ShowAction = value;


            }
        }

        TreeMenu menu;
        [Browsable(false)]
        public TreeMenu TreeMenu
        {
            get { return menu; }
            set { menu = value; }
        }
        Fwk.UI.Controls.Menu.Tree.MenuItem _MenuItemSelected;
        [Browsable(false)]
        public Fwk.UI.Controls.Menu.Tree.MenuItem MenuItem
        {
            get { return _MenuItemSelected; }
            set { _MenuItemSelected = value; }
        }
        #endregion

        #region Constructor

        public UC_MenuItemEditor()
        {
            InitializeComponent();
        }

        #endregion

        /// <summary>
        /// Rellena el Menu item actual .-  
        /// </summary>
        public void FillMenuItem()
        {

            _MenuItemSelected.SelectedImageIndex = m_Image_Sel_index;

            _MenuItemSelected.ImageIndex = m_Image_index;

            _MenuItemSelected.AssemblyInfo = this.txtAssembly.Text;
            _MenuItemSelected.DisplayName = this.txtDisplayName.Text;

            _MenuItemSelected.ToolTipInfo = txtToolTipInfo.Text;
            _MenuItemSelected.Enabled = this.checkBoxEnabled.Enabled;
            _MenuItemSelected.AuthorizationRuleName = this.btnAuthorizationRule.Text;
            _MenuItemSelected.Tag = this.txtTag.Text;
        }



        /// <summary>
        /// Rellena los valores del menu    
        /// </summary>
        public void Populate()
        {

            this.txtDisplayName.Text = _MenuItemSelected.DisplayName;
            this.txtAssembly.Text = _MenuItemSelected.AssemblyInfo;

            this.txtToolTipInfo.Text = _MenuItemSelected.ToolTipInfo;
            this.checkBoxEnabled.Checked = _MenuItemSelected.Enabled;
            this.btnAuthorizationRule.Text = _MenuItemSelected.AuthorizationRuleName;
            this.txtTag.Text = _MenuItemSelected.Tag;

            if (_MenuItemSelected.ParentID.Equals(0))
                this.txtCategory.Text = "Is root node";
            else
                this.txtCategory.Text = FRM_MainDevExpress.Menu.ItemList.Get(_MenuItemSelected.ParentID).DisplayName;

            MenuImage m = FRM_MainDevExpress.Menu.ImageList.Get(_MenuItemSelected.ImageIndex);
            if (m != null)
            {
                m_Image_index = m.Index;
                pictureBoxImage.Image = m.Image;
            }
            m = FRM_MainDevExpress.Menu.ImageList.Get(_MenuItemSelected.SelectedImageIndex);
            if (m != null)
            {
                m_Image_Sel_index = m.Index;
                pictureBoxImageSelected.Image = m.Image;
            }

            SetShowAction();
        }



        public string AssemblyBaseType { get; set; }
        private void btnAssemblyinfo_Click(object sender, EventArgs e)
        {
            using (FRM_AssemblyExplorer frm = new FRM_AssemblyExplorer(AssemblyBaseType))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.SelectedPelsoft != null)
                    {
                        txtAssembly.Text = frm.SelectedPelsoft.AssemblyInfo;

                    }
                }
            }
        }

        private void btnSelImageType_Click(object sender, EventArgs e)
        {
            SelImage(this.pictureBoxTypeImage, ref m_ImageType_index);

        }
        private void btnSelectedImage_Click(object sender, EventArgs e)
        {
            SelImage(this.pictureBoxImageSelected, ref m_Image_Sel_index);
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            SelImage(this.pictureBoxImage, ref m_Image_index);
        }

        private void SelImage(PictureBox pPictureBox, ref int? index)
        {


            using (frmImageList frm = new frmImageList())
            {
                frm.Populate();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    pPictureBox.Image = frm.SelectedImage.Image;
                    index = frm.SelectedImage.Index;
                }
            }
        }


        /// <summary>
        /// Habilita y deshabilita los controles
        /// </summary>
        /// <param name="pEnable"></param>
        void EnableControls(Boolean pEnable)
        {
            txtAssembly.Enabled = pEnable;
            txtDisplayName.Enabled = pEnable;

            txtToolTipInfo.Enabled = pEnable;

            txtCategory.Enabled = false;// && _MenuItemSelected.IsCategory;
            checkBoxEnabled.Enabled = pEnable;
            btn_ImageIndex.Enabled = pEnable;
            btn_SelectedImageIndex.Enabled = pEnable;
            btnAssemblyinfo.Enabled = pEnable;

            btnSelImageType.Enabled = pEnable;

            btnAuthorizationRule.Enabled = pEnable;
            txtTag.Enabled = pEnable;
        }

        /// <summary>
        /// limpia todos los controles
        /// </summary>
        public void ClearControls()
        {
            txtAssembly.Text = String.Empty;
            txtDisplayName.Text = String.Empty;

            txtToolTipInfo.Text = String.Empty;
            checkBoxEnabled.Enabled = false;
            pictureBoxImageSelected.Image = null;
            pictureBoxImage.Image = null;
            pictureBoxTypeImage.Image = null;

        }


        void SetCategoryEnabled(bool pIsCategory)
        {
            txtAssembly.Enabled = !pIsCategory;
            txtCategory.Enabled = pIsCategory;
            btnAssemblyinfo.Enabled = !pIsCategory;
            btnSelImageType.Enabled = !pIsCategory;
        }

        void SetShowAction()
        {
            String wTitle = String.Empty;
            switch (_ShowAction)
            {
                case Action.Edit:
                    {
                        wTitle = "Menu updating";
                        EnableControls(true);
                        break;
                    }
                case Action.New:
                    {
                        wTitle = "Menu creating";
                        EnableControls(true);
                        break;
                    }
                case Action.Query:
                    {
                        wTitle = "Menu consulting";
                        EnableControls(false);
                        break;
                    }
            }
            if (this.ParentForm != null)
                this.ParentForm.Text = wTitle;

        }



        private void txtCategory_Validated(object sender, EventArgs e)
        {
            if (_MenuItemSelected == null)
            {
                //errorProvider1.SetError((Control)sender, "Select menú item ");
                //MessageBox.Show("Select menú item ");
                return;
            }
            if (_MenuItemSelected.ParentID.Equals(0) && _ShowAction == Action.Edit)
            {
                if (string.IsNullOrEmpty(txtCategory.Text))
                {
                    errorProvider1.SetError((Control)sender, "Category value must not be empty");
                    return;
                }
                //Determina si la categoria fue modificada
                //_CategoryChange = (string.Compare(txtCategory.Text, _MenuItemSelected.Category) != 0);

                errorProvider1.SetError((Control)sender, String.Empty);
            }

        }

        public EventHandler imageComboBoxEdit1_EditValueChanged { get; set; }

        private void btnAuthorizationRule_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FRM_RuleSelector wRuleSelectorForm = new FRM_RuleSelector();
            wRuleSelectorForm.OnSelectRule += new EventHandler(wRuleSelectorForm_OnSelectRule);
            wRuleSelectorForm.AllowRulesMultiSelect = false;
            wRuleSelectorForm.ShowDialog();
        }

        void wRuleSelectorForm_OnSelectRule(object sender, EventArgs e)
        {
            btnAuthorizationRule.Text = ((FRM_RuleSelector)sender).SelectedRule.Name;// wRuleSelectorForm.se //((AuthorizationRuleData)sender).Name; 
        }
    }
}
