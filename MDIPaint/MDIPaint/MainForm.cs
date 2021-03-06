using Magnum.FileSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginInterface;

namespace MDIPaint
{
    public partial class MainForm : Form
    {
        public static Color CurrentColor { get; set; }
        public static Color Eraser { get; set; }
        public static int CurrentWidth = 5;
        public static int TheFigureNumber = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сверхуВнизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void слеваНаправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void упорядочитьЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm formAbout = new AboutForm();
            formAbout.ShowDialog();
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Green;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Blue;
        }

        private void желтыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Yellow;
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Red;
        }

        private void фиолетовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Purple;
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentColor = Color.Black;
        }

        private void другойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();

            if (d.ShowDialog() == DialogResult.OK)
            {
                CurrentColor = d.Color;
            }
        }


        private void размерХолстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentFormSize dSize = new DocumentFormSize();
            dSize.DocumentFormWidth = ActiveMdiChild.Width;
            dSize.DocumentFormHeight = ActiveMdiChild.Height;
            if (dSize.ShowDialog() == DialogResult.OK)
            {
                ActiveMdiChild.Height = dSize.DocumentFormHeight;
                ActiveMdiChild.Width = dSize.DocumentFormWidth;
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CurrentWidth = (int)numericUpDown1.Value;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((DocumentForm)ActiveMdiChild).SaveAs();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpeg, *.jpg)|*.jpeg;*.jpg|Все файлы ()*.*|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                DocumentForm formChild = new DocumentForm(openFile.FileName);
                formChild.MdiParent = this;
                formChild.Show();
            }
        }
        private int documentCounter = 1;
        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentForm d = new DocumentForm();
            d.Text = $"Документ {documentCounter++}";
            d.MdiParent = this;
            d.Show();
        }

        private void рисунокToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            размерХолстаToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void окноToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            сверхуВнизToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            каскадомToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            слеваНаправоToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            упорядочитьЗначкиToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            DocumentForm canvas = (ActiveMdiChild as DocumentForm);
            canvas.Width = (int)(canvas.Bitmap.Width * 0.6f);
            canvas.Height = (int)(canvas.Bitmap.Height * 0.8f);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            DocumentForm canvas = (ActiveMdiChild as DocumentForm);
            canvas.Width = (int)(canvas.Bitmap.Width * 1.2f);
            canvas.Height = (int)(canvas.Bitmap.Height * 1.2f);
        }



        void FindPlugins()
        {

            // папка с плагинами

            string folder = System.AppDomain.CurrentDomain.BaseDirectory;

            // dll-файлы в этой папке

            string[] files = System.IO.Directory.GetFiles(folder, "*.dll");
            foreach (string file in files)
                try
                {
                    Assembly assembly = Assembly.LoadFile(file);
                    foreach (Type type in assembly.GetTypes())
                    {
                        Type iface = type.GetInterface("PluginInterface.IPlugin");
                        if (iface != null)
                        {
                            IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                            //plugins.Add(plugin.Name, plugin);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки плагина\n" + ex.Message);
                }

        }

        private void Brush_Click(object sender, EventArgs e)
        {
            TheFigureNumber = 1;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            TheFigureNumber = 2;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            TheFigureNumber = 3;
        }

        private void Star_Click(object sender, EventArgs e)
        {
            TheFigureNumber = 4;
        }
    }
}

