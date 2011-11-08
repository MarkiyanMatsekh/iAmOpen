using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock
{
    public class MockData
    {
        static readonly Status statusOK = new Status() { ID = 1, Name = "OK" };
        static readonly Status statusNW = new Status() { ID = 2, Name = "NotWorking" };

        static readonly State state_1 = new State() { ID = 1, Name = "State1" };
        static readonly State state_2 = new State() { ID = 2, Name = "State2" };

        static readonly User user_1 = new User() { ID = 1, Nickname = "Nick_1", FirstLoginDLC = DateTime.Now, PrivacyOn = true };
        static readonly User user_2 = new User() { ID = 2, Nickname = "Nick_2", FirstLoginDLC = DateTime.Now, PrivacyOn = true };

        static readonly List<Institution> _institutions = new List<Institution>()
        {
            new Institution() { ID = 1, CoordinatesX = 1, CoordinatesY = 2, StateID = state_1.ID, StatusID = statusOK.ID, UserID = user_1.ID, IconPath = "somePath1", CreatedDLC = DateTime.Now, Rating = 5, Status = statusOK, State = state_1, CreatedByUser = user_1},
            new Institution() { ID = 2, CoordinatesX = 10, CoordinatesY = 21, StateID = state_1.ID, StatusID = statusOK.ID, UserID = user_2.ID, IconPath = "somePath2", CreatedDLC = DateTime.Now, Rating = 4, Status = statusNW, State = state_2, CreatedByUser = user_2},
            new Institution() { ID = 3, CoordinatesX = 11, CoordinatesY = 92, StateID = state_1.ID, StatusID = statusNW.ID, UserID = user_1.ID, IconPath = "somePath3", CreatedDLC = DateTime.Now, Rating = 3, Status = statusOK, State = state_1, CreatedByUser = user_1}
        };

        static readonly List<State> _states = new List<State>()
        {
            state_1,
            state_2
        };

        static readonly List<Chain> _chains = new List<Chain>()
        {
            new Chain(){ ID = 1, Name = "Silpo"}, 
            new Chain(){ ID = 2, Name = "Arsen"}, 
            new Chain(){ ID = 3, Name = "Local"}
        };

        static readonly List<Status> _statuses = new List<Status>()
        {
            statusOK,
            statusNW
        };

        static readonly List<User> _users = new List<User>()
        {
            user_1,
            user_2
        };

        static readonly List<Review> _reviews = new List<Review>()
                                                    {
                                                        new Review(){ID = 1, UserID = user_1.ID, Author = user_1, Text = "Review#1", InstitutionID = _institutions[0].ID, ReferredInstitution = _institutions[0], DateOfReport = DateTime.Now},
                                                        new Review(){ID = 2, UserID = user_2.ID, Author = user_2, Text = "Review#2", InstitutionID = _institutions[1].ID, ReferredInstitution = _institutions[1], DateOfReport = DateTime.Now},
                                                        new Review(){ID = 3, UserID = user_1.ID, Author = user_1, Text = "Review#3", InstitutionID = _institutions[2].ID, ReferredInstitution = _institutions[2], DateOfReport = DateTime.Now}
                                                    };  

        static readonly List<WorkTime> _workTimes = new List<WorkTime>()
                                                        {
                                                            new WorkTime(){ ID = 1, Date = new DateTime(2011,11,04), InstitutionID = _institutions[0].ID, Institution = _institutions[0], DayOfWeek = 1, OpeningTime = new TimeSpan(9,0,0), ClosingTime = new TimeSpan(18,0,0)},
                                                            new WorkTime(){ ID = 2, Date = new DateTime(2011,11,05), InstitutionID = _institutions[1].ID, Institution = _institutions[1], DayOfWeek = 2, OpeningTime = new TimeSpan(10,0,0), ClosingTime = new TimeSpan(17,0,0)},
                                                            new WorkTime(){ ID = 3, Date = new DateTime(2011,11,06), InstitutionID = _institutions[2].ID, Institution = _institutions[2], DayOfWeek = 3, OpeningTime = new TimeSpan(11,0,0), ClosingTime = new TimeSpan(15,0,0)}
                                                        }; 

        static readonly List<Role> _roles = new List<Role>()
                                                {
                                                    new Role(){ ID = 1, Name = "Administrator", Users = new Collection<User>()
                                                                                                            {
                                                                                                                user_1,
                                                                                                                user_2
                                                                                                            }},
                                                    new Role(){ID = 2, Name = "Guest", Users = null}
                                                }; 

        static readonly List<InstitutionType> _institutionTypes = new List<InstitutionType>()
                                                                      {
                                                                          new InstitutionType(){ID = 1, Name = "Cafe", IconPath = "IconPath1", Institutions = new Collection<Institution>()
                                                                                                                                                                  {
                                                                                                                                                                      _institutions[0],
                                                                                                                                                                      _institutions[2]
                                                                                                                                                                  }},
                                                                          new InstitutionType(){ID = 2, Name = "Pub", IconPath = "IconPath2", Institutions = new Collection<Institution>()
                                                                                                                                                                 {
                                                                                                                                                                     _institutions[1]
                                                                                                                                                                 }}
                                                                      }; 

        static readonly List<Vote> _votes = new List<Vote>()
                                                {
                                                    new Vote(){ID = 1, InstitutionID = _institutions[0].ID, Institution = _institutions[0], UserID = user_1.ID, Voter = user_1, Value = 3},
                                                    new Vote(){ID = 2, InstitutionID = _institutions[1].ID, Institution = _institutions[1], UserID = user_2.ID, Voter = user_2, Value = 4},
                                                    new Vote(){ID = 3, InstitutionID = _institutions[2].ID, Institution = _institutions[2], UserID = user_1.ID, Voter = user_1, Value = 5}
                                                }; 

        static readonly List<UserExternalAccountToken> _userExternalAccountTokens = new List<UserExternalAccountToken>()
                                                                                        {
                                                                                            new UserExternalAccountToken(){ID = 1, UserID = user_1.ID, User = user_1, ExternalAccountID = _externalAccounts[0].ID, Account = _externalAccounts[0], SecurityToken = 111111},
                                                                                            new UserExternalAccountToken(){ID = 2, UserID = user_2.ID, User = user_2, ExternalAccountID = _externalAccounts[1].ID, Account = _externalAccounts[1], SecurityToken = 222222}
                                                                                        }; 

        static readonly List<ExternalAccount> _externalAccounts = new List<ExternalAccount>()
                                                                     {
                                                                         new ExternalAccount(){ID = 1, Name = "ExternalAcc1", UserExternalAccounts = new Collection<UserExternalAccountToken>()
                                                                                                                                                         {
                                                                                                                                                             _userExternalAccountTokens[0]
                                                                                                                                                         }},
                                                                         new ExternalAccount(){ID = 2, Name = "ExternalAcc2", UserExternalAccounts = new Collection<UserExternalAccountToken>()
                                                                                                                                                         {
                                                                                                                                                             _userExternalAccountTokens[1]
                                                                                                                                                         }}
                                                                     };

        public static List<Institution> Institutions { get { return _institutions; } }

        public static List<Chain> Chains { get { return _chains; } }

        public static List<Status> Statuses { get { return _statuses; } }

        public static List<State> States { get { return _states; } }

        public static List<User> Users { get { return _users; } }

        public static List<Review> Reviews { get { return _reviews; } }

        public static List<WorkTime> WorkTimes { get { return _workTimes; } }

        public static List<Role> Roles { get { return _roles; } }

        public static List<InstitutionType> InstitutionTypes { get { return _institutionTypes; } }

        public static List<Vote> Votes { get { return _votes; } }

        public static List<UserExternalAccountToken> UserExternalAccountTokens { get { return _userExternalAccountTokens; } }

        public static List<ExternalAccount> ExternalAccounts { get { return _externalAccounts; } }
    }
}
