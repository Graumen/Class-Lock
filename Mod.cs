using Microsoft.Xna.Framework;
using System.Linq;
using System;
using Terraria.UI;
using Terraria;
namespace Class_Lock
{
    class Mod0 : Terraria.ModLoader.Mod
    {
        public static UserInterface f0 = new UserInterface();
        public override object Call(params object[] a0)
        {
            for (int f0 = 2; 7 > f0; f0++) if (a0[f0] != null) UI.f2[f0 - 2].f0.Add(a0[f0] as Predicate<Projectile>);
            UI.f2.Add(new Class(a0[0] as Predicate<Projectile>, a0[1] as string));
            return "";
        }
        public override void Load()
        {
            UI.f2.Clear();
            UI.f2.AddRange(new Class[]
            {
                new Class(_ => !(_.magic || _.melee || _.ranged || _.thrown), "Summon"),
                new Class(_ => _.magic, "Magic"),
                new Class(_ => _.melee, "Melee"),
                new Class(_ => _.ranged, "Ranged"),
                new Class(_ => _.thrown, "Throwing")
            });
            f0.SetState(new UI());
            UI.f4.Clear();
        }
        public override void ModifyInterfaceLayers(System.Collections.Generic.List<GameInterfaceLayer> a0)
        {
            int f0 = a0.FindIndex(_ => _.Name == "Vanilla: Mouse Text");

            if (-1 < f0)
            {
                a0.Insert(f0, new LegacyGameInterfaceLayer("", () =>
                {
                    if (!Main.LocalPlayer.GetModPlayer<ModPlayer0>().f1.Any()) Mod0.f0.Draw(Main.spriteBatch, new GameTime());
                    return true;
                }, InterfaceScaleType.UI));
            }
        }
        public override void UpdateUI(GameTime a0) => f0.Update(a0);
    }
}