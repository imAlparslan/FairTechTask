using System.Configuration;

namespace RemotingTask.Server.Database
{
    public class DatabaseSettings : ConfigurationSection
    {
        [ConfigurationProperty("DBHost", IsRequired = true)]
        public string DBHost
        {
            get { return (string)this["DBHost"]; }
            private set { this["DBHost"] = value; }
        }

        [ConfigurationProperty("DBPort", IsRequired = true)]
        public string DBPort
        {
            get { return (string)this["DBPort"]; }
            private set { this["DBPort"] = value; }
        }

        [ConfigurationProperty("DBName", IsRequired = true)]
        public string DBName
        {
            get { return (string)this["DBName"]; }
            private set { this["DBName"] = value; }
        }

        [ConfigurationProperty("DBUser", IsRequired = true)]
        public string DBUser
        {
            get { return (string)this["DBUser"]; }
            private set { this["DBUser"] = value; }
        }

        [ConfigurationProperty("DBPW", IsRequired = true)]
        public string DBPW
        {
            get { return (string)this["DBPW"]; }
            private set { this["DBPW"] = value; }
        }

        public string MasterDbConnectionString
        {
            get
            {
                return $"Server={DBHost},{DBPort};Database=master;User Id={DBUser};Password={DBPW};TrustServerCertificate=True;";
            }
        }
        public string applicationConnectionString
        {
            get
            {
                return $"Server={DBHost},{DBPort};Database={DBName};User Id={DBUser};Password={DBPW};TrustServerCertificate=True;";
            }
        }


        public static DatabaseSettings Load()
        {
            return (DatabaseSettings)ConfigurationManager.GetSection("DatabaseSettings");
        }
    }
}
