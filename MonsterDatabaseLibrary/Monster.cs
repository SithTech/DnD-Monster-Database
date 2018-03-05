using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
DnD Monster Database

Name
Type - undead, human, orc, etc
Sub_Type - human (black, white, asian, mexican) 
Territory - environment they can do found. forest, desert, etc
CR - Challenge Rating
Alignment
AC - Armor class (eg difficulty to hit, hit chance)
Hp - Health points
Size
Page Number
Source Book/ Material
Notes
*/

namespace MonsterDatabaseLibrary
{
    public class Monster
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Territory { get; set; }
        public string ChallengeRating { get; set; }
        public string Alignment { get; set; }
        public string ArmorClass { get; set; }
        public string HealthPoints { get; set; }
        //public string ExperiencePoints { get; set; }
        public string Size { get; set; }
        public string PageNumber { get; set; }
        public string SourceBook { get; set; }
        public string Notes { get; set; }

        public int ID { get; set; }     //Will be used to allow non-unique Name values


        public Monster()
        {
            ID = -1;
        }


    }
}
