using System.ComponentModel.DataAnnotations;
namespace WorldCup.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string? Team1 { get; set; }
        public string? Team2 { get; set; }

        public string? flag1 { get; set; }
        public string? flag2 { get; set;}

        public int score1 { get; set; }
        public int score2 { get; set; }

        public double position1 { get; set; }
        public double position2 { get; set; }

        public int passing1 { get; set; }
        public int passing2 { get; set;}

        public int shootOnTarget1 { get; set; }
        public int shootOnTarget2 { get; set; }

        public int yellowCard1 { get; set; }
        public int yellowCard2 { get; set; }

        public int redCard1 { get; set; }
        public int redCard2 { get; set; }

    }
}
