using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lession_001
{
    abstract class AbstractVehicle
    {
        private string m_name;
        private double m_weight;
        private DateTime m_production_year;
        private string m_original;
        private string m_version;
        private string m_Type;

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

        public double Weight
        {
            get
            {
                return m_weight;
            }

            set
            {
                m_weight = value;
            }
        }

        public DateTime Production_year
        {
            get
            {
                return m_production_year;
            }

            set
            {
                m_production_year = value;
            }
        }

        public string Original
        {
            get
            {
                return m_original;
            }

            set
            {
                m_original = value;
            }
        }

        public string Version
        {
            get
            {
                return m_version;
            }

            set
            {
                m_version = value;
            }
        }

        public string Type
        {
            get
            {
                return m_Type;
            }

            set
            {
                m_Type = value;
            }
        }

        public abstract double Get_Price();

        public abstract int Get_Capacity();

    }
}
