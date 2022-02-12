using Microsoft.EntityFrameworkCore;
using NhsWebDemo.DataContext;
using Faker;
using System.ComponentModel;

namespace NhsWebDemo.Models
{
    public class LocalUserDataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            Random random = new Random();
            string[] Service = { "Mental Health services", "Community services", "Learning Disability services", "Dementia services", "Dental services", "Children's services" };
            string[] Location = { "Shipley", "New Mill", "Linfield Mount", "Airedale", "Somerset House", "Moorlands View Hospital" };

            using (var context = new LocalDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<LocalDBContext>>()))
            {
                // Check for any records already in database.
                if (context.LocalUserModels.Any())
                {
                    return;   // Database has been seeded
                }
                for (int i = 1; i < 10; i++)
                {
                    // Generate Random field Data
                    int locationId = random.Next(0, Location.Length);
                    int serviceId = random.Next(0, Service.Length);
                    var randomAppointments = RandomNumber.Next(5, 10);
                    var randomAttended = RandomNumber.Next(1, randomAppointments);
                    context.LocalUserModels.Add(
                        new LocalUserModel
                        {
                            iD = i,
                            name = Name.FullName(NameFormats.Standard),
                            organisation = "BDCT",
                            service = Service[serviceId],
                            location = Location[locationId], 
                            dailyAppointments = randomAppointments,
                            dailyAttended = randomAttended,
                            dailyCancelled = 2,
                            dailyNonCompliance = 4,
                            dailyLate = 3,
                            dailySafetyAlerts = 2,
                            dailyMissingData = 5,

                            weeklyAppointments = randomAppointments*7,
                            weeklyAttended = randomAttended*7,
                            weeklyCancelled = 2,
                            weeklyNonCompliance = 4,
                            weeklyLate = 3,
                            weeklySafetyAlerts = 2,
                            weeklyMissingData = 5,

                            monthlyAppointments = randomAppointments,
                            monthlyAttended = randomAttended,
                            monthlyCancelled = 2,
                            monthlyNonCompliance = 4,
                            monthlyLate = 3,
                            monthlySafetyAlerts = 2,
                            monthlyMissingData = 5
                        }
                        );
                }

                context.SaveChanges();
            }
        }
    }
}

