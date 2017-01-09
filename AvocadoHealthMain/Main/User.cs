using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Interfaces;

namespace Main
{
    public class User :  Person, IPerson
    {
        
        public string _Gender { get; private set; }
        public Trainer Trainer { get; set; }
        public double _Mass { get; set; }
        public double _MuscleMass { get; set; }
        public List<Training> _TrainingsList { get; set; }
        //Тук промених да очаква интерфейса за храна, а не конректен клас храна - Мартин
        public List<Interfaces.IFoods> _RecomendedFood { get; set; }
        public double _Calories { get; set; }
        public double _CarboHydrates { get; set; }
        public double _Fats { get; set; }
        public double _Proteins { get; set; }
        // Липсват списъци за история какво е ял, какво е тренирал и тн. - Мартин



        public User(string firstName, string lastName, string gender) : base(firstName, lastName)
        {
            this._Gender = gender;
            this._FirstName = firstName;
            this._LastName = lastName;
            
        }


        public override void Eat(Food Food, double mass)
        {
            this._Calories += (Food.Calories * mass);
            this._Fats += (Food.Fats * mass);
            this._Proteins += (Food.Proteins * mass);
        }

        // Смених тук да иска интерфейса, а не конкретен клас - Мартин
        internal void SetTraining(Interfaces.ITrainings training)
        {
            throw new NotImplementedException();
        }

        public override void Train(Training training, double duration)
        {
            training.Train(this, duration);
        }
    }
}
