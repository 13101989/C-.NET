namespace OOP1
{
    class Program
    {
        static void Main()
        {
            User gicu = new User("Gicu", 1997);
            var postGicu = SayHello(gicu);
            ShowPost(postGicu);

            Moderator ana = new Moderator("Ana", 2003);
            var postAna = SayHello(ana);
            ShowPost(postAna);

            Administrator paula = new Administrator("Paula", 1996);
            var postPaula = SayHello(paula);
            ShowPost(postPaula);

            var postModifedByAna = ClearPost(postGicu, ana);
            ShowPost(postGicu);
            ShowPost(postModifedByAna);

            var postModifiedByPaula = ClearPost(postAna, paula);
            ShowPost(postAna);
            ShowPost(postModifiedByPaula);
        }

        static Post ClearPost(Post postInstance, IModerator moderatorInstance)
        {
            return moderatorInstance.UpdatePost(postInstance, "erased content");
        }

        static void ShowPost(Post post)
        {
            Console.WriteLine(post.text);
        }

        static Post SayHello(User userInstance)
        {
            return userInstance.CreatePost($"My name is {userInstance.Name} and I'm {userInstance.Age} years old.");
        }
    }
}
