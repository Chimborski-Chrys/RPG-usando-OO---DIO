namespace Jogo_RPG.src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType, int Hp, int Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mana = Mana;
        }

         public override string Attack(){
            return this.Name + " Atacou com katana";
        }
    }
}