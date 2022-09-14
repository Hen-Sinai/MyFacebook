using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormAlbumPhotos : Form
    {
        private readonly Album r_Album;

        public FormAlbumPhotos(Album i_Album)
        {
            InitializeComponent();
            r_Album = i_Album;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchPhotos).Start();
        }

        private void fetchPhotos()
        {
            const int k_Width = 80, k_Height = 80, k_DropLine = 6, k_MaxPhotos = 18;
            const string k_Caption = "Facebook Error fetching albums.";
            int indexOfAlbums = 0, indexRow = 1, indexCol = 1;
            Label labelAlbumName;
            PictureBox pictureBoxPhoto;

            try
            {
                foreach (Photo photo in r_Album.Photos)
                {
                    pictureBoxPhoto = new PictureBox();
                    pictureBoxPhoto.Image = photo.ImageAlbum;
                    pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxPhoto.Location = new Point(indexCol * (pictureBoxPhoto.Width + 5), k_Height * indexRow + indexRow);
                    pictureBoxPhoto.Width = k_Width;
                    pictureBoxPhoto.Height = k_Height;
                    labelAlbumName = new Label
                    {
                        Text = photo.Name,
                        ForeColor = Color.White,
                        BackColor = Color.Transparent
                    };
                    pictureBoxPhoto.Controls.Add(labelAlbumName);
                    pictureBoxPhoto.TabIndex = indexOfAlbums;
                    this.Invoke(new Action(() => this.Controls.Add(pictureBoxPhoto)));
                    indexOfAlbums++;
                    if (indexOfAlbums % k_DropLine == 0)
                    {
                        indexRow += 1;
                        indexCol = 0;
                    }

                    if (indexOfAlbums == k_MaxPhotos)
                    {
                        break;
                    }

                    indexCol++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, k_Caption);
            }
        }
    }
}