using LotusAPI.Controls;
using LotusAPI.MV;
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
        LotusAPI.HW.VideoCapture _cam = null;
        PointcloudViewer _pcv = null;

        public Form1() {
            InitializeComponent();

            Logger.Add(new LogViewLogger(logView1));
            //Logger.Add(new FileLogger("D:\\log.txt"));

            _pcv = new PointcloudViewer(pointcloudView1);

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

        private void btConnect_Click(object sender, EventArgs e) {
            try {

                if(_cam == null) {
                    _cam = new HW.VideoCapture(0);
                }

                if(_cam!=null && _cam.IsConnected) timer_capture.Start();
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        private void timer_capture_Tick(object sender, EventArgs e) {
            try {
                if(_cam == null) return;
                if(false == _cam.IsConnected) return;

                var img = _cam.Capture();

                //image processing
                var gimg = img.ToGray();
                var edges = gimg.Canny(50, 100);

                imgview.SetImage(edges);
                
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        private void flatButton1_Click_1(object sender, EventArgs e) {
            try {
                var pc= DialogUtils.OpenPLYFile();
                _pcv.Clear();
                _pcv.Add(new Pointcloud(pc),Color.Yellow);
                _pcv.Render();
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        //change some codes
        //asdfasd

    }
}
