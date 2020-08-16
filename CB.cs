using Microsoft.Xna.Framework;
using static Terraria.Main;
using System.Linq;
using Terraria.UI;
namespace Class_Lock
{
    class CB : UIElement
    {
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            Height.Set(35, 0);
            if (ContainsPoint(MouseScreen)) LocalPlayer.mouseInterface = true;
            Left.Set(7, 0);
            Top.Set(221, 0);
            UI.Panel(ContainsPoint(MouseScreen) ? new Color(121, 155, 255) : new Color(73, 96, 234), Color.Black, new Rectangle((int)GetDimensions().X, (int)GetDimensions().Y, (int)Width.Pixels, 35), sb);
            Terraria.Utils.DrawBorderString(sb, "Confirm", new Vector2((Width.Pixels - 64) / 2 + GetDimensions().X, 7 + GetDimensions().Y), Color.White);
            Width.Set(System.Math.Max(122, 49 + TUIL.il.Max()), 0);
        }
        public override void DoubleClick(UIMouseEvent evt)
        {
            var lp = LocalPlayer.GetModPlayer<MP>();
            var pj = new Terraria.Projectile();

            foreach (var _ in TUIL.cl)
            {
                for (int id = 1; id < Terraria.ModLoader.ProjectileLoader.ProjectileCount; id++)
                {
                    if (_.chosen && _.pl.All(pp => pp(pj)))
                    {
                        if ("Melee" == _.name) lp.melee = true;
                        lp.idl.Add(pj.type);
                    }
                    pj.SetDefaults(id);
                }
            }
        }
        public override void MouseDown(UIMouseEvent _) => PlaySound(12);
        public override void MouseOver(UIMouseEvent _) => PlaySound(12);
    }
}