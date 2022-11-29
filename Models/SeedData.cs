using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WorldCup.Data;

namespace WorldCup.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WorldCupContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WorldCupContext>>()))
            {
                // Look for any movies.
                if (context.Match.Any())
                {
                    return;   // DB has been seeded
                }
                context.Match.AddRange(
                    new Match
                    {
                        Team1 = "Viet Nam",
                        Team2 = "England",
                        flag1 = "../../img/vietnam.png",
                        flag2 = "../../img/england.png",
                        score1 = 10,
                        score2 = 0,
                        position1 = 90,
                        position2 = 10,
                        passing1 = 1000,
                        passing2 = 150,
                        shootOnTarget1 = 20,
                        shootOnTarget2 = 2,
                        yellowCard1 = 0,
                        yellowCard2 = 10,
                        redCard1 = 0, 
                        redCard2 = 2
                    },
                    new Match
                    {
                        Team1 = "Argentina",
                        Team2 = "Portugal",
                        flag1 = "../../img/argentina.png",
                        flag2 = "../../img/poturgal.png",
                        score1 = 0,
                        score2 = 0,
                        position1 = 50,
                        position2 = 50,
                        passing1 = 400,
                        passing2 = 400,
                        shootOnTarget1 = 20,
                        shootOnTarget2 = 20,
                        yellowCard1 = 2,
                        yellowCard2 = 2,
                        redCard1 = 0,
                        redCard2 = 0
                    },
                    new Match
                    {
                        Team1 = "France",
                        Team2 = "Italy",
                        flag1 = "../../img/france.png",
                        flag2 = "../../img/italia.png",
                        score1 = 3,
                        score2 = 3,
                        position1 = 60,
                        position2 = 40,
                        passing1 = 700,
                        passing2 = 550,
                        shootOnTarget1 = 20,
                        shootOnTarget2 = 22,
                        yellowCard1 = 4,
                        yellowCard2 = 1,
                        redCard1 = 0,
                        redCard2 = 0
                    },
                    new Match
                    {
                        Team1 = "Viet Nam",
                        Team2 = "Argentina",
                        flag1 = "../../img/vietnam.png",
                        flag2 = "../../img/argentina.png",
                        score1 = 20,
                        score2 = 0,
                        position1 = 90,
                        position2 = 10,
                        passing1 = 2000,
                        passing2 = 50,
                        shootOnTarget1 = 40,
                        shootOnTarget2 = 2,
                        yellowCard1 = 0,
                        yellowCard2 = 10,
                        redCard1 = 0,
                        redCard2 = 2
                    },
                    new Match
                    {
                        Team1 = "France",
                        Team2 = "England",
                        flag1 = "../../img/france.png",
                        flag2 = "../../img/england.png",
                        score1 = 4,
                        score2 = 3,
                        position1 = 70,
                        position2 = 30,
                        passing1 = 600,
                        passing2 = 450,
                        shootOnTarget1 = 20,
                        shootOnTarget2 = 25,
                        yellowCard1 = 0,
                        yellowCard2 = 1,
                        redCard1 = 0,
                        redCard2 = 0
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
