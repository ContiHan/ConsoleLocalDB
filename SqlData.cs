using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLocalDB
{
    internal class SqlData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public string FullInfo
        {
            get => ($"{Name} {Age}");
        }
    }
}
