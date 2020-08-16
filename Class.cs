using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System;
using Terraria.UI;
using Terraria;
namespace Class_Lock
{
    class Class : UIElement
    {
        public bool chosen;
        public List<Predicate<Projectile>> pl = new List<Predicate<Projectile>>();
        public string name;
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            Height.Set(35, 0);
            if (ContainsPoint(Main.MouseScreen)) Main.LocalPlayer.mouseInterface = true;
            Left.Set(7, 0);
            UI.Panel(chosen || ContainsPoint(Main.MouseScreen) ? new Color(121, 155, 255) : new Color(73, 96, 234), chosen ? new Color(231, 177, 48) : Color.Black, new Rectangle((int)GetDimensions().X, (int)GetDimensions().Y, (int)Width.Pixels, 35), sb);
            Utils.DrawBorderString(sb, name, new Vector2(7 + GetDimensions().X, 7 + GetDimensions().Y), Color.White);
            Width.Set(14 + TUIL.il.Max(), 0);
        }
        public Class(Predicate<Projectile> pp, string Name)
        {
            name = Name;
            pl.Add(pp);
        }
        public override void MouseDown(UIMouseEvent _)
        {
            chosen = !chosen;
            Main.PlaySound(12);
        }
        public override void MouseOver(UIMouseEvent _) => Main.PlaySound(12);
    }
}