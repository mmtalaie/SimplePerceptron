using Accord.Controls;
using Accord.Statistics.Distributions.Multivariate;
using Accord.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Threading;

namespace HW1
{
    public partial class Form1 : Form
    {
        ColorSequenceCollection colors = new ColorSequenceCollection();
        double[] wp;
        double[] wh;
        double alpha;
        static Semaphore semaphore = new Semaphore(1, 1);
        List<double[][]> samples;
        public Form1()
        {
            InitializeComponent();
            oldclf = new List<LineObj>();
            oldclh = new List<LineObj>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alpha = double.Parse(tbxlr.Text);
            Button.CheckForIllegalCrossThreadCalls = false;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            System.Windows.Forms.Label.CheckForIllegalCrossThreadCalls = false;


        }


        List<LineObj> oldclf;
        List<LineObj> oldclh;
        private void PlotLine(ZedGraphControl zedGraphControl1, double[] w, Color color)
        {


            //semaphore.WaitOne();
            var graph = zedGraphControl1.GraphPane;
            var x = zedGraphControl1.GraphPane.XAxis;

            var xstart = x.Scale.Min;
            var xend = x.Scale.Max;
            var ystart = (-w[1] / w[2]) * xstart - w[0] / w[2];
            var yend = (-w[1] / w[2]) * xend - w[0] / w[2];
            LineObj classifier = new LineObj(color, xstart, ystart, xend, yend);
            try
            {
                //graph.GraphObjList.Where(x=>x.);
                if (oldclf != null && classifier != null)
                {
                    foreach (var item in oldclf)
                    {
                        graph.GraphObjList.Remove(item);
                    }
                    oldclf.Clear();
                }
            }
            catch (Exception ex)
            {

            }
            try
            {

                graph.GraphObjList.Add(classifier);
                oldclf.Add(classifier);
                zedGraphControl1.Refresh();
            }
            catch (Exception)
            {


            }


        }
        private void PlotLineh(ZedGraphControl zedGraphControl1, double[] w, Color color)
        {


            var graph = zedGraphControl1.GraphPane;
            var x = zedGraphControl1.GraphPane.XAxis;

            var xstart = x.Scale.Min;
            var xend = x.Scale.Max;
            var ystart = (-w[1] / w[2]) * xstart - w[0] / w[2];
            var yend = (-w[1] / w[2]) * xend - w[0] / w[2];
            LineObj classifier = new LineObj(color, xstart, ystart, xend, yend);
            try
            {
                if (oldclh != null && classifier != null)
                {
                    foreach (var item in oldclh)
                    {
                        graph.GraphObjList.Remove(item);
                    }
                    oldclh.Clear();
                }
            }
            catch (Exception ex)
            {

            }
            graph.GraphObjList.Add(classifier);
            oldclh.Add(classifier);
            zedGraphControl1.Refresh();
        }

        public void CreateScatterplot(ZedGraphControl zgc, List<double[][]> graph, int n)
        {
            GraphPane myPane = zgc.GraphPane;
            myPane.CurveList.Clear();

            // تنظیمات نمایش
            myPane.Title.Text = "Clasification Space";
            myPane.XAxis.Title.Text = "X";
            myPane.YAxis.Title.Text = "Y";
            //myPane.XAxis.Scale.Max = 10;
            //myPane.XAxis.Scale.Min = -10;
            //myPane.YAxis.Scale.Max = 10;
            //myPane.YAxis.Scale.Min = -10;
            myPane.XAxis.IsAxisSegmentVisible = true;
            myPane.YAxis.IsAxisSegmentVisible = true;
            myPane.YAxis.IsVisible = true;
            myPane.XAxis.IsVisible = true;
            myPane.Border.IsVisible = true;


            //تولید مختصات   
            PointPairList[] list = new PointPairList[graph.Count];
            int k = 0;
            foreach (var item in graph)
            {
                list[k] = new PointPairList();
                for (int i = 0; i < item.Length; i++)
                    list[k].Add(item[i][0], item[i][1]);
                k++;
            }

            // اضافه کرن نمونه ها 
            LineItem myCurve = myPane.AddCurve("Mixture", new PointPairList(), Color.Gray, SymbolType.Diamond);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Gray);

