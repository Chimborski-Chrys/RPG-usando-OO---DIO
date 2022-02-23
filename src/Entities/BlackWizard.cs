namespace Jogo_RPG.src.Entities
{
    public class BlackWizard : Hero
    {       
         public BlackWizard(string Name, int Level, string HeroType, int Hp, int Mana)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mana = Mana;
        }

        public override string Attack(){
            return this.Name + " Atacou com magia das sombras";
        }

        public string Attack(int Bonus){

            if(Bonus > 6 ){
                return this.Name + " Lançou magia das sombras super efetiva com bonus de " + Bonus;
            }else{
                 return this.Name + " Lançou magia das sombras de baixa efetividade com bonus de " + Bonus;
            }
            
        }
    }
}