using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDsurBDDimmo
{
    public struct Methode
    {
        public string DefinirChemainBDD()
        {
            return "server=localhost; database=immo; port=3306;User Id=root; password=root";
        }
        public bool ChercheUtilisateurs(out DataSet infos)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBDO);
            string query = "";
            try
            {

            }
        }

    }
}
