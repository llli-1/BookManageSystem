using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace bookmaster
{
    internal class Dao
    {
        MySqlConnection sc;
        //数据库连接
        public MySqlConnection connect()
        {
            string str = "Database=t1;Data Source=localhost;User Id=root;Password=mysql";//连接数据库的参数
            sc = new MySqlConnection(str);//连接数据库
            sc.Open();//打开数据库
            return sc;//返回数据库连接对象
        }

        public MySqlCommand command(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql)// 更新操作  //返回int类型，告诉你受影响的行数  //传入对应的sql语句
        {
            return command(sql).ExecuteNonQuery();
        }

        public MySqlDataReader read(string sql)//读取操作  SqlDataReader->MySqlDataReader
        {
            return command(sql).ExecuteReader();//通过输入的ID和密码讲在数据库里查询出来的结果 显示出来
        }
        public void DaoClose()
        {
            sc.Close();//关闭数据库连接
        }
    }
}
