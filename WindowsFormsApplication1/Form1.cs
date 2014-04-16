using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo downloadedMessageInfo = new DirectoryInfo(@"D:\1\");

            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }

            foreach (var file in Directory.GetFiles(@"e:\Projects\_archive\kotgrom\captured\big\"))
            {
                var scaled = Image.FromFile(file);
                using (Graphics g = Graphics.FromImage(scaled))
                {
                    Image vm = Image.FromFile(@"e:\Projects\Publish\KotGrom\images\kotavdom.png");

                    g.DrawImage(vm, (scaled.Width/2 + 50), (scaled.Height/2+110));
                }



                scaled.Save(file.Replace(@"e:\Projects\_archive\kotgrom\captured\big\", @"D:\1\"));
            }
            
        }
    }
}
