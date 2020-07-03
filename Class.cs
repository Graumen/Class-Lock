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
        public bool selected;
        public List<Predicate<Projectile>> pl = new List<Predicate<Projectile>>();
        public string name;
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            BackgroundColor = ContainsPoint(Main.MouseScreen) || selected ? new Color(88, 114, 212, 255) : new Color(44, 57, 106, 255);
            base.DrawSelf(sb);
            BorderColor = selected ? new Color(255, 213, 0, 255) : Color.Black;
            if (ContainsPoint(Main.MouseScreen)) Main.LocalPlayer.mouseInterface = true;
            Utils.DrawBorderString(sb, name, new Vector2(7 + GetDimensions().X, 7 + GetDimensions().Y), Color.White);
        }
        public override void Recalculate()
        {
            base.Recalculate();
            Height.Set(35, 0);
            Width.Set(14 + UI.fl.Max(), 0);
        }
        public Class(Predicate<Projectile> pp, string Name)
        {
            name = Name;
            pl.Add(pp);
        }
        public override void MouseDown(UIMouseEvent _)
        {
            BorderColor = selected ? Color.Black : new Color(255, 213, 0, 255);
            Main.PlaySound(12);
            selected = !selected;
            UI.uil.Clear();
        }
        public override void MouseOver(UIMouseEvent _) => Main.PlaySound(12);
    }
}