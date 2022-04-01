namespace projeto1_dio.src.Entities
{
    public class Knight : Hero{
        public Knight(string Name, int Level, string HeroType, int MagicPoints, int HP){

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
            return this.Name  +  " Atacou com a sua espada ";
        }
        public virtual string Attack(int Bonus){

           if (Bonus > 5) { 
                return this.Name +  " Atacou com sua lança e defendeu com seu escudo " + Bonus; 
            }else{
                return this.Name +  " Atacou com a espada e sua armadura " + Bonus;
            }
        }
    }
}