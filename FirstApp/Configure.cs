using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public static class Configure
    {
        public static string UserName { get; set; } = null;
        public static string Password { get; set; } = null;
        public static int? Dictionary_id { get; set; } = null;


        public static IQueryable<T> SelectRandom<T>(this IQueryable<T> list, int count)
        {
            return list.OrderBy(_ => Guid.NewGuid()).Take(count);
        }
    }
}
