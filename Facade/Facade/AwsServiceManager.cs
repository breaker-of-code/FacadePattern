namespace Facade
{
    public class AwsServiceManager : ICloudService
    {
        public void Login(string username, string password)
        {
            //code to login to AWS
        }

        public void Logout()
        {
            //code to logout from AWS
        }

        public void SaveData(string data)
        {
            //code to save data to AWS
        }

        public object FetchData(string key)
        {
            //code to fetch data from AWS

            return null;
        }
    }
}