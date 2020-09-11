using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FireSharp

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

//

namespace DataAcess
{
    public  class Connect
    {


        public static IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "gVKZV6XGTxCDGqVLanc8p9Rkw6Z3Ey2efNk8wbNk",
            BasePath = "https://ricoydesign.firebaseio.com/"
        };

    }
}
