namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType dbType)
        {
            if (dbType == DatabaseType.SqlServer)
            {
                return new SqlServerDatabase();
            }

            if (dbType == DatabaseType.Oracle)
            {
                return new OracleDatabase();
            }
            throw new Exception("Unknown database type");
        }
    }
}
