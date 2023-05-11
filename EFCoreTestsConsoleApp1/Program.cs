using EFCoreTestsConsoleApp1;
using Microsoft.EntityFrameworkCore;

// update-database -context SchoolContextNT

var id = new Guid("0eb69c8e-538e-4b4f-a878-08db5190935d");

// Add one-to-one tracking // WORKING
//using (var context = new SchoolContext())
//{

//    var std = new Person()
//    {
//        Info = new Info
//        {
//            First = "A",
//            Last = "B",
//        }
//    };

//    context.Persons.Add(std);
//    context.SaveChanges();
//}

// Add one-to-one NO TRACKING // WORKING
//using (var context = new SchoolContextNT())
//{
//    var std = new Person()
//    {
//        Info = new Info
//        {
//            First = "A " + DateTime.Now,
//            Last = "B " + DateTime.Now,
//        }
//    };

//    context.Persons.Add(std);
//    context.SaveChanges();
//}

// Add many-to-one NO TRACKING // WORKING!!!
//using (var context = new SchoolContextNT())
//{
//	var account = new Account
//	{
//		Name = "This is test account!"
//	};

//	var person = new Person();
//	person.Accounts.Add(account);

//	context.Persons.Add(person);
//	context.SaveChanges();
//}

// Update one-to-one // WORKING
//using (var context = new SchoolContext())
//{
//    var p = context.Persons.Include(x => x.Info).FirstOrDefault(x => x.Id == new Guid("0eb69c8e-538e-4b4f-a878-08db5190935d"));
//    p.Info.First = "FIRST";
//    p.Info.Last = "LAST";
//    context.Persons.Update(p);
//    context.SaveChanges();
//}

// Update one-to-one NO TRACKING // NOT WORKING
//using (var context = new SchoolContextNT())
//{
//    var p = context.Persons.Include(x => x.Info).FirstOrDefault(x => x.Id == new Guid("0eb69c8e-538e-4b4f-a878-08db5190935d"));
//    p.Info.First = "FIRST";
//    p.Info.Last = "LAST";
//    context.Persons.Update(p);
//    context.SaveChanges();
//}

// Update many-to-one // WORKING
//using (var context = new SchoolContext())
//{
//    var p = context.Persons.FirstOrDefault(x => x.Id == new Guid("0eb69c8e-538e-4b4f-a878-08db5190935d"));
//    var acc = new Account
//    {
//        Name = "Account " + new Random().NextInt64(),
//    };
//    p.Accounts.Add(acc);
//    context.SaveChanges();
//}

// Update many-to-one NO TRACKING // NOT WORKING
//using (var context = new SchoolContextNT())
//{
//    var p = context.Persons.FirstOrDefault(x => x.Id == new Guid("0eb69c8e-538e-4b4f-a878-08db5190935d"));
//    var acc = new Account
//    {
//        Name = "Account " + new Random().NextInt64() + " 1",
//    };
//    p.Accounts.Add(acc);
//    context.Persons.Update(p);
//    context.SaveChanges();
//}

// WORKING!!!

// Update one-to-one NO TRACKING
//using (var context = new SchoolContextNT())
//{
//    var p = context.Persons.Include(x => x.Info).FirstOrDefault(x => x.Id == new Guid("0eb69c8e-538e-4b4f-a878-08db5190935d"));
//    p.Info.First = "FIRST 222";
//    p.Info.Last = "LAST 222";
//    context.Infos.Update(p.Info);
//    context.SaveChanges();
//}

// Add many-to-one NO TRACKING
//using (var context = new SchoolContextNT())
//{
//    var p = context.Persons.FirstOrDefault(x => x.Id == id);
//    var acc = new Account
//    {
//        Name = "Account " + new Random().NextInt64() + " 5",
//        Person = p
//    };
//    context.Accounts.Add(acc);
//    context.SaveChanges();
//}

// Add one-to-one NO TRACKING
//using (var context = new SchoolContextNT())
//{
//    var info = context.Infos.FirstOrDefault(x => x.PersonId == id);
//    info.First = "FIRST 3";
//    info.Last = "LAST 3";
//    context.Infos.Update(info);
//    context.SaveChanges();
//}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
