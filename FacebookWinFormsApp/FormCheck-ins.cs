using System;
using System.Windows.Forms;
using FacebookApp.Logic;

namespace BasicFacebookFeatures
{
    public partial class FormCheck_ins : Form
    {
        private readonly FacadeManager r_facadeManager;

        public FormCheck_ins(FacadeManager i_FacadeManager)
        {
            InitializeComponent();
            r_facadeManager = i_FacadeManager;
        }

        private void fetchCheck_ins()
        {
            checkinBindingSource.DataSource = r_facadeManager.LoggedInUser.Checkins;
            if (listBoxCheckins.Items.Count == 0)
            {
                MessageBox.Show("No Checkins to retrieve :(");
            }
        }

        private void FormCheck_ins_Load(object sender, EventArgs e)
        {
            fetchCheck_ins();
        }
    }
}