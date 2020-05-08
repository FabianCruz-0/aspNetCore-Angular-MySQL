using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vsc_net_ang.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        //Siempre que se tenga una propiedad Collection, se debe inicializar en el ctor de la clase.


        public Make()
        {
            Models = new Collection<Model>();
            /*La diferencia entre una Ilist, List a ICollection, Collection, es que las listas
            Permiten acceder a un objeto dentro de la colección mediante un índice, sin embargo
            En este proyecto no queremos eso, sólo serializarlos. Ejemplo lista: 

            var makes = new dbContext.Makes.ToList();
            makes.Models[0]
            */
        }
    }
}