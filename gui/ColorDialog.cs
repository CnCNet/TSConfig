using System;
using System.Drawing;
using System.Windows.Forms;
using tsconfig.domain;

namespace gui
{

    public class TSColorDialog : Form
    {

        private Label  HoverColorLabel;
        public WWColor WWColor;
        public Label   SelectedLabel;


        private void EnterColor(object sender, EventArgs e, WWColor c)
        {
            HoverColorLabel.Text = c.Name;
        }

        private void LeaveColor(object sender, EventArgs e)
        {
            HoverColorLabel.Text = WWColor.Name;
        }

        private void ClickColor(object sender, MouseEventArgs e, Label l, WWColor c)
        {
            SelectedLabel.BorderStyle = BorderStyle.Fixed3D;
            l.BorderStyle = BorderStyle.FixedSingle;
            WWColor = c;
            SelectedLabel = l;
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

        public TSColorDialog (WWColor current)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MinimizeBox = false;
            MaximizeBox = false;

            Text = "Color";
            WWColor = current;
            int x = 0;
            int y = 10;
            int size = 20;
            int pad = 6;
            int columns = 10;
            int rows = 5;
            Size = new Size(columns * (size+pad) +pad+8,
                            rows * (size + pad) +pad+100);

            int col = 0;
            int row = 0;
            foreach (WWColor c in WWColor.Array)
            {
                Label l = new Label();
                l.Location = new Point(x + pad + (col * (size+pad)),
                                       y + pad + (row * (size+pad)));
                l.Size = new Size(size,size);
                l.BackColor = Color.FromArgb(c.R,c.G,c.B);
                if (current == c)
                {
                    l.BorderStyle = BorderStyle.FixedSingle;
                    SelectedLabel = l;
                }
                else
                {
                    l.BorderStyle = BorderStyle.Fixed3D;
                }
                l.MouseEnter += new EventHandler ((sender, e) => EnterColor(sender, e, c));
                l.MouseLeave += new EventHandler (LeaveColor);
                l.MouseClick += new MouseEventHandler ((sender, e) => ClickColor(sender, e, l, c));
                this.Controls.Add(l);

                col += 1;
                if (col >= columns)
                {
                    col = 0;
                    row += 1;
                }
            }

            HoverColorLabel = new Label();
            HoverColorLabel.Location = new Point(pad + 4, y + rows * (size + pad) + pad);
            HoverColorLabel.Text = current.Name;
            Controls.Add(HoverColorLabel);

            Button ok = new Button();
            ok.Location = new Point (pad, rows * (size + pad) + pad + 34);
            ok.Text = "OK";
            ok.Click += new EventHandler(ClickOK);
            Controls.Add(ok);

            Button cancel = new Button();
            cancel.Location = new Point (pad + 80, rows * (size + pad) + pad + 34);
            cancel.Text = "Cancel";
            cancel.Click += new EventHandler(ClickCancel);
            Controls.Add(cancel);

            AcceptButton = ok;
            CancelButton = cancel;

        }
    }
}
