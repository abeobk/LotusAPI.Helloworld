using LotusAPI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusAPI.Helloworld {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            Logger.Add(new LogViewLogger(logView1));
            //Logger.Add(new FileLogger("D:\\log.txt"));


            Library.Initialize();

        }

        private void flatButton1_Click(object sender, EventArgs e) {
            Logger.Debug("Button is clicked!");
        }

        private void btLoad_Click(object sender, EventArgs e) {
            try {
                var img = DialogUtils.OpenImage();
                if(img == null) throw new Exception("Image is null!");
                if(img.IsEmpty) throw new Exception("Image is invalid!");
                imgview.SetImage(img);
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        //change some codes
        //asdfasd

    }
}
