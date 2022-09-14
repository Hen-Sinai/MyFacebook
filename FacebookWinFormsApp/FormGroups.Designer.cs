
namespace BasicFacebookFeatures
{
    partial class FormGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroups));
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(36, 217);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(490, 204);
            this.listBoxGroups.TabIndex = 2;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGroups.Location = new System.Drawing.Point(532, 217);
            this.pictureBoxGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(121, 106);
            this.pictureBoxGroups.TabIndex = 3;
            this.pictureBoxGroups.TabStop = false;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 454);
            this.Controls.Add(this.pictureBoxGroups);
            this.Controls.Add(this.listBoxGroups);
            this.Name = "FormGroups";
            this.Text = "FormGroups";
            this.Load += new System.EventHandler(this.FormGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
    }
}