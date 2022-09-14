using System;
using System.Windows.Forms;
using FacebookApp.Logic;

namespace BasicFacebookFeatures
{
    public partial class FormFeatures : Form
    {
        private Form m_ActiveForm;
        private readonly FacadeManager r_FacadeManager;

        public FormFeatures(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_FacadeManager = i_FacadeManager;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void FormFeatures_Load(object sender, EventArgs e)
        {
            initializationStyleOfForm();
        }

        private void initializationStyleOfForm()
        {
            checkBoxRememberMe.Checked = r_FacadeManager.RememberUser;
        }

        private void pictureBoxUserInfo_Click(object sender, EventArgs e)
        {
            Form formUserInfo = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormUserInfo);

            m_ActiveForm = formUserInfo;
            formUserInfo.ShowDialog();
        }

        private void pictureBoxEvents_Click(object sender, EventArgs e)
        {
            Form formEvents = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormEvents);

            m_ActiveForm = formEvents;
            formEvents.ShowDialog();
        }

        private void pictureBoxAlbums_Click(object sender, EventArgs e)
        {
            Form formAlbums = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormAlbums);

            m_ActiveForm = formAlbums;
            formAlbums.ShowDialog();
        }

        private void pictureBoxPost_Click(object sender, EventArgs e)
        {
            Form formPosts = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormPosts);

            m_ActiveForm = formPosts;
            formPosts.ShowDialog();
        }

        private void pictureBoxFriends_Click(object sender, EventArgs e)
        {
            Form formFriends = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormFriends);

            m_ActiveForm = formFriends;
            formFriends.ShowDialog();
        }

        private void pictureBoxBirthdayCard_Click(object sender, EventArgs e)
        {
            Form formBirthdayCard = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormBirthdayCard);

            m_ActiveForm = formBirthdayCard;
            formBirthdayCard.ShowDialog();
        }
       
        private void pictureBoxCheck_ins_Click(object sender, EventArgs e)
        {
            Form formCheckins = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormCheckins);

            m_ActiveForm = formCheckins;
            formCheckins.ShowDialog();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            r_FacadeManager.LogoutFromFacebook();
            checkBoxRememberMe.Checked = false;
            MessageBox.Show("Logout succeeded!");
            Close();    
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_FacadeManager.RememberFormDetails(checkBoxRememberMe.Checked);
        }

        private void pictureBoxGroups_Click(object sender, EventArgs e)
        {
            Form formGroups = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormGroups);

            m_ActiveForm = formGroups;
            formGroups.ShowDialog();
        }
    }
}