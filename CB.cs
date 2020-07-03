using Microsoft.Xna.Framework;
using static Terraria.Main;
using System.Linq;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;
namespace Class_Lock
{
    class CB : UIPanel
    {
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            BackgroundColor = ContainsPoint(MouseScreen) ? new Color(88, 114, 212, 255) : new Color(44, 57, 106, 255);
            base.DrawSelf(sb);
            Height.Set(35, 0);
            if (ContainsPoint(MouseScreen)) LocalPlayer.mouseInterface = true;
            Terraria.Utils.DrawBorderString(sb, "Confirm", new Vector2((UI.fl.Max() - 11) / 2 + GetDimensions().X, 7 + GetDimensions().Y), Color.White);
            Width.Set(53 + UI.fl.Max(), 0);
        }
        public override void DoubleClick(UIMouseEvent evt)
        {
            var lp = LocalPlayer.GetModPlayer<ModPlayer0>();
            var pj = new Terraria.Projectile();

            foreach (var Class in UI.cl)
            {
                for (int id = 1; id < Terraria.ModLoader.ProjectileLoader.ProjectileCount; id++)
                {
                    if (Class.pl.All(_ => _(pj)) && Class.selected)
                    {
                        lp.idl.Add(pj.type);
                        if ("Melee" == Class.name) lp.melee = true;
                    }
                    pj.SetDefaults(id);
                }
            }
        }
        public override void MouseDown(UIMouseEvent _) => PlaySound(12);
        public override void MouseOver(UIMouseEvent _) => PlaySound(12);
    }
}