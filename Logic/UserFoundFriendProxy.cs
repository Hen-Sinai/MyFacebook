using System;
using FacebookWrapper.ObjectModel;
using System.Device.Location;

namespace Logic
{
    public class UserFoundFriendProxy
    {
        private const int k_YearIndex = 2;
        private const char k_BirthdaySign = '/';
        
        public User FacebookUser { get; }
        public int UserAge { get; private set; }
        public string Link { get; set; }
        public string PictureLargeURL { get; }
        public string CommonStr { get; set; }
        public City Location { get; }
        public string DistanceBetweenUserAndFoundFriendUser { get; private set; }

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                return FacebookUser.Posts;
            }
        }

        public UserFoundFriendProxy(User i_User)
        {
            FacebookUser = i_User;
            CommonStr = "";
            calculateUserAge();
            calculateDistanceBetweenUserAndFriend();
        }

        private void calculateDistanceBetweenUserAndFriend()
        {
            GeoCoordinateWatcher userLoggedInGeoCoordinate = new GeoCoordinateWatcher(new GeoPositionAccuracy());
            GeoCoordinate friendGeoCoordinate = new GeoCoordinate();

            if (FacebookUser.Location.Location != null)
            {
                friendGeoCoordinate.Longitude = FacebookUser.Location.Location.Longitude.Value;
                friendGeoCoordinate.Latitude = FacebookUser.Location.Location.Latitude.Value;
                DistanceBetweenUserAndFoundFriendUser = userLoggedInGeoCoordinate.Position.Location.GetDistanceTo(friendGeoCoordinate).ToString();
            }
            else
            {
                DistanceBetweenUserAndFoundFriendUser = "Can't calculate the distance.";
            }
        }

        private void calculateUserAge()
        {
            string[] birthDay;
            int userYearOfBorn = 0, currentYear = DateTime.Now.Year;

            if (FacebookUser == null)
            {
                throw new Exception("No User");
            }
            
            birthDay = FacebookUser.Birthday.Split(k_BirthdaySign);
            if (int.TryParse(birthDay[k_YearIndex], out userYearOfBorn))
            {
                UserAge = currentYear - userYearOfBorn;
            }
            else
            {
                throw new ArgumentException("Invalid birthday format.");
            }
        }

        public override string ToString()
        {
            return string.Format(
                @"{0}
Birthday: {1}
Gender: {2} 
Age: {3}
City: {4}
Relationship Status: {5}
Distance: {6}",
                FacebookUser.Name,
                FacebookUser.Birthday,
                FacebookUser.Gender,
                UserAge,
                FacebookUser.Location.Name,
                FacebookUser.RelationshipStatus.ToString(),
                DistanceBetweenUserAndFoundFriendUser);
        }
    }
}