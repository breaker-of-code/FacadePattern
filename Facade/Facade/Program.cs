namespace Facade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Program _instance = new Program();

            _instance.LoginToCloud(new FirebaseServiceManager(), "hafeez.akram", "password");
            _instance.FetchDataFromCloud(new AwsServiceManager(), "123");
            _instance.LogoutFromCloud(new FirebaseServiceManager());
            _instance.SaveDataToCloud(new PlayfabServiceManager(), "this is an example of Facade Pattern");
        }
        
        private void LoginToCloud(ICloudService service, string username, string password)
        {
            service.Login(username, password);
        }
        
        private void LogoutFromCloud(ICloudService service)
        {
            service.Logout();
        }
        
        private void SaveDataToCloud(ICloudService service, string data)
        {
            service.SaveData(data);
        }

        private void FetchDataFromCloud(ICloudService service, string key)
        {
            service.FetchData(key);
        }
    }
}