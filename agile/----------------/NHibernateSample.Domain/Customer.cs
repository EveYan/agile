using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateSample.Domain
{
    public class Customer
    {
        public virtual String name { get; set; }
        public virtual String password { get; set; }
        public virtual int id { get; set; }

        //////////////////////////////////!!!!method
        /*
        public void changename(string bname)
        {
            name=bname;
        }
        */
        /*
        public virtual void changepassword(string bpass)
        {
            password = bpass;
        }*/
    }
}
