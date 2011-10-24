using System;
using System.Collections.Generic;
using System.Data.Entity;
using IAmOpen.Model.Concrete;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Initialization
{
    public class InstitutionInitializer : DropCreateDatabaseIfModelChanges<InstitutionContext>
    {
        protected override void Seed(InstitutionContext context)
        {
            var extAccounts = new List<ExternalAccount>
                                  {
                                      new ExternalAccount() {Name="Facebook", ExternalAccountID=1},
                                      new ExternalAccount() {Name="Vkontakte", ExternalAccountID=2}
                                  };
            extAccounts.ForEach(s => context.ExternalAccounts.Add(s));
            context.SaveChanges();

            var users = new List<User>
                            {
                                new User { Nickname = "Harry", FirstLoginDLC = DateTime.Now },
                                new User { Nickname = "Harry2", FirstLoginDLC = DateTime.Now }
                            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var statuses = new List<Status>
                              {
                                  new Status { Name="OK"},
                                  new Status { Name="NotOK"}
                              };

            statuses.ForEach(s => context.Statuses.Add(s));
            context.SaveChanges();

            var states = new List<State>
                              {
                                  new State { Name="State1"},
                                  new State { Name="State2"}
                              };

            states.ForEach(st => context.States.Add(st));
            context.SaveChanges();

            var institutions = new List<Institution>
                                   {
                                       new Institution { CreatedDLC = DateTime.Now, CoordinatesX = 5.5, CoordinatesY = 7.9, UserID = 1, IconPath = "somePath", StatusID=1, StateID=1},
                                       new Institution { CreatedDLC = DateTime.Now, CoordinatesX = 5.9, CoordinatesY = 7.3, UserID = 2, IconPath = "somePath", StatusID=2, StateID=2}
                                   };

            institutions.ForEach(s => context.Institutions.Add(s));
            context.SaveChanges();

            var instTypes = new List<InstitutionType>
                                   {
                                       new InstitutionType { IconPath="somePath", Name="Cafe"},
                                       new InstitutionType { IconPath="somePath", Name="PubB"}
                                   };

            instTypes.ForEach(it => context.Types.Add(it));
            context.SaveChanges();

            var chains = new List<Chain>
                             {
                                 new Chain {IconPath = "path",Name = "Silpo", StatusID=1},
                                 new Chain {IconPath = "path2", Name = "Arsen", StatusID=2}
                             };
            chains.ForEach(s => context.Chains.Add(s));
            context.SaveChanges();

            var reviews = new List<Review>
                              {
                                  new Review { UserID = 1,DateOfReport = DateTime.Now, InstitutionID = 1,Text = "blabla"},
                                  new Review { UserID = 1,DateOfReport = DateTime.Now, InstitutionID = 2,Text = "blabla"},
                                  new Review { UserID = 2,DateOfReport = DateTime.Now, InstitutionID = 1,Text = "blabla"},
                                  new Review { UserID = 2,DateOfReport = DateTime.Now, InstitutionID = 2,Text = "blabla"}
                              };

            reviews.ForEach(r => context.Reviews.Add(r));
            context.SaveChanges();

            var userAccounts = new List<UserExternalAccountToken>
                             {
                                 new UserExternalAccountToken { UserID=1,ExternalAccountID=1,SecurityToken=888},
                                 new UserExternalAccountToken { UserID=1,ExternalAccountID=2,SecurityToken=999}
                             };
            userAccounts.ForEach(ua => context.ExternalAccountTokens.Add(ua));
            context.SaveChanges();

            base.Seed(context);

        }

    }
}
