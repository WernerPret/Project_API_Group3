namespace SEN381_API_Group3.shared.models;

public abstract class TreatmentCoverage
{
    String coverageID;
    String coverageDescription;
    int numberOfGeneralVisits;
    int numberOfSpecialistsVisits;

    protected TreatmentCoverage(string coverageID, string coverageDescription, int numberOfGeneralVisits, int numberOfSpecialistsVisits)
    {
        this.coverageID = coverageID;
        this.coverageDescription = coverageDescription;
        this.numberOfGeneralVisits = numberOfGeneralVisits;
        this.numberOfSpecialistsVisits = numberOfSpecialistsVisits;
    }
    protected TreatmentCoverage()
    {
        //Used to set default values in child classes
    }

    public string CoverageID { get => coverageID; set => coverageID = value; }
    public string CoverageDescription { get => coverageDescription; set => coverageDescription = value; }
    public int NumberOfGeneralVisits { get => numberOfGeneralVisits; set => numberOfGeneralVisits = value; }
    public int NumberOfSpecialistsVisits { get => numberOfSpecialistsVisits; set => numberOfSpecialistsVisits = value; }
}