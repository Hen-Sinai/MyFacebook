
namespace BasicFacebookFeatures
{
    partial class FormPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosts));
            this.textBoxPosts = new System.Windows.Forms.TextBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxPostComment = new System.Windows.Forms.ListBox();
            this.pictureBoxComment = new System.Windows.Forms.PictureBox();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.labelPost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPosts
            // 
            this.textBoxPosts.Location = new System.Drawing.Point(86, 44);
            this.textBoxPosts.Name = "textBoxPosts";
            this.textBoxPosts.Size = new System.Drawing.Size(363, 26);
            this.textBoxPosts.TabIndex = 0;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(33, 99);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(290, 144);
            this.listBoxPosts.TabIndex = 1;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxPostComment
            // 
            this.listBoxPostComment.FormattingEnabled = true;
            this.listBoxPostComment.ItemHeight = 20;
            this.listBoxPostComment.Location = new System.Drawing.Point(33, 261);
            this.listBoxPostComment.Name = "listBoxPostComment";
            this.listBoxPostComment.Size = new System.Drawing.Size(562, 144);
            this.listBoxPostComment.TabIndex = 2;
            this.listBoxPostComment.SelectedIndexChanged += new System.EventHandler(this.listBoxPostComment_SelectedIndexChanged);
            // 
            // pictureBoxComment
            // 
            this.pictureBoxComment.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxComment.Location = new System.Drawing.Point(521, 197);
            this.pictureBoxComment.Name = "pictureBoxComment";
            this.pictureBoxComment.Size = new System.Drawing.Size(74, 64);
            this.pictureBoxComment.TabIndex = 3;
            this.pictureBoxComment.TabStop = false;
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPost.Location = new System.Drawing.Point(341, 99);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(139, 144);
            this.pictureBoxPost.TabIndex = 4;
            this.pictureBoxPost.TabStop = false;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSetStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSetStatus.Location = new System.Drawing.Point(467, 34);
            this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(99, 42);
            this.buttonSetStatus.TabIndex = 5;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = false;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.BackColor = System.Drawing.Color.Transparent;
            this.labelPost.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPost.Location = new System.Drawing.Point(19, 19);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(113, 22);
            this.labelPost.TabIndex = 6;
            this.labelPost.Text = "new post:";
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(598, 430);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.pictureBoxPost);
            this.Controls.Add(this.pictureBoxComment);
            this.Controls.Add(this.listBoxPostComment);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.textBoxPosts);
            this.Name = "FormPosts";
            this.Text = "FormPosts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxPostComment;
        private System.Windows.Forms.PictureBox pictureBoxComment;
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.Label labelPost;
    }
}