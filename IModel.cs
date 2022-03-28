using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForArchitecture
{
    public interface IModel
    {

        void addCity(Link link);

        List<Link> getMatrix();
        

        bool solve(List<Link> matrix);
    }
}
