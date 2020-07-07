namespace Class_Lock
{
    class TFUISB : Terraria.GameContent.UI.Elements.FixedUIScrollbar
    {
        public static bool imh;
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            base.DrawSelf(sb);
            if (IsMouseHovering) Terraria.Main.LocalPlayer.mouseInterface = true;
            imh = IsMouseHovering;
        }
        public TFUISB(Terraria.UI.UserInterface ui) : base(ui) { }
    }
}