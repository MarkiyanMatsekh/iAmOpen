using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IAmOpen.Model.Models;

namespace IAmOpen.Model.Concrete.Mock
{
    public class MockData
    {
        static Status statusOK = new Status() { StatusID = 1, Name = "OK" };
        static Status statusNW = new Status() { StatusID = 2, Name = "NotWorking" };

        static State state_1 = new State() { StateID = 1, Name = "State1" };
        static State state_2 = new State() { StateID = 2, Name = "State2" };

        static User user_1 = new User() { UserID = 1, Nickname = "Nick_1", FirstLoginDLC = DateTime.Now, PrivacyOn = true };
        static User user_2 = new User() { UserID = 2, Nickname = "Nick_2", FirstLoginDLC = DateTime.Now, PrivacyOn = true };

        private static Chain chain_1 = new Chain() {ChainID = 1, Name = "Silpo"};
        private static Chain chain_2 = new Chain() {ChainID = 2, Name = "Arsen"};
        private static Chain chain_3 = new Chain() {ChainID = 3, Name = "Local"};

        static List<Institution> _institutions = new List<Institution>()
                           {
                               new Institution() { InstitutionID = 1, CoordinatesX = 1, CoordinatesY = 2, StateID = state_1.StateID, StatusID = statusOK.StatusID, UserID = user_1.UserID, IconPath = "somePath1", CreatedDLC = DateTime.Now, Rating = 5, Status = statusOK, State = state_1, CreatedByUser = user_1},
                               new Institution() { InstitutionID = 2, CoordinatesX = 10, CoordinatesY = 21, StateID = state_1.StateID, StatusID = statusOK.StatusID, UserID = user_2.UserID, IconPath = "somePath2", CreatedDLC = DateTime.Now, Rating = 4, Status = statusNW, State = state_2, CreatedByUser = user_2},
                               new Institution() { InstitutionID = 3, CoordinatesX = 11, CoordinatesY = 92, StateID = state_1.StateID, StatusID = statusNW.StatusID, UserID = user_1.UserID, IconPath = "somePath3", CreatedDLC = DateTime.Now, Rating = 3, Status = statusOK, State = state_1, CreatedByUser = user_1}
                           };

        static List<State> _states = new List<State>()
                           {
                               state_1,
                               state_2
                           };

        static List<Chain> _chains = new List<Chain>()
                           {
                               chain_1,
                               chain_2,
                               chain_3
                           };

        static List<Status> _statuses = new List<Status>()
                           {
                               statusOK,
                               statusNW
                           };

        static List<User> _users = new List<User>()
                           {
                               user_1,
                               user_2
                           };

        static List<Vote> _votes = new List<Vote>()
                           {
                               new Vote(){ VoteID = 1, UserID = Users[0].UserID, Voter = Users[0], InstitutionID = Institutions[0].InstitutionID, Institution = Institutions[0]},
                               new Vote(){ VoteID = 2, UserID = Users[1].UserID, Voter = Users[1], InstitutionID = Institutions[1].InstitutionID, Institution = Institutions[1]},
                               new Vote(){ VoteID = 3, UserID = Users[0].UserID, Voter = Users[0], InstitutionID = Institutions[2].InstitutionID, Institution = Institutions[2]}
                           };

        public static List<Institution> Institutions { get { return _institutions; } }

        public static List<Chain> Chains { get { return _chains; } }

        public static List<Status> Statuses { get { return _statuses; } }

        public static List<State> States { get { return _states; } }

        public static List<User> Users { get { return _users; } }

        public static List<Vote> Votes { get { return _votes; } }
    }
}
