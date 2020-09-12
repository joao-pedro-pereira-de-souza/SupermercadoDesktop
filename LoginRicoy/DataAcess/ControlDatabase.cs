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

using System.Data;


namespace DataAcess
{
    public class ControlDatabase
    {

        public IFirebaseClient client;

        public ControlDatabase()
        {
            client = new FireSharp.FirebaseClient(Connect.config);
        }

        public List<Produtos> GetList(string listDiretory)
        {
            FirebaseResponse response = client.Get(listDiretory);

            List<Produtos> Prod = response.ResultAs<List<Produtos>>();

            return Prod;
        }

        public void SetListProd(string lisDiretory, Produtos prods)
        {
            FirebaseResponse response = client.Set(lisDiretory, prods);

        }

      
    }
}
