using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Imaging;
using NUnit.Framework.Constraints;

namespace Energy.Forms
{
    public partial class DataUsegeDevice : Form
    {
        private Dictionary<Type, SolidBrush> brush2;

        public DataUsegeDevice()
        {
            InitializeComponent();
            Initiatialize();
        }

        private void Initiatialize()
        {
            this.Text = "Мой Дом";
            this.Size = new Size(1500, 750);
            CreateBrush();
        }

        private void CreateBrush()
        {
            brush2 = new Dictionary<Type, SolidBrush>();
            brush2[Type.Computer] = new SolidBrush(Color.Yellow);
            brush2[Type.Condition] = new SolidBrush(Color.Red);
            brush2[Type.DishWasher] = new SolidBrush(Color.Blue);
            brush2[Type.Freese] = new SolidBrush(Color.Green);
            brush2[Type.Lamp] = new SolidBrush(Color.Pink);
        }

        public Bitmap Draws(Color bgCol, int width, int height, List<Device> vals)
        {
            // Создаем новый образ и стираем фон
            Bitmap mybit = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(mybit);
            SolidBrush brush = new SolidBrush(bgCol);
            graphics.FillRectangle(brush, 0, 0, width, height);
            brush.Dispose();

            // Сумма для получения общего
            var all = vals.Select(e => e.SumUsege).Sum();

            // Рисуем круговую диаграмму
            var startZ = 0.0f;
            var endZ = 0.0f;
            var current = 0.0;
            foreach (var e in vals)
            {
                current += e.SumUsege;
                startZ = endZ;
                endZ = (float)(current / all) * 360.0f;
                var x = brush2[e.TypeDevice];
                graphics.FillPie(x, 0.0f, 0.0f, width, height, startZ, endZ - startZ);
            }

            // Очищаем ресурсы кисти
            foreach (SolidBrush cleanBrush in brush2.Values)
                cleanBrush.Dispose();

            return mybit;
        }

        private void DataUsegeDevice_Paint(object sender, PaintEventArgs e)
        {
            var myColor = Color.FromArgb(255, 255, 255);
            var vals = Manager.GetDevicesData().ToList();
            Bitmap myBitmap = Draws(myColor, 300, 300, vals);
            Graphics g = e.Graphics;
            
            g.DrawImage(myBitmap, 5, 5);
            g.FillEllipse(new SolidBrush(Color.White), 30, 30, 250, 250);
        }

        private void DataUsegeDevice_Load(object sender, EventArgs e)
        {

        }
    }
}
