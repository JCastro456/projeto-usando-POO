namespace projeto1_dio.src.Entities
{
    public class Wizard : Hero{
        public Wizard(string Name, int Level, string HeroType, int MagicPoints, int HP){

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
           return this.Name +  " Lançou Magia ";
        }   

        public virtual string Attack(int Bonus){

            if (Bonus > 6){ 
                return this.Name +  " Lançou Magia super efetiva " + Bonus; 
            }else{
                return this.Name +  " Lançou escudo protetor " + Bonus;
            }

        }         
    }   
}