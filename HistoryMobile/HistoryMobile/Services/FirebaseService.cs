using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace HistoryMobile.Services
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

        public static List<T> Get<T>(string path)
        {
            var response = Client.GetAsync(path);
            if(response.Result.StatusCode == HttpStatusCode.OK)
            {
                FirebaseResponse result = response.Result;
                Dictionary<string, T> collections = result.ResultAs<Dictionary<string, T>>();
                List<T> data = new List<T>();
                foreach(var key in collections.Keys)
                {
                    data.Add(collections[key]);
                }
                return data;
            }
            return null;
        }
    }
}
