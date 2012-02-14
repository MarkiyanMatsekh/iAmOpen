using System;
using System.Collections.Generic;
using Iamopen.Common.ServiceModels;

namespace Iamopen.Availability.OnlineAvailability.Interface.Models
{
    public class InstitutionsStatisticsInfo
    {
        public List<int> DesiredInstitutionsIDs;
        public DateTime LastUpdateTime;
    }

    public class InstitutionsStatisticsResult : OperationResult
    {
        public List<InstitutionStatistics> InstitutionStatistics;
    }

    public class InstitutionStatistics
    {
        public int InstitutionID;
        public InstitutionActivity StatisticalActivity;
    }


}
