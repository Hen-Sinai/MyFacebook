using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookApp.Logic;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormAlbums : Form
    {
        private readonly FacadeManager r_FacadeManager;

        public FormAlbums(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchAlbums).Start();
        }

        private void fetchAlbums()
        {
            const int k_Width = 80, k_Height = 80, k_DropLine = 5, k_MaxAlbum = 10;
            string k_Caption = "Facebook Error fetching albums.";
            int indexOfAlbums = 0,indexRow = 1, indexCol = 1;
            PictureBox pictureBoxAlbum;
            User loggedInUSer = r_FacadeManager.LoggedInUser;

            try
            {
                foreach (Album album in loggedInUSer.Albums)
                {
                    pictureBoxAlbum = new PictureBox();
                    pictureBoxAlbum.Image = album.ImageAlbum;
                    pictureBoxAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxAlbum.Location = new Point(indexCol * (pictureBoxAlbum.Width + 5), k_Height * indexRow +indexRow);
                    pictureBoxAlbum.Width = k_Width;
                    pictureBoxAlbum.Height = k_Height;
                    Label labelAlbumName = new Label
                    {
                        Text = album.Name,
                        ForeColor = Color.White,
                        BackColor = Color.Transparent
                    };
                    pictureBoxAlbum.Controls.Add(labelAlbumName);
                    pictureBoxAlbum.TabIndex = indexOfAlbums;
                    pictureBoxAlbum.Click += pictureBoxAlbum_Clicked;
                    this.Invoke(new Action(() => this.Controls.Add(pictureBoxAlbum)));
                    indexOfAlbums++;
                    if(indexOfAlbums == k_DropLine)
                    {
                        indexRow += 1;
                        indexCol = 0;
                    }

                    if (indexOfAlbums == k_MaxAlbum)
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

        private void pictureBoxAlbum_Clicked(object sender, EventArgs e)
        {
            const string k_Caption = "No Photos.";
            int indexOfChosenAlbum = (sender as PictureBox).TabIndex;

            if (r_FacadeManager.LoggedInUser.Albums[indexOfChosenAlbum].Photos.Count > 0)
            {
                new Thread(() => showFormAlbumsPhotos(indexOfChosenAlbum)).Start();
            }
            else
            {
                MessageBox.Show("There is no photos in this album", k_Caption);
            }
        }

        private void showFormAlbumsPhotos(int i_IndexOfChosenAlbum)
        {
            FormAlbumPhotos formAlbumPhotos;

            formAlbumPhotos = new FormAlbumPhotos(r_FacadeManager.LoggedInUser.Albums[i_IndexOfChosenAlbum]);
            formAlbumPhotos.ShowDialog();
        }
    }
}
