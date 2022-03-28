using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForArchitecture
{
    internal class Controller
    {
        private IModel model;
        private IView view;

        public Controller(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
        }

        public void run()
        {
            view.show();
            do
            {

            } while (true);
        }
    }
}
