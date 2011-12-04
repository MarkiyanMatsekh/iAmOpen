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
                 new Availability.Common.DB.DomainModels.TableStatus() { ID = 1 },
                 new Availability.Common.DB.DomainModels.TableStatus() { ID = 3 },
                 new Availability.Common.DB.DomainModels.TableStatus() { ID = 4 },
                 new Availability.Common.DB.DomainModels.TableStatus() { ID = 0 }
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

        [Test]
        public void ReservationStatusConvertionTest()
        {
            // Arrange
            var reservationStatuses = new[] 
            {
                 new Availability.Common.DB.DomainModels.ReservationStatus() { ID = 1 },
                 new Availability.Common.DB.DomainModels.ReservationStatus() { ID = 3 },
                 new Availability.Common.DB.DomainModels.ReservationStatus() { ID = 4 },
                 new Availability.Common.DB.DomainModels.ReservationStatus() { ID = 0 }
            };
            var count = reservationStatuses.Length;


            // Act
            var results = new bool[count];
            ReservationStatus ts;
            for (int i = 0; i < reservationStatuses.Length; i++)
            {
                var tableStatus = reservationStatuses[i];
                try
                {
                    ts = (ReservationStatus)(tableStatus);
                    results[i] = true;
                }
                catch (DBIncompatibilityException)
                {
                    results[i] = false;
                }
            }

            // Assert
            var actualResults = new[] { true, true, true, false };
            for (int i = 0; i < count; i++)
            {
                Assert.AreEqual(results[i], actualResults[i],
                    "StatusID {0} exists == {1}", reservationStatuses[i].ID, actualResults);
            }

        }
    }
}
