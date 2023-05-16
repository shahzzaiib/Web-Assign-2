using System.ComponentModel.DataAnnotations;

namespace Web_Assignment_2.Models

{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Team { get; set; }
        public string Gender { get; internal set; }
        public string SkillLevel { get; internal set; }
    }

}
