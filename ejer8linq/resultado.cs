using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer8linq
{
    class resultado
    {
       
            private int ID_number;
            private string ID_name;
            private int Quantity_Sell;

            public resultado(int ID_number, string ID_name,int Quantity_Sell)
            {
                this.ID_number = ID_number;
                this.ID_name = ID_name;
                this.Quantity_Sell = Quantity_Sell;
            }

            public int getID_number()
            {
                return ID_number;
            }
            public void setID_number(int ID_number)
            {
                this.ID_number=ID_number;
            }
            public string getID_name()
            {
                return ID_name;
            }
            public void setID_name(string ID_name)
            {
                 this.ID_name=ID_name;
            }
            public int GetQuantity_Sell()
            {
                return Quantity_Sell;
            }

            public void setQuantity_Sell(int Quantity_Sell)
            {
                 this.Quantity_Sell=Quantity_Sell;
            }


        public override string ToString()
        {
            return ID_number + "      "  + "    " + ID_name +  "        " + Quantity_Sell;
            
        }


    }
    
  
}
