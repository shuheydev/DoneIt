using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DoneIt.Models
{
    public class AppDbContext : IdentityDbContext //IdentityDbContextクラスを継承
    {
        //コンストラクタ
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //テーブルのモデル（クラス）を指定する
        //DbSet<Movie> Movie {get; set;} //例
        DbSet<WorkingItem> WorkingItem { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}


//チュートリアル65~