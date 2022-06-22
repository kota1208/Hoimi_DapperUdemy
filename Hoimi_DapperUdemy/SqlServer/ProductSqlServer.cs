using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoimi_DapperUdemy.SqlServer
{
    public static class ProductSqlServer
    {
        private static string _connectionString;
        //static なコンストラクタ
        static ProductSqlServer()
        {
            //dbに接続するための接続文字列を作成する
            //MSが簡単に作成できるように用意してくれいる
            var builder = new SqlConnectionStringBuilder();
            //PCの名前
            builder.DataSource = "DESKTOP-49CIQAK";
            //データベース名
            builder.InitialCatalog = "Hoimi";
            //windows認証だとtrue,sqlserver認証だとfalse
            builder.IntegratedSecurity = true;
            //接続文字列の生成
            _connectionString = builder.ToString();


        }

        public static DataTable GetDataTable()
        {

            //DataTable
            var sql = @"select *from product;";


            DataTable dataTable = new DataTable();
            //dbと接続する
            using (var connection = new SqlConnection(_connectionString))
            //adapterがsqlを実行して、結果を返す
            using (var adapter = new SqlDataAdapter(sql, connection))
            {
                //usingはDBの接続の後始末を自動で行ってくれる


                //接続を開く
                connection.Open();

                //sqlを実行して、dataTableに値を入れる
                adapter.Fill(dataTable);

            }
            return dataTable;

        }

        public static ArrayList GetDataReader()
        {
            //DataTable
            var sql = @"select *from product;";

            //戻り値用のListを生成
            var result = new ArrayList();

            //dbと接続する
            using (var connection = new SqlConnection(_connectionString))
            using (var Command = new SqlCommand(sql, connection))
            {

                //接続を開く
                connection.Open();
                //sqlを実行し、１行ずつ答えを返す
                using (var reader = Command.ExecuteReader())
                {
                    //次の行に進む
                    //DataRederは１行ずつ取得していく
                    while(reader.Read())
                    {
                        //dbと、c#がわのデータ型、ビット数を合わせる必要がある
                        //Object型でもどってくるので、変換する
                        int productId = Convert.ToInt32(reader["Productid"]);
                        int productPrice = Convert.ToInt32(reader["productPrice"]);
                        string productName = Convert.ToString(reader["productName"]);

                        //Entity の作成
                        ProductEntity entity = new ProductEntity(productId, productName, productPrice);
                       
                        result.Add(entity);


                    }
                }

            }
            return result;
        }

        public static void insert(ProductEntity product)
        {

            string sql = @"insert into product(productName,ProductPrice)values(@productName,@price);";

            //dbと接続する
            using (var connection = new SqlConnection(_connectionString))
            using(var command = new SqlCommand(sql, connection))
            {

                //接続を開く
                connection.Open();
                //値をセットしていく
                command.Parameters.AddWithValue("@productName", product.ProductName);
                command.Parameters.AddWithValue("@price", product.ProductPrice);
                //sql 実行
                //実行件数が結果として戻ってくる。
                command.ExecuteNonQuery();

            }
        }

        public static List<ProductEntity> GetDapperRead()
        {
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            //DataTable
            var sql = @"select *from product";


            //dbと接続する
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<ProductEntity>(sql).ToList();
               
            }
            
        }

        public static void DapperInsert(ProductEntity product)
        {
            string sql = @"insert into product(ProductName,productPrice)values(@ProductName,@ProductPrice);";

            
            
            //dbと接続する
            using (var connection = new SqlConnection(_connectionString))
            {
                

                connection.Execute(sql, new
                {
                    ProductName=product.ProductName,
                    ProductPrice=product.ProductPrice,
                });

            }
        }
    }
}
