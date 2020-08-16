using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;
namespace Class_Lock
{
    class UI : Terraria.UI.UIState
    {
        public override void OnInitialize()
        {
            var dp = new DP();

            dp.Append(new CB());
            dp.Append(new ScrollBar());
            dp.Append(new TUIL());
            Append(dp);
        }
        public static void Panel(Color bgc, Color boc, Rectangle dim, Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            sb.Draw(GetTexture("Class_Lock/bl"), new Vector2(2 + dim.X, dim.Height - 8 + dim.Y), boc);
            sb.Draw(GetTexture("Class_Lock/br"), new Vector2(dim.Width - 8 + dim.X, dim.Height - 8 + dim.Y), boc);
            sb.Draw(GetTexture("Class_Lock/tl"), new Vector2(2 + dim.X, 2 + dim.Y), boc);
            sb.Draw(GetTexture("Class_Lock/tr"), new Vector2(dim.Width - 8 + dim.X, 2 + dim.Y), boc);
            sb.Draw(GetTexture("Class_Lock/wp"), new Rectangle(2 + dim.X, 8 + dim.Y, 2, dim.Height - 16), bgc);
            sb.Draw(GetTexture("Class_Lock/wp"), new Rectangle(4 + dim.X, 4 + dim.Y, 4, dim.Height - 8), bgc);
            sb.Draw(GetTexture("Class_Lock/wp"), new Rectangle(8 + dim.X, 2 + dim.Y, dim.Width - 16, dim.Height - 4), bgc);
            sb.Draw(GetTexture("Class_Lock/wp"), new Rectangle(8 + dim.X, dim.Height - 2 + dim.Y, dim.Width - 16, 2), boc);
            sb.Draw(GetTexture("Class_Lock/wp"), new Rectangle(8 + dim.X, dim.Y, dim.Width - 16, 2), boc);
            sb.Draw(GetTexture("Class_Lock/wp"), new Rectangle(dim.Width - 2 + dim.X, 8 + dim.Y, 2, dim.Height - 16), boc);
            sb.Draw(GetTexture("Class_Lock/wp"), new Rectangle(dim.Width - 4 + dim.X, 8 + dim.Y, 2, dim.Height - 16), bgc);
            sb.Draw(GetTexture("Class_Lock/wp"), new Rectangle(dim.Width - 8 + dim.X, 4 + dim.Y, 4, dim.Height - 8), bgc);
            sb.Draw(GetTexture("Class_Lock/wp"), new Rectangle(dim.X, 8 + dim.Y, 2, dim.Height - 16), boc);
        }
    }
}