namespace SEN381_API_Group3.shared.models;

public class SilverCoverage : TreatmentCoverage
{
    public SilverCoverage(string coverageID, string coverageDescription, int numberOfGeneralVisits, int numberOfSpecialistsVisits) : base(coverageID, coverageDescription, numberOfGeneralVisits, numberOfSpecialistsVisits)
    {
    }

    public SilverCoverage() : base()
    {
        //Set default values
    }
}