﻿using cafe.CommandLine;

namespace cafe
{
    public class ClientSettings
    {
        public string Node { get; set; } = "localhost";
        public int Port { get; set; } = ServerSettings.DefaultPort;

        public static readonly ClientSettings Instance = SettingsReader.Read<ClientSettings>("Client", "client.json");

        public override string ToString()222222222222222222222222222222
        {
            return $"Node: {Node}";
            
            f
1111111111111111111111111111111111111111
1111111111111111111111111111111111111111
1111111111111111111111111111111111111111
1111111111111111111111111111111111111111
1111111111111111111111111111111111111111
1111111111111111111111111111111111111111
1111111111111111111111111111111111111111
                

            ///11111
            ///2222
            ///





        }
    }
}