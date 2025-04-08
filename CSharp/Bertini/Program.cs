using Bertini.ContentContext;
using Bertini.SubscriptionContext;

namespace Bertini;

class Program
{
    static void Main(string[] args)
    {
        var articles = new List<Article>();
        articles.Add(new Article("Article about OOP", "Object Orientation"));
        articles.Add(new Article("Article about C#", "C# Programming Language"));
        articles.Add(new Article("Article about .NET", ".NET Framework"));

        // foreach(var article in articles){
        //     Console.WriteLine(Article.Id);
        //     Console.WriteLine(Article.Title);
        //     Console.WriteLine(Article.Url);
        // }

        var courses = new List<Course>();
        var courseOOP = new Course("OOP Fudamentals", "oop-fundamentals");
        var courseCSharp = new Course("C# Fundamentals", "csharp-fundamentals");
        var courseAspNet = new Course("ASP.NET Core Fundamentals", "aspnet-core-fundamentals");

        courses.Add(courseOOP);
        courses.Add(courseCSharp);
        courses.Add(courseAspNet);

              var careers = new List<Career>();
        var careerDotnet = new Career("DotNet Especialist", "dotnet-specialist");
        var careerItem = new CareerItem(1,"Start here","",courseCSharp);
        var careerItem3 = new CareerItem(3,"Start here","",courseAspNet);
        var careerItem2 = new CareerItem(2,"Learn OOP","",courseOOP);
        careerDotnet.Items.Add(careerItem);
        careers.Add(careerDotnet);

        foreach(var career in careers){
            Console.WriteLine(career.Id);
            Console.WriteLine(career.Title);
            Console.WriteLine(career.Url);
            foreach(var item in career.Items.OrderBy(x => x.Order)){
                Console.WriteLine($"{item.Order} - {item.Title}");
                Console.WriteLine(item.Course?.Title);

                foreach (var notification in item.Notifications)
                {
                    Console.WriteLine($"Property: {notification.Property} - Message: {notification.Message}");
                }
            }
        }

        var PayPalSubscription = new PayPalSubscription();
        var student = new Student();
        student.Subscriptions.Add(PayPalSubscription);
    }
}
