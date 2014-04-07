using System.Data.Entity;
using System.Linq;
using TrumpGame.Model;

namespace TrumpGame.Data.Infrastructure
{
    public class DatabaseManagerDalc
    {
        /// <summary>
        /// Cria o banco de dados caso ainda não exista
        /// </summary>
        public void CreateDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TrumpGameContext>());

            SetInitialLoad();
        }

        /// <summary>
        /// Preenche o banco com a carga inicial
        /// </summary>
        private void SetInitialLoad()
        {
            using (var db = new TrumpGameContext())
            {
                #region Category

                int categoryCount = db.Categories.Count(cat => cat.Description == "Marvel");

                if (categoryCount == 0)
                {
                    db.Categories.Add(new Category() { Description = "Marvel" });
                    db.SaveChanges();
                }

                #endregion
            }
        }
    }
}
