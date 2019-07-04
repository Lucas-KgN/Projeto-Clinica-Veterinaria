using System;
using System.Collections.Generic;
using System.Text;
using Persistencia;

namespace Servico
{
    public class DataBaseCreated
    {
        public static void CreatedDataBase()
        {
            using (EFContext context = new EFContext())
            {
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
