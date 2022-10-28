namespace PetzyTrial.Model.Entity
{
    public class PetOwner
    {

        public int PetOwnerId { get; set; }
        public string PetOwnerName { get; set; } 

        public string PetOwnerEmail { get; set; }

        public string PetOwnerMobileNumber { get; set; }

        public string PetOwnerAddress { get; set; }
        public Pet pet { get; set; }

        public int PetId { get; set; }




    }
}
