using cafe.CommandLine;

namespace cafe
{
    public class ClientSettings
    {
        public string Node { get; set; } = "localhost";
        public int Port { get; set; } = ServerSettings.DefaultPort;

        public static readonly ClientSettings Instance = SettingsReader.Read<ClientSettings>("Client", "client.json");

        public override string ToString()
        {
            return $"Node: {Node}";

            ///11111
            ///2222
            ///





        }
    }
}



2222222222222222222





3333333333333333333333333



3333333333333
