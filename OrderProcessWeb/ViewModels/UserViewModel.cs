﻿namespace OrderProcessWeb.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public int RoleId { get; set; }
    }
}