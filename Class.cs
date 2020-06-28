using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;
using Terraria;
namespace Class_Lock
{
    class Class : UIPanel
    {
        public List<Predicate<Projectile>> f0 = new List<Predicate<Projectile>>();
        public bool f1;
        public string f2;
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch a0)
        {
            BackgroundColor = ContainsPoint(Main.MouseScreen) || f1 ? new Color(88, 114, 212, 255) : new Color(44, 57, 106, 255);
            base.DrawSelf(a0);
            BorderColor = f1 ? new Color(255, 213, 0, 255) : Color.Black;
            if (ContainsPoint(Main.MouseScreen)) Main.LocalPlayer.mouseInterface = true;
            Utils.DrawBorderString(a0, f2, new Vector2(7 + GetDimensions().X, 7 + GetDimensions().Y), Color.White);
        }
        public override void Recalculate()
        {
            base.Recalculate();
            Height.Set(35, 0);
            Width.Set(14 + UI.f3.Max(), 0);
        }
        public Class(Predicate<Projectile> a0, string a1)
        {
            f0.Add(a0);
            f2 = a1;
        }
        public override void MouseDown(UIMouseEvent a0)
        {
            BorderColor = f1 ? Color.Black : new Color(255, 213, 0, 255);
            Main.PlaySound(12);
            f1 = !f1;
            UI.f4.Clear();
        }
        public override void MouseOver(UIMouseEvent a0) => Main.PlaySound(12);
    }
}