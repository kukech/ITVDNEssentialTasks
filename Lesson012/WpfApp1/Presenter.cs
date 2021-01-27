using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow;
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.someEvent += MainWindow_someEvent;
        }

        private void MainWindow_someEvent(object sender, EventArgs e)
        {
            this.mainWindow.textblox.Text = this.model.Method(this.mainWindow.textblox.Text);
        }
    }
}
