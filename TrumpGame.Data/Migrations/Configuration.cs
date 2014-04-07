using TrumpGame.Model;

namespace TrumpGame.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TrumpGameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TrumpGameContext context)
        {
            context.Categories.AddOrUpdate(
                cat => cat.Description,
                new Category { Description = "Marvel" }
                );

            base.Seed(context);
        }
    }
}
