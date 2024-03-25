namespace _2._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(", ");

            string title = inputData[0];
            string content = inputData[1];
            string author = inputData[2];

            Articles article = new Articles(title, content, author);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandInfo = Console.ReadLine().Split(": ");

                string command = commandInfo[0];
                string data = commandInfo[1];

                if (command == "Edit")
                {
                    article.Edit(data);
                }

                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(data);
                }

                else if (command == "Rename")
                {
                    article.Rename(data);
                }
            }

            Console.WriteLine(article);
        }
    }

    public class Articles
    {
        public Articles(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
