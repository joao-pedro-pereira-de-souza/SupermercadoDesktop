using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace DataAcess
{
    class ConnectUser
    {

        public static IFirebaseConfig config = new FirebaseConfig()
        {
            BasePath = "https://chatricoy.firebaseio.com/",
            AuthSecret = "aDgiNv5n3M7oq2CA9vcMIP4dPqwckCpJ4EEkSGoF"
        };



    }
}
