namespace RepositoryLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using DomainLayer.Models.Department;   

    internal sealed class Configuration : DbMigrationsConfiguration<RepositoryLayer.Persistence.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepositoryLayer.Persistence.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            #region Add Departments

            var departments = new List<DepartmentModel>()
            {
                new DepartmentModel()
                {
                    CityLocation = "Craiova",
                    Email = "finance@yahoo.com",
                    ID = 1,
                    Name = "Finance",
                    PhoneNumber = "123-444-5551",
                    StateLocation = "DOLJ",
                    Url = "https://en.wikipedia.org/wiki/Mihai_Tr%C4%83istariu"
                },

                new DepartmentModel()
                {
                    CityLocation = "Craiova",
                    Email = "construction@yahoo.com",
                    ID = 2,
                    Name = "Constuction",
                    PhoneNumber = "123-444-5552",
                    StateLocation = "DOLJ",
                    Url = "https://ro.wikipedia.org/wiki/Florin_Salam"
                },

                new DepartmentModel()
                {
                    CityLocation = "Craiova",
                    Email = "accounting@yahoo.com",
                    ID = 3,
                    Name = "Accounting",
                    PhoneNumber = "123-444-5553",
                    StateLocation = "DOLJ",
                    Url = "https://ro.wikipedia.org/wiki/Dan_Bursuc"
                },

                new DepartmentModel()
                {
                    CityLocation = "Craiova",
                    Email = "transportation@yahoo.com",
                    ID = 4,
                    Name = "Transportation",
                    PhoneNumber = "123-444-5554",
                    StateLocation = "DOLJ",
                    Url = "http://www.mihaipetre.ro/"
                },

                new DepartmentModel()
                {
                    CityLocation = "Craiova",
                    Email = "humanresources@yahoo.com",
                    ID = 5,
                    Name = "Human Resources",
                    PhoneNumber = "123-444-5555",
                    StateLocation = "DOLJ",
                    Url = "https://www.youtube.com/watch?v=dlZlBxgsr9M"
                },

                new DepartmentModel()
                {
                    CityLocation = "Craiova",
                    Email = "marketing@yahoo.com",
                    ID = 6,
                    Name = "Marketing",
                    PhoneNumber = "123-444-5556",
                    StateLocation = "DOLJ",
                    Url = "https://www.youtube.com/watch?v=2Bv3wjUUSc8"
                },

                new DepartmentModel()
                {
                    CityLocation = "Craiova",
                    Email = "sales@yahoo.com",
                    ID = 6,
                    Name = "Sales",
                    PhoneNumber = "123-444-5557",
                    StateLocation = "DOLJ",
                    Url = "https://www.youtube.com/watch?v=VGt-BZ-SxGI&t=436s"
                }
            };

            #endregion

            //context.Departments.RemoveRange(departments);
            //context.SaveChanges();
        }
    }
}
