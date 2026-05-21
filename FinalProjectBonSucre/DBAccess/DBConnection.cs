namespace FinalProjectBonSucre.DBAccess
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=ZACS_WINDOWS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Command Timeout=0";
            return new SqlConnection(connectionString);
        }
    }
}
