namespace SEN381_API_Group3.shared.models;

public class PlatinumCoverage : TreatmentCoverage
{
    public PlatinumCoverage(string coverageID, string coverageDescription, int numberOfGeneralVisits, int numberOfSpecialistsVisits) : base(coverageID, coverageDescription, numberOfGeneralVisits, numberOfSpecialistsVisits)
    {
    }
    
}

