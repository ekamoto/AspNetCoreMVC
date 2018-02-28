using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMVC.Domain {
    
    // Classe de domínio não pode ter dependência
    // exemplo DataAnnotations [MaxLength(50)]
    public class Category {

        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public Category()
        {
            
        }
    }


}