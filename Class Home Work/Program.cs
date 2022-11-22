

using Class_Home_Work;
using System.Xml;

Console.WriteLine("UserName daxil edin :");

string UserName = Console.ReadLine();

Console.WriteLine("Password daxil edin :");

string Password = Console.ReadLine();

Console.WriteLine("Ugurla daxil oldunuz :");

user user = new user(UserName, Password );

admin admin = new admin(true, "blog section");

Console.WriteLine("IsSuperAdmin:" + admin.IsSuperAdmin);

Console.WriteLine("Section :" + admin.Section);

Console.WriteLine("Adminin butun datalari :" + admin.Return());
