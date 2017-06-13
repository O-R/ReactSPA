using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using ReactSPACore.Service;

namespace ReactSPACore.Data
{
    public class DbBase : IDapper
    {
        public IDapper Dapper { get; }
        public DbBase(IDapper dapper)
        {
            this.Dapper = dapper;

        }
        public DbBase()
        {
            this.Dapper = ServiceProvider.GetService<IDapper>();
        }

        /// <summary>
        /// 增、删、改同步操作
        /// </summary>
        /// <param name="connection">链接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>int</returns>
        public int ExcuteNonQuery(string connection, string cmd, DynamicParameters param, bool flag = false)
        {
            return Dapper.ExcuteNonQuery(connection, cmd, param, flag);
        }

        /// <summary>
        /// 增、删、改异步操作
        /// </summary>
        /// <param name="connection">链接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>int</returns>
        public Task<int> ExcuteNonQueryAsync(string connection, string cmd, DynamicParameters param, bool flag = false)
        {
            return Dapper.ExcuteNonQueryAsync(connection, cmd, param, flag);
        }

        /// <summary>
        /// 同步查询操作
        /// </summary>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>T</returns>
        public T ExecuteScalar<T>(string connection, string cmd, DynamicParameters param, bool flag = false)
        {
            return Dapper.ExecuteScalar<T>(connection, cmd, param, flag);
        }
        /// <summary>
        /// 同步查询一条数据
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        public T GetOne<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new()
        {
            return Dapper.GetOne<T>(connection, cmd, param, flag);
        }

        /// <summary>
        /// /// 异步查询一条数据
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        public Task<T> GetOneAsync<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new()
        {
            return Dapper.GetOneAsync<T>(connection, cmd, param, flag);
        }

        /// <summary>
        /// 同步查询数据集合
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        public IList<T> GetList<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new()
        {
            return Dapper.GetList<T>(connection, cmd, param, flag);
        }

        /// <summary>
        /// 同步查询数据集合
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        public IList<T> GetListAsPage<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new()
        {
            return Dapper.GetListAsPage<T>(connection, cmd, param, flag);
        }

        /// <summary>
        /// /// 异步查询数据集合
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        public Task<IList<T>> GetListAsync<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new()
        {
            return Dapper.GetListAsync<T>(connection, cmd, param, flag);
        }

        /// <summary>
        /// 同步分页查询数据集合
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        public IList<T> GetListByPage<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new()
        {
            return Dapper.GetListByPage<T>(connection, cmd, param, flag);
        }

        /// <summary>
        /// 异步分页查询数据集合
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="connection">连接字符串</param>
        /// <param name="cmd">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="flag">true存储过程，false sql语句</param>
        /// <returns>t</returns>
        public Task<IList<T>> GetListByPageAsync<T>(string connection, string cmd, DynamicParameters param, bool flag = false) where T : class, new()
        {
            return Dapper.GetListByPageAsync<T>(connection, cmd, param, flag);
        }
    }
}