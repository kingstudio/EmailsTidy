using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace DBHelp
{
    /// <summary>
    /// Access Help
    /// </summary>
    public class Access
    {
        #region 小功能
        /// <summary>
        /// 数据库访问
        /// </summary>
        OleDbConnection conn;
        string conString;
        public OleDbConnection con
        {
            get
            {
                if (conn == null)
                {
                    conn = new OleDbConnection(conString);
                }
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
        }


        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        /// <param name="conString"></param>
        public Access(string conString)
        {
            try
            {
                conn = new OleDbConnection(conString);
                this.conString = conString;
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        /// <param name="conString"></param>
        public Access()
        {
            try
            {
                this.conString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["myconn"].ToString() + ";Jet OLEDB:Database PassWord=sa";
                conn = new OleDbConnection(this.conString);
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// 关闭数据库
        /// </summary>
        private void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// 填充
        /// </summary>
        /// <param name="com"></param>
        /// <param name="array"></param>
        void SetParametersArray(ref OleDbCommand com, ParametersArray array)
        {
            foreach (OleDbParameter item in array.GetArray())
            {
                com.Parameters.Add(item);
            }
        }
        #endregion
        #region 执行SQL语句并返回受影响的行数
        /// <summary>
        /// 执行SQL语句并返回受影响的行数
        /// </summary>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            try
            {
                using (OleDbCommand com = new OleDbCommand(sql, con))
                {
                    int re = com.ExecuteNonQuery();
                    com.Dispose();
                    return re;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                closeConnection();
            }
        }


        /// <summary>
        /// 执行SQL语句并返回受影响的行数
        /// </summary>
        public int ExecuteNonQuery(string sql, OleDbParameter par)
        {
            try
            {
                using (OleDbCommand com = new OleDbCommand(sql, con))
                {
                    com.Parameters.Add(par);
                    int re = com.ExecuteNonQuery();
                    com.Dispose();
                    return re;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                closeConnection();
            }
        }

        /// <summary>
        /// 执行SQL语句并返回受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql, ParametersArray array)
        {
            try
            {
                OleDbCommand com = new OleDbCommand(sql, con);
                SetParametersArray(ref com, array);
                int re = com.ExecuteNonQuery();
                com.Dispose();
                return re;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                closeConnection();
            }
        }
        #endregion
        #region ExecuteReader
        public OleDbDataReader ExecuteReader(string sql)
        {
            try
            {
                using (OleDbCommand com = new OleDbCommand(sql, con))
                {
                    OleDbDataReader reader = com.ExecuteReader();
                    com.Dispose();
                    return reader;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                closeConnection();
            }
        }
        public OleDbDataReader ExecuteReader(string sql, OleDbParameter par)
        {
            try
            {
                using (OleDbCommand com = new OleDbCommand(sql, con))
                {
                    com.Parameters.Add(par);
                    OleDbDataReader reader = com.ExecuteReader();
                    com.Dispose();
                    return reader;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                closeConnection();
            }
        }
        public OleDbDataReader ExecuteReader(string sql, ParametersArray array)
        {
            try
            {
                OleDbCommand com = new OleDbCommand(sql, con);
                SetParametersArray(ref com, array);
                OleDbDataReader reader = com.ExecuteReader();
                com.Dispose();
                return reader;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                closeConnection();
            }
        }
        #endregion
        #region 读取查询结果中的第一行第一列
        /// <summary>
        /// 读取查询结果中的第一行第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql)
        {
            try
            {
                using (OleDbCommand com = new OleDbCommand(sql, con))
                {
                    object ob = com.ExecuteScalar();
                    com.Dispose();
                    return ob;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                closeConnection();
            }
        }

        /// <summary>
        /// 读取查询结果中的第一行第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql, OleDbParameter par)
        {
            try
            {
                using (OleDbCommand com = new OleDbCommand(sql, con))
                {
                    com.Parameters.Add(par);
                    object ob = com.ExecuteScalar();
                    com.Dispose();
                    return ob;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                closeConnection();
            }
        }

        /// <summary>
        /// 读取查询结果中的第一行第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql, ParametersArray array)
        {
            try
            {
                OleDbCommand com = new OleDbCommand(sql, con);
                SetParametersArray(ref com, array);
                object ob = com.ExecuteScalar();
                com.Dispose();
                return ob;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                closeConnection();
            }
        }
        #endregion
        #region 执行Insert语句,并返回新添加的记录ID
        /// <summary>
        /// 执行Insert语句,并返回新添加的记录ID
        /// </summary>
        /// <returns></returns>
        public object ExecuteNonQueryAndGetIdentity(string sql)
        {
            try
            {
                using (OleDbCommand com = new OleDbCommand(sql, con))
                {
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        com.CommandText = "select @@identity";
                        object ob = com.ExecuteScalar();
                        com.Dispose();
                        return ob;
                    }
                    else
                    {
                        throw new Exception("记录添加不成功！");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                closeConnection();
            }
        }

        /// <summary>
        /// 执行Insert语句,并返回新添加的记录ID
        /// </summary>
        public object ExecuteNonQueryAndGetIdentity(string sql, OleDbParameter par)
        {
            try
            {
                using (OleDbCommand com = new OleDbCommand(sql, con))
                {
                    com.Parameters.Add(par);
                    if (com.ExecuteNonQuery() >= 1)
                    {
                        com.CommandText = "select @@identity";
                        object ob = com.ExecuteScalar();
                        com.Dispose();
                        return ob;
                    }
                    else
                    {
                        throw new Exception("记录添加不成功！");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                closeConnection();
            }
        }

        /// <summary>
        /// 执行Insert语句,并返回新添加的记录ID
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        public object ExecuteNonQueryAndGetIdentity(string sql, ParametersArray array)
        {
            try
            {
                OleDbCommand com = new OleDbCommand(sql, con);
                SetParametersArray(ref com, array);
                if (com.ExecuteNonQuery() >= 1)
                {
                    com.CommandText = "select @@identity";
                    object ob = com.ExecuteScalar();
                    com.Dispose();
                    return ob;
                }
                else
                {
                    throw new Exception("记录添加不成功！");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                closeConnection();
            }
        }
        #endregion
        #region 返回DataSet
        /// <summary>
        /// 返回DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql)
        {
            try
            {
                using (OleDbDataAdapter adpter = new OleDbDataAdapter(sql, con))
                {
                    DataSet ds = new DataSet();
                    adpter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                closeConnection();
            }
        }

        /// <summary>
        /// 返回DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql, OleDbParameter par)
        {
            try
            {
                using (OleDbCommand com = new OleDbCommand(sql, con))
                {
                    com.Parameters.Add(par);
                    using (OleDbDataAdapter adpter = new OleDbDataAdapter(com))
                    {
                        DataSet ds = new DataSet();
                        adpter.Fill(ds);
                        com.Dispose();
                        return ds;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                closeConnection();
            }
        }

        /// <summary>
        /// 返回DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql, ParametersArray array)
        {
            try
            {
                OleDbCommand com = new OleDbCommand(sql, con);
                SetParametersArray(ref com, array);
                using (OleDbDataAdapter adpter = new OleDbDataAdapter(com))
                {
                    DataSet ds = new DataSet();
                    adpter.Fill(ds);
                    com.Dispose();
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                closeConnection();
            }
        }
        #endregion
    }

    /// <summary>
    /// 一组Parameters对象
    /// </summary>
    public class ParametersArray
    {
        List<System.Data.OleDb.OleDbParameter> par = new List<System.Data.OleDb.OleDbParameter>();
        /// <summary>
        /// 添加新参数
        /// </summary>
        /// <param name="par"></param>
        public void Add(System.Data.OleDb.OleDbParameter par)
        {
            this.par.Add(par);
        }
        /// <summary>
        /// 获取全部
        /// </summary>
        /// <returns></returns>
        public List<System.Data.OleDb.OleDbParameter> GetArray()
        {
            return this.par;
        }
    }
}
