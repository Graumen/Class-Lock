using Microsoft.Xna.Framework;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using Terraria.GameContent.UI.Elements;
namespace Class_Lock
{
    class UI : Terraria.UI.UIState
    {
        CB f0 = new CB();
        DP f1 = new DP();
        public static List<Class> f2 = new List<Class>();
        public static List<float> f3 = new List<float>() { 25 };
        public static UIList f4 = new UIList();
        TFUISB f5 = new TFUISB(Mod0.f0);
        UIPanel f6 = new UIPanel();
        public override void OnInitialize()
        {
            Append(f1);
            f0.Left.Set(7, 0);
            f1.Append(f0);
            f1.Append(f6);
            f1.BackgroundColor = new Color(0, 128, 255, 255);
            f1.Left.Set(500, 0);
            f1.SetPadding(0);
            f1.Top.Set(200, 0);
            f4.Left.Set(7, 0);
            f4.SetPadding(0);
            f4.SetScrollbar(f5);
            f4.Top.Set(2, 0);
            f5.Top.Set(13, 0);
            f6.Append(f4);
            f6.Append(f5);
            f6.BackgroundColor = new Color(0, 64, 128, 255);
            f6.Left.Set(7, 0);
            f6.SetPadding(0);
            f6.Top.Set(7, 0);
        }
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch a0)
        {
            if (!f4._items.Any())
            {
                f4.Add(new UIPanel());
                f4.AddRange(f2.OrderBy(_ => !_.f1).ThenBy(_ => _.f2));
            }
            f0.Top.Set(Min(21 + f2.Count * 40, 341), 0);
            foreach (var f0 in f2) f3.Add(Terraria.Main.fontMouseText.MeasureString(f0.f2).X);
            f6.Height.Set(Min(329, 9 + f2.Count * 40), 0);
            f6.Width.Set(53 + f3.Max(), 0);
            f1.Height.Set(Min(383, 63 + f2.Count * 40), 0);
            f1.Width.Set(67 + f3.Max(), 0);
            f5.Height.Set(Min(303, f2.Count * 40 - 17), 0);
            f5.Left.Set(26 + f3.Max(), 0);
            f4.Height.Set(Min(325, 5 + f2.Count * 40), 0);
            f4.Width.Set(14 + f3.Max(), 0);
        }
    }
}