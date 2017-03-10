using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lession_001
{
    abstract class AbstractAnimal
    {
        private string m_name;
        private int m_age;
        private string m_color;

        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        public int Age
        {
            get
            {
                return m_age;
            }

            set
            {
                m_age = value;
            }
        }

        public string Color
        {
            get
            {
                return m_color;
            }

            set
            {
                m_color = value;
            }
        }

        public abstract int Get_Number_Of_Legs();

        public abstract string Get_Declaration();

        protected virtual string Get_Remark()
        { return "Animal"; }

        protected virtual string Get_HelloWorld()
        {
            return "Hello world";
        }
    }
}
