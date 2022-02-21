
using ConsoleApp1;
{
}

using (ApplicationContext db = new ApplicationContext())
{
    swi _swi = new swi();

    // создаем два объекта User
    Personal user1 = new Personal { NamePersonal = "Tom" };
    Personal user2 = new Personal { NamePersonal = "Alice" };
    Book Book1 = new Book { NameBook = "Harry Potter" };
    Book Book2 = new Book { NameBook = "Tolsotoy" };


    // добавляем их в бд
    db.personal.AddRange(user1, user2);
    db.book.AddRange(Book1, Book2);
    //db.arenda.AddRange(, );
    db.SaveChanges();

    //  получаем объекты из бд и выводим на консоль
    var users = db.personal;
    Console.WriteLine("Users list:");
    foreach (Personal u in users)
    {
        Console.WriteLine($"{u.Id}.{u.NamePersonal}");
    }
    var knigi = db.book;
    Console.WriteLine("Book list:");
    foreach (Book b in knigi)
    {
        Console.WriteLine($"{b.Id}.{b.NameBook}");
    }
    var aren = db.arenda;
    Console.WriteLine("Arenda list:");
    foreach (Arenda a in aren)
    {
        Console.WriteLine($"{a.NamePersonal}");
    }
    Console.WriteLine("Арендовать книгу? Введите 1(da)/2(net)");

    //int vib;
    //vib = int.Parse(Console.ReadLine());

    //if (vib == 1)
    //{
       Console.WriteLine("Введите id пользователя:");
   int vibp;
      vibp = int.Parse(Console.ReadLine());
      Console.WriteLine("Введите id книги:");
       int vibb;
      vibb = int.Parse(Console.ReadLine());
    //    if (vibp == 1 & vibb == 1)
    //    {
    //        Arenda us1 = new Arenda { NamePersonal = "Tom", NameBook = "Harry Potter" };
    //        db.arenda.AddRange(us1);

    //    }
    //    else if (vibp == 1 & vibb == 2)
    //    {
    //        Arenda us2 = new Arenda { NamePersonal = "Tom", NameBook = "Tolstoy" };
    //        db.arenda.AddRange(us2);

    //    }
    //    else if (vibp == 2 & vibb == 1)
    //    {
    //        Arenda us2 = new Arenda { NamePersonal = "Alice", NameBook = "Harry Potter" };
    //        db.arenda.AddRange(us2);

    //    }
    //    else if (vibp == 2 & vibb == 2)
    //    {
    //        Arenda us2 = new Arenda { NamePersonal = "Alice", NameBook = "Tolstoy" };
    //        db.arenda.AddRange(us2);

    //    }
    //    else
    //    {
    //        Console.WriteLine("такого нет");
    //    }
    //////////////
    ///
   // var consoleAnswer = int.Parse(Console.ReadLine());
    //switch (consoleAnswer)
    //{
    //    case 1:
    //        {

    //            Console.WriteLine("введите имя пользователя");
    //            string nameUser = Console.ReadLine();

    //            Console.WriteLine("введите имя книги");
    //            string nameBook = Console.ReadLine();

    //            Arenda arenda = new Arenda { NamePersonal = nameUser, NameBook = nameBook };
    //            db.arenda.Add(arenda);
    //            break;
    //        }
    //    case 2:
    //        {

    //            break;
    //        }
    //}
    Arenda arenda = new Arenda() { NamePersonal = _swi.ConstrucrorName(vibp), NameBook = _swi.ConstrucrorBook(vibb) };
    db.arenda.Add(arenda);
   

    

    ///////////////////





    db.SaveChanges();
        Console.WriteLine("Arenda list:");
        foreach (Arenda a in aren)
        {
            Console.WriteLine($"{a.NamePersonal}. {a.NameBook}");
        }

    //}
}


    

