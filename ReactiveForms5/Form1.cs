using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reactive.Linq;

namespace ReactiveForms5
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            Observable.FromEventPattern(e => this.Click += e, e => this.Click -= e).ObserveOn(this)
                .Subscribe(e=>
                {
                    this.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255));
                }); 
        }
    }
}
