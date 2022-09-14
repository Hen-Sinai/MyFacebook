
namespace BasicFacebookFeatures
{
    partial class FormBirtdayCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBirtdayCard));
            this.richTextBoxBDCard = new System.Windows.Forms.RichTextBox();
            this.labelCard = new System.Windows.Forms.Label();
            this.listBoxBDFriends = new System.Windows.Forms.ListBox();
            this.flowLayoutPanelBDCards = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddBDCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxBDCard
            // 
            this.richTextBoxBDCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxBDCard.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxBDCard.Location = new System.Drawing.Point(25, 66);
            this.richTextBoxBDCard.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxBDCard.Name = "richTextBoxBDCard";
            this.richTextBoxBDCard.ReadOnly = true;
            this.richTextBoxBDCard.Size = new System.Drawing.Size(452, 87);
            this.richTextBoxBDCard.TabIndex = 1;
            this.richTextBoxBDCard.Text = "Tell your friends how much you care, \nbut in you own special way...";
            this.richTextBoxBDCard.Click += new System.EventHandler(this.richTextBoxBDCard_Click);
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.BackColor = System.Drawing.Color.Transparent;
            this.labelCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCard.Location = new System.Drawing.Point(20, 23);
            this.labelCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(254, 30);
            this.labelCard.TabIndex = 4;
            this.labelCard.Text = "Create Birthday Card!";
            // 
            // listBoxBDFriends
            // 
            this.listBoxBDFriends.Font = new System.Drawing.Font("Aharoni", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBDFriends.FormattingEnabled = true;
            this.listBoxBDFriends.ItemHeight = 16;
            this.listBoxBDFriends.Location = new System.Drawing.Point(11, 183);
            this.listBoxBDFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBDFriends.Name = "listBoxBDFriends";
            this.listBoxBDFriends.Size = new System.Drawing.Size(163, 228);
            this.listBoxBDFriends.TabIndex = 5;
            this.listBoxBDFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxBDFriends_SelectedIndexChanged);
            // 
            // flowLayoutPanelBDCards
            // 
            this.flowLayoutPanelBDCards.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBDCards.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelBDCards.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanelBDCards.Location = new System.Drawing.Point(178, 183);
            this.flowLayoutPanelBDCards.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelBDCards.Name = "flowLayoutPanelBDCards";
            this.flowLayoutPanelBDCards.Size = new System.Drawing.Size(453, 249);
            this.flowLayoutPanelBDCards.TabIndex = 6;
            // 
            // buttonAddBDCard
            // 
            this.buttonAddBDCard.AccessibleDescription = "Add Card";
            this.buttonAddBDCard.AccessibleName = "Add Card";
            this.buttonAddBDCard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddBDCard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAddBDCard.FlatAppearance.BorderSize = 0;
            this.buttonAddBDCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBDCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBDCard.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddBDCard.Location = new System.Drawing.Point(504, 79);
            this.buttonAddBDCard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddBDCard.Name = "buttonAddBDCard";
            this.buttonAddBDCard.Size = new System.Drawing.Size(109, 41);
            this.buttonAddBDCard.TabIndex = 7;
            this.buttonAddBDCard.Tag = "";
            this.buttonAddBDCard.Text = "Add Card";
            this.buttonAddBDCard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonAddBDCard.UseVisualStyleBackColor = false;
            this.buttonAddBDCard.Click += new System.EventHandler(this.buttonAddBDCard_Click);
            // 
            // FormBirtdayCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(642, 458);
            this.Controls.Add(this.flowLayoutPanelBDCards);
            this.Controls.Add(this.buttonAddBDCard);
            this.Controls.Add(this.listBoxBDFriends);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.richTextBoxBDCard);
            this.Name = "FormBirtdayCard";
            this.Text = "FormBirtdayCard";
            this.Load += new System.EventHandler(this.FormBirtdayCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxBDCard;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.ListBox listBoxBDFriends;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBDCards;
        private System.Windows.Forms.Button buttonAddBDCard;
    }
}