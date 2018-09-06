using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace angular.euromade.ru.Models.Repository
{
    public class EuromadeDbContext: DbContext
    {
        public EuromadeDbContext(DbContextOptions<EuromadeDbContext> options)
            :base(options)
        {

        }
    }
}
