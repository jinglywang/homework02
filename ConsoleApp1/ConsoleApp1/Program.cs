using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			var users = new List<Models.User>();

			users.Add(new Models.User { Name = "Dave", Password = "hello" });
			users.Add(new Models.User { Name = "Steve", Password = "steve" });
			users.Add(new Models.User { Name = "Lisa", Password = "hello" });

			Console.WriteLine("All users:");
			users.ForEach(user => Console.WriteLine("Name: {0}, Password: {1}", user.Name, user.Password));

			Console.WriteLine("\nUsers with password as 'hello':");
			users.Where(user => user.Password == "hello").ToList().ForEach(user => Console.WriteLine("Name: {0}, Password: {1}", user.Name, user.Password));

			users.RemoveAll(user => user.Name.ToLower() == user.Password);

			Console.WriteLine("\nUsers whose password is not the lowercase of the name:");
			users.ForEach(user => Console.WriteLine("Name: {0}, Password: {1}", user.Name, user.Password));

			Models.User firstHelloUser = users.First(user => user.Password == "hello");
			users.Remove(firstHelloUser);

			Console.WriteLine("\nThe remaining users:");
			users.ForEach(user => Console.WriteLine("Name: {0}, Password: {1}", user.Name, user.Password));

			Console.ReadKey();
		}
	}
}
