namespace RestAPI_project.Dtos.Character        
{
    public class UpdateCharacterDto
    {
        public int Id {get; set;}
      // set it to Nullable or add = "Frodo";
      public string Name {get; set;} = "Frodo";
      public int HitPoints {get; set;} = 100;
      public int Strength {get; set;} = 10;
      public int Defense {get; set;} = 10;
      public int Intelligence {get; set;} = 10;
      public RpgClass Class {get; set;} = RpgClass.Knight;  
    }
}
