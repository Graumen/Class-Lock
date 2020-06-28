using static Terraria.Main;
using Terraria.UI;
namespace Class_Lock
{
    class DP : Terraria.GameContent.UI.Elements.UIPanel
    {
        float f0, f1;
        public static bool f2;
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch a0)
        {
            if (f2)
            {
                Left.Set(mouseX - f0, 0);
                Top.Set(mouseY - f1, 0);
            }
            base.DrawSelf(a0);
            if (IsMouseHovering) LocalPlayer.mouseInterface = true;
        }
        public override void MouseDown(UIMouseEvent a0)
        {
            if (!TFUISB.f0) f2 = true;
            f0 = mouseX - Left.Pixels;
            f1 = mouseY - Top.Pixels;
        }
        public override void MouseUp(UIMouseEvent a0) => f2 = false;
    }
}