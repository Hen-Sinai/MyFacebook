using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormPosts : Form
    {
        private readonly FacadeManager r_FacadeManager;

        public FormPosts(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchPosts).Start();
        }

        private void fetchPosts()
        {
            const string k_Caption = "Facebook Error! ";

            try
            {
                listBoxPosts.Items.Clear();
                foreach (Post post in r_FacadeManager.LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                    }
                    else
                    {
                        listBoxPosts.Invoke((new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))))); listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(k_Caption, ex.Message);
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            const string k_Caption = "Facebook Error!";

            try
            {
                Status postedStatus = r_FacadeManager.LoggedInUser.PostStatus(textBoxPosts.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(k_Caption, ex.Message);
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected;

            pictureBoxPost.Image = null;
            selected = r_FacadeManager.LoggedInUser.Posts[listBoxPosts.SelectedIndex];
            if (selected != null)
            {
                if (selected.Type == Post.eType.photo && selected.PictureURL != null)
                {
                    pictureBoxPost.Invoke(new Action(() => pictureBoxPost.LoadAsync(selected.PictureURL)));
                }

                try
                {
                    listBoxPostComment.Invoke(new Action(() => listBoxPostComment.DisplayMember = "Message"));
                    listBoxPostComment.Invoke(new Action(() => listBoxPostComment.DataSource = selected.Comments));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Loading comments went wrong");
                }
            }
        }

        private void listBoxPostComment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected;

            pictureBoxComment.Image = null;
            selected = r_FacadeManager.LoggedInUser.Posts[listBoxPostComment.SelectedIndex];
            if (selected.Type == Post.eType.photo)
            {
                try
                {
                    pictureBoxComment.LoadAsync(selected.PictureURL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Facebook error loading comment picture" + ex.Message);
                }
            }
        }
    }
}
