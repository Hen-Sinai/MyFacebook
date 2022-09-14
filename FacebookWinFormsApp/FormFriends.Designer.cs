
namespace BasicFacebookFeatures
{
    partial class FormFriends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriends));
            this.panelViewInsertInfoFormFriend = new System.Windows.Forms.Panel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxFriendProfile = new System.Windows.Forms.PictureBox();
            this.panelViewMyFriend = new System.Windows.Forms.Panel();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.richTextBoxLatestPost = new System.Windows.Forms.RichTextBox();
            this.webBrowserLocation = new System.Windows.Forms.WebBrowser();
            this.labelInCommon = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.buttonViewFriendOnFB = new System.Windows.Forms.Button();
            this.panelViewInsertInfoFormFriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).BeginInit();
            this.panelViewMyFriend.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelViewInsertInfoFormFriend
            // 
            this.panelViewInsertInfoFormFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelViewInsertInfoFormFriend.BackgroundImage")));
            this.panelViewInsertInfoFormFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelViewInsertInfoFormFriend.Controls.Add(this.comboBoxCategory);
            this.panelViewInsertInfoFormFriend.Controls.Add(this.buttonSearch);
            this.panelViewInsertInfoFormFriend.Controls.Add(this.textBoxSearch);
            this.panelViewInsertInfoFormFriend.Location = new System.Drawing.Point(21, 112);
            this.panelViewInsertInfoFormFriend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelViewInsertInfoFormFriend.Name = "panelViewInsertInfoFormFriend";
            this.panelViewInsertInfoFormFriend.Size = new System.Drawing.Size(459, 348);
            this.panelViewInsertInfoFormFriend.TabIndex = 50;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(85, 29);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(330, 36);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.Text = "Choose Category";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(307, 134);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Size = new System.Drawing.Size(98, 36);
            this.buttonSearch.TabIndex = 37;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBoxSearch.Location = new System.Drawing.Point(35, 138);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.ReadOnly = true;
            this.textBoxSearch.Size = new System.Drawing.Size(253, 29);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.Text = "Search By Name...";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // pictureBoxFriendProfile
            // 
            this.pictureBoxFriendProfile.Location = new System.Drawing.Point(20, 30);
            this.pictureBoxFriendProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxFriendProfile.Name = "pictureBoxFriendProfile";
            this.pictureBoxFriendProfile.Padding = new System.Windows.Forms.Padding(1);
            this.pictureBoxFriendProfile.Size = new System.Drawing.Size(157, 156);
            this.pictureBoxFriendProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFriendProfile.TabIndex = 38;
            this.pictureBoxFriendProfile.TabStop = false;
            this.pictureBoxFriendProfile.Visible = false;
            // 
            // panelViewMyFriend
            // 
            this.panelViewMyFriend.BackColor = System.Drawing.Color.Transparent;
            this.panelViewMyFriend.Controls.Add(this.labelInCommon);
            this.panelViewMyFriend.Controls.Add(this.labelGender);
            this.panelViewMyFriend.Controls.Add(this.labelBirthday);
            this.panelViewMyFriend.Controls.Add(this.labelFriendName);
            this.panelViewMyFriend.Controls.Add(this.pictureBoxFriendProfile);
            this.panelViewMyFriend.Controls.Add(this.labelPost);
            this.panelViewMyFriend.Controls.Add(this.richTextBoxLatestPost);
            this.panelViewMyFriend.Location = new System.Drawing.Point(502, 100);
            this.panelViewMyFriend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelViewMyFriend.Name = "panelViewMyFriend";
            this.panelViewMyFriend.Size = new System.Drawing.Size(544, 548);
            this.panelViewMyFriend.TabIndex = 49;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(39, 304);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(0, 33);
            this.labelGender.TabIndex = 46;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.ForeColor = System.Drawing.Color.Black;
            this.labelBirthday.Location = new System.Drawing.Point(39, 269);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(0, 33);
            this.labelBirthday.TabIndex = 45;
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendName.ForeColor = System.Drawing.Color.Tomato;
            this.labelFriendName.Location = new System.Drawing.Point(39, 0);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(0, 50);
            this.labelFriendName.TabIndex = 44;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelPost.Location = new System.Drawing.Point(310, 56);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(118, 20);
            this.labelPost.TabIndex = 43;
            this.labelPost.Text = "Latest post..";
            this.labelPost.Visible = false;
            // 
            // richTextBoxLatestPost
            // 
            this.richTextBoxLatestPost.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBoxLatestPost.Font = new System.Drawing.Font("Aharoni", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLatestPost.Location = new System.Drawing.Point(314, 80);
            this.richTextBoxLatestPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxLatestPost.Name = "richTextBoxLatestPost";
            this.richTextBoxLatestPost.ReadOnly = true;
            this.richTextBoxLatestPost.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxLatestPost.Size = new System.Drawing.Size(174, 380);
            this.richTextBoxLatestPost.TabIndex = 40;
            this.richTextBoxLatestPost.Text = "";
            this.richTextBoxLatestPost.Visible = false;
            // 
            // webBrowserLocation
            // 
            this.webBrowserLocation.Location = new System.Drawing.Point(1015, 180);
            this.webBrowserLocation.Name = "webBrowserLocation";
            this.webBrowserLocation.Size = new System.Drawing.Size(250, 250);
            this.webBrowserLocation.TabIndex = 0;
            this.webBrowserLocation.Visible = false;
            // 
            // labelInCommon
            // 
            this.labelInCommon.AutoSize = true;
            this.labelInCommon.Location = new System.Drawing.Point(303, 4);
            this.labelInCommon.Name = "labelInCommon";
            this.labelInCommon.Size = new System.Drawing.Size(0, 20);
            this.labelInCommon.TabIndex = 47;
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(809, 49);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(0, 20);
            this.labelDetails.TabIndex = 51;
            // 
            // buttonViewFriendOnFB
            // 
            this.buttonViewFriendOnFB.BackColor = System.Drawing.Color.LightBlue;
            this.buttonViewFriendOnFB.Location = new System.Drawing.Point(1145, 436);
            this.buttonViewFriendOnFB.Name = "buttonViewFriendOnFB";
            this.buttonViewFriendOnFB.Size = new System.Drawing.Size(120, 37);
            this.buttonViewFriendOnFB.TabIndex = 48;
            this.buttonViewFriendOnFB.Text = "View Friends ";
            this.buttonViewFriendOnFB.UseVisualStyleBackColor = false;
            this.buttonViewFriendOnFB.Visible = false;
            this.buttonViewFriendOnFB.Click += new System.EventHandler(this.buttonViewFriendOnFB_Click);
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1277, 755);
            this.Controls.Add(this.buttonViewFriendOnFB);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.webBrowserLocation);
            this.Controls.Add(this.panelViewInsertInfoFormFriend);
            this.Controls.Add(this.panelViewMyFriend);
            this.Name = "FormFriends";
            this.Text = "FormFriends";
            this.Load += new System.EventHandler(this.FormFriends1_Load);
            this.panelViewInsertInfoFormFriend.ResumeLayout(false);
            this.panelViewInsertInfoFormFriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).EndInit();
            this.panelViewMyFriend.ResumeLayout(false);
            this.panelViewMyFriend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelViewInsertInfoFormFriend;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfile;
        private System.Windows.Forms.Panel panelViewMyFriend;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.RichTextBox richTextBoxLatestPost;
        private System.Windows.Forms.WebBrowser webBrowserLocation;
        private System.Windows.Forms.Label labelInCommon;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Button buttonViewFriendOnFB;
    }
}