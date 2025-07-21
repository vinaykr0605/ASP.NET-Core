namespace mvc_app.Models;

public class EngineeringDepartmentModel
{
    public string[] CurrentSoftwareProjects { get; set; }

    public EngineeringDepartmentModel(){
        CurrentSoftwareProjects = ["Cool Web Appp", "Cool Mobile App", "Cool Desktop App"];
    }
}