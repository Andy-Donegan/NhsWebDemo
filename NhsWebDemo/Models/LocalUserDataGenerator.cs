using Microsoft.EntityFrameworkCore;
using NhsWebDemo.DataContext;
using Faker;

namespace NhsWebDemo.Models
{
    public class LocalUserDataGenerator
    {
        enum Organisation
        {
            Public,
            Private,
            Internal,
        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LocalDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<LocalDBContext>>()))
            {
                // Look for any board games already in database.
                if (context.LocalUserModels.Any())
                {
                    return;   // Database has been seeded
                }

                for (int i = 1; i < 10; i++)
                {
                    var randomAppointments = RandomNumber.Next(5, 10);
                    var randomAttended = RandomNumber.Next(1, randomAppointments);
                    context.LocalUserModels.Add(
                        new LocalUserModel
                        {
                            iD = i,
                            name = Name.FullName(NameFormats.Standard),
                            organisation = Faker.Company.Name().ToString(),
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

