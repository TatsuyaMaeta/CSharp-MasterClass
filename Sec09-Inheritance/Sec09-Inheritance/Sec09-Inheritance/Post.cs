using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sec09_Inheritance
{
    public class Post
    {

        private static int currentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool Ispublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            Ispublic = true;
            SendByUsername = "Denis";
        }

        public Post(string title,bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.Ispublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title,bool isPublic)
        {
            this.Title = title;
            this.Ispublic = isPublic;

        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername); 
        }

    }
}
