namespace Iamopen.OnlineReservations.Implementation.DB.Models
{
    internal class Hall
    {
        internal int ID;
        internal int No;

        internal int InstitutionID;

        internal string Name;
        internal int TablesCount;

        internal bool IsSmokingHall;

        internal double EntranceLeft;
        internal double EntranceTop;
        internal double EntranceWidth;
        internal double EntranceHeight;
    }
}
