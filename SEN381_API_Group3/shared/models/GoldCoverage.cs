namespace SEN381_API_Group3.shared.models;

public class GoldCoverage : TreatmentCoverage
{
    public GoldCoverage(string coverageID, string coverageDescription, int numberOfGeneralVisits, int numberOfSpecialistsVisits) : base(coverageID, coverageDescription, numberOfGeneralVisits, numberOfSpecialistsVisits)
    {
           
    }
    public GoldCoverage() : base()
    {
        //Set default values
    }
}