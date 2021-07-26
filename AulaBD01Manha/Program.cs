using System;
using System.Data.SqlClient;

namespace AulaBD01Manha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Source=BUE205D39;Initial Catalog=tempdb;Persist Security Info=True;User ID=guest01;Password=***********
            // ****************
            // Lembre de atualizar a sua Cadeia de Conexao
            // ****************
            SqlConnection conn = new SqlConnection("Data Source = BUE205D94; Initial Catalog = DBTurmaManha; User ID = guest01; Password = @Senac2021");
            SqlCommand cmd;
            //conn.ConnectionString = "Data Source=BUE205D39;Initial Catalog=tempdb;Persist Security Info=True;User ID=guest01;Password=***********";
            // exec 01

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Insira o {0}° cliente", i + 1);
            //    string nome = Console.ReadLine();
            //    string cpf = Console.ReadLine();
            //    int idade = int.Parse(Console.ReadLine());
            //    string insert = $"INSERT into dbo.Pessoa (Nome,CPF,Idade) values ('{nome}','{cpf}',{idade})";
            //    cmd = new SqlCommand(insert, conn);// preparação do insert
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //// update
            //string update = "UPDATE dbo.Pessoa Set Nome = 'Joao' , Idade = 25 WHERE idPessoa = 1";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //// delete
            //string delete = "DELETE from dbo.Pessoa WHERE Nome = 'Carlos'";
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //// Select
            //string select = "SELECT * FROM dbo.Pessoa";
            //cmd = new SqlCommand(select, conn);

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["idPessoa"]);
            //    Console.WriteLine(dr[1]);
            //    Console.WriteLine(dr[2]);
            //    Console.WriteLine(dr["Idade"]);
            //    Console.WriteLine("-------------//---------------®");
            //}
            //dr.Close();
            //conn.Close();

            // Exc 02

            for (int i = 0; i < 3; i ++)
            {
                Console.WriteLine("Insira o {0}° Cachorro",i+1);
                string nome = Console.ReadLine();
                string nomeDoDono = Console.ReadLine();
                string telefoneDoDono = Console.ReadLine();
                string insert = $"INSERT into dbo.Cachorro(Nome, NomeDoDono, TelefoneDoDono) value('{nome}','{nomeDoDono}','{telefoneDoDono}')";
                cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }


            // Exc 03

        }
    }
}
