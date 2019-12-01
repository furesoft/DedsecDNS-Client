using nUpdate.Updating;
using System;
using System.Globalization;
using System.Reflection;

namespace DedSecDns_Client.Core
{
    public static class Updater
    {
        public static UpdateManager manager;

        public static void Init()
        {
            var currentVersion = new UpdateVersion(Assembly.GetExecutingAssembly().GetName().Version.ToString());

            manager = new UpdateManager(new Uri("http://furesoft.bplaced.net/updates/dns-client/updates.json"), "<RSAKeyValue><Modulus>taqq8+iZppH4sm8L49YHAWBf/l5HkJik9jl452i5zegfUYYpNfAAyWEmZlbFROGp/JymFU87+OAnLNT87IuT2QI/zQ8mUPJCdSK7nE1dp2RpLFvloJOuUER8rjJnS/R6ZfgrklaprBRpneKaW84h5FaczvFUPlvZYHtg1+bdD3bVWj81GjSEjWOaY8+gr0DEMhXCofvtgUUShRSeRivTAtVPUwPQPxn4IjsiCaBtyW4IaArdSFDGiKIW861P+SVzvEbZec3vHP0WvS/OT8mB9V6Cj7euCD5Bdq7mbTkmPW+LLAAretbbT82DdDInMBWBdA7An/SSTVoJNXirOE4bYQp5ZkmvE2lzMs4yUiXqFlWc2ukx/L20IGCMA5p7+TRYmw/BRFoMUntmMbVXh2m9m/4I0hafTXMS1+t6Zq3pBmeiBBHd7+vtYH3WU/a4Y45FSZqr/sVErLy7pPWbmKCSYY7IyKWMb3npu9Y9A8SNwzVqXy5HETq0xFJNbZ3+lpocj7fXnMLv/7H5QEood3wMFv1wet38BOX6mwvTdjWuwlUCsRNWNIghP1yvdW0mL1pL15l5lroycQDz+JT2Mld9YaLIQ5NbxF24HVW4cq5aFXKoOh8V6rDUvhYTEZz0zGpthpzulvtYGoYmnQrCfLSWiGxa4BkuzGpaT1D6qX1dX2irp66OYoj3qJOsIU94jP6va8/5wxp2+7pPEBw03/b63M9079Rijf/XBw6/CFNxRU9jdYuPzXtgfTXNXuKvuTTx0cDbHPQ3BHuIjkPBQTp8tt8FsT895cGfwcISEyZWqlTug+feo5+8g4yem5qDIc/2htPsJOb+ehjRwFsCFPnbZQgJePn5UConQCuZX09bXRGhZt1H5pqF8S0wZBBp6s4ePOnrNzqj6pglj6q9JZFFKVIMgm63waNlKCF/14YY4ZvCtB+j2FmVZ/jrWgLZV1mBxX1uk98KwslZIG4sHoalNaQxlZeVSJ1mDmyu84X8tsRfe514gdkNDcTI2MDCLIxKnfeyGrHqydNkHlqL7zDNRLIh8iapEz4Fx5pXFIZ6HNbnyPKLhiIUuFgP1Fr7oCF1GLhrIbDQEutc71USzDkGlEskONd0hAAyKVq7NKP4KyI0bSurw7UawD6/rk5f2e96VDgC4fcpiZ6DTlhfcnl+OxOWtRlVbRvzvn9IwzwpiGtrbtnnVwKh4cjV/FJJbDG9Ax3g3/NrzLT99KP0scJqgbYP0wsecqAmezSxm6RRK2L6Y1H0rop1LVtD43MjoSfE1rocoKMms5+ZUffObHQB3zAUxg+3Igd4sO4TRGCzs/9eX0O4D/8YL2B9tj2ifAFVcaOFcLkBRG0sYD02eUI72Q==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", new CultureInfo("en"), currentVersion);
            manager.RunInstallerAsAdmin = false;
        }

        public static void InstallIfAvailable()
        {
            if (manager.SearchForUpdates())
            {
                manager.DownloadPackages();
                manager.InstallPackage();
            }
        }
    }
}