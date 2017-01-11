using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9linq
{
    class cities
    {
        private string name;

        public cities(string name){
            this.name = name;
            }
        public string getCities()
        {
            return name;
        }

        public void setCities(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;

        }

    }
}
