using System.ComponentModel;

namespace NhsWebDemo.Models
{
    public class LocalUserModel
    {
        public int iD { get; set; }
        public string name { get; set; }
        public string organisation { get; set; }
        public int dailyAppointments { get; set; }
        public int dailyAttended { get; set; }
        public int dailyCancelled { get; set; }
        public int dailyNonCompliance { get; set; }
        public int dailyLate { get; set; }
        public int dailySafetyAlerts { get; set; }
        public int dailyMissingData { get; set; }

        public int weeklyAppointments { get; set; }
        public int weeklyAttended { get; set; }
        public int weeklyCancelled { get; set; }
        public int weeklyNonCompliance { get; set; }
        public int weeklyLate { get; set; }
        public int weeklySafetyAlerts { get; set; }
        public int weeklyMissingData { get; set; }

        public int monthlyAppointments { get; set; }
        public int monthlyAttended { get; set; }
        public int monthlyCancelled { get; set; }
        public int monthlyNonCompliance { get; set; }
        public int monthlyLate { get; set; }
        public int monthlySafetyAlerts { get; set; }
        public int monthlyMissingData { get; set; }
    }
}
