using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Kursova17
{
    public partial class Form1 : Form
    {
        private readonly Random rnd = new Random();
        private const int MaxPoints = 10000;

        public Form1()
        {
            InitializeComponent();
            string photoPath = Path.Combine(Application.StartupPath, "photo.jpg");
            if (File.Exists(photoPath))
                LoadPhoto(photoPath);
        }

        // ===================== Допоміжні методи =====================

        private static bool Finite(double value)
        {
            return !double.IsNaN(value) && !double.IsInfinity(value);
        }

        private static bool ReadNumber(string text, out double value)
        {
            value = 0;
            if (string.IsNullOrWhiteSpace(text))
                return false;

            text = text.Trim().Replace(',', '.');
            return double.TryParse(text, NumberStyles.Float,
                CultureInfo.InvariantCulture, out value) && Finite(value);
        }

        private static bool MakeGrid(double min, double max, double step,
            out List<double> grid, out string error)
        {
            grid = new List<double>();
            error = null;

            if (!(step > 0))
            {
                error = "Крок dx має бути додатним числом.";
                return false;
            }
            if (min > max)
            {
                error = "xmin не може бути більшим за xmax.";
                return false;
            }

            double r = (max - min) / step;
            int n;
            // Якщо відношення майже ціле — включаємо xmax
            if (Math.Abs(r - Math.Round(r)) < 1e-12 * Math.Max(1.0, Math.Abs(r)))
                n = (int)Math.Round(r) + 1;
            else
                n = (int)Math.Floor(r) + 1;

            if (n > MaxPoints)
            {
                error = $"Занадто багато точок ({n}). Максимум {MaxPoints}.";
                return false;
            }

            for (int i = 0; i < n; i++)
            {
                double x = min + i * step;
                if (i > 0 && !(x > grid[i - 1]))
                {
                    error = "Крок занадто малий для точності типу double.";
                    return false;
                }
                grid.Add(x);
            }

            // Підправити останній вузол до xmax, якщо майже збігається
            if (n > 1 && Math.Abs(grid[n - 1] - max) < 1e-9 * Math.Max(1.0, Math.Abs(max)))
                grid[n - 1] = max;

            return true;
        }

        /// <summary>
        /// f1(x) = log(q * cos(a - x)) / (q * x)
        /// Умови: x ≠ 0, q·cos(a−x) > 0
        /// </summary>
        private static bool F1(double x, double q, double a,
            out double y, out string reason)
        {
            y = 0;
            reason = null;

            if (x == 0.0)
            {
                reason = "x = 0: ділення на нуль";
                return false;
            }

            double cosArg = Math.Cos(a - x);
            if (!Finite(cosArg))
            {
                reason = "cos(a−x) не скінченний";
                return false;
            }

            double arg = q * cosArg;
            if (!(arg > 0.0))
            {
                reason = "q·cos(a−x) ≤ 0: логарифм не визначений";
                return false;
            }

            double denom = q * x;
            if (denom == 0.0) // теоретично неможливо, бо q>0 і x≠0, але на всяк випадок
            {
                reason = "знаменник = 0";
                return false;
            }

            y = Math.Log(arg) / denom;
            if (!Finite(y))
            {
                reason = "результат не скінченний";
                return false;
            }
            return true;
        }

        /// <summary>
        /// f2(x) = ∛(q − sin(a·x))
        /// Визначена для всіх дійсних значень підкореневого виразу.
        /// </summary>
        private static bool F2(double x, double q, double a,
            out double y, out string reason)
        {
            y = 0;
            reason = null;

            double p = q - Math.Sin(a * x);
            if (!Finite(p))
            {
                reason = "проміжне значення (q − sin(a·x)) не скінченне";
                return false;
            }

            // Дійсний кубічний корінь з урахуванням знака
            double absRoot = Math.Pow(Math.Abs(p), 1.0 / 3.0);
            y = (p < 0.0) ? -absRoot : absRoot;

            if (!Finite(y))
            {
                reason = "результат не скінченний";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Повертає 1 для f1 (q ≤ 0.25), 2 для f2 (q > 0.25).
        /// </summary>
        private static int Branch(double q)
        {
            return (q <= 0.25) ? 1 : 2;
        }

        // ===================== Завантаження фото =====================

        private void LoadPhoto(string path)
        {
            try
            {
                if (picStudent.Image != null)
                {
                    picStudent.Image.Dispose();
                    picStudent.Image = null;
                }

                // Завантажуємо копію, щоб не блокувати файл
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (var img = Image.FromStream(fs))
                {
                    picStudent.Image = new Bitmap(img);
                }
                lblPhoto.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося завантажити фотографію:\n" + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ===================== Обробники кнопок =====================

        private void btnStart_Click(object sender, EventArgs e)
        {
            // 1. Зчитування параметрів
            if (!ReadNumber(txtXmin.Text, out double xmin) ||
                !ReadNumber(txtXmax.Text, out double xmax) ||
                !ReadNumber(txtDx.Text, out double dx) ||
                !ReadNumber(txtA.Text, out double a))
            {
                MessageBox.Show(
                    "Усі поля (xmin, xmax, dx, a) мають містити скінченні числа.\n" +
                    "Можна використовувати кому або крапку.",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Побудова сітки
            if (!MakeGrid(xmin, xmax, dx, out List<double> grid, out string gridError))
            {
                MessageBox.Show(gridError, "Помилка сітки",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Очищення та підготовка
            lstF1.BeginUpdate();
            lstF2.BeginUpdate();
            try
            {
                lstF1.Items.Clear();
                lstF2.Items.Clear();

                int n1 = 0, n2 = 0, failed = 0;

                // 4–7. Цикл табуляції
                foreach (double x in grid)
                {
                    // q ∈ (0; 1]
                    double q = 1.0 - rnd.NextDouble();

                    if (Branch(q) == 1)
                    {
                        if (F1(x, q, a, out double y, out string reason))
                        {
                            lstF1.Items.Add(string.Format(
                                CultureInfo.InvariantCulture,
                                "x={0:G8}  q={1:G8}  y={2:G8}", x, q, y));
                            n1++;
                        }
                        else
                        {
                            lstF1.Items.Add(string.Format(
                                CultureInfo.InvariantCulture,
                                "x={0:G8}  q={1:G8}  {2}", x, q, reason));
                            failed++;
                        }
                    }
                    else
                    {
                        if (F2(x, q, a, out double y, out string reason))
                        {
                            lstF2.Items.Add(string.Format(
                                CultureInfo.InvariantCulture,
                                "x={0:G8}  q={1:G8}  y={2:G8}", x, q, y));
                            n2++;
                        }
                        else
                        {
                            lstF2.Items.Add(string.Format(
                                CultureInfo.InvariantCulture,
                                "x={0:G8}  q={1:G8}  {2}", x, q, reason));
                            failed++;
                        }
                    }
                }

                // 8. Підсумки
                txtCnt1.Text = n1.ToString();
                txtCnt2.Text = n2.ToString();
                lblStatus.Text = string.Format(
                    "Точок: {0}   Успішних: {1}   Помилок: {2}",
                    grid.Count, n1 + n2, failed);
            }
            finally
            {
                lstF1.EndUpdate();
                lstF2.EndUpdate();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstF1.Items.Clear();
            lstF2.Items.Clear();
            txtCnt1.Text = "0";
            txtCnt2.Text = "0";
            lblStatus.Text = "";
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Виберіть фотографію";
                dlg.Filter = "Зображення|*.jpg;*.jpeg;*.png;*.bmp|Усі файли|*.*";
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog() == DialogResult.OK)
                    LoadPhoto(dlg.FileName);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (picStudent.Image != null)
            {
                picStudent.Image.Dispose();
                picStudent.Image = null;
            }
            base.OnFormClosed(e);
        }
    }
}
