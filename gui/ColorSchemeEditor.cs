using System;
using System.Drawing;
using System.Windows.Forms;
using tsconfig.domain;

namespace gui
{
    public class ColorSchemeEditor : Form
    {

        public ColorSelectorButton[] Colors = new ColorSelectorButton[8];
        public CheckBox BkgColor;
        public int TextBackgroundColor;

        private void RestoreDefaults (object s, EventArgs e)
        {
            Colors[0].WWColor = WWColor.ByIndex(3);  // Gold
            Colors[1].WWColor = WWColor.ByIndex(21); // Red
            Colors[2].WWColor = WWColor.ByIndex(47); // Blue
            Colors[3].WWColor = WWColor.ByIndex(73); // Green
            Colors[4].WWColor = WWColor.ByIndex(27); // Orange
            Colors[5].WWColor = WWColor.ByIndex(55); // Light Blue
            Colors[6].WWColor = WWColor.ByIndex(39); // Purple
            Colors[7].WWColor = WWColor.ByIndex(33); // Pink
            BkgColor.Checked = false;
        }
        private void InitColors ()
        {
            Colors[0] = new ColorSelectorButton(WWColor.ByIndex(3),"Gold");
            Colors[1] = new ColorSelectorButton(WWColor.ByIndex(21),"Red");
            Colors[2] = new ColorSelectorButton(WWColor.ByIndex(47),"Blue");
            Colors[3] = new ColorSelectorButton(WWColor.ByIndex(73),"Green");
            Colors[4] = new ColorSelectorButton(WWColor.ByIndex(27),"Orange");
            Colors[5] = new ColorSelectorButton(WWColor.ByIndex(55),"Light Blue");
            Colors[6] = new ColorSelectorButton(WWColor.ByIndex(39),"Purple");
            Colors[7] = new ColorSelectorButton(WWColor.ByIndex(33),"Pink");
        }

        public ColorSchemeEditor ()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Color Scheme Editor";
            Size = new Size(256, 370);
            MinimizeBox = false;
            MaximizeBox = false;


            int leftpad = 8;
            int toppad = 10;
            int btnPad = 120;

            BkgColor = new CheckBox();
            BkgColor.Location = new Point(leftpad +12,toppad);
            BkgColor.Size = new Size(248, 40);
            BkgColor.Text = "Use black background for messages";
            Controls.Add(BkgColor);
            toppad = 60;

            InitColors();
            
            int row = 0;
            foreach (ColorSelectorButton c in Colors)
            {
                Label l = new Label();
                l.Location = new Point(leftpad, toppad + row);
                l.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                l.Text = c.WWName + " =";
                this.Controls.Add(l);
                c.Location = new Point(btnPad, toppad + row);
                this.Controls.Add(c);
                row += 30;
            }

            Button ok = new Button();
            ok.Location = new Point(leftpad, toppad + 260);
            ok.Text = "OK";
            ok.Click += new EventHandler(ClickOK);
            Controls.Add(ok);

            Button cancel = new Button();
            cancel.Location = new Point(88, toppad + 260);
            cancel.Text = "Cancel";
            cancel.Click += new EventHandler(ClickCancel);
            Controls.Add(cancel);

            Button reset = new Button();
            reset.Location = new Point(168, toppad + 260);
            reset.Text = "Defaults";
            reset.Click += new EventHandler(RestoreDefaults);
            Controls.Add(reset);

            AcceptButton = ok;
            CancelButton = cancel;
        }

        private void ClickOK(object s, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ClickCancel(object s, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    public class ColorSelectorButton : Button
    {
        private WWColor w;
        public WWColor WWColor
        {
            get { return w; }
            set
            {
                w = value;
                BackColor = Color.FromArgb(w.R,w.G,w.B);
            }
        }
        public string WWName { get; set; }
        public ColorSelectorButton(WWColor c,string n)
        {
            WWColor = c;
            WWName = n;
            Click += new EventHandler(Clicked);
        }

        public void Clicked (object s, EventArgs e)
        {
            TSColorDialog d = new TSColorDialog(WWColor);
            d.ShowDialog();
            if (DialogResult.OK == d.DialogResult)
            {
                WWColor = d.WWColor;
            }
        }
    }
}
