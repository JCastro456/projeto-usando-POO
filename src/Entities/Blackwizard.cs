namespace projeto1_dio.src.Entities
{
    public class Blackwizard : Hero{
      
        public Blackwizard(string Name, int Level, string HeroType, int MagicPoints, int HP){

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
            this.MagicPoints = MagicPoints;
            this.HP = HP;
        }

        public override string ToString(){
          return this.Name + " " + this.Level + " " + this.HeroType + " " + this.MagicPoints + " " + this.HP;
        }   
        public override string Attack(){
            return this.Name  +  " Atacou com a seu raio paralizante ";
        }    
        public virtual string Attack(int Bonus) {

           if (Bonus > 4){ 
                return this.Name +  " Lançou o feitiço de explosão " + Bonus; 
            }else{
                return this.Name +  " Lançou um feitiço de desarmamento " + Bonus;
            }
        }
    }       
}