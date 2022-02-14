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
                    // Generate Daily Data
                    var randomAppointments = RandomNumber.Next(5, 10);
                    var randomAttended = RandomNumber.Next(2, randomAppointments-1);
                    var randomMissingData = RandomNumber.Next(0, randomAppointments - 2);

                    // Generate Weekly Data
                    var RandomWeeklyAppointments = (RandomNumber.Next(7, 9) * 5) + RandomNumber.Next(0,5);
                    var RandomWeeklyAttended = (RandomWeeklyAppointments - RandomNumber.Next(7,15));
                    
                    // Generate Monthly Data
                    var RandomMonthlyAppointments = (RandomNumber.Next(7, 8) * 20) + RandomNumber.Next(0, 15);
                    var randomMonthlyAttended = (RandomMonthlyAppointments - RandomNumber.Next(9, 20));


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
                            dailyCancelled = RandomNumber.Next(0, 2),
                            dailyNonCompliance = RandomNumber.Next(0, 1),
                            dailyLate = RandomNumber.Next(0,3),
                            dailySafetyAlerts = RandomNumber.Next(0,2),
                            dailyMissingData = RandomNumber.Next(0,randomAppointments-2),

                            weeklyAppointments = RandomWeeklyAppointments,
                            weeklyAttended = RandomWeeklyAttended,
                            weeklyCancelled = RandomNumber.Next(2,(RandomWeeklyAppointments-RandomWeeklyAttended)),
                            weeklyNonCompliance = RandomNumber.Next(1, (RandomWeeklyAppointments - RandomWeeklyAttended)),
                            weeklyLate = RandomNumber.Next(5,12),
                            weeklySafetyAlerts = RandomNumber.Next(1,6),
                            weeklyMissingData = RandomNumber.Next(8,RandomWeeklyAppointments/2),

                            monthlyAppointments = RandomMonthlyAppointments,
                            monthlyAttended = randomMonthlyAttended,
                            monthlyCancelled = RandomNumber.Next(6, (RandomMonthlyAppointments - randomMonthlyAttended)),
                            monthlyNonCompliance = RandomNumber.Next(4, (RandomMonthlyAppointments - randomMonthlyAttended)),
                            monthlyLate = RandomNumber.Next(10, 30),
                            monthlySafetyAlerts = RandomNumber.Next(0, 12),
                            monthlyMissingData = RandomNumber.Next(24, RandomMonthlyAppointments / 2)
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
                        LastLocation = false,
                        ZIndex = 5,
                    },
                    new LocalUserMapModel
                    {
                        Id = 6,
                        Lat = 53.826975,                        
                        Long = -1.779180,
                        Title = "Travel",
                        PointTime = "09:30",
                        IsComplete = false,
                        IsLate = false,
                        IsTravel = true,
                        LastLocation = false,
                        ZIndex = 6,
                    },
                    new LocalUserMapModel
                    {
                        Id = 7,
                        Lat = 53.826383,                        
                        Long = -1.779985,
                        Title = "Travel",
                        PointTime = "09:35",
                        IsComplete = false,
                        IsLate = false,
                        IsTravel = true,
                        LastLocation = false,
                        ZIndex = 7,
                    },
                    new LocalUserMapModel
                    {
                        Id = 8,
                        Lat = 53.825683,                        
                        Long = -1.780453,
                        Title = "Travel",
                        PointTime = "09:40",
                        IsComplete = false,
                        IsLate = false,
                        IsTravel = true,
                        LastLocation = false,
                        ZIndex = 8,
                    },
                    new LocalUserMapModel
                    {
                        Id = 9,
                        Lat = 53.825465,                        
                        Long = -1.780550,
                        Title = Name.FullName(NameFormats.Standard),
                        PointTime = "09:42",
                        IsComplete = false,
                        IsLate = false,
                        IsTravel = false,
                        LastLocation = true,
                        ZIndex = 9,
                    },
                    new LocalUserMapModel
                    {
                        Id = 10,
                        Lat = 53.82260807883355,                        
                        Long = -1.777503010633929,
                        Title = Name.FullName(NameFormats.Standard),
                        PointTime = "11:00",
                        IsComplete = false,
                        IsLate = true,
                        IsTravel = false,
                        LastLocation = false,
                        ZIndex = 10,
                    },
                    new LocalUserMapModel
                    {
                        Id = 11,
                        Lat = 53.81757296610641,                        
                        Long = -1.7810274329912588,
                        Title = Name.FullName(NameFormats.Standard),
                        PointTime = "12:00",
                        IsComplete = false,
                        IsLate = false,
                        IsTravel = false,
                        LastLocation = false,
                        ZIndex = 11,
                    },
                    new LocalUserMapModel
                    {
                        Id = 12,
                        Lat = 53.8223266644526,                        
                        Long = -1.7614473645388233,
                        Title = Name.FullName(NameFormats.Standard),
                        PointTime = "14:00",
                        IsComplete = false,
                        IsLate = false,
                        IsTravel = false,
                        LastLocation = false,
                        ZIndex = 12,
                    },
                    new LocalUserMapModel
                    {
                        Id = 13,
                        Lat = 53.82872501937481,                        
                        Long = -1.7680227998765294,
                        Title = Name.FullName(NameFormats.Standard),
                        PointTime = "15:00",
                        IsComplete = false,
                        IsLate = false,
                        IsTravel = false,
                        LastLocation = false,
                        ZIndex = 13,
                    },
                    new LocalUserMapModel
                    {
                        Id = 14,
                        Lat = 53.83836403776075,                        
                        Long = -1.7906804237328133,
                        Title = Name.FullName(NameFormats.Standard),
                        PointTime = "16:00",
                        IsComplete = false,
                        IsLate = false,
                        IsTravel = false,
                        LastLocation = false,
                        ZIndex = 14,
                    },
                    new LocalUserMapModel
                    {
                        Id = 15,
                        Lat = 53.83958123273104,                        
                        Long = -1.788846319061861,
                        Title = "New Mill Meeting",
                        PointTime = "16:45",
                        IsComplete = false,
                        IsLate = false,
                        IsTravel = false,
                        LastLocation = false,
                        ZIndex = 15,
                    }
                    ); ;


                context.SaveChanges();

            }
        }
    }
}

