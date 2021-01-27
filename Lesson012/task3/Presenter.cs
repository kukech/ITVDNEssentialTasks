using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace task3
{
    class Presenter
    {
        MainWindow mainWindow;
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            mainWindow.StartTimer += MainWindow_StartTimer;
            mainWindow.Secondmetr.Text = Model.SecondTime.ToString();
            mainWindow.StopTimer += MainWindow_StopTimer;
            mainWindow.ResetTimer += MainWindow_ResetTimer;
        }

        private void MainWindow_ResetTimer(object sender, EventArgs e)
        {
            this.mainWindow.Secondmetr.Text = Model.Clear();

        }

        private void MainWindow_StopTimer(object sender, EventArgs e)
        {
            Model.isRun = false;
        }

        private void MainWindow_StartTimer(object sender, EventArgs e)
        {
            Model.isRun = true;
            //while (Model.isRun)
            {
                this.mainWindow.Secondmetr.Text = Model.Run();
            }
        }

    }
}
