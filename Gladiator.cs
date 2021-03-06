using System;

namespace TextGame{

    public class Gladiator{

        public Gladiator(string _name, string _combatClass){
            Name = _name;
            CombatClass = _combatClass;
            HealthMax = 100;
            HealthCurrent = this.HealthMax;
            StaminaMax = 100;
            StaminaCurrent = this.StaminaMax;
            ManaMax = 100;
            ManaCurrent = this.ManaMax;
        }

        public string Name { get; set; }
        public string CombatClass { get; set; }
        public double HealthMax { get; set; }
        public double HealthCurrent { get; set; }
        public double StaminaMax { get; set; }
        public double StaminaCurrent { get; set; }
        public double ManaMax { get; set; }
        public double ManaCurrent { get; set; }

        /*string name = "def";
        string combatClass = "def";
        double hpMax = 100;
        double hpCurrent = 100;
        double staminaMax = 100;
        double staminaCurrent = 100;
        double manaMax = 100;
        double manaCurrent = 100;
        int attack = 10;
        public int defense { get; set; }

        //Getters
        public string getName(){
            return this.name;
        }

        public string getCombatClass(){
            return this.combatClass;
        }

        public double getHpMax(){
            return this.hpMax;
        }

        public double getHpCurrent(){
            return this.hpCurrent;
        }

        //Setters
        public void setName(string s){
            this.name = s;
        }

        public void setCombatClass(string s){
            this.combatClass = s;
        }

        public void setHpMax(double d){
            this.hpMax = d;
        }

        public void setHpCurrent(double d){
            this.hpCurrent = d;
        }*/

    }
}