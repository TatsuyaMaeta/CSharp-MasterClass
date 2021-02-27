using System;
namespace Sec09_Inheritance
{
    class ImagePost:Post
    {
        public string ImageURL{ get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            //以下のプロパティとgetNextIDメソッドはPostから継承されています。
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.Ispublic = isPublic;

            //ここから下のImageUrlはImagePostのメンバだが、Postに存在するメンバではない(ImagePost固有)
            this.ImageURL = imageURL;

        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} by {3}", this.ID, this.Title, this.SendByUsername,this.ImageURL);
        }

    }
}
