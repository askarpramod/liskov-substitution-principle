namespace LSP
{
    public static class DatabaseGateway
    {
        private const string WriteToDatabase = "write to database";

        private static string Database;

        public static void WriteToDBForce(PowerUser user, string message)
        {
            user.SetupAccessRight(WriteToDatabase, true);
            WriteToDB(user, message);
        }

        public static void WriteToDB(PowerUser user, string message)
        {
            if (user.GetValueOfAccessRight(WriteToDatabase))
            {
                Database = message;
            }
        }

        public static string ReadFromDB()
        {
            return Database;
        }
    }
}