using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MonsterScaler_WPF
{
    class JsonProcessor
    {
        JsonReader reader;
        JsonSerializer se;

        public void ReadJSONFile (string filename)
        {
            reader.Read();
            se.Deserialize(reader);
        }
    }
}
