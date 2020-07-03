using static Terraria.Main;
using Terraria.UI;
namespace Class_Lock
{
    class DP : Terraria.GameContent.UI.Elements.UIPanel
    {
        float x, y;
        public static bool md;
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            if (md)
            {
                Left.Set(mouseX - x, 0);
                Top.Set(mouseY - y, 0);
            }
            base.DrawSelf(sb);
            if (IsMouseHovering) LocalPlayer.mouseInterface = true;
        }
        public override void MouseDown(UIMouseEvent _)
        {
            if (!TFUISB.imh) md = true;
            x = mouseX - Left.Pixels;
            y = mouseY - Top.Pixels;
        }
        public override void MouseUp(UIMouseEvent _) => md = false;
    }
}