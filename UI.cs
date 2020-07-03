using Microsoft.Xna.Framework;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using Terraria.GameContent.UI.Elements;
namespace Class_Lock
{
    class UI : Terraria.UI.UIState
    {
        CB cb = new CB();
        DP dp = new DP();
        public static List<Class> cl = new List<Class>();
        public static List<float> fl = new List<float>() { 25 };
        public static UIList uil = new UIList();
        TFUISB tfuisb = new TFUISB(Mod0.ui);
        UIPanel uip = new UIPanel();
        public override void OnInitialize()
        {
            Append(dp);
            cb.Left.Set(7, 0);
            dp.Append(cb);
            dp.Append(uip);
            dp.BackgroundColor = new Color(0, 128, 255, 255);
            dp.Left.Set(500, 0);
            dp.SetPadding(0);
            dp.Top.Set(200, 0);
            tfuisb.Top.Set(13, 0);
            uil.Left.Set(7, 0);
            uil.SetPadding(0);
            uil.SetScrollbar(tfuisb);
            uil.Top.Set(2, 0);
            uip.Append(tfuisb);
            uip.Append(uil);
            uip.BackgroundColor = new Color(0, 64, 128, 255);
            uip.Left.Set(7, 0);
            uip.SetPadding(0);
            uip.Top.Set(7, 0);
        }
        protected override void DrawSelf(Microsoft.Xna.Framework.Graphics.SpriteBatch sb)
        {
            if (!uil._items.Any())
            {
                uil.Add(new UIPanel());
                uil.AddRange(cl.OrderBy(_ => !_.selected).ThenBy(_ => _.name));
            }
            cb.Top.Set(Min(21 + cl.Count * 40, 341), 0);
            dp.Height.Set(Min(383, 63 + cl.Count * 40), 0);
            dp.Width.Set(67 + fl.Max(), 0);
            foreach (var _ in cl) fl.Add(Terraria.Main.fontMouseText.MeasureString(_.name).X);
            tfuisb.Height.Set(Min(303, cl.Count * 40 - 17), 0);
            tfuisb.Left.Set(26 + fl.Max(), 0);
            uil.Height.Set(Min(325, 5 + cl.Count * 40), 0);
            uil.Width.Set(14 + fl.Max(), 0);
            uip.Height.Set(Min(329, 9 + cl.Count * 40), 0);
            uip.Width.Set(53 + fl.Max(), 0);
        }
    }
}