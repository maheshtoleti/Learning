using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public static class StartDBContext
    {
        public static void startDBContext(IServiceCollection services)
        {
            var connection = @"Server=.;Database=QuestionBank;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<QuestionBankContext>
                    (options => options.UseSqlServer(connection));
        }
    }
}
