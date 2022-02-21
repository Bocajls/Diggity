using Diggity.Project.Models.Concrete;
using Diggity.Project.Utilities;
using Newtonsoft.Json;
using System.IO;

namespace Diggity.Project.Context
{
    public class ContextHandler
    {
        private string _basePath => $@"{Path.GetTempPath()}\Diggity\";

        public ContextHandler()
        {
            if (!Directory.Exists(_basePath))
            {
                Directory.CreateDirectory(_basePath);
            }
        }

        public void SaveWorld(World world)
        {
            var file = $"{_basePath}World.txt";
            CreateFileIfNotExists(file);
            File.WriteAllText(file, Extensions.Compress(JsonConvert.SerializeObject(world, typeof(World), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto })));
        }


        public World LoadWorld()
        {
            var file = $"{_basePath}World.txt";

            CreateFileIfNotExists(file);

            return JsonConvert.DeserializeObject<World>(Extensions.Decompress(File.ReadAllText(file)), new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                NullValueHandling = NullValueHandling.Ignore,
            });
        }

        private void CreateFileIfNotExists(string file)
        {
            if (File.Exists(file))
            {
                return;
            }

            using var f = File.Create(file);
            f.Close();
        }
    }
}