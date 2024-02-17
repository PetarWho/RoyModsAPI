using RoyModsAPI.Contracts;

namespace RoyModsAPI.Services
{
    public class UserService : IUserService
    {
        public List<string> GetUsers(string path)
        {

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string fileContents = reader.ReadToEnd();

                    return fileContents.Trim().Split(",").ToList();
                }
            }
            catch
            {
                return new List<string>();
            }
        }
    }
}
