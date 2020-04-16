namespace Server.Items
{
    public class BladedWhip : BaseSword, Server.Engines.Craft.IRepairable
    {
        public Server.Engines.Craft.CraftSystem RepairSystem { get { return Server.Engines.Craft.DefTinkering.CraftSystem; } }
        public override int LabelNumber { get { return 1125643; } } // Bladed Whip

        [Constructable]
        public BladedWhip()
            : base(0xA28B)
        {
            Weight = 5.0;
        }

        public BladedWhip(Serial serial)
            : base(serial)
        {
        }

        public override bool CanBeWornByGargoyles { get { return true; } }
        public override WeaponAbility PrimaryAbility { get { return WeaponAbility.BleedAttack; } }
        public override WeaponAbility SecondaryAbility { get { return WeaponAbility.WhirlwindAttack; } }
        public override int StrengthReq { get { return 20; } }
        public override int MinDamage { get { return 13; } }
        public override int MaxDamage { get { return 17; } }
        public override float Speed { get { return 3.25f; } }
        public override int DefHitSound { get { return 0x23B; } }
        public override int DefMissSound { get { return 0x23A; } }
        public override int InitMinHits { get { return 30; } }
        public override int InitMaxHits { get { return 60; } }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
