using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July
{
   
        public class PhotoAlbum
        {
            private int numberOfPages;

            public PhotoAlbum()
            {
                numberOfPages = 16;
            }

            public PhotoAlbum(int pages)
            {
                numberOfPages = pages;
            }

            public int GetNumberOfPages() { return numberOfPages; }
        }

        public class BigPhotoAlbum
        {
            private int numberOfPages;

            public BigPhotoAlbum()
            {
                numberOfPages = 64;
            }

            public int GetNumberOfPages() { return numberOfPages; }
        }

        //class AlbumTest
        //{
        //    static void Main(string[] args)
        //    {
        //        PhotoAlbum album1 = new PhotoAlbum();
        //        PhotoAlbum album2 = new PhotoAlbum(24);
        //        BigPhotoAlbum album3 = new BigPhotoAlbum();

        //        Console.WriteLine("The Photo Album 1 has {0} pages", album1.GetNumberOfPages());
        //        Console.WriteLine("The Photo Album 2 has {0} pages", album2.GetNumberOfPages());
        //        Console.WriteLine("The Photo Album 3 has {0} pages", album3.GetNumberOfPages());
        //        Console.ReadLine();
        //    }
        //}
    }
/*
 output
 The Photo Album 1 has 16 pages
 The Photo Album 1 has 24 pages
 The Photo Album 1 has 64 pages
     */
