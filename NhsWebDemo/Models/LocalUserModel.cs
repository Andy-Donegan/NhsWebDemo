using System.ComponentModel;

namespace NhsWebDemo.Models
{
    public class LocalUserModel
    {
        public int iD { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Organisation")]
        public string organisation { get; set; }
        [DisplayName("Service")]
        public string service { get; set; }
        [DisplayName("Location")]
        public string location { get; set; }
        [DisplayName("Appointments")]
        public int dailyAppointments { get; set; }
        [DisplayName("Attended")]
        public int dailyAttended { get; set; }
        [DisplayName("Cancelled")]
        public int dailyCancelled { get; set; }
        [DisplayName("Non Compliance")]
        public int dailyNonCompliance { get; set; }
        [DisplayName("Late")]
        public int dailyLate { get; set; }
        [DisplayName("Safety Alerts")]
        public int dailySafetyAlerts { get; set; }
        [DisplayName("Missing Data")]
        public int dailyMissingData { get; set; }

        [DisplayName("Appointments")]
        public int weeklyAppointments { get; set; }
        [DisplayName("Attended")]
        public int weeklyAttended { get; set; }
        [DisplayName("Cancelled")]
        public int weeklyCancelled { get; set; }
        [DisplayName("Non Compliance")]
        public int weeklyNonCompliance { get; set; }
        [DisplayName("Late")]
        public int weeklyLate { get; set; }
        [DisplayName("Safety Alerts")]
        public int weeklySafetyAlerts { get; set; }
        [DisplayName("Missing Data")]
        public int weeklyMissingData { get; set; }

        [DisplayName("Appointments")]
        public int monthlyAppointments { get; set; }
        [DisplayName("Attended")]
        public int monthlyAttended { get; set; }
        [DisplayName("Cancelled")]
        public int monthlyCancelled { get; set; }
        [DisplayName("Non Compliance")]
        public int monthlyNonCompliance { get; set; }
        [DisplayName("Late")]
        public int monthlyLate { get; set; }
        [DisplayName("Safety Alerts")]
        public int monthlySafetyAlerts { get; set; }
        [DisplayName("Missing Data")]
        public int monthlyMissingData { get; set; }
    }
}
