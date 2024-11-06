namespace Domain.Entities;

public class Room
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public bool InMaintenance { get; set; }

    public bool IsAvailable
    {
        get
        {
            if(!this.InMaintenance || this.HasGuest)
            {
                return false;
            }

            return true;
        }
    }

    public bool HasGuest
    {
        //Verificar se existe bookins aberto para essa room 
        get { return true; }
    }
}