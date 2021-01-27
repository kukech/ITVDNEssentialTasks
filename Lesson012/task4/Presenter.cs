using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow1;
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow1 = mainWindow;
            this.model = new Model();
            this.mainWindow1.EventSum += MainWindow1_EventSum;
            this.mainWindow1.EventSub += MainWindow1_EventSub;
            this.mainWindow1.EventMul += MainWindow1_EventMul;
            this.mainWindow1.EventDiv += MainWindow1_EventDiv;
        }

        private void MainWindow1_EventDiv(object sender, EventArgs e)
        {
            mainWindow1.Result.Text = model.Div(mainWindow1.NumberA.Text, mainWindow1.NumberB.Text);
        }

        private void MainWindow1_EventMul(object sender, EventArgs e)
        {
            mainWindow1.Result.Text = model.Mul(mainWindow1.NumberA.Text, mainWindow1.NumberB.Text);
        }

        private void MainWindow1_EventSub(object sender, EventArgs e)
        {
            mainWindow1.Result.Text = model.Sub(mainWindow1.NumberA.Text, mainWindow1.NumberB.Text);
        }

        private void MainWindow1_EventSum(object sender, EventArgs e)
        {
            mainWindow1.Result.Text = model.Sum(mainWindow1.NumberA.Text, mainWindow1.NumberB.Text);
        }
        
    }
}
