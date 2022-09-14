using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Logic;

namespace FacebookApp
{
    namespace Logic
    {
        public sealed class FacadeManager
        {
            private static readonly object sr_CreateLock = new object();
            private AppSettings m_AppSettings;
            private static FacadeManager s_This;
            
            public User LoggedInUser { get; set; }
            public LoginResult LoginResult { get; private set; }
            public static FacadeManager Instance
            {
                get
                {
                    if (s_This == null)
                    {
                        lock (sr_CreateLock)
                        {
                            if (s_This == null)
                            {
                                s_This = new FacadeManager();
                            }
 
                        }
                    }

                    return s_This;
                }
            }

            private FacadeManager()
            {
                LoginResult = null;
                LoggedInUser = null;
                m_AppSettings = null;
            }

            public List<String> BDCards
            {
                get
                {
                    return m_AppSettings.BDCards;
                }
            }

            public bool RememberUser
            {
                get
                {
                    return m_AppSettings.RememberMeUser;
                }
            }

            public void InitializationAppSettings()
            {
                m_AppSettings = AppSettings.LoadFromFile();
            }

            public void LogoutFromFacebook()
            {
                if (m_AppSettings.LastAccessToken == null)
                {
                    FacebookService.LogoutWithUI();
                }

                LoginResult = null;
            }

            public void RememberFormDetails(bool i_RememberUser)
            {
                m_AppSettings.RememberMeUser = i_RememberUser;
                m_AppSettings.LastAccessToken = (m_AppSettings.RememberMeUser && LoginResult != null) ?
                    LoginResult.AccessToken : null;
                m_AppSettings.SaveToFile();
            }

            public UserFoundFriendProxy GetMyRandomFriendAccordingToCategory(string i_ChosenCategory)
            {
                string o_InCommon = "";

                if (LoggedInUser == null)
                {
                    throw new MisuseException("No login info.", "User");
                }

                return Features.GetMyRandomFriendAccordingToCategory(this, i_ChosenCategory, out o_InCommon);
            }

            private bool checkIfAutoLogin()
            {
                bool autoConncet = false;

                if (m_AppSettings.RememberMeUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
                {
                    LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                    autoConncet = true;
                }

                return autoConncet;
            }

            public void AddCardToSavedCards(string i_Card_Message)
            {
                Features.AddCardToSavedCards(this, i_Card_Message);
            }

            public void PostBDCard(User i_BDFriend, string i_BDCard)
            {
                if (LoggedInUser == null)
                {
                    throw new MisuseException("No login info.", "User");
                }

                Features.PostBDCard(this, i_BDFriend, i_BDCard);
            }

            public List<User> FindAllFriendsWithTodayBDay()
            {
                if (LoggedInUser == null)
                {
                    throw new MisuseException("No login info.", "User");
                }

                return Features.FindAllFriendsWithTodayBDay(this);
            }

            public void HandleErrorWithsUserPermission()
            {
                m_AppSettings.LastAccessToken = null;
                m_AppSettings.RememberMeUser = false;
                m_AppSettings.SaveToFile();
            }

            public void LoginToFacebook()
            {
                if (!checkIfAutoLogin())
                {
                    LoginResult = FacebookService.Login(
                        /// Our App ID:
                        "3259697794244932",
                        /// requested permissions:
                        "email",
                        "public_profile",
                        "user_age_range",
                        "user_birthday",
                        "user_events",
                        "user_friends",
                        "user_gender",
                        "user_hometown",
                        "user_likes",
                        "user_link",
                        "user_location",
                        "user_photos",
                        "user_posts",
                        "user_videos"
                    );
                }

                if (IsLoginResultAccessTokenNotNullOrEmpty())
                {
                    LoggedInUser = LoginResult.LoggedInUser;
                }
            }

            public bool IsLoginResultAccessTokenNotNullOrEmpty()
            {
                return (!string.IsNullOrEmpty(LoginResult.AccessToken));
            }
        }
    }
}
