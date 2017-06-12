using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;

namespace ReactSPADal.Core
{
    public class SqlHelper
    {
        private ISqlHelper _sqlhelper;
        public SqlHelper(ISqlHelper sqlhelper)
        {
            this._sqlhelper = sqlhelper;
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
            return _sqlhelper.ExcuteNonQuery(connection, cmd, param, flag);
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
            return _sqlhelper.ExcuteNonQueryAsync(connection, cmd, param, flag);
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
            return _sqlhelper.ExecuteScalar<T>(connection, cmd, param, flag);
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
            return _sqlhelper.GetOne<T>(connection, cmd, param, flag);
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
            return _sqlhelper.GetOneAsync<T>(connection, cmd, param, flag);
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
            return _sqlhelper.GetList<T>(connection, cmd, param, flag);
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
            return _sqlhelper.GetListAsPage<T>(connection, cmd, param, flag);
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
            return _sqlhelper.GetListAsync<T>(connection, cmd, param, flag);
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
            return _sqlhelper.GetListByPage<T>(connection, cmd, param, flag);
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
            return _sqlhelper.GetListByPageAsync<T>(connection, cmd, param, flag);
        }
    }
}