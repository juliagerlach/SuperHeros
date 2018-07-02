namespace SuperHero.Migrations
{
    using SuperHero.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SuperHero.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SuperHero.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
                context.Superhero.AddOrUpdate(
                  s => s.Name,
                  new Superhero { Name = "Wonder Woman", Alterego = "Diana Prince", PrimaryAbility = "Superhuman strength", SecondaryAbility = "Empathy", Catchphrase = "Merciful Minerva!"},
                  new Superhero { Name = "Catwoman", Alterego = "Selena Kyle", PrimaryAbility = "Combat", SecondaryAbility = "Stealth", Catchphrase = "You're catnip to a girl like me." },
                  new Superhero { Name = "Elektra", Alterego = "Erynys", PrimaryAbility = "Hypnosis", SecondaryAbility = "Silent scream", Catchphrase = "Don't worry. Death's not that bad." },
                  new Superhero { Name = "Supergirl", Alterego = "Linda Lang", PrimaryAbility = "Flight", SecondaryAbility = "Invulnerability", Catchphrase = null },
                  new Superhero { Name = "Poison Ivy", Alterego = "Pamela Lillian Isley", PrimaryAbility = "Chlorokinesis", SecondaryAbility = "Toxic immunity", Catchphrase = null }
                );
                context.SaveChanges();
        }
    }
}