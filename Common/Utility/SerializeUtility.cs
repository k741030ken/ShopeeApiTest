using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Common.Utility
{
    public class SerializeUtility
    {
        /// <summary>
        /// 將物件XML Serialize成 XML字串
        /// </summary>
        /// <param name="pObject">要轉換的物件</param>
        /// <returns></returns>
        public String SerializeObject(Object pObject)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                XmlSerializer xs = new XmlSerializer(pObject.GetType());

                StringWriter output = new StringWriter(new StringBuilder());
                xs.Serialize(output, pObject);

                return output.ToString();
            }
            catch (Exception e)
            {
                string error = e.Message;
                return null;
            }
        }

        /// <summary>
        /// 將傳入的XML字串，轉成物件
        /// </summary>
        /// <typeparam name="T">物件型態</typeparam>
        /// <param name="pXmlizedString">XML字串</param>
        /// <returns>物件</returns>
        public T DeserializeObject<T>(String pXmlizedString)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));

            StringWriter output = new StringWriter(new StringBuilder(pXmlizedString));

            TextReader stringReader = new StringReader(pXmlizedString);
            return (T)xs.Deserialize(stringReader);
        }

        /// <summary>
        /// 將傳入的XML字串，轉成物件
        /// </summary>
        /// <param name="inputType">物件型態</param>
        /// <param name="pXmlizedString">XML字串</param>
        /// <returns>物件</returns>
        public object DeserializeObject(Type inputType, String pXmlizedString)
        {
            XmlSerializer xs = new XmlSerializer(inputType);

            StringWriter output = new StringWriter(new StringBuilder(pXmlizedString));

            TextReader stringReader = new StringReader(pXmlizedString);
            return xs.Deserialize(stringReader);
        }

        /// <summary>
        /// 複制物件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sampleObject"></param>
        /// <returns></returns>
        public T CloneObject<T>(object sampleObject)
        {
            string pXmlizedString = SerializeObject(sampleObject);

            XmlSerializer xs = new XmlSerializer(typeof(T));

            StringWriter output = new StringWriter(new StringBuilder(pXmlizedString));

            TextReader stringReader = new StringReader(pXmlizedString);

            return (T)xs.Deserialize(stringReader);
        }

        /// <summary>
        /// ObjectDeserializeJsonStr
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public string ObjectDeserializeJsonStr<T>(T data)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                Type objectType = typeof(T);
                var properties = objectType.GetProperties().Where(prop => prop.CanRead && prop.CanWrite);
                StringWriter sw = new StringWriter(result);
                if (properties != null && properties.Count() > 0)
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        writer.Formatting = Formatting.Indented;
                        writer.WriteStartObject();
                        foreach (var prop in properties)
                        {
                            var name = prop.Name;
                            var value = prop.GetValue(data, null);
                            writer.WritePropertyName(name);
                            writer.WriteValue(UtilityFactory.Instance().StringUtility.IIF(value));
                        }
                        writer.WriteEndObject();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result.ToString();
        }

        /// <summary>
        /// JsonStringDeserializeObject
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="st"></param>
        /// <returns></returns>
        public TResult JsonStringDeserializeObject<TResult>(string st)
        {
            byte[] jsonBytes = Encoding.UTF8.GetBytes(st);
            using (var stream = new MemoryStream(jsonBytes))
            {
                return JsonDeserializeObject<TResult>(stream);
            }
        }

        /// <summary>
        /// JsonDeserializeObject
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="responseStream"></param>
        /// <returns></returns>
        public TResult JsonDeserializeObject<TResult>(Stream responseStream)
        {
            using (var sr = new StreamReader(responseStream))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    var jstr = sr.ReadToEnd();
                    // jstr = File.ReadAllText(path); // this does not trigger warning
                    return JsonConvert.DeserializeObject<TResult>(jstr);
                    // var jObj = new JavaScriptSerializer().Deserialize<Input>(jstr); // this does not trigger warning
                }
            }
        }
    }
}
