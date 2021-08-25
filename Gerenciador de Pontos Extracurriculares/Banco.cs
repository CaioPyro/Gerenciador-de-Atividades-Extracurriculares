using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.IO;
using System.Diagnostics;

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
                cmd.CommandText = "SELECT n_matricula AS 'Matrícula', t_nome AS 'Nome' FROM tb_aluno WHERE t_nome != 'Coordenador' ORDER BY t_nome";
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
                cmd.CommandText = "UPDATE tb_aluno SET n_matricula="+a.n_matricula+", t_nome='"+a.t_nome+"', n_cpf="+a.n_cpf+", t_curso='"+a.t_curso+"', t_acesso='"+a.t_acesso+"', n_pontos="+a.n_pontos+" WHERE n_matricula="+a.n_matricula1;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alterações salvas");
                vcon.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                cmd.CommandText = "INSERT INTO tb_aluno (t_nome, n_matricula, n_cpf, t_curso, t_acesso, n_pontos, a_foto) VALUES (@t_nome, @n_matricula, @n_cpf, @t_curso, @t_acesso,0,@a_foto)";
                cmd.Parameters.AddWithValue("@t_nome", a.t_nome);
                cmd.Parameters.AddWithValue("@n_matricula", a.n_matricula);
                cmd.Parameters.AddWithValue("@n_cpf", a.n_cpf);
                cmd.Parameters.AddWithValue("@t_curso", a.t_curso);
                cmd.Parameters.AddWithValue("@t_acesso", a.t_acesso);
                cmd.Parameters.AddWithValue("@a_foto", a.a_foto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo aluno inserido!");
                vcon.Close();
            }
            catch (Exception)
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

        public static void alterarImagem(Aluno a)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_aluno SET a_foto = @a_foto WHERE n_matricula = @n_matricula";
                cmd.Parameters.AddWithValue("@a_foto", a.a_foto);
                cmd.Parameters.AddWithValue("@n_matricula", a.n_matricula);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Imagem alterada com sucesso");
                vcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Funções da Atividade
        
        public static void NovaAtividadeComCertificado(Atividade A)
        {

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_atividade (t_nomeAtividade, n_data, n_pontosObtidos, t_tipoAtividade, t_descricao, n_matricula, t_nomeCertificado, a_pdf) VALUES (@t_nomeAtividade, @n_data, @n_pontosObtidos, @t_tipoAtividade, @t_descricao, @n_matricula, @t_nomeCertificado, @a_pdf)";
                cmd.Parameters.AddWithValue("@t_nomeAtividade", A.t_nomeAtividade);
                cmd.Parameters.AddWithValue("@n_data", A.n_data);
                cmd.Parameters.AddWithValue("@n_pontosObtidos", A.n_pontosObtidos);
                cmd.Parameters.AddWithValue("@t_tipoAtividade", A.t_tipoAtividade);
                cmd.Parameters.AddWithValue("@t_descricao", A.t_descricao);
                cmd.Parameters.AddWithValue("@n_matricula", A.n_matricula);
                cmd.Parameters.AddWithValue("@t_nomeCertificado", Path.GetFileName(A.t_nomeCertificado));
                cmd.Parameters.AddWithValue("@a_pdf", File.ReadAllBytes(A.a_pdf));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nova atividade registrada!");
                vcon.Close();
                somaPontos(A);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao registrar atividade!");
            }

        }

        public static void NovaAtividadeSemCertificado(Atividade A)
        {

            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_atividade (t_nomeAtividade, n_data, n_pontosObtidos, t_tipoAtividade, t_descricao, n_matricula, t_nomeCertificado) VALUES (@t_nomeAtividade, @n_data, @n_pontosObtidos, @t_tipoAtividade, @t_descricao, @n_matricula, 'Certificado não cadastrado')";
                cmd.Parameters.AddWithValue("@t_nomeAtividade", A.t_nomeAtividade);
                cmd.Parameters.AddWithValue("@n_data", A.n_data);
                cmd.Parameters.AddWithValue("@n_pontosObtidos", A.n_pontosObtidos);
                cmd.Parameters.AddWithValue("@t_tipoAtividade", A.t_tipoAtividade);
                cmd.Parameters.AddWithValue("@t_descricao", A.t_descricao);
                cmd.Parameters.AddWithValue("@n_matricula", A.n_matricula);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nova atividade registrada!");
                vcon.Close();
                somaPontos(A);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao registrar atividade!");
            }

        }

        public static void somaPontos(Atividade P)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_aluno SET n_pontos = (n_pontos + '"+ P.n_pontosObtidos +"') WHERE n_matricula = '"+ P.n_matricula +"'";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
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
                                        t_descricao AS 'Descrição',
                                        t_nomeCertificado AS 'Certificado'
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
                cmd.CommandText = @"SELECT 
                                        id_atividade AS 'ID da Atividade',
                                        n_matricula AS 'Matrícula do Aluno',
                                        t_nomeAtividade AS 'Nome da Atividade',
                                        n_data AS 'Data',
                                        n_pontosObtidos AS 'Pontos Obtidos',
                                        t_tipoAtividade AS 'Tipo de Atividade',
                                        t_descricao AS 'Descrição',
                                        t_nomeCertificado AS 'Certificado'
                                    FROM
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

        public static DataTable consultaAtivIDstr(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = @"SELECT 
                                        id_atividade AS 'ID da Atividade',
                                        n_matricula AS 'Matrícula do Aluno',
                                        t_nomeAtividade AS 'Nome da Atividade',
                                        n_data AS 'Data',
                                        n_pontosObtidos AS 'Pontos Obtidos',
                                        t_tipoAtividade AS 'Tipo de Atividade',
                                        t_descricao AS 'Descrição',
                                        t_nomeCertificado AS 'Certificado'
                                    FROM
                                        tb_atividade
                                    WHERE
                                        id_atividade = " + id;
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

        public static void excluirAtividadeAluno(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_atividade WHERE n_matricula=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q)
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void abrirCertificado(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT a_pdf FROM tb_atividade WHERE id_atividade =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                var bytes = cmd.ExecuteScalar() as byte[];
                vcon.Close();

                if (bytes != null)
                {
                    var nomeCertificado = consultaAtivIDstr(id).Rows[0].Field<string>("Certificado").ToString();
                    var arquivoTemp = Path.GetFileName(nomeCertificado);
                    arquivoTemp = Path.ChangeExtension(arquivoTemp, Path.GetExtension(nomeCertificado));
                    File.WriteAllBytes(arquivoTemp, bytes);
                    Process.Start(arquivoTemp);
                }

                else
                {
                    MessageBox.Show("Nenhum certificado foi encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void editarAtividadeSemCertificado(Atividade A)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_atividade SET id_atividade=" + A.id_atividade + ", n_matricula=" + A.n_matricula + ", t_nomeAtividade='" + A.t_nomeAtividade + "', n_data='" + A.n_data + "', n_pontosObtidos=" + A.n_pontosObtidos + ", t_tipoAtividade='" + A.t_tipoAtividade + "', t_descricao='" + A.t_descricao + "', t_nomeCertificado='Certificado não cadastrado' WHERE id_atividade=" + A.id_atividade + "";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atividade alterada com sucesso");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void editarAtividadeComCertificado(Atividade A)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_atividade SET id_atividade= @id_atividade, n_matricula= @n_matricula, t_nomeAtividade= @t_nomeAtividade, n_data= @n_data, n_pontosObtidos= @n_pontosObtidos, t_tipoAtividade= @t_tipoAtividade, t_descricao= @t_descricao, t_nomeCertificado= @t_nomeCertificado, a_pdf= @a_pdf WHERE id_atividade= @id_atividade";
                cmd.Parameters.AddWithValue("@id_atividade", A.id_atividade);
                cmd.Parameters.AddWithValue("@n_matricula", A.n_matricula);
                cmd.Parameters.AddWithValue("@t_nomeAtividade", A.t_nomeAtividade);
                cmd.Parameters.AddWithValue("@n_data", A.n_data);
                cmd.Parameters.AddWithValue("@n_pontosObtidos", A.n_pontosObtidos);
                cmd.Parameters.AddWithValue("@t_tipoAtividade", A.t_tipoAtividade);
                cmd.Parameters.AddWithValue("@t_descricao", A.t_descricao);
                cmd.Parameters.AddWithValue("@t_nomeCertificado", Path.GetFileName(A.t_nomeCertificado));
                cmd.Parameters.AddWithValue("@a_pdf", File.ReadAllBytes(A.a_pdf));
                cmd.Parameters.AddWithValue("@id_atividade", A.id_atividade);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atividade alterada com sucesso");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void alterarMatricula(Int64 matricula, Int64 matricula1)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_atividade SET n_matricula = @n_matricula WHERE n_matricula = @n_matricula1";
                cmd.Parameters.AddWithValue("@n_matricula", matricula);
                cmd.Parameters.AddWithValue("@n_matricula1", matricula1);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
