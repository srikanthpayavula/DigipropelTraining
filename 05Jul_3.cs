using System;

namespace _5Jul_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Photobook album=new Photobook();
            Console.WriteLine(album.GetNumpages());
            
            Photobook bigalbum=new Photobook(24);
            Console.WriteLine(bigalbum.GetNumpages());
            
            SuperPhotoBook superalbum=new SuperPhotoBook();
            Console.WriteLine(superalbum.GetNumpages());
            Console.Read();
        }
    }
    public class Photobook{
        protected int numPages;
        public Photobook(){
            numPages=16;
        }
        public Photobook(int num){
            this.numPages=num;
        }
        public int GetNumpages(){
            return numPages;
        }
    }
    public class SuperPhotoBook:Photobook{
        public SuperPhotoBook(){
            numPages=64;
        }
    }

}
/*output
16 
24
64
*/