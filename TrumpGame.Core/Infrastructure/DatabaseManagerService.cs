using System;
using TrumpGame.Data.Infrastructure;

namespace TrumpGame.Core.Infrastructure
{
    public class DatabaseManagerService
    {
        /// <summary>
        /// Cria o banco de dados caso ainda não exista
        /// </summary>
        public void CreateDatabase()
        {
            try
            {
                var databaseManagerDalc = new DatabaseManagerDalc();
                databaseManagerDalc.CreateDatabase();
            }
            catch (Exception ex)
            {
                //TODO: Alterar a forma de logar erros
                var newException = new Exception(string.Format("Erro ao criar o banco de dados: {1}", ex.Message));
                throw newException;
            }
        }
    }
}
