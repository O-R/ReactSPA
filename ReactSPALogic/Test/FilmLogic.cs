using Microsoft.Data.Sqlite;
using ReactSPADal.Core;
using ReactSPAModel.Test;

namespace ReactSPALogic.Test
{
    public class FilmLogic
    {

        public void test(string conectpath)
        {
            SqliteConnectionStringBuilder sb = new SqliteConnectionStringBuilder();
            sb.DataSource = conectpath;
            var result = new SqlHelper(new SqliteDapper()).GetList<Film>(sb.ToString(), "select * from film", null);
            // new SqliteDapper()
            // new SqliteDapper().ExcuteNonQuery<Film>("","",null);
        }
    }
}