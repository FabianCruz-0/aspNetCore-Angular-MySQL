namespace vsc_net_ang.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Make Make { get; set; }
        /*También le voy a agregar la prop de una foreing key que facilite la creación de objetos.
        Esto facilitará la creación de la siguiente manera:
        
        var Model = new Model();
        Model.MakeId = 1;   isted of:

        Model.Makae = dbContext.Makes.Find(1);
        */
        public int MakeId { get; set; }
        /*Usando la convención de colocar Make y MakeId Entity FW sabrá que hace referencia
        al mismo objeto, haciendo que el uso de Code First Migrations no creará una col. adicional
        ------IMPORTANTE------- SI EN LA CLASE MAKE EL ID USA BYTE, AQUÍ TAMBIÉN SE DEBERÍA USAR BYTE
        */
    }
}