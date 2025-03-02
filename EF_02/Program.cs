using EF_01.Data;
using EF_01.Data.Models;

namespace EF_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();

            // Insert a new record

            Topic topic01 = new Topic
            {
                Name = "Entity Framework"
            };

            Topic topic02 = new Topic
            {
                Name = "LINQ"
            };

            dbContext.Add(topic01);
            dbContext.Add(topic02);
            // State of the entity is Added

            dbContext.SaveChanges();


            //---------------------
            // Select a record

            Topic topic = dbContext.Topic.Find(1);
            Console.WriteLine(topic.Name);

            //-------------------

            // Update a record

            Topic Currtopic = dbContext.Topic.Find(1);
            Currtopic.Name = "Entity Framework Core";

            // State of the entity is Modified

            //-------------------

            // Delete a record

            Topic Deltopic = dbContext.Topic.Find(2);
            dbContext.Remove(Deltopic);

            dbContext.SaveChanges();



        }
    }
}
