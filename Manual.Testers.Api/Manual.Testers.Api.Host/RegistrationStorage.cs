using Manual.Testers.Api.Host.Models.Account;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Manual.Testers.Api.Host
{
    public class RegistrationStorage
    {
        private static ConcurrentDictionary<string, UserData> _registratedUsers = new ConcurrentDictionary<string, UserData>();

        public static bool AddUser(UserData user) => _registratedUsers.TryAdd(user.UserName, user);

        public static bool IsRegistrated(UserData user) =>
            (_registratedUsers.Keys.Contains(user.UserName) && _registratedUsers[user.UserName].Password == user.Password);
    }
}
