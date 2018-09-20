using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionInitializer<Student> initializer = new CollectionInitializer<Student>(2);

            initializer.AddElementsToCollection(new Student { Name="John", Age=25 }, new Student { Name="Jane", Age=24 });
            Student[] collection = initializer.RetrieveAllElements();
            Student student = initializer.RetreiveElementOnIndex(1);

            foreach (Student element in collection)
            {
                Console.WriteLine(element.Name + " " + element.Age);
            }

            Console.WriteLine();
            Console.WriteLine($"Element on the selected index is: {student.Name}");

            Console.ReadKey();
        }
    }
}
