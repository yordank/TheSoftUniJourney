using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photographers
{
    class TagTransofrmer
    { 
        public static string Transform(string TagValue)
        {
            if(!TagValue.StartsWith("#"))
            {
                TagValue = "#" + TagValue;
            }
            if(TagValue.Contains(" "))
            {
                TagValue = TagValue.Replace(" ", "");
            }

            if (TagValue.Contains("\t"))
            {
                TagValue = TagValue.Replace("\t", "");
            }

            if(TagValue.Length>20)
            {
                TagValue = TagValue.Substring(0, 20);
            }

            return TagValue;

        }
    }
}
