using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Iamopen.Availability.AMS.Proxy.Generated;
using Iamopen.Common.ServiceModels;

namespace Iamopen.Availability.AMS.Proxy
{
    public static class SafeAMS
    {
        public static OperationResult ChangeTableStatus(int tableID, TableStatus tableStatus)
        {
            return Safe(proxy =>
            proxy.ChangeTableStatus(new ChangeTableStatusInfo
            {
                TableID = tableID,
                TableStatus = tableStatus,
            }));
        }



        private static T Safe<T>(Func<AvailabilityManagementServiceClient, T> action)
            where T : OperationResult, new()
        {
            var proxy = new AvailabilityManagementServiceClient();
            T result;
            try
            {
                result = action(proxy);
            }
            catch (CommunicationException ex)
            {
                result = new T
                {
                    ExecutionResult = new ExecutionResult(ResultCode.Fail,
                                                          "Communication error has occured",
                                                          ex.Message)
                };
            }
            catch (TimeoutException ex)
            {
                result = new T
                {
                    ExecutionResult = new ExecutionResult(ResultCode.Fail,
                                                          "operation had timed out",
                                                          ex.Message)
                };
            }
            catch (Exception ex)
            {
                result = new T
                {
                    ExecutionResult = new ExecutionResult(ResultCode.Fail,
                                                          "Unexpected error has occured",
                                                          ex.Message)
                };
            }
            finally
            {
                if (proxy.State == CommunicationState.Faulted)
                {
                    proxy.Abort();
                }
                proxy.Close();
            }
            return result;

        }

    }
}
