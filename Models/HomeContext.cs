using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M6_EAI_Scrapping_Output.Class;
using MySqlConnector;

namespace M6_EAI_Scrapping_Output.Models
{
    public class HomeContext
    {
        string conn = "server=localhost;port=3306;user=root;password=;database=db_scrap";

        public ListBuku GetListBuku()
        {
            using var connection = new MySqlConnection(conn);
            ListBuku Res = new ListBuku();
            List<Buku> buku = new List<Buku>();
            try
            {
                connection.Open();
                string strquery = "SELECT * FROM scrap_page_1";
                var command = new MySqlCommand(strquery, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Buku bk = new Buku();
                    bk.id = Convert.ToString(reader["id"]);
                    bk.title = Convert.ToString(reader["title"]);
                    bk.price = Convert.ToString(reader["price"]);
                    bk.sold = Convert.ToString(reader["sold"]);
                    bk.condition = Convert.ToString(reader["condition"]);
                    bk.assurance = Convert.ToString(reader["assurance"]);
                    bk.weight = Convert.ToString(reader["weight"]);
                    bk.seller = Convert.ToString(reader["seller"]);
                    bk.description = Convert.ToString(reader["description"]);
                    buku.Add(bk);
                }
                Res.ErrorCode = "0";
                Res.ErrorDesc = "Success";
                Res.buku = buku;
            }
            catch (Exception e)
            {
                Res.ErrorCode = "1";
                Res.ErrorDesc = e.Message.ToString();
                throw;
            }

            return Res;
        }
    }
}
