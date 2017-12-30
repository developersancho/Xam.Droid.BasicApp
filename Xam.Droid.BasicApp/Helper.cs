using System;
using Newtonsoft.Json;
namespace Xam.Droid.BasicApp
{
    public static class Helper
    {

        public static string ToJson(this object item)
        {
            var value = JsonConvert.SerializeObject(item);
            return value;
        }

        public static T FromJson<T>(string item)
        {
            return JsonConvert.DeserializeObject<T>(item);
        }
    }
}
