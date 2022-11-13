using WebApiCoder.Controllers;

namespace WebApiCoder.Repository
{
    public static class Connection
    {


        public static string traerConnection()
        {
            return "Server = MARCOSLEAL1\\MSSQLSERVER01; Database = SistemaGestion; trusted_connection = True;";
        }


    }

}
