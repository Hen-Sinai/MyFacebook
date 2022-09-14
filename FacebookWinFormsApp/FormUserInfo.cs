using System;
using System.Windows.Forms;
using FacebookApp.Logic;

namespace BasicFacebookFeatures
{
    public partial class FormUserInfo : Form
    {
        private readonly FacadeManager r_FacadeManager;

        public FormUserInfo(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
        }

        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            fetchUserInfo();
        }

        private void fetchUserInfo()
        {
            const string k_Caption = "Data Error!";

            try
            {
                LabelName.Text = r_FacadeManager.LoggedInUser.Name;
                PictureBoxProfile.LoadAsync(r_FacadeManager.LoggedInUser.PictureNormalURL);
                PictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                LabelFriendNum.Text = r_FacadeManager.LoggedInUser.Friends.Count.ToString();
                LabelBirthday.Text = r_FacadeManager.LoggedInUser.Birthday;
                LabelEmail.Text = r_FacadeManager.LoggedInUser.Email;
                LabelLocation.Text = r_FacadeManager.LoggedInUser.Location.ToString();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(k_Caption, ex.Message);
            }
        }
    }
}
