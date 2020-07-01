using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Reyuko.Utils.Common
{
    public static class Helper
    {
        public enum enUploadType
        {
            Images,
            Files,
        }

        public static string UploadFilter(enUploadType type)
        {
            string filter = "";
            if (type == enUploadType.Images)
            {
                filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                    "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                    "Portable Network Graphic (*.png)|*.png";
            }
            else if (type == enUploadType.Files)
            {
                filter = "AllFiles|*.*";
            }

            return filter;
        }
        public static string UploadFile(enUploadType type, Stream file, string filename)
        {
            try
            {
                string path = "./files";
                if (type == enUploadType.Images)
                    path = path + "/images";
                else if (type == enUploadType.Files)
                    path = path + "/files";

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                path = path + "/" + filename;

                if (File.Exists(path))
                    File.Delete(path);

                BinaryReader reader = new BinaryReader(file);
                FileStream fstream = new FileStream(path, FileMode.CreateNew);
                BinaryWriter wr = new BinaryWriter(fstream);
                wr.Write(reader.ReadBytes((int)file.Length));
                wr.Close();
                fstream.Close();

                return path;
            }
            catch (Exception ex)
            {
            }

            return "";
        }

        public static bool IsNumeric(string number)
        {
            int n;
            var isNum = int.TryParse(number, out n);
            return isNum;
        }

        public static bool IsDateTime(string date)
        {
            DateTime dt;
            var isDate = DateTime.TryParse(date, out dt);
            return isDate;
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey> (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static String UnCamelCase(String s, string d)
        {
            Regex r = new Regex(
               @"  (?<=[A-Z])(?=[A-Z][a-z])    # UC before me, UC lc after me
                |  (?<=[^A-Z])(?=[A-Z])        # Not UC before me, UC after me
                |  (?<=[A-Za-z])(?=[^A-Za-z])  # Letter before me, non letter after me
                ",
               RegexOptions.IgnorePatternWhitespace
            );

            string result = "";
            foreach (string part in r.Split(s))
            {
                result += part + d;
            }

            return result.Substring(0, result.Length - 1);
        }

        public static decimal Round(decimal number, int precision)
        {
            return System.Math.Round(number, precision);
        }

        public static string SerializeObject(object obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj, new Newtonsoft.Json.JsonSerializerSettings { StringEscapeHandling = Newtonsoft.Json.StringEscapeHandling.EscapeHtml });
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static object MapTo<T>(this T ObjectFrom, object ObjectTo)
        {
            var listProperty = ObjectFrom.GetType().GetProperties();
            foreach (var prop in listProperty)
            {
                var PropObjB = (from obj in ObjectTo.GetType().GetProperties().ToList()
                                where obj.Name == prop.Name
                                select obj).FirstOrDefault();
                if (PropObjB != null)
                {
                    ObjectTo.GetType().GetProperty(prop.Name).SetValue(ObjectTo, prop.GetValue(ObjectFrom, null), null);
                }
            }
            return ObjectTo;
        }

        public static object MapFrom<T>(this T ObjectTo, object ObjectFrom)
        {
            var listProperty = ObjectFrom.GetType().GetProperties();
            foreach (var prop in listProperty)
            {
                var PropObjB = (from obj in ObjectTo.GetType().GetProperties().ToList()
                                where obj.Name == prop.Name
                                select obj).FirstOrDefault();
                if (PropObjB != null)
                {
                    ObjectTo.GetType().GetProperty(prop.Name).SetValue(ObjectTo, prop.GetValue(ObjectFrom, null), null);
                }
            }
            return ObjectTo;
        }

    }
}
