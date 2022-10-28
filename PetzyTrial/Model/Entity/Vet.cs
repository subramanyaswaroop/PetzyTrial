using System.ComponentModel.DataAnnotations;

namespace PetzyTrial.Model.Entity
{
    public class Vet
    {

        public int VetId { get; set; }
       
        public string VetName { get; set; } 

        public string VetSpeciality { get; set; }

        public string VetMobileNumber { get; set; }


        [EmailAddress]
        public string VetEmail { get; set; }

        public int VetNPINumber { get; set; }

        public string VetClinic { get; set; }

        public bool IsAvailable { get; set; }

        public Appointment appointment { get; set; }
        public int AppointmentId { get; set; }
        


       

        
    }
}
