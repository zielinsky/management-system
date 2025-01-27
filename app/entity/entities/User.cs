﻿using management_system.app.entity;
using System;
using System.Data.SQLite;

namespace management_system
{
    public class User : Person, Entity
    {
        public string[] DatabaseColumnNames() => new string[] { "name", "surname", "tin" };
        public string[] DatabaseColumnValues() => new string[] { $"'{Name}'", $"'{Surname}'", $"'{Tin}'" };

        public User(string name, string surname, string tin)
        {
            Id = -1;
            Name = name;
            Tin = tin;
            Surname = surname;
        }
        public User(int id, string name, string surname, string tin)
        {
            Id = id;
            Name = name;
            Tin = tin;
            Surname = surname;
        }

        public override string ToString() => $"User:\tName: {Name}\tTin: {Tin}";

        public void AddToDatabase(Database db) => db.em.AddUser(this);
        public void UpdateDatabase(Database db) => db.em.UpdateUser(this);

    }
}