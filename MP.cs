using System.Collections.Generic;
using Terraria.ModLoader.IO;
using Terraria;
namespace Class_Lock
{
    class MP : Terraria.ModLoader.ModPlayer
    {
        public bool melee;
        public List<int> idl = new List<int>();
        public override void Load(TagCompound tc)
        {
            idl = tc.Get<List<int>>("idl");
            melee = tc.GetBool("melee");
        }
        public override bool? CanHitNPC(Item _, NPC a) => melee ? (bool?)null : false;
        public override bool? CanHitNPCWithProj(Projectile pj, NPC _) => idl.Contains(pj.type) ? (bool?)null : false;
        public override TagCompound Save() => new TagCompound { ["idl"] = idl, ["melee"] = melee };
    }
}