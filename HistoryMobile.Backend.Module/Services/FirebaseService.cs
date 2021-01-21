using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace HistoryMobile.Backend.Module.Services
{
    public class FirebaseService
    {
        static IFirebaseConfig firebaseConfig = new FirebaseConfig
        {
            AuthSecret = "L1WdWgTaKkEWLAlmaHRpCImBqQcvp2viCMuX8zvq",
            BasePath = "https://history-6f5c0-default-rtdb.firebaseio.com/",
        };

        static IFirebaseClient client { get; set; }

        public static IFirebaseClient Client
        {
            get
            {
                if (client == null)
                {
                    client = new FirebaseClient(firebaseConfig);
                }
                return client;
            }
        }

        public static bool Insert<T>(string path, T model)
        {
            try
            {
                PushResponse response = Client.Push(path, model);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }

        }
    }
}
