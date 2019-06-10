using System;
using System.Collections.Generic;
using Voucherify.Core.Serialization;

namespace Voucherify.Core.Extensions
{
    public static class ListExtensions
    {
        public static string ToString<T>(List<T> list){

            if (list != null) {
                List<string> result = new List<string>();

                foreach (T element in list) {
                    result.Add(element.ToString());
                }
                
                return "[" + String.Join(",", result.ToArray()) + "]";
            }

            return "null";
        }
    }
}
