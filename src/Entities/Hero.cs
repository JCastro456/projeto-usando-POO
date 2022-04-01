namespace projeto1_dio.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;
        public int MagicPoints;
        public int HP;
        public Hero(string Name, int Level, string HeroType, int MagicPoints, int HP){

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
            this.MagicPoints = MagicPoints;
            this.HP = HP;

        }

        public Hero () {
        }

        public override string ToString() {

           return this.Name + " " + this.Level + " " + this.HeroType;
        }
        public virtual string Attack(){
           return this.Name +  " Lançou Magia ";
        }   

    }
}