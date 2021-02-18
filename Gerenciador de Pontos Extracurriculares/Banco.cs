using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows;

namespace Projeto
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = "+Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosAlunos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_aluno";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public static DataTable ObterAlunosMatricula()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT n_matricula AS 'Matrícula', t_nome AS 'Nome' FROM tb_aluno ORDER BY t_nome";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosAlunos(string matricula)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_aluno WHERE n_matricula="+matricula;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void atualizarAluno(Aluno a)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_aluno SET n_matricula="+a.n_matricula+", t_nome='"+a.t_nome+"', n_cpf="+a.n_cpf+", t_curso='"+a.t_curso+"', t_acesso='"+a.t_acesso+"', n_pontos="+a.n_pontos+" WHERE n_matricula="+a.n_matricula;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void excluirAluno(string matricula)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_aluno WHERE n_matricula=" + matricula;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void NovoAluno(Aluno a)
        {
            if (existeMatricula(a))
            {
                MessageBox.Show("Matrícula já existente!");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_aluno (t_nome, n_matricula, n_cpf, t_curso, t_acesso, n_pontos) VALUES (@t_nome, @n_matricula, @n_cpf, @t_curso, @t_acesso, 0)";
                cmd.Parameters.AddWithValue("@t_nome", a.t_nome);
                cmd.Parameters.AddWithValue("@n_matricula", a.n_matricula);
                cmd.Parameters.AddWithValue("@n_cpf", a.n_cpf);
                cmd.Parameters.AddWithValue("@t_curso", a.t_curso);
                cmd.Parameters.AddWithValue("@t_acesso", a.t_acesso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo aluno inserido!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo aluno!");
            }
 
        }

        public static bool existeMatricula(Aluno a)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText =  "SELECT n_matricula FROM tb_aluno WHERE n_matricula='"+a.n_matricula+"'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }

            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }

        //Funções da Atividade

        public static bool existeMatriculaAtiv(Atividade A)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT n_matricula FROM tb_atividade WHERE n_matricula='" + A.n_matricula + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }

            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }        
        
        public static void NovaAtividade(Atividade A)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_atividade (t_nomeAtividade, n_data, n_pontosObtidos, t_tipoAtividade, t_descricao, n_matricula) VALUES (@t_nomeAtividade, @n_data, @n_pontosObtidos, @t_tipoAtividade, @t_descricao, @n_matricula)";
                cmd.Parameters.AddWithValue("@t_nomeAtividade", A.t_nomeAtividade);
                cmd.Parameters.AddWithValue("@n_data", A.n_data);
                cmd.Parameters.AddWithValue("@n_pontosObtidos", A.n_pontosObtidos);
                cmd.Parameters.AddWithValue("@t_tipoAtividade", A.t_tipoAtividade);
                cmd.Parameters.AddWithValue("@t_descricao", A.t_descricao);
                cmd.Parameters.AddWithValue("@n_matricula", A.n_matricula);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nova atividade registrada!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar atividade!");
            }

        }

        public static DataTable consultaAtiv(Atividade a)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"select 
                                        id_atividade AS 'ID da Atividade',
                                        n_matricula AS 'Matrícula do Aluno',
                                        t_nomeAtividade AS 'Nome da Atividade',
                                        n_data AS 'Data',
                                        n_pontosObtidos AS 'Pontos Obtidos',
                                        t_tipoAtividade AS 'Tipo de Atividade',
                                        t_descricao AS 'Descrição'
                                    From
                                        tb_atividade
                                    WHERE
                                        n_matricula = "+ a.n_matricula;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable consultaAtivID(Atividade a)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"select 
                                        id_atividade AS 'ID da Atividade',
                                        n_matricula AS 'Matrícula do Aluno',
                                        t_nomeAtividade AS 'Nome da Atividade',
                                        n_data AS 'Data',
                                        n_pontosObtidos AS 'Pontos Obtidos',
                                        t_tipoAtividade AS 'Tipo de Atividade',
                                        t_descricao AS 'Descrição'
                                    From
                                        tb_atividade
                                    WHERE
                                        id_atividade = " + a.id_atividade;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void atualizarAtividade(Atividade A)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_atividade SET id_atividade="+ A.id_atividade +" ,n_matricula=" + A.n_matricula + ", t_nomeAtividade='" + A.t_nomeAtividade + "', n_data=" + A.n_data + ", n_pontosObtidos="+ A.n_pontosObtidos +" , t_tipoAtividade='" + A.t_tipoAtividade + "', t_descricao='" + A.t_descricao + "' WHERE id_atividade=" + A.id_atividade;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public static DataTable ObterDadosAtividades(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"
                    SELECT * FROM tb_atividade
                    WHERE
                        n_matricula=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void excluirAtividade(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_atividade WHERE id_atividade=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q, string msgOK=null,string msgERRO=null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }

    }
}
