using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookApp.Logic;

namespace BasicFacebookFeatures
{
    public partial class FormGroups : Form
    {
        private readonly FacadeManager r_FacadeManager;

        public FormGroups(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectedGroup;

            if (listBoxGroups.SelectedItems.Count == 1)
            {
                selectedGroup = listBoxGroups.SelectedItem as Group;
                try
                {
                    pictureBoxGroups.LoadAsync(selectedGroup.PictureNormalURL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Facebook error loading picture. " + ex.Message);
                }
            }
        }

        private void fetchGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";
            try
            {
                foreach (Group group in r_FacadeManager.LoggedInUser.Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Facebook error fetching groups." + ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void FormGroups_Load(object sender, EventArgs e)
        {
            fetchGroups();
        }
    }
}