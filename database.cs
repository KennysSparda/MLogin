using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Login_M
{
    class database
    {
        private static SQLiteConnection conexao;

        public static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source="+Global.localdb + Global.dbname);
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_users";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable Command(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //////////////////// Functions signup //////////////////////////

        public static void NewUser(user u)
        {
            if(existUserName(u))
            {
                MessageBox.Show("Usuário já existe");
                return;
            }
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_users (USER_NAME, USER_PASSWD) VALUES(@name, @password)";
                cmd.Parameters.AddWithValue("@name", u.user_name);
                cmd.Parameters.AddWithValue("@password", u.user_password);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário criado com sucesso!");
                ConexaoBanco().Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao criar novo usuário");
                ConexaoBanco().Close();
                throw ex;
            }
        }

        //////////////////// End Functions signup //////////////////////

        ///////////////////// General routines /////////////////////////

        public static bool existUserName(user u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT USER_NAME FROM tb_users WHERE USER_NAME='"+u.user_name+"'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
