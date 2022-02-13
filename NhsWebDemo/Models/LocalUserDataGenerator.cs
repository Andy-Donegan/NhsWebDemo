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
                // Create Mapping Data
                if (context.LocalUserMapModels.Any())
                {
                    return;   // Database has been seeded
                }

                context.LocalUserMapModels.AddRange(
                    new LocalUserMapModel
                    {
                        Id = 1,
                        Lat = 53.829721,
                        Long = -1.778213,
                        Title = "Travel",
                        PointTime = "08:00",
                        IsComplete = true,
                        IsLate = false,
                        IsTravel = true,
                        LastLocation = false,
                        ZIndex = 1,
                    },
                    new LocalUserMapModel
                    {
                        Id = 2,
                        Lat = 53.829226,
                        Long = -1.778373,
                        Title = "Travel",
                        PointTime = "08:05",
                        IsComplete = true,
                        IsLate = false,
                        IsTravel = true,
                        LastLocation = false,
                        ZIndex = 2,
                    },
                    new LocalUserMapModel
                    {
                        Id = 3,
                        Lat = 53.828402,
                        Long = -1.779187,
                        Title = "Travel",
                        PointTime = "08:10",
                        IsComplete = true,
                        IsLate = false,
                        IsTravel = true,
                        LastLocation = false,
                        ZIndex = 3,
                    },
                    new LocalUserMapModel
                    {
                        Id = 4,
                        Lat = 53.827623,
                        Long = -1.778806,
                        Title = "Travel",
                        PointTime = "08:15",
                        IsComplete = true,
                        IsLate = false,
                        IsTravel = true,
                        LastLocation = false,
                        ZIndex = 4,
                    },
                    new LocalUserMapModel
                    {
                        Id = 5,
                        Lat = 53.827665,
                        Long = -1.778612,
                        Title = Name.FullName(NameFormats.Standard),
                        PointTime = "08:20",
                        IsComplete = true,
                        IsLate = false,
                        IsTravel = false,
                        LastLocation = true,
                        ZIndex = 5,
                    }
                    ); ;


                context.SaveChanges();

            }
        }
    }
}

