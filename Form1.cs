using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace KMU_SimulationTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ObjectForScripting = new ScriptManager(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            this.webBrowser1.Navigate(curDir + "\\index.html");
            this.webBrowser1.ScriptErrorsSuppressed = true;

            label1.BackColor = Color.Transparent;
        }

        private void tabControl3_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabControl3.TabCount - 1;
            if (this.tabControl3.GetTabRect(lastIndex).Contains(e.Location))
            {
                this.tabControl3.TabPages.Insert(lastIndex, "New Tab");
                this.tabControl3.SelectedIndex = lastIndex;
            }
        }

        private void tabControl3_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabControl3.TabCount - 1)
                e.Cancel = true;
        }
    }

    [ComVisible(true)]
    public class ScriptManager
    {
        Form1 _form;
        public ScriptManager(Form1 form)
        {
            _form = form;
        }
        public void ShowMessage(string point)
        {
            MessageBox.Show(point.ToString());

        }



        public void SetTimeBar(int count)
        {
            //Console.WriteLine(count);
            //_form.trackBar_timeBar.Value = count;
            //_form.lab_Content_CurrentTime.Text = _form.ConvertToTimeString(_form.startTimeSeconds + _form.trackBar_timeBar.Value);

            //if (count == 20)
            //{
            //    _form.addOrder(new Order(23, 1, 1));
            //}
            //if (count == 60)
            //{
            //    _form.addOrder(new Order(21, 1, 1));
            //}
        }


        public void setBusTimeCount(int no, int count)
        {
            //Console.WriteLine("bus_no : " + no + " , timeCount : " + count);
            //int idx = _form.buses.FindIndex(x => x.no == no);
            //if (_form.buses[idx].path_perSecond.Count - 1 <= count)
            //{
            //    //_form.buses[idx].curTimeCount = _form.buses[idx].path_perSecond.Count-1;
            //    foreach (Order od in _form.buses[idx].orderList)
            //    {
            //        BusStop f_stop = _form.busStops[od.f_st_no];
            //        BusStop t_stop = _form.busStops[od.t_st_no];

            //        if (f_stop.numOfWaiting == 0)
            //            _form.resetBusStopMarker_ToDefault(f_stop.busStop_id);

            //        if (t_stop.numOfWaiting == 0)
            //            _form.resetBusStopMarker_ToDefault(f_stop.busStop_id);

            //    }

            //    _form.buses[idx].init();

            //    _form.updateHtmlBusRoute(_form.buses[idx]);

            //    //_form.buses[idx].startTime = _form.startTimeSeconds + count
            //}
            //else
            //{
            //    _form.buses[idx].curTimeCount = count;
            //}


        }

        public void busLocation(string point)
        {
            //Console.WriteLine(point);
            //this._form.label2.Text = point;
            //string[] p = point.Split(',');
            //double lat = Convert.ToDouble(p[0].Replace("(", ""));
            //double lng = Convert.ToDouble(p[1].Replace(")", ""));
            //PointLatLng bus_location = new PointLatLng(lat, lng);

            //double closest_link = Links.FirstOrDefault(b => b.Value == bus_location).Key;
            //if (closest_link != 0)
            //{
            //    int bus_station = busStops.FirstOrDefault(b => b.Value == closest_link).Key;
            //    if (bus_station != 0)
            //    {
            //        blackList_bus.Add(bus_station);
            //    }
            //}
        }
    }
}
