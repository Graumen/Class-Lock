using Microsoft.Xna.Framework;
using static Terraria.Main;
using System.Linq;
using Terraria.UI;
namespace Class_Lock
{
    class DP : UIElement
    {
        bool md;
        float x, y;
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            if (md)
            {
                Left.Set(mouseX - x, 0);
                Top.Set(mouseY - y, 0);
            }
            Height.Set(263, 0);
            if (ContainsPoint(MouseScreen)) LocalPlayer.mouseInterface = true;
            UI.Panel(new Color(0, 128, 255), Color.Black, new Rectangle((int)GetDimensions().X, (int)GetDimensions().Y, (int)Width.Pixels, 263), sb);
            if (5 < TUIL.cl.Count) UI.Panel(new Color(4, 97, 213), Color.Black, new Rectangle((int)GetDimensions().X - 23 + (int)Width.Pixels, (int)GetDimensions().Y + 5, 16, 213), sb);
            Width.Set((5 < TUIL.cl.Count ? 63 : 42) + TUIL.il.Max(), 0);
        }
        public override void MouseDown(UIMouseEvent _)
        {
            md = true;
            x = mouseX - Left.Pixels;
            y = mouseY - Top.Pixels;
        }
        public override void MouseUp(UIMouseEvent _) => md = false;
    }
}