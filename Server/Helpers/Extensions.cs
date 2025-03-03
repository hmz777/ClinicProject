﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace ClinicProject.Server.Helpers
{
    public static class TempDataExtensions
    {
        public static void Put<T>(this ITempDataDictionary tempData, string key, T value) where T : class
        {
            tempData[key] = JsonConvert.SerializeObject(value);
        }

        public static T? Get<T>(this ITempDataDictionary tempData, string key) where T : class
        {
            if (tempData.TryGetValue(key, out object? o))
            {
                return JsonConvert.DeserializeObject<T>((string?)o);
            }

            return default;
        }
    }
}
