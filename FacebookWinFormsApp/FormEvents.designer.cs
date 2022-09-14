
namespace BasicFacebookFeatures
{
    partial class FormEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvents));
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonAttend = new System.Windows.Forms.Button();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(40, 174);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(324, 264);
            this.listBoxEvents.TabIndex = 0;
            // 
            // buttonAttend
            // 
            this.buttonAttend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAttend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAttend.BackgroundImage")));
            this.buttonAttend.Enabled = false;
            this.buttonAttend.FlatAppearance.BorderSize = 0;
            this.buttonAttend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttend.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAttend.Location = new System.Drawing.Point(384, 392);
            this.buttonAttend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAttend.Name = "buttonAttend";
            this.buttonAttend.Size = new System.Drawing.Size(232, 46);
            this.buttonAttend.TabIndex = 9;
            this.buttonAttend.Text = "Respond Attending!";
            this.buttonAttend.UseVisualStyleBackColor = true;
            this.buttonAttend.Visible = false;
            this.buttonAttend.Click += new System.EventHandler(this.buttonAttend_Click);
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEvent.Location = new System.Drawing.Point(432, 256);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(148, 115);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvent.TabIndex = 8;
            this.pictureBoxEvent.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(391, 174);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 20);
            this.labelDate.TabIndex = 10;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(391, 217);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(0, 20);
            this.labelLocation.TabIndex = 11;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 451);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonAttend);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.listBoxEvents);
            this.Name = "FormEvents";
            this.Text = "FormEvents";
            this.Load += new System.EventHandler(this.FormEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonAttend;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelLocation;
    }
}