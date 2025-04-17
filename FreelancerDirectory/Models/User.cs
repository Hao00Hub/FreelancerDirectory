namespace FreelancerDirectory.Models
{
    public class User
    {
        //@GET   - GET USER
        //@POST  - ADD USER
        //@PUT   - UPDATE USER
        //DELETE - DELETE USER

        public int    Id          { get; set; }
        public string UserName    { get; set; }
        public string Mail        { get; set; }
        public string PhoneNumber { get; set; }
        public string Skillsets   { get; set; }
        public string Hobby       { get; set; }

    }
}
