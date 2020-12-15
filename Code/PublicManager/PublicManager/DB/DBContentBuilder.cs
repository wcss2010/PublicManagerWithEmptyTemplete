using System;
using System.Collections.Generic;
using System.Text;

namespace PublicManager.DB
{
    public abstract class DBContentBuilder<ResultEntity>
    {
        public ResultEntity getDBContent(string dbFile)
        {
            //SQLite数据库工厂
            System.Data.SQLite.SQLiteFactory factory = new System.Data.SQLite.SQLiteFactory();

            //NDEY数据库连接
            Noear.Weed.DbContext context = new Noear.Weed.DbContext("main", "Data Source = " + dbFile, factory);
            //是否在执入后执行查询（主要针对Sqlite）
            context.IsSupportSelectIdentityAfterInsert = false;
            //是否在Dispose后执行GC用于解决Dispose后无法删除的问题（主要针对Sqlite）
            context.IsSupportGCAfterDispose = true;

            try
            {
                return getDBContent(context);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
                return default(ResultEntity);
            }
            finally
            {
                factory.Dispose();
                context.Dispose();
            }
        }

        public abstract ResultEntity getDBContent(Noear.Weed.DbContext context);
    }
}