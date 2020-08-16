using Microsoft.Xna.Framework;
using static Terraria.Main;
using System.Linq;
using System;
using Terraria.UI;
namespace Class_Lock
{
    class ScrollBar : UIElement
    {
        bool md;
        public static int dps, y;
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            Height.Set(Math.Max(20, 209 * 5 / TUIL.cl.Count), 0);
            if (5 < TUIL.cl.Count && md) TUIL.dps = (y - mouseY) / ((209 - (int)Height.Pixels) / (TUIL.cl.Count - 5)) * 40 + dps;
            if ((5 - TUIL.cl.Count) * 40 > dps) dps = (5 - TUIL.cl.Count) * 40;
            if ((5 - TUIL.cl.Count) * 40 > TUIL.dps) TUIL.dps = (5 - TUIL.cl.Count) * 40;
            if (0 < dps) dps = 0;
            if (0 < TUIL.dps) TUIL.dps = 0;
            if (ContainsPoint(MouseScreen)) LocalPlayer.mouseInterface = true;
            Left.Set(Math.Max(113, 40 + TUIL.il.Max()), 0);
            Top.Set(5 < TUIL.cl.Count ? (209 - Height.Pixels) / (TUIL.cl.Count - 5) * -TUIL.dps / 40 + 7 : 7, 0);
            UI.Panel(ContainsPoint(MouseScreen) || md ? new Color(231, 177, 48) : new Color(194, 120, 4), Color.Black, new Rectangle((int)GetDimensions().X, (int)GetDimensions().Y - 2, 16, (int)Height.Pixels + 4), sb);
            Width.Set(16, 0);
        }
        public override void MouseDown(UIMouseEvent _)
        {
            md = true;
            PlaySound(12);
            y = mouseY;
        }
        public override void MouseUp(UIMouseEvent _)
        {
            if (5 < TUIL.cl.Count) dps += (y - mouseY) / ((209 - (int)Height.Pixels) / (TUIL.cl.Count - 5)) * 40;
            md = false;
        }
        public override void MouseOver(UIMouseEvent _) => PlaySound(12);
    }
}