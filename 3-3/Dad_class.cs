using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    public abstract class Dad_class : IBaseInterface
    {
        private bool person { get; set; }
        protected Dad_class(bool Person)
        {
            person = Person;
        }
        
        public abstract void getmid();
        public abstract void print();
        protected abstract void userFill();
        protected abstract void rndFill();

        protected void Initialization(bool person)
        {

            
            if (person)
                userFill();
            else
                rndFill();
            getmid();
            print();
        }
    }
}
