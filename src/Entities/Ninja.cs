namespace projeto1_dio.src.Entities
{
    public class Ninja : Hero{ 
        
        public Ninja(string Name, int Level, string HeroType, int MagicPoints, int HP){

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
            return this.Name  +  " Atacou com a sua espada Ninja ";
        }

        public virtual string Attack(int Bonus){

           if (Bonus > 7){ 
                return this.Name +  " Lançou estrelas Ninjas " + Bonus; 
            }else {
                return this.Name +  " Lançou fumaça " + Bonus;
            }
        }

    }
}