namespace SEN381_API_Group3.models;

public class MedicalServiceProvider
{
    private String policyProviderID;
    private String policyProviderName;
    private String policyProviderAddresses;
    private String policyProviderStatus;


   public MedicalServiceProvider(String policyProviderID, String policyProviderName, String policyProviderAddresses, String policyProviderStatus)
    {
        this.policyProviderID = policyProviderID;
        this.policyProviderName = policyProviderName;  
        this.policyProviderAddresses = policyProviderAddresses;
        this.policyProviderStatus = policyProviderStatus;
    }
    



   public string PolicyProviderID { get => policyProviderID; set => policyProviderID = value; }
    public string PolicyProviderName { get => policyProviderName; set => policyProviderName = value; }
    public string PolicyProviderAddresses { get => policyProviderAddresses; set => policyProviderAddresses = value; }
    public string PolicyProviderStatus { get => policyProviderStatus; set => policyProviderStatus = value; }
}