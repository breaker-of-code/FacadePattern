using System.Collections.Generic;

namespace Facade
{
    public class FirebaseServiceManager : ICloudService
    {
        public void Login(string username, string password)
        {
            //code to login to firebase
        }

        public void Logout()
        {
            //code to logout from firebase
        }

        public void SaveData(string data)
        {
            //code to save data to firebase
        }

        public object FetchData(string key)
        {
            //code to fetch data from firebase

            return null;
        }
    }
}