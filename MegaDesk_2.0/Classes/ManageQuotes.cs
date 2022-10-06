using MegaDesk_Ebenal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MegaDesk_2_0.Classes
{
    internal class ManageQuotes
    {
        public static List<DeskQuote> GetQuotes()
        {
            return JsonConvert.DeserializeObject<List<DeskQuote>>(File.ReadAllText(@"./quotes.json"));
        }

        public static void AppendQuote(DeskQuote quote)
        {
            List<DeskQuote> list = GetQuotes() == null ? new List<DeskQuote>() : GetQuotes();
            list.Add(quote);
            File.WriteAllText(@"./quotes.json", JsonConvert.SerializeObject(list));
        }
    }
}
