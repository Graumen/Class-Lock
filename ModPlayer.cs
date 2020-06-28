using System.Collections.Generic;
using Terraria.ModLoader.IO;
using Terraria;
namespace Class_Lock
{
    class ModPlayer0 : Terraria.ModLoader.ModPlayer
    {
        public bool f0;
        public List<int> f1 = new List<int>();
        public override bool? CanHitNPC(Item a0, NPC a1) => f0 ? (bool?)null : false;
        public override bool? CanHitNPCWithProj(Projectile a0, NPC a1) => f1.Contains(a0.type) ? (bool?)null : false;
        public override TagCompound Save() => new TagCompound { ["f0"] = f0, ["f1"] = f1 };
        public override void Load(TagCompound a0)
        {
            f0 = a0.GetBool("f0");
            f1 = a0.Get<List<int>>("f1");
        }
    }
}