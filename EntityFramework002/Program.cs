using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new VidzyEntities1();
            video.AddVideo("Video1", null, "Drama");
            video.AddVideo("Video2", null, "Comedy");
            video.AddVideo("Video3", null, "Action");
        }
    }
}
