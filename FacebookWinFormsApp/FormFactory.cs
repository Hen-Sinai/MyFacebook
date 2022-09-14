using System;
using System.Windows.Forms;
using FacebookApp.Logic;

namespace BasicFacebookFeatures
{
    internal static class FormFactory
    {
        private static FormLogin s_FormLogin;

        public enum eFormType
        {
            FormLogin,
            FormUserInfo,
            FormPhotoAlbums,
            FormAlbums,
            FormBirthdayCard,
            FormCheckins,
            FormEvents,
            FormFeatures,
            FormFriends,
            FormGroups,
            FormPosts
        }

        public static Form CreateFormAccordingToType(eFormType i_TypeOfFormToCreate)
        {
            Form formToReturn;

            if (i_TypeOfFormToCreate != eFormType.FormLogin && s_FormLogin == null)
            {
                throw new MisuseException("No login info.", "FormLogin");
            }

            switch (i_TypeOfFormToCreate)
            {
                case eFormType.FormLogin:
                    s_FormLogin = new FormLogin();
                    formToReturn = s_FormLogin;
                    break;
                case eFormType.FormUserInfo:
                    formToReturn = new FormUserInfo(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormAlbums:
                    formToReturn = new FormAlbums(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormFeatures:
                    formToReturn = new FormFeatures(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormBirthdayCard:
                    formToReturn = new FormBirtdayCard(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormGroups:
                    formToReturn = new FormGroups(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormPosts:
                    formToReturn = new FormPosts(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormEvents:
                    formToReturn = new FormEvents(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormFriends:
                    formToReturn = new FormFriends(s_FormLogin.FacadeManager);
                    break;
                case eFormType.FormCheckins:
                    formToReturn = new FormCheck_ins(s_FormLogin.FacadeManager);
                    break;
                default:
                    throw new Exception("invalid form to create.");
            }

            return formToReturn;
        }
    }
}

