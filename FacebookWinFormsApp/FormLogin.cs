using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookApp.Logic;
using Facebook;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private Form m_FeaturesForm;
        private readonly FacadeManager r_FacadeManager;

        public FormLogin()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            r_FacadeManager = FacadeManager.Instance;
        }

        public FacadeManager FacadeManager
        {
            get 
            { 
                return r_FacadeManager;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                r_FacadeManager.InitializationAppSettings();
                r_FacadeManager.LoginToFacebook();

                if (r_FacadeManager.IsLoginResultAccessTokenNotNullOrEmpty())
                {
                    buttonLogin.Text = $"logged in as {r_FacadeManager.LoggedInUser.Name}";
                    this.Hide();
                    m_FeaturesForm = FormFactory.CreateFormAccordingToType(FormFactory.eFormType.FormFeatures);
                    m_FeaturesForm.ShowDialog();
                    buttonLogin.Text = "Login";
                }
                else
                {
                    MessageBox.Show(r_FacadeManager.LoginResult.ErrorMessage, "Login Failed");
                }
            }
            catch (FacebookOAuthException exception)
            {
                r_FacadeManager.HandleErrorWithsUserPermission();
                MessageBox.Show(exception.Message, "Login Failed");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
        }
    }
}
