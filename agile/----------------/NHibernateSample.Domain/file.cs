using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateSample.Domain
{
    public class file
    {
        public virtual int id { get; set; }
        public virtual string title { get; set; }
        public virtual string type { get; set; }
        public virtual DateTime time { get; set; }
        public virtual string text { get; set; }

        /*
        public void changename(string btitle)
        {
            title = btitle;
        }
        */

        public virtual void changetype(string btype)
        {
            type = btype;
        }

        public virtual void changetime()
        {
            DateTime btime = DateTime.Now;
            time = btime;
        }

        public virtual void changetext(string btext)
        {
            text = btext;
        }
    }
}
