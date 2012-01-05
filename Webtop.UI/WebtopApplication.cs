using System;
using System.ComponentModel;
using System.Windows.Forms;
using Nancy.Hosting.Self;

namespace Webtop.UI
{
    public partial class WebtopApplication : Form
    {
        private readonly NancyHost host;

        public WebtopApplication()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Form1_Closing);
        
            host = new NancyHost(new Uri(@"http://localhost:1234"));
            host.Start();

            viewWindow.Navigate("http://localhost:1234/");
        }

        void Form1_Closing(object sender, CancelEventArgs e)
        {
            host.Stop();
        }
    }
}
