namespace PetzyTrial.Model.Entity
{
    public class PatientDetails
    {
        public int PetDeatilsId { get; set; }

        public Vital vital { get; set; }

        public int VitalId { get; set; }
        public Symptom symptom { get; set; }
        public int SymptomId { get; set; }

        public Prescription prescription { get; set; }
        public int PrescriptionId { get; set; }

        public Appointment appointment { get; set; }

        public int AppointmentId { get; set; }

        public Pet pet { get; set; }
        public int PetId { get; set; }
    }
}
