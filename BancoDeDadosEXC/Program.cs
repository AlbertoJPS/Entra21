using System;
using System.Data.SqlClient;

namespace BancoDeDadosEXC
{
    class Program
    {
        static void Main(string[] args)
        {


            // Exc 02

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o {0}° Cachorro", i + 1);
            //    string nome = Console.ReadLine();
            //    string nomeDoDono = Console.ReadLine();
            //    string telefoneDoDono = Console.ReadLine();
            //    string insert = $"INSERT into dbo.Cachorro (Nome,NomeDoDono,TelefoneDoDono) values ('{nome}', '{nomeDoDono}', '{telefoneDoDono}')";
            //    cmd = new SqlCommand(insert, conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //string select = "SELECT * from dbo.Cachorro";
            //string select = "SELECT * from dbo.Cachorro WHERE idCachorro > 2";
            //string select = "SELECT * from dbo.Cachorro WHERE nome LIKE '%lu%'";  e NOT LIKE
            //cmd = new SqlCommand(select, conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["IdCachorro"]);
            //    Console.WriteLine(dr[1]);
            //    Console.WriteLine(dr[2]);
            //    Console.WriteLine(dr[3]);
            //    Console.WriteLine("---------------");
            //}

            //dr.Close();
            //conn.Close();

            /// Exc 0001
            /// 
            SqlConnection conn = new SqlConnection("Data Source=entra21serv.database.windows.net,1433;Initial Catalog=ExcEntra21;Persist Security Info=True;User ID=adm;Password=13062005x#");
            //SqlConnection conn = new SqlConnection("Data Source = BUE205D94; Initial Catalog = DBTurmaManha; User ID = guest01; Password = @Senac2021");
            SqlCommand cmd;
            while (true)
            {
                Console.WriteLine("    ***MENU***\n1 - Adicionar\n2 - Remover\n3 - Atualizar\n4 - Mostrar\n5 - Encerrar\n");
                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine("\nQual o nome?");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Qual o preço?");
                    int preco = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a Quantidade em estoque?");
                    int qtd = int.Parse(Console.ReadLine());

                    string insert = $"INSERT into dbo.Produto (Nome,Preco,QtdEstoque) values ('{nome}','{preco}','{qtd}')";
                    cmd = new SqlCommand(insert, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (escolha == 2)
                {
                    string select = "SELECT Nome from dbo.Produto";
                    cmd = new SqlCommand(select, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Console.WriteLine("\nLista de Produtos\n-------------------");
                    while (dr.Read())
                    {
                        Console.WriteLine("-- " + dr[0] + "\n");
                    }
                    dr.Close();
                    conn.Close();

                    Console.Write("-------------------\nQual produto deseja excluir?\n");
                    string produtoParaExcluir = Console.ReadLine();
                   
                    string delete = $"DELETE from dbo.Produto WHERE Nome = '{produtoParaExcluir}'";
                    cmd = new SqlCommand(delete, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("\nID  Nome    Preço    QtdEstoque");
                    Console.WriteLine("--------------------------------");
                    string select = "SELECT * from dbo.Produto";
                    cmd = new SqlCommand(select, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + "  " + dr[1] + "     " + dr[2] + "          " + dr[3]);
                        Console.WriteLine("--------------------------------");
                    }
                    dr.Close();
                    conn.Close();
                    Console.WriteLine("\nQual produto deseja atualizar?");
                    string produto = Console.ReadLine();
                    Console.WriteLine("\nInsira os datos do novo produto:");
                    Console.Write("\nNome      : ");
                    string nome = Console.ReadLine();
                    Console.Write("\nPreço     : ");
                    int preco = int.Parse(Console.ReadLine());
                    Console.Write("\nQtdEstoque: ");
                    int qtd = int.Parse(Console.ReadLine());

                    string update = $"UPDATE dbo.Produto set Nome = '{nome}',Preco = {preco},QtdEstoque = {qtd} WHERE Nome = '{produto}'";
                    cmd = new SqlCommand(update, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                else if (escolha == 4)
                {
                    Console.WriteLine("\nID  Nome    Preço    QtdEstoque");
                    Console.WriteLine("--------------------------------");
                    string select = $"SELECT * from dbo.Produto";
                    cmd = new SqlCommand(select, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr[0] + "  " + dr[1] + "     " + dr[2] + "          " + dr[3]);
                        Console.WriteLine("--------------------------------");
                    }
                    dr.Close();
                    conn.Close();
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    break; 
                }
                Console.Clear();
            }
        }
    }
}
