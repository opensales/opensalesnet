﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace org.ahren.web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Prueba : IPrueba
    {
           

        public string[] GetBlogPosts()
        {
            String[] v = { "hola", "mundo" };
            return v;
        }


    }
}