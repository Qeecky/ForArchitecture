using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForArchitecture
{
    internal class Model : IModel
    {
        private List<Link> matrix;

        public Model(List<Link> matrix)
        {
            this.matrix = matrix;
        }

        public List<Link> getMatrix()
        {
            return matrix;
        }

        public void addCity(Link link)
        {
            matrix.Add(link); ;
            
            
        }

        public bool solve(List<Link> matrix)
        {
            if (matrix == null || matrix.Count <= 0)
            {
                Console.WriteLine("empty map");
                return false;
            }
            else
            {
                
            }
            return false;
        }
    }
}
