namespace Facade
{
    public interface ICloudService
    {
        void Login(string username, string password);

        void Logout();
        
        void SaveData(string data);

        object FetchData(string key);
    }
}