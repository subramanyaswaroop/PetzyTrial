﻿namespace PetzyTrial.Model.Entity
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }  
        
        public string ReasonForAppointment { get; set; }
    }
}
