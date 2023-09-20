using System;

namespace Matematikkk
{
    class Program
    {
        static void Main(string[] args) 
        {
            DortIslem dortIslem = new DortIslem(); //benim toplama işlemini yapan metodum var ,bu metot DortIslem classında olduğu için bu classtan bir örnek oluşturmam lazım..
            dortIslem.Topla(5, 6);
            dortIslem.Topla(8, 9);
                                                   
        }
    }
}