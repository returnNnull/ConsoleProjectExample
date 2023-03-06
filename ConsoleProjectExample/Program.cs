// See https://aka.ms/new-console-template for more information

using ConsoleProjectExample;

var roleList = new DataSource<Role>();
InitRole();

var usersList = new DataSource<User>();
InitUsers();

var employersList = new DataSource<Employer>();
InitEmployers();


var lists = new ListView<string>(new List<string>
{
    "Список пользователей",
    "Список ролей",
    "Информация о пользователях"
});


lists.Show();
var selected = int.Parse(Console.ReadLine());

ShowSelectedList(selected);


selected = int.Parse(Console.ReadLine());

void ShowSelectedList(int value)
{
    switch (value)
    {
        case 0:
            var list = new ListView<User>(usersList.GetAll());
            list.Header = "////////Пользователи////////////";
            list.Show();
            break;
        case 1 :
            var list2 = new ListView<Role>(roleList.GetAll());
            list2.Header = "////////Роли////////////";
            list2.Show();
            break;
        case 2 :
            var list3 = new ListView<Employer>(employersList.GetAll());
            list3.Header = "////////Информация о пользователях////////////";
            list3.Show();
            break;
    }
}

void InitEmployers()
{
    employersList.Add(new Employer()
    {
        Name = "Иванов Иван",
        Age = 25,
        BirthDay = new DateTime(1992,3,12),
        User = new User()
        {
            Login = "mail@mail.com",
            Password = "12345",
            Roles = new List<Role>()
            {
                new()
                {
                    Id = 0,
                    Value = "Admin"
                }
            }
        }
    });
}

void InitUsers()
{
   usersList.Add(new User()
   {
       Login = "mail@mail.com",
       Password = "12345",
       Roles = new List<Role>()
       {
           new()
           {
               Id = 0,
               Value = "Admin"
           }
       }
   });
}

void InitRole()
{
    roleList.Add(new Role()
    {
        Id = 0,
        Value = "Admin"
    });
    
    roleList.Add(new Role()
    {
        Id = 1,
        Value = "User"
    });
    
    roleList.Add(new Role()
    {
        Id = 2,
        Value = "Operator"
    });
}