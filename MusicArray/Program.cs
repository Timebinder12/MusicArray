using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Rock,
            Country,
            Alternative,
            Rap,
            Metal
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int songSize = int.Parse(Console.ReadLine());
            Music[] collection = new Music[songSize];

            try
            {
                for (int i = 0; i < songSize; i++)
                {
                    Console.WriteLine("Please enter the song title.");
                    collection[i].setTitle(Console.ReadLine());

                    Console.WriteLine("Please enter the song artist.");
                    collection[i].setArtist(Console.ReadLine());

                    Console.WriteLine("Please enter the name of the album.");
                    collection[i].setAlbum(Console.ReadLine());

                    Console.WriteLine("Please enter the song length.");
                    collection[i].setLength(Console.ReadLine());

                    Console.WriteLine("Please input the genre of your song \nR - Rock \nC - Country \nA - Alternative \nP - Rap \nM - Metal");
                    collection[i].setGenre(Genre.Rock);
                    char z = char.Parse(Console.ReadLine());
                
                    switch (z)
                    {
                        case 'R':
                            collection[i].setGenre(Genre.Rock);
                            break;
                        case 'C':
                            collection[i].setGenre(Genre.Country);
                            break;
                        case 'A':
                            collection[i].setGenre(Genre.Alternative);
                            break;
                        case 'P':
                            collection[i].setGenre(Genre.Rap);
                            break;
                        case 'M':
                            collection[i].setGenre(Genre.Metal);
                            break;
                    }
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for(int i = 0; i < collection.Length; i++)
                {
                    Console.WriteLine(collection[i].Display());
                }
            }
        }
    }
}
