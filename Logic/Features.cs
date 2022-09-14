using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using Logic;

namespace FacebookApp
{
    namespace Logic
    {
        internal static class Features
        {
            private delegate bool DelegateInCommon(User i_Friend, User i_User, out string o_InCommon);

            public static UserFoundFriendProxy GetMyRandomFriendAccordingToCategory(FacadeManager i_FacadeManager, string i_ChosenCategory, out string o_InCommon) // ADD: out string mutual obj
            {
                UserFoundFriendProxy userResult = null;
                DelegateInCommon functionCheckIfInCommon;

                o_InCommon = "";
                switch (i_ChosenCategory)
                {
                    case "Birthday":
                        functionCheckIfInCommon = checkIfThereIsBirthdayCommon;
                        userResult = getMyRandomFriend(i_FacadeManager, functionCheckIfInCommon, out string bDInCommon);
                        break;
                    case "Relationship status":
                        functionCheckIfInCommon = checkIfThereIsRelationshipStatusInCommon;
                        userResult = getMyRandomFriend(i_FacadeManager, functionCheckIfInCommon, out string rSInCommon);
                        break;
                    case "Liked pages":
                        functionCheckIfInCommon = checkIfThereIsPageInCommon;
                        userResult = getMyRandomFriend(i_FacadeManager, functionCheckIfInCommon, out string lPInCommon);
                        break;
                    case "Checks in":
                        functionCheckIfInCommon = checkIfThereIsCheckInInCommon;
                        userResult = getMyRandomFriend(i_FacadeManager, functionCheckIfInCommon, out string cIInCommon);
                        break;
                    case "Events you are not sure about":
                        functionCheckIfInCommon = checkIfThereIsEventInCommon;
                        userResult = getMyRandomFriend(i_FacadeManager, functionCheckIfInCommon, out string eInCommon);
                        break;
                }

                return userResult;
            }

            private static UserFoundFriendProxy getMyRandomFriend(FacadeManager i_Manager, DelegateInCommon i_FunctionCheckIfCommon, out string o_InCommon)
            {
                o_InCommon = "";
                List<User> listFriendsCategory = getListOfFriendsAccordingToCategory(i_Manager, i_FunctionCheckIfCommon, out o_InCommon);
                UserFoundFriendProxy userResult = null;

                if (listFriendsCategory.Count != 0)
                {
                    Random rnd = new Random();
                    int indexChosenFriend = rnd.Next(0, listFriendsCategory.Count);

                    userResult = new UserFoundFriendProxy(listFriendsCategory[indexChosenFriend]);
                    userResult.CommonStr = userResult.CommonStr += o_InCommon;
                }

                return userResult;
            }

            private static List<User> getListOfFriendsAccordingToCategory(FacadeManager i_FacadeManager,
                DelegateInCommon i_FunctionCheckIfCommon, out string o_InCommon)
            {
                List<User> resFriendsList = new List<User>();

                o_InCommon = "";
                foreach (User friend in i_FacadeManager.LoggedInUser.Friends)
                {
                    if (i_FunctionCheckIfCommon(friend, i_FacadeManager.LoggedInUser, out o_InCommon))
                    {
                        resFriendsList.Add(friend);
                    }
                }

                return resFriendsList;
            }

            private static bool checkIfThereIsBirthdayCommon(User i_Friend, User i_User, out string o_InCommon)
            {
                bool res = false;

                o_InCommon = "";
                if (i_Friend.Birthday == i_User.Birthday)
                {
                    o_InCommon = "Same Birthday!";
                    res = true;
                }

                return res;
            }

            private static bool checkIfThereIsEventInCommon(User i_Friend, User i_User, out string o_InCommon)
            {
                bool isCommonEvent = false;

                o_InCommon = "";
                foreach (Event EventOfFriend in i_Friend.EventsMaybe)
                {
                    foreach (Event EventOfUser in i_User.EventsMaybe)
                    {
                        if (EventOfFriend.Id == EventOfUser.Id)
                        {
                            o_InCommon = "You're both still hesitating about the event: ";
                            o_InCommon += EventOfUser.Name;
                            isCommonEvent = true;
                            break;
                        }
                    }

                    if (isCommonEvent == true)
                    {
                        break;
                    }
                }

                return isCommonEvent;
            }

            private static bool checkIfThereIsCheckInInCommon(User i_Friend, User i_User, out string o_InCommon)
            {
                bool isCommonCheckIn = false;

                o_InCommon = "";
                foreach (Checkin checkInFriend in i_Friend.Checkins)
                {
                    foreach (Checkin checkInUser in i_User.Checkins)
                    {
                        if (checkInFriend.Id == checkInUser.Id)
                        {
                            o_InCommon = "You both checked in at ";
                            o_InCommon += checkInFriend.Name;
                            isCommonCheckIn = true;
                            break;
                        }
                    }

                    if (isCommonCheckIn == true)
                    {
                        break;
                    }
                }

                return isCommonCheckIn;
            }

            private static bool checkIfThereIsPageInCommon(User i_Friend, User i_User, out string o_InCommon)
            {
                bool isCommonPage = false;

                o_InCommon = "";
                foreach (Page pageLikeFriend in i_Friend.LikedPages)
                {
                    foreach (Page pageLikeUser in i_User.LikedPages)
                    {
                        if (pageLikeUser.Id == pageLikeFriend.Id)
                        {
                            o_InCommon = "You both like: ";
                            o_InCommon += pageLikeUser.Name;
                            isCommonPage = true;
                            break;
                        }
                    }

                    if (isCommonPage == true)
                    {
                        break;
                    }
                }

                return isCommonPage;
            }

            private static bool checkIfThereIsRelationshipStatusInCommon(User i_Friend, User i_User, out string o_InCommon)
            {
                o_InCommon = "";
                if (i_Friend.RelationshipStatus == i_User.RelationshipStatus)
                {
                    o_InCommon = "Both your relationship statuses are: ";
                    o_InCommon += i_User.RelationshipStatus.ToString().ToLower();
                }

                return o_InCommon.Length > 0;
            }

            public static void AddCardToSavedCards(FacadeManager i_Manager, string i_Card_Message)
            {
                if (!i_Manager.BDCards.Contains(i_Card_Message))
                    i_Manager.BDCards.Add(i_Card_Message);
            }

            public static void PostBDCard(FacadeManager i_Manager, User i_BDFriend, string i_BDCard)
            {
                string friendID = i_BDFriend.Id;

                i_Manager.LoggedInUser.PostStatus(i_BDCard, null, null, friendID);
            }

            public static List<User> FindAllFriendsWithTodayBDay(FacadeManager i_FacadeManager)
            {
                List<User> res_Friends_List = new List<User>();
                string today_Date = DateTime.Today.ToString();

                foreach (User friend in i_FacadeManager.LoggedInUser.Friends)
                {
                    if (friend.Birthday == today_Date)
                    {
                        res_Friends_List.Add(friend);
                    }
                }

                return res_Friends_List;
            }
        }
    }
}

