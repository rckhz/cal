using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class BotaoArredondado : Button
{
    private int raio = 4;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Raio { get { return raio; } set { raio = value; } }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // pinta os cantos com a cor do pai (fundo do form)
        Color corFundo = Parent != null ? Parent.BackColor : Color.FromArgb(45, 45, 45);
        e.Graphics.Clear(corFundo);

        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, Raio * 2, Raio * 2, 180, 90);
        path.AddArc(Width - Raio * 2, 0, Raio * 2, Raio * 2, 270, 90);
        path.AddArc(Width - Raio * 2, Height - Raio * 2, Raio * 2, Raio * 2, 0, 90);
        path.AddArc(0, Height - Raio * 2, Raio * 2, Raio * 2, 90, 90);
        path.CloseFigure();

        e.Graphics.FillPath(new SolidBrush(BackColor), path);
        e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor),
            new RectangleF(0, 0, Width, Height),
            new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
    }
}