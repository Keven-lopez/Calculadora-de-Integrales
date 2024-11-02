using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Custom;
using MaximaSharp;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Data.SqlTypes;

namespace IDK
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        private string imagePath = "C:/Users/ded5t/source/repos/IDK/IDK/plot.jpg";

        public Form1()
        {
            InitializeComponent();
            LoadCustomFont();
            ApplyCustomFont(this);
        }
        private void LoadCustomFont()
        {

            privateFontCollection = new PrivateFontCollection();

            string fontPath1 = Path.Combine(Application.StartupPath, "C:\\Users\\ded5t\\source\\repos\\IDK\\IDK\\Resources\\m6x11.ttf");
            

            privateFontCollection.AddFontFile(fontPath1);


        }

        // Apply the custom font to specific controls
        private void ApplyCustomFont(Control control)
        {
            Font customFont1 = new Font(privateFontCollection.Families[0], 40f);
            Font customFont2 = new Font(privateFontCollection.Families[0], 25f);
            Font customFont3 = new Font(privateFontCollection.Families[0], 18f);
            Font customFont4 = new Font(privateFontCollection.Families[0], 12f);

            foreach (Control childControl in control.Controls)
            {
                if (childControl is Label label)
                {
                    label.Font = customFont3;
                    label.ForeColor = Color.White;
                    label.BackColor = Color.Transparent;
                }
                else if (childControl is TextBox textBox)
                {
                    textBox.Font = customFont3;
                }
                else if (childControl is Button button)
                {
                    button.Font = customFont4;
                    button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                }
                else if (childControl is RadioButton butt)
                {
                    butt.Font = customFont2;
                    butt.BackColor = Color.Transparent;
                    butt.ForeColor = Color.White;
                    butt.FlatAppearance.MouseDownBackColor = Color.Transparent;
                }
                else if (childControl is ComboBox combo)
                {
                    combo.Font = customFont4;
                }
                else if (childControl is TableLayoutPanel tpanel)
                {
                    ApplyCustomFont(tpanel); // Recursive call for nested panels
                }
                else if (childControl is Panel panel)
                {
                    ApplyCustomFont(panel); // Recursive call for nested panels
                }
            }
            labelTitle.Font = customFont1;
            labelTitle.Location = new Point(400, 10);
            labelTitle.BackColor = Color.Transparent;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            axWindowsMediaPlayer1.URL = "C:\\Users\\ded5t\\source\\repos\\IDK\\IDK\\Resources\\Balatro  Complete Original Soundtrack Official.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            comboBox1.SelectedIndex = 0;
            radioButtonIndefinite.Checked = true;
        }

        private void buttonIndefinite_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            // Generate the plot using Maxima and GnuPlot
            string result = Regex.Replace(textBox1.Text, @"sqrt\(([^)]+)\)", "Math.Sqrt($1)");
            string result2 = Regex.Replace(result, @"e^\(([^)]+)\)", "Math.Pow(Math.E,$1)");
            try
            {
                var exp = Maxima.ToExpression("double, double", "x", result2);
                var resul = exp.Integrate();
                textBox2.Text = resul.ToString();
                var gnu = CustomCommands.ToGnuplotString(resul);
                CustomCommands.PlotGraph(imagePath, resul, gnu);
                this.Refresh();
                Thread.Sleep(10000);
                this.Refresh();
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    pictureBox1.Image = new Bitmap(fs);
                    double.PositiveInfinity.ToString();
                }
                SetForegroundWindow(this.Handle);
            }
            catch (Exception ex)
            {
                SetForegroundWindow(this.Handle);
                MessageBox.Show("Error en la expresion");
                SetForegroundWindow(this.Handle);
                textBox1.Text = "";
                return;
            }
            
        }

        private void radioButtonIndefinite_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIndefinite.Checked)
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
                comboBox1.Enabled = false;
                if (pictureBox2.Image != null)
                {
                    pictureBox2.Image.Dispose();
                    pictureBox2.Image = null;
                }
            }
            else
            {
                panel1.Enabled = false;
                panel2.Enabled = true;
                comboBox1.Enabled = true;
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
            }
        }

        private void buttonDefinite_Click(object sender, EventArgs e)
        {
            double sup = 1;
            double inf = 0;
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
                pictureBox2.Image = null;
            }

            if (textBoxSup.Text == "" || textBoxInf.Text == "")
            {
                MessageBox.Show("Porfavor ingrese los limites");
                return;
            }

            if (textBoxSup.Text == "inf")
            {
                sup = double.PositiveInfinity;
            }
            else
            {
                sup = int.Parse(textBoxSup.Text);
            }

            if (textBoxInf.Text == "-inf")
            {
                inf = double.NegativeInfinity;
            }
            else
            {
                inf = int.Parse(textBoxInf.Text);
            }

            string result = Regex.Replace(textBoxDefinite.Text, @"sqrt\(([^)]+)\)", "Math.Sqrt($1)");
            string result2 = Regex.Replace(result, @"e^\(([^)]+)\)", "Math.Exp($1)");
            try
            {
                var exp = Maxima.ToExpression("double, double", "x", result2);
                var resul = exp.Integrate();
                var limit = exp.Integrate();
                textBoxDefResul.Text = resul.ToString();
                if (comboBox1.SelectedIndex == 0)
                {
                    var gnu = CustomCommands.ToGnuplotString(resul);
                    limit = exp.Integrate(inf, sup);
                    CustomCommands.PlotGraph(imagePath, resul, gnu);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    var gnu = CustomCommands.ToGnuplotString(exp);
                    limit = exp.IntegrateValor(inf, sup);
                    CustomCommands.PlotGraph(imagePath, exp, gnu);
                }
                textBoxAprox.Text = limit.ToString();
                this.Refresh();
                Thread.Sleep(10000);
                this.Refresh();
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    pictureBox2.Image = new Bitmap(fs);
                }
                SetForegroundWindow(this.Handle);
            } catch (Exception ex)
            {
                SetForegroundWindow(this.Handle);
                MessageBox.Show("Error en la expresion");
                SetForegroundWindow(this.Handle);
                textBoxDefinite.Text = "";
                return;
            }

        }

        private void buttonLimpiarDef_Click(object sender, EventArgs e)
        {
            textBoxDefinite.Text = "";
            textBoxDefResul.Text = "";
            textBoxAprox.Text = "";
            textBoxSup.Text = "";
            textBoxInf.Text = "";
            pictureBox2.Image = null;
        }
    }
}