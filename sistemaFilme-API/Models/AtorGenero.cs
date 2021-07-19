namespace sistemaFilme_API.Models
{
    public class AtorGenero
    {

        public AtorGenero() { }
       
           public AtorGenero(int atorId,int generoId)
        {
            this.atorId = atorId;
         
            this.generoId = generoId;
         

        }


        
        public int atorId { get; set; }
        public Ator ator { get; set; }

        public int generoId { get; set; }
        public Genero genero { get; set; }

        

        


      
    }
}