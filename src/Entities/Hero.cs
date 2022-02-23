namespace Jogo_RPG.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType, int Hp, int Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mana = Mana;
        }

        public Hero()
        {
            
        }
        public string Name;
        public int Level;
        public string HeroType;
        public int Hp;
        public int Mana;

        public override string ToString(){
            return this.Name + " " + "\n" +
            "Lv. " + this.Level + " " + this.HeroType + "\n" +
            "HP " + this.Hp + "/ " + this.Hp + "\n" +
            "MP " + this.Mana + "/ " + this.Mana;
        }

        public virtual string Attack(){
            return this.Name + " Atacou com sua espada";
        }

    }
}