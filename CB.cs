using Microsoft.Xna.Framework;
using static Terraria.Main;
using System.Linq;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;
namespace Class_Lock
{
    class CB : UIPanel
    {
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch a0)
        {
            BackgroundColor = ContainsPoint(MouseScreen) ? new Color(88, 114, 212, 255) : new Color(44, 57, 106, 255);
            base.DrawSelf(a0);
            Height.Set(35, 0);
            if (ContainsPoint(MouseScreen)) LocalPlayer.mouseInterface = true;
            Terraria.Utils.DrawBorderString(a0, "Confirm", new Vector2((UI.f3.Max() - 11) / 2 + GetDimensions().X, 7 + GetDimensions().Y), Color.White);
            Width.Set(53 + UI.f3.Max(), 0);
        }
        public override void DoubleClick(UIMouseEvent a0)
        {
            var f0 = LocalPlayer.GetModPlayer<ModPlayer0>();
            var f1 = new Terraria.Projectile();

            foreach (var c in UI.f2)
            {
                for (int f2 = 1; f2 < Terraria.ModLoader.ProjectileLoader.ProjectileCount; f2++)
                {
                    if (c.f0.All(_ => _(f1)) && c.f1)
                    {
                        f0.f1.Add(f1.type);
                        if ("Melee" == c.f2) f0.f0 = true;
                    }
                    f1.SetDefaults(f2);
                }
            }
        }
        public override void MouseDown(UIMouseEvent a0) => PlaySound(12);
        public override void MouseOver(UIMouseEvent a0) => PlaySound(12);
    }
}