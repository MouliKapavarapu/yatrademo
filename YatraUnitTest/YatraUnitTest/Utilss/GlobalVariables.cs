using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using NUnit.Framework;
using System.Text;
using System.Threading.Tasks;

namespace YatraUnitTest.Utilss
{
   public class GlobalVariables
    {
        public static readonly string YatraUrl = ConfigurationManager.AppSettings["YatraUrl"].ToString();
    }
}
