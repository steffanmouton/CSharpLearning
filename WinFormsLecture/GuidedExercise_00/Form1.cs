using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidedExercise_00
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void WriteNewFile(object sender, EventArgs e)
        {
            ////This Works, but file address is hardcoded to THIS desktop.
            //var pathToDesktop = "C:/Users/s188045/Desktop/GuidedExercise_00.txt";
            //File.WriteAllText(pathToDesktop, "test text");
            var pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var fileName = "GuidedExercise_00.txt";
            var fullPath = pathDesktop + '/' + fileName;
            File.WriteAllText( fullPath , "test text");
        }

     
    }
}
