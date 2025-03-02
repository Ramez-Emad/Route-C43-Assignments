using EF_01.Data;
using EF_01.Data.Models;

namespace EF_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using ITIDbContext dbContext = new ITIDbContext();

                // Insert new records safely
                var topic01 = new Topic()
                { 
                    Name = "Entity Framework"
                };

                var topic02 = new Topic()
                {
                    Name = "LINQ"
                };

                dbContext.Add(topic01);
                dbContext.Add(topic02);
                dbContext.SaveChanges();
                Console.WriteLine("Topics inserted successfully.");

                //---------------------
                // Select a record safely

                var topic = dbContext.Topic.FirstOrDefault(t => t.Id == 1);
                if (topic != null)
                {
                    Console.WriteLine($"Selected Topic: {topic.Name}");
                }
                else
                {
                    Console.WriteLine("Topic with ID 1 not found.");
                }

                //-------------------
                // Update a record safely

                var currTopic = dbContext.Topic.FirstOrDefault(t => t.Id == 1);
                if (currTopic != null)
                {
                    currTopic.Name = "Entity Framework Core";
                    dbContext.SaveChanges();
                    Console.WriteLine("Topic updated successfully.");
                }
                else
                {
                    Console.WriteLine("Topic with ID 1 not found for update.");
                }

                //-------------------
                // Delete a record safely

                var delTopic = dbContext.Topic.FirstOrDefault(t => t.Id == 2);
                if (delTopic != null)
                {
                    dbContext.Remove(delTopic);
                    dbContext.SaveChanges();
                    Console.WriteLine("Topic deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Topic with ID 2 not found for deletion.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