            for (int i = 0; i < graph.Count; i++)
            {
                // اتساب نمونه ها
                Color color = colors[i];
                myCurve = myPane.AddCurve("D" + (i + 1), list[i], color, SymbolType.Diamond);
                myCurve.Line.IsVisible = false;
                myCurve.Symbol.Border.IsVisible = false;
                myCurve.Symbol.Fill = new Fill(color);
            }

            // تعیین رنگ بک گراند
            myPane.Fill = new Fill(Color.WhiteSmoke);

            zgc.AxisChange();
            zgc.Invalidate();
        }



        private void btnPlot_Click(object sender, EventArgs e)
        {
            try
            {
                crntepc.Text = "";
                lblcurnheb.Text = "";
                var dist = new MultivariateNormalDistribution(

                   // mean vector mu
                   mean: new double[]
                   {double.Parse(mx.Text),double.Parse(my.Text)},

                   // covariance matrix sigma
                   covariance: new double[,]
                   {{ double.Parse(cxx.Text),double.Parse(cxy.Text)},{ double.Parse(cyx.Text), double.Parse(cyy.Text) }}
               );
                var dist2 = new MultivariateNormalDistribution(

                   // mean vector mu
                   mean: new double[]
                   {double.Parse(mx2.Text),double.Parse(my2.Text)},

                   // covariance matrix sigma
                   covariance: new double[,]
                   {{ double.Parse(cxx2.Text),double.Parse(cxy2.Text)},{ double.Parse(cyx2.Text), double.Parse(cyy2.Text) }}
               );
                samples = new List<double[][]>();
                double[][] sampleA = dist.Generate(int.Parse(tbxCount.Text));
                samples.Add(sampleA);
                double[][] sampleB = dist2.Generate(int.Parse(tbxCount.Text));
                samples.Add(sampleB);
                CreateScatterplot(zedGraphControl1, samples, 2);
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                btnHeb.Enabled = true;
                button2.Enabled = true;
                zedGraphControl1.GraphPane.GraphObjList.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxlr.Text = "0.01";
            alpha = 0.01;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            Random random = new Random();
            wp = new double[] { random.NextDouble(), random.NextDouble(), random.NextDouble() };
            new Thread(() => PlotLine(zedGraphControl1, wp, Color.Orange)).Start();
            new Thread(() => Perseptern(samples, int.Parse(tbxbs.Text), int.Parse(tbxe.Text))).Start();
            button1.Enabled = false;
            button2.Enabled = false;
            btnHeb.Enabled = false;
            btnPlot.Enabled = false;
            button3.Enabled = false;
        }
        private void btnHeb_Click(object sender, EventArgs e)
        {
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            Random random = new Random();
            wh = new double[] { random.NextDouble(), random.NextDouble(), random.NextDouble() };
            new Thread(() => PlotLineh(zedGraphControl1, wh, Color.Green)).Start();
            new Thread(() => Heb(samples, int.Parse(tbxbs.Text), int.Parse(tbxe.Text))).Start();
            button1.Enabled = false;
            button2.Enabled = false;
            btnHeb.Enabled = false;
            btnPlot.Enabled = false;
            button3.Enabled = false;
        }

        private void Heb(List<double[][]> indata, int Batch, int ittration)
        {
            List<double[]> data = new List<double[]>();
            int k = -1;
            foreach (var item in indata)
            {
                foreach (var rows in item)
                {
                    data.Add(new double[] { 1.0, rows[0], rows[1], k });
                }
                k += 2;
            }
            data.Shuffle();


            int BCount = 0;
            double T = 0;
            for (int i = 0; i < ittration; i++)
            {

                data.Shuffle();
                foreach (var item in data)
                {
                    button3.Enabled = false;
                    if (BCount < Batch)
                    {
                        T = item[3];

                        wh[0] += sign(T, item[0]);
                        wh[1] += sign(T, item[1]);
                        wh[2] += sign(T, item[2]);
                        BCount++;
                    }
                    else
                    {
                        Task.Factory.StartNew(() => PlotLineh(zedGraphControl1, wh, Color.Green)).Wait();
                        BCount = 0;
                    }
                }
                lblcurnheb.Text = $" Heb Current Epoch is {i + 1}";
            }
            button1.Enabled = true;
            button2.Enabled = true;
            btnPlot.Enabled = true;
            button2.Enabled = true;
            btnHeb.Enabled = true;
            button3.Enabled = true;
        }
        private double sign1(double t, double v)
        {

            if (t == 0 || v == 0)
                return 0;
            else return 1;
           
        }
        private double sign(double t, double v)
        {

            if (t * v > 0)
                return t * v;
            if (t * v < 0)
                return t * v;

            return 0;
        }

        public void Perseptern(List<double[][]> indata, int Batch, int ittration)
        {
            List<double[]> data = new List<double[]>();
            int k = -1;
            foreach (var item in indata)
            {
                foreach (var rows in item)
                {
                    data.Add(new double[] { 1.0, rows[0], rows[1], k });
                }
                k += 2;
            }
            data.Shuffle();


            int BCount = 0;
            double Y = 0;
            double T = 0;
            for (int i = 0; i < ittration; i++)
            {

                if (chbrlr.Checked)
                    if (i > ittration * 0.8)
                    {
                        alpha = alpha * 0.7;
                        tbxlr.Text = alpha.ToString();
                    }
                data.Shuffle();
                double x1bar = 0;
                double x2bar = 0;
                foreach (var item in data)
                {
                    button3.Enabled = false;
                    if (BCount < Batch)
                    {
                        x1bar += item[1];
                        x2bar += item[2];
                        Y += item[0] * wp[0] + item[1] * wp[1] + item[2] * wp[2];
                        T += item[3];
                        BCount++;
                    }
                    else
                    {

                        BCount = 0;
                        var m = (T - Y) / (double)Batch;
                        if (m > 0)
                            m = 1;
                        else if (m < 0)
                            m = -1;
                        wp[0] += alpha * m;
                        wp[1] += alpha * m * (x1bar / Batch);
                        wp[2] += alpha * m * (x2bar / Batch);
                        Y = 0;
                        T = 0;
                        Task.Factory.StartNew(() => PlotLine(zedGraphControl1, wp, Color.Orange)).Wait();
                        x1bar = 0;
                        x2bar = 0;
                    }

                }
                crntepc.Text = $"Persepteron Current Epoch is {i + 1}";
            }

            button1.Enabled = true;
            button2.Enabled = true;
            btnHeb.Enabled = true;
            btnPlot.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            btnHeb.Enabled = false;
            btnPlot.Enabled = false;
            button3.Enabled = false;

            zedGraphControl1.GraphPane.GraphObjList.Clear();
            Random random = new Random();
            wp = new double[] { random.NextDouble(), random.NextDouble(), random.NextDouble() };
            new Thread(() => PlotLine(zedGraphControl1, wp, Color.Orange)).Start();
            wh = new double[] { random.NextDouble(), random.NextDouble(), random.NextDouble() };
            new Thread(() => PlotLineh(zedGraphControl1, wh, Color.Green)).Start();


            Task.Factory.StartNew(() => Heb(samples, int.Parse(tbxbs.Text), int.Parse(tbxe.Text)));
            Task.Factory.StartNew(() => Perseptern(samples, int.Parse(tbxbs.Text), int.Parse(tbxe.Text)));

        }
    }
}
