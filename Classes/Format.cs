using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR18.Classes
{
    public class Format
    {
        public int id {  get; set; }
        public string format { get; set; }
        public string descrition { get; set; }

        public Format(int _id, string _format, string descrition)
        {
            this.id = _id;
            this.format = _format;
            this.descrition = descrition;
        }

        public static List<Format> AllFormats()
        {
            List<Format> allFormat = new List<Format>();
            allFormat.Add(new Format(1, "A4", ""));
            allFormat.Add(new Format(2, "A3", ""));
            allFormat.Add(new Format(3, "A2", ""));
            allFormat.Add(new Format(4, "A1", ""));

            return allFormat;
        }
    }
}
