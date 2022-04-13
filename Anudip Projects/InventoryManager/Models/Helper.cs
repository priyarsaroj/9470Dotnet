using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryBeginners.Models;
using CodesByAniz.Tools;

namespace InventoryBeginners.Models
{
    public static class Helper
    {
        
        public static string GetTypeName(string fullTypeName)
        {
            string retString = "";

            try
            {
                int lastIndex = fullTypeName.LastIndexOf('.') + 1;
                retString = fullTypeName.Substring(lastIndex, fullTypeName.Length - lastIndex);
            }
            catch 
            {
                retString = fullTypeName;
            }
            return retString.Replace("]","");
        }
    }
}
