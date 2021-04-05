using System;
using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using SocialReader.objects;

namespace SocialReader.dao
{
    public class AccountDao
    {
        /*
         * Returns id of inserted account.
         * Returns -1 if failed.
         */
        public int Create(Account account)
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Account
                            where a.Id == account.Id
                            select a;

                if (query.Any()) return -1;
                db.Insert(account);
                // Apply Id on account object.
                var lastId = (from a in db.Account orderby a.Id select a.Id).Max();

                account.Id = lastId;
                return lastId;
            }

        }

        // Nullable
        public Account GetById(int id)
        {
            using (var db = new DbSocialReader())
            {
                /*var query = from a in db.Account
                        where a.Id == id
                        select new
                        {
                            Account = a,
                            Users = a.Users.Where(user => user.AccountId == id)
                        };

                Console.WriteLine(query.First().Account);
                Console.WriteLine(query.First().Users);
                Console.WriteLine(query.ToArray());
                var account = query.First().Account;
                foreach (var arr in query.ToArray())
                {
                    account.Users.AddRange(arr.Users);
                }
                //account.Users.AddRange(query.First().Users);

                *//*var query = from a in db.Account
                            where a.Id == id
                            select a;

                return query.FirstOrDefault();*//*
                return account;*/

                var query = from a in db.Account
                            join user in db.User
                            on a.Id equals user.AccountId
                            where a.Id == id
                            select new { a, user };

                /*Console.WriteLine(query.First().a);
                Console.WriteLine(query.First().user);
                Console.WriteLine(query.ToArray());*/
                var account = query.First().a;
                foreach (var arr in query.ToArray())
                {
                    //Console.WriteLine("arr.user: " + arr.user);
                    account.Users.Add(arr.user);
                }
                //account.Users.AddRange(query.First().users);
                return account;
            }
        }

        // Nullable
        public Account GetByUsername(string username)
        {
            using (var db = new DbSocialReader())
            {
                /*var query = from a in db.Account
                            where a.Username == username
                            select a;

                return query.FirstOrDefault();*/

                //db.Account.LoadWith(a=>a.Users).Where(a.Users.Where(User ))
                var query = from a in db.Account
                            join user in db.User
                            on a.Id equals user.AccountId
                            where a.Username == username
                            select new { a, user };

                /*Console.WriteLine(query.First().a);
                Console.WriteLine(query.First().user);
                Console.WriteLine(query.ToArray());*/
                if (query.Count() == 0) return null;
                var account = query.First().a;
                foreach (var arr in query.ToArray())
                {
                    //Console.WriteLine("arr.user: " + arr.user);
                    account.Users.Add(arr.user);
                }
                //account.Users.AddRange(query.First().users);
                return account;
            }
        }

        // Nullable
        public Account GetByEmail(string email)
        {
            using (var db = new DbSocialReader())
            {
                /*var query = from a in db.Account
                            where a.Email == email
                            select a;

                return query.FirstOrDefault();*/

                /*var query = from a in db.Account
                            where a.Email == email
                            select new
                            {
                                Account = a,
                                Users = a.Users.FindAll(user => user.AccountId == a.Id)
                            };

                var account = query.First().Account;
                foreach (var arr in query.ToArray())
                {
                    account.Users.AddRange(arr.Users);
                }
                //account.Users.AddRange(query.First().Users);
                return account;*/

                var query = from a in db.Account
                            join user in db.User
                            on a.Id equals user.AccountId
                            where a.Email == email
                            select new { a, user };

                /*Console.WriteLine(query.First().a);
                Console.WriteLine(query.First().user);
                Console.WriteLine(query.ToArray());*/
                if (query.Count() == 0) return null;
                var account = query.First().a;
                foreach (var arr in query.ToArray())
                {
                    //Console.WriteLine("arr.user: " + arr.user);
                    account.Users.Add(arr.user);
                }
                //account.Users.AddRange(query.First().users);
                return account;
            }
        }

        public void Update(Account account)
        {
            using (var db = new DbSocialReader())
            {
                db.Update(account);
            }
        }

        public void Delete(Account account)
        {
            using (var db = new DbSocialReader())
            {
                db.Delete(account);
            }
        }

        public List<Account> All()
        {
            using (var db = new DbSocialReader())
            {
                var query = from a in db.Account select a;
                return query.ToList();
            }
        }
    }
}