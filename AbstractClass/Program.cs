using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek ornek = new Calisma(); //EN SON BAKILACAK YER!! Aşağıyı incelersek, Calisma class'ı Ornek'ten miras alıyor. Dolayısıyla her Ornek bir Calisma'dır. Burada Ornek referansında Calisma nesnesi tuttuk. Çünkü hiyerarşi var. Polimorphyzm! Abstract referans noktası üzerinden abstractın drived classlarından(Ornek'ten kalıtım alan-Ornek'in miras verdikleri) herhangibi birisinin nesnesi üzerinden calismamizi yapabiliyoruz.
            ornek.MyProperty = 89;
            ornek.y(); //Y'nin gövdesi Calisma'da old.dan dolayı Calisma nesnesi üzerinden çalışacaktır. MyProperty'de aynı şekilde.
        }
    }

    //abstract class Myclass //Bu sınıf içerisinde abstarct olarak işaretlenen metot veya propertyler bu sınıftan kalıtım alan her sınıfta yazılmak veya uygulanmak veya implement edilmek zorundadır
    //    //abstract sınıf içerisinde abstract olmayan metotlar da vardır. Abstract olanlar tanımlandıkları abstract class içinde sadece imzalarıyla yazılır, gövdeleriyle yazılmaz. Gövdeleri kalıtım alan sınıfta override edilerek yazılır. Private olamazlar.
    //    //İçinde herhangi bir abstract yapı olan sınıfın kendisi de abstract class olması gerekmekte.
    //    //abstract classlardan nesne yaratılamaz. referans noktası alınabilir. Sebebi ilk satır.
    //{
    //    public void x()
    //    {

    //    }
    //    public abstract void y();

    //    abstract public int MyProperty { get; set; }
    //}

    abstract class Ornek
    { 
    public void x()
    {

    }
    public abstract void y();

    abstract public int MyProperty { get; set; }
}


    class Calisma : Ornek   
    {
      
        public override void y()
        {
            Console.WriteLine("ali");
        }

        public override int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
       
}

