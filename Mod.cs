using Microsoft.Xna.Framework;
using System.Linq;
using System;
using Terraria.UI;
using Terraria;
namespace Class_Lock
{
    class Mod : Terraria.ModLoader.Mod
    {
        public static UserInterface ui = new UserInterface();
        public override object Call(params object[] _)
        {
            for (int id = 2; 7 > id; id++) if (_[id] != null) TUIL.cl[id - 2].pl.Add(_[id] as Predicate<Projectile>);
            TUIL.cl.Add(new Class(_[0] as Predicate<Projectile>, _[1] as string));
            return "";
        }
        public override void Load()
        {
            TUIL.cl.Clear();
            TUIL.cl.AddRange(new Class[]
            {
                new Class(_ => !(_.magic || _.melee || _.ranged || _.thrown), "Summon"),
                new Class(_ => _.magic, "Magic"),
                new Class(_ => _.melee, "Melee"),
                new Class(_ => _.ranged, "Ranged"),
                new Class(_ => _.thrown, "Throwing")
            });
            TUIL.il.Clear();
            TUIL.il.Add(73);
            ui.SetState(new UI());
        }
        public override void ModifyInterfaceLayers(System.Collections.Generic.List<GameInterfaceLayer> il)
        {
            int mti = il.FindIndex(_ => _.Name == "Vanilla: Mouse Text");

            if (-1 < mti)
            {
                il.Insert(mti, new LegacyGameInterfaceLayer("", () =>
                {
                    if (!Main.LocalPlayer.GetModPlayer<MP>().idl.Any()) ui.Draw(Main.spriteBatch, new GameTime());
                    return true;
                }, InterfaceScaleType.UI));
            }
        }
        public override void UpdateUI(GameTime gt) { if (!Main.LocalPlayer.GetModPlayer<MP>().idl.Any()) ui?.Update(gt); }
    }
}