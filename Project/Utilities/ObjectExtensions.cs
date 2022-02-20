﻿using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Diggity.Project.Utilities
{
    public static class ObjectExtensions
    {
        public static T CopyObject<T>(this object objSource)
        {
            using MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, objSource);
            stream.Position = 0;
            return (T)formatter.Deserialize(stream);
        }

        public static T CreateDeepCopy<T>(T obj)
        {
            using var ms = new MemoryStream();
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(ms, obj);
            ms.Seek(0, SeekOrigin.Begin);
            return (T)serializer.Deserialize(ms);
        }

        public static object DeepCopyJson(object o)
        {
            JsonSerializerOptions jsonOptions;
            jsonOptions = new JsonSerializerOptions();
            jsonOptions.Converters.Add(new JsonStringEnumConverter());
            var json = JsonSerializer.Serialize(o, jsonOptions);
            return JsonSerializer.Deserialize(json, o.GetType(), jsonOptions);
        }
    }
}
