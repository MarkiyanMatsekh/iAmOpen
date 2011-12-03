using System.Collections.Generic;
using Iamopen.Common.Exceptions;
using Iamopen.Common.ServiceModels;
using NUnit.Framework;

namespace Iamopen.Site.Tests.OnlineReservationsTests
{
    [TestFixture]
    public class DBCompatibilityTests
    {
        [Test]
        public void TableStatusConvertionTest()
        {
            // Arrange
            var tableStatuses = new[] 
            {
                 new Availability.OnlineAvailability.Implementation.DomainModels.TableStatus() { ID = 1 },
                 new Availability.OnlineAvailability.Implementation.DomainModels.TableStatus() { ID = 3 },
                 new Availability.OnlineAvailability.Implementation.DomainModels.TableStatus() { ID = 4 },
                 new Availability.OnlineAvailability.Implementation.DomainModels.TableStatus() { ID = 0 }
            };
            var count =   tableStatuses.Length;
            

            // Act
            var results = new bool[count];
            TableStatus ts;
            for (int i = 0; i < tableStatuses.Length; i++)
            {
                var tableStatus = tableStatuses[i];
                try
                {
                    ts = (TableStatus)(tableStatus);
                    results[i] = true;
                }
                catch (DBIncompatibilityException)
                {
                    results[i] = false;
                }
            }

            // Assert
            var actualResults = new[] { true, true, false, false };
            for (int i = 0; i < count; i++ )
            {
                Assert.AreEqual(results[i], actualResults[i],
                    "StatusID {0} exists == {1}", tableStatuses[i].ID, actualResults);
            }
                
        }
    }
}
