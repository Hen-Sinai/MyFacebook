
namespace BasicFacebookFeatures
{
    partial class FormCheck_ins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheck_ins));
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.panelChcekins = new System.Windows.Forms.Panel();
            this.checkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkinBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.checkinBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.pictureURLPictureBox = new System.Windows.Forms.PictureBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.panelChcekins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingNavigator)).BeginInit();
            this.checkinBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.DataSource = this.checkinBindingSource;
            this.listBoxCheckins.DisplayMember = "Name";
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 20;
            this.listBoxCheckins.Location = new System.Drawing.Point(111, 267);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(399, 364);
            this.listBoxCheckins.TabIndex = 1;
            // 
            // panelChcekins
            // 
            this.panelChcekins.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelChcekins.Controls.Add(createdTimeLabel);
            this.panelChcekins.Controls.Add(this.createdTimeDateTimePicker);
            this.panelChcekins.Controls.Add(descriptionLabel);
            this.panelChcekins.Controls.Add(this.descriptionTextBox);
            this.panelChcekins.Controls.Add(this.nameLabel1);
            this.panelChcekins.Controls.Add(this.pictureURLPictureBox);
            this.panelChcekins.Location = new System.Drawing.Point(517, 267);
            this.panelChcekins.Name = "panelChcekins";
            this.panelChcekins.Size = new System.Drawing.Size(360, 364);
            this.panelChcekins.TabIndex = 2;
            // 
            // checkinBindingSource
            // 
            this.checkinBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Checkin);
            // 
            // checkinBindingNavigator
            // 
            this.checkinBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.checkinBindingNavigator.BindingSource = this.checkinBindingSource;
            this.checkinBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.checkinBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.checkinBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.checkinBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.checkinBindingNavigatorSaveItem});
            this.checkinBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.checkinBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.checkinBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.checkinBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.checkinBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.checkinBindingNavigator.Name = "checkinBindingNavigator";
            this.checkinBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.checkinBindingNavigator.Size = new System.Drawing.Size(946, 33);
            this.checkinBindingNavigator.TabIndex = 3;
            this.checkinBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // checkinBindingNavigatorSaveItem
            // 
            this.checkinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.checkinBindingNavigatorSaveItem.Enabled = false;
            this.checkinBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("checkinBindingNavigatorSaveItem.Image")));
            this.checkinBindingNavigatorSaveItem.Name = "checkinBindingNavigatorSaveItem";
            this.checkinBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.checkinBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(13, 155);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(108, 20);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.checkinBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(17, 178);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(340, 26);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(13, 75);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(17, 110);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(340, 26);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(13, 21);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(200, 23);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "label1";
            // 
            // pictureURLPictureBox
            // 
            this.pictureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.checkinBindingSource, "PictureURL", true));
            this.pictureURLPictureBox.Location = new System.Drawing.Point(225, 243);
            this.pictureURLPictureBox.Name = "pictureURLPictureBox";
            this.pictureURLPictureBox.Size = new System.Drawing.Size(89, 82);
            this.pictureURLPictureBox.TabIndex = 7;
            this.pictureURLPictureBox.TabStop = false;
            // 
            // FormCheck_ins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 683);
            this.Controls.Add(this.checkinBindingNavigator);
            this.Controls.Add(this.panelChcekins);
            this.Controls.Add(this.listBoxCheckins);
            this.Name = "FormCheck_ins";
            this.Text = "FormCheck_ins";
            this.Load += new System.EventHandler(this.FormCheck_ins_Load);
            this.panelChcekins.ResumeLayout(false);
            this.panelChcekins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingNavigator)).EndInit();
            this.checkinBindingNavigator.ResumeLayout(false);
            this.checkinBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.Panel panelChcekins;
        private System.Windows.Forms.BindingSource checkinBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.PictureBox pictureURLPictureBox;
        private System.Windows.Forms.BindingNavigator checkinBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton checkinBindingNavigatorSaveItem;
    }
}