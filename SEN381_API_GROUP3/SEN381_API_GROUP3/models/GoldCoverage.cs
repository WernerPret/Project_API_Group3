namespace SEN381_API_Group3.models;

public class GoldCoverage : TreatmentCoverage
{
    public GoldCoverage() : base()
    {
        this.CoverageID = "";
        this.CoverageDescription = "";
        this.NumberOfGeneralVisits = 0;
        this.NumberOfSpecialistsVisits = 0;//Default values to be defined later

    }
}