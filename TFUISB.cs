namespace Class_Lock
{
    class TFUISB : Terraria.GameContent.UI.Elements.FixedUIScrollbar
    {
        public static bool f0;
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch a0)
        {
            base.DrawSelf(a0);
            f0 = IsMouseHovering;
            if (IsMouseHovering) Terraria.Main.LocalPlayer.mouseInterface = true;
        }
        public TFUISB(Terraria.UI.UserInterface a0) : base(a0)
        {
        }
    }
}