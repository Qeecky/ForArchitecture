using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForArchitecture
{
    public class Link
    {
        private int weight;
        private List<City> cities;
        public Link(int weight, City city1, City city2)
        {
            this.weight = weight;
            cities = new List<City>();
            cities.Add(city1);
            cities.Add(city2);
        }

        public int getWeight()
        { 
            return weight;
        }
    }
}
