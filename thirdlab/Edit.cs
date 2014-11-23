using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thirdlab.ObjMod;

namespace thirdlab
{
    public partial class Edit : Form
    {
        public CustomLabel score = new CustomLabel();
        public CustomAdduction add = new CustomAdduction();
        public CustomButton start = new CustomButton();
        public CustomButton edit = new CustomButton();
        public CustomPanel ForGame = new CustomPanel();
        bool _edit;
        Point _startPoint;
        Control _current;
        Point _now;
        public Edit()
        {
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                _edit = true;
                _startPoint = new Point(e.X, e.Y);
                _current = (Button)sender;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                _now = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y - menuStrip1.Height);
                int X = Cursor.Position.X, Y = Cursor.Position.Y;
                FontAndSize.Show(new Point(X, Y));
            }
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (_edit && _current != null)
                {
                    _current.Top += e.Y - _startPoint.Y;
                    _current.Left += e.X - _startPoint.X;
                }
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                _edit = false;
            }
        }

        private void ScoreLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                _edit = true;
                _startPoint = new Point(e.X, e.Y);
                _current = (Label)sender;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                _now = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y - menuStrip1.Height);
                int X = Cursor.Position.X, Y = Cursor.Position.Y;
                OnlyFont.Show(new Point(X, Y));
            }
        }

        private void ScoreLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (_edit && _current != null)
                {
                    _current.Top += e.Y - _startPoint.Y;
                    _current.Left += e.X - _startPoint.X;
                }
            }
        }

        private void ScoreLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                _edit = false;
                score.LeftTop = ScoreLabel.Location;
            }
        }

        private void PanelForGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                _edit = true;
                _startPoint = new Point(e.X, e.Y);
                _current = (Panel)sender;
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                _now = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y - menuStrip1.Height);
                int X = Cursor.Position.X, Y = Cursor.Position.Y;
                SizePlus.Show(new Point(X, Y));
            }
        }

        private void PanelForGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (_edit && _current != null)
                {
                    _current.Top += e.Y - _startPoint.Y;
                    _current.Left += e.X - _startPoint.X;
                }
            }
        }

        private void PanelForGame_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                _edit = false;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                score.LeftTop = ScoreLabel.Location;
                edit.LeftTop = EditButton.Location;
                start.LeftTop = StartButton.Location;
                ForGame.LeftTop = PanelForGame.Location;
                Skin currSkin = new Skin() { Score = score, adduct = add, Edit = edit,
                    Start = start, panel = ForGame };
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    bf.Serialize(fs, currSkin);
                }
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontChoose fc = new FontChoose();
            fc.ShowDialog();
            if (fc.DialogResult == DialogResult.OK)
            {
                Font _font = fc.FontChoosen;
                foreach (Control i in this.Controls)
                {
                    if (i.Location.X <= _now.X && i.Location.X + i.Width >= _now.X
                               && i.Location.Y <= _now.Y && i.Location.Y + i.Height >= _now.Y)
                    {
                        MessageBox.Show("YO!");
                        i.Font = _font;
                        if (i is Label)
                        {
                            if (i.Name == "ScoreLabel")
                                score.CustomFont = _font;
                        }
                        else if (i is Button)
                        {
                            if (i.Name == "StartButton")
                                start.CustomFont = _font;
                            if (i.Name == "EditButton")
                                edit.CustomFont = _font;
                        }
                    }
                    else
                        Font = _font;
                }
            }            
        }

        private void цветПришельцевToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAdd ea = new EditAdd(add);
            ea.ShowDialog();
        }

        private void Edit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _now = new Point(Cursor.Position.X, Cursor.Position.Y );
                int X = Cursor.Position.X, Y = Cursor.Position.Y;
                OnlyFont.Show(new Point(X, Y));
            }
        }

        private void создатьИконкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateIconImage cii = new CreateIconImage();
            cii.ShowDialog();
        }

        private void размерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeChange sc = new SizeChange();
            sc.ShowDialog();
            if (sc.DialogResult == DialogResult.OK)
            {
                Size _size = sc.returnable;
                foreach (Control i in this.Controls)
                {
                    if (i.Location.X <= _now.X && i.Location.X + i.Width >= _now.X
                               && i.Location.Y <= _now.Y && i.Location.Y + i.Height >= _now.Y)
                    {
                        if (i is Button)
                        {
                            if (i.Name == "StartButton")
                            {
                                start.CustSize = _size;
                            }
                            if (i.Name == "EditButton")
                            {
                                edit.CustSize = _size;
                            }
                            i.Size = _size;
                        }
                    }
                }
            }
        }

        private void размерToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SizeChangeAdd sc = new SizeChangeAdd();
            sc.ShowDialog();
            if (sc.DialogResult == DialogResult.OK)
            {
                Size _size = sc.returnable;
                Image _icons = sc.Icons;
                foreach (Control i in this.Controls)
                {
                    if (i.Location.X <= _now.X && i.Location.X + i.Width >= _now.X
                               && i.Location.Y <= _now.Y && i.Location.Y + i.Height >= _now.Y)
                    {
                        if (i is Panel)
                        {
                            if (i.Name == "PanelForGame")
                            {
                                i.Size = _size;
                                ForGame.Icons = _icons;
                                ForGame.size = _size;
                            }
                        }
                    }
                }
            }
        }

    }
}