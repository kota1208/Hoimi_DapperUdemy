using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoimi_DapperUdemy.SqlServer
{
       //sealedは継承できなくする修飾子
    public sealed class ProductEntity
    {

        //insert用のコンストラクタ
        public ProductEntity( string productName, int productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;

        }

        //ct tab*2 でコンストラクタを作成できる
        public ProductEntity(int productId,string productName,int productPrice)
        {
            ProductId= productId;
            ProductName= productName;
            ProductPrice= productPrice;

        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}
