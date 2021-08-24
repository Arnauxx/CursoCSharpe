using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioStringBuilder.Entities
{
    class Post
    {
        //Variables
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } =  new List<Comment>();

        //Constructors
        public Post()
        {

        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            //StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes); 
            sb.Append(" Likes - "); 
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment comments in Comments)
            {
                sb.AppendLine(comments.Text);
            }
            return sb.ToString();

        }





    }






}
