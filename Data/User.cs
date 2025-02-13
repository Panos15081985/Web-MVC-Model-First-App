


using SchoolApp.Core.Enums;

namespace SchoolApp
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public UserRole UserRole { get; set; }

        public virtual Teacher? Teacher { get; set; }
        public virtual Student? Student { get; set; }
    }
}

// Lazy Loading (τεμπέλικη φόρτωση):
//Το virtual επιτρέπει στο Entity Framework (EF) να δημιουργήσει proxy αντικείμενα για την υποστήριξη της τεμπέλικης φόρτωσης.

//Lazy loading σημαίνει ότι οι σχετιζόμενες οντότητες (π.χ. Teacher ή Student) δεν φορτώνονται από τη βάση δεδομένων
//όταν φορτώνεται η οντότητα User. Αντίθετα, φορτώνονται μόνο όταν προσπαθήσεις να τις χρησιμοποιήσεις.
